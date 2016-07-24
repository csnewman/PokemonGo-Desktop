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
		private const string USER_AGENT = "niantic";
		private const string LOGIN_URL = "https://sso.pokemon.com";
		private const string LOGIN_ENDPOINT = "/sso/login?service=https%3A%2F%2Fsso.pokemon.com%2Fsso%2Foauth2.0%2FcallbackAuthorize";
		private const string OAUTH_ENDPOINT = "/sso/oauth2.0/accessToken";
		private const string CLIENT_ID = "mobile-app_pokemon-go";
		private const string REDIRECT_URI = "https://www.nianticlabs.com/pokemongo/error";
		private const string CLIENT_SECRET = "w8ScCUXJQc6kXKw8FiOhd8Fixzht18Dq3PEVkUCP5ZPxtgyWsbTvWHFLm2wNY0JR";
		private string token;

		public DesktopNetworkInterface(){
			ServicePointManager.ServerCertificateValidationCallback = delegate {
				return true;
			};
		}

		public bool loginPTC(string username, string password){
			IRestClient loginClient = new RestClient (LOGIN_URL);
			loginClient.CookieContainer = new CookieContainer ();
			loginClient.UserAgent = USER_AGENT;
			loginClient.FollowRedirects = false;

			IRestResponse inital = loginClient.Execute (new RestRequest(LOGIN_ENDPOINT, Method.GET));
			//TODO: Error check
			JObject data = JObject.Parse (inital.Content);

			RestRequest request = new RestRequest (LOGIN_ENDPOINT, Method.POST);
			request.AddParameter ("lt", (string)data ["lt"]);
			request.AddParameter ("execution", (string)data ["execution"]);
			request.AddParameter ("_eventId", "submit");
			request.AddParameter ("username", username);
			request.AddParameter ("password", password);

			IRestResponse response = loginClient.Execute (request);
			//TODO: Error check
			string location = response.GetHeader ("location");
			if(location == null){
				Debug.LogError ("No location header returned!");
				return false;
			}

			IDictionary<string, string> query = location.GetQuerySection().ParseQueryString (true);
			if(!query.ContainsKey("ticket")){
				Debug.LogError ("No ticket returned");
				return false;
			}
			Debug.Log ("Ticket: "+query["ticket"]);

			RestRequest renew = new RestRequest (OAUTH_ENDPOINT, Method.POST);
			renew.AddParameter ("client_id", CLIENT_ID);
			renew.AddParameter ("redirect_uri", REDIRECT_URI);
			renew.AddParameter ("client_secret", CLIENT_SECRET);
			renew.AddParameter ("grant_type", "refresh_token");
			renew.AddParameter ("code", query["ticket"]);

			IRestResponse renewResponse = loginClient.Execute (renew);
			token = renewResponse.Content.ParseQueryString (true) ["access_token"];
			Debug.Log ("Token: "+token);
			return true;
		}

		public bool loginGoogle(string email, string password){
			Debug.LogError ("Google login is not supported yet");
			return false;
		}

	}
}

