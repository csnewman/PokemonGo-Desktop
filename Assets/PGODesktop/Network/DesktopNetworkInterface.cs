using System;
using System.Net;
using RestSharp;
using RestSharp.Extensions;
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using Google.Protobuf;
using POGOProtos.Networking.Envelopes;
using POGOProtos.Networking.Requests;
using POGOProtos.Networking.Requests.Messages;
using Random = System.Random;

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
	    private readonly Random _random;
	    private RequestEnvelope.Types.AuthInfo _authInfo;

        public DesktopNetworkInterface()
		{
		    _random = new Random();
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
			string token = renewResponse.Content.ParseQueryString (true) ["access_token"];
			Debug.Log ("Token: "+token);

            _authInfo = new RequestEnvelope.Types.AuthInfo()
            {
                Provider = "ptc",
                Token = new RequestEnvelope.Types.AuthInfo.Types.JWT()
                {
                    Contents = token,
                    Unknown2 = 59
                }
            };
            
            return PtcLoginResult.Success;
		}

		public bool LoginGoogle(string email, string password){
			Debug.LogError ("Google login is not supported yet");
			return false;
		}

	    private void PerformApiRequest(bool useTicket, params Request[] requests)
	    {
	        RequestEnvelope requestEnvelope = new RequestEnvelope
	        {
	            StatusCode = 2,
	            RequestId = _random.NextULong(),
                Longitude = Utils.FloatToULong(0),
	            Latitude = Utils.FloatToULong(0),
                Altitude = 10d,
	            Unknown12 = 989,
                Requests =
                {
                    requests
                }
	        };

	        if (useTicket)
	        {
	            requestEnvelope.AuthInfo = _authInfo;
	        }
	        else
	        {
	            //TODO: Use ticket
	        }
            
            //TODO: Call RPC

            //TODO: Decode response
        }
        

	}
}

