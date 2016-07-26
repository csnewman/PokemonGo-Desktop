using System;
using System.Net;
using RestSharp;
using RestSharp.Extensions;
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;


namespace PGODesktop.Network
{
	public class DesktopNetworkInterface : INetworkInterface
	{
		private const string UserAgent = "niantic";
		private const string LoginUrl = "https://sso.pokemon.com";
		private const string LoginEndpoint = "/sso/login?service=https%3A%2F%2Fsso.pokemon.com%2Fsso%2Foauth2.0%2FcallbackAuthorize";
		private const string OauthEndpoint = "/sso/oauth2.0/accessToken";
		private const string ClientId = "mobile-app_pokemon-go";
		private const string RedirectUri = "https://www.nianticlabs.com/pokemongo/error";
		private const string ClientSecret = "w8ScCUXJQc6kXKw8FiOhd8Fixzht18Dq3PEVkUCP5ZPxtgyWsbTvWHFLm2wNY0JR";
		private string _token;

		public DesktopNetworkInterface(){
			ServicePointManager.ServerCertificateValidationCallback = delegate {
				return true;
			};
		}

		public PtcLoginResult LoginPtc(string username, string password){
			IRestClient loginClient = new RestClient (LoginUrl);
			loginClient.CookieContainer = new CookieContainer ();
			loginClient.UserAgent = UserAgent;
			loginClient.FollowRedirects = false;

			IRestResponse inital = loginClient.Execute (new RestRequest(LoginEndpoint, Method.GET));
			//TODO: Error check
			JObject data = JObject.Parse (inital.Content);

			RestRequest request = new RestRequest (LoginEndpoint, Method.POST);
			request.AddParameter ("lt", (string)data ["lt"]);
			request.AddParameter ("execution", (string)data ["execution"]);
			request.AddParameter ("_eventId", "submit");
			request.AddParameter ("username", username);
			request.AddParameter ("password", password);

			IRestResponse response = loginClient.Execute (request);
			//TODO: Error check
			string location = response.GetHeader ("location");
			if(location == null){
				Debug.LogError ("No location header returned! " + response.StatusCode + "(" + response.StatusDescription + ")  " + response.Content);
			    JObject errorData = JObject.Parse(response.Content);
			    if ((string) errorData["error_code"] == "users.login.activation_required")
			    {
                    return PtcLoginResult.VerificationNeeded;
			    }
			    else
			    {
                    return PtcLoginResult.InvalidCredentials;
                }
			}

			IDictionary<string, string> query = location.GetQuerySection().ParseQueryString (true);
			if(!query.ContainsKey("ticket")){
				Debug.LogError ("No ticket returned");
				return PtcLoginResult.Error;
			}
			Debug.Log ("Ticket: "+query["ticket"]);

			RestRequest renew = new RestRequest (OauthEndpoint, Method.POST);
			renew.AddParameter ("client_id", ClientId);
			renew.AddParameter ("redirect_uri", RedirectUri);
			renew.AddParameter ("client_secret", ClientSecret);
			renew.AddParameter ("grant_type", "refresh_token");
			renew.AddParameter ("code", query["ticket"]);

			IRestResponse renewResponse = loginClient.Execute (renew);
			_token = renewResponse.Content.ParseQueryString (true) ["access_token"];
			Debug.Log ("Token: "+_token);
			return PtcLoginResult.Success;
		}

		public bool LoginGoogle(string email, string password){
			Debug.LogError ("Google login is not supported yet");
			return false;
		}

	}
}

