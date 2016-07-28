using System;
using System.Net;
using RestSharp;
using RestSharp.Extensions;
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using com.google.common.geometry;
using Google.Protobuf;
using POGOProtos.Networking.Envelopes;
using POGOProtos.Networking.Requests;
using POGOProtos.Networking.Requests.Messages;
using POGOProtos.Networking.Responses;
using Random = System.Random;
using AuthInfo = POGOProtos.Networking.Envelopes.RequestEnvelope.Types.AuthInfo;

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
	    private const string RpcUrl = "https://pgorelease.nianticlabs.com";
	    private const string RpcInitialEndpoint = "/plfe/rpc";
        private readonly Random _random;
	    private IRestClient _rpcClient;
	    private AuthInfo _authInfo;
	    private AuthTicket _authTicket;
	    private string _rpcEndpoint;

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
            
            _authInfo = new AuthInfo()
		    {
		        Provider = "ptc",
		        Token = new AuthInfo.Types.JWT()
		        {
		            Contents = token,
		            Unknown2 = 14
		        }
		    };
            
            CompleteInitialSetup();
            return PtcLoginResult.Success;
		}
        
		public bool LoginGoogle(string email, string password){
			Debug.LogError ("Google login is not supported yet");
			return false;
		}

	    public void CompleteInitialSetup()
	    {
	        _rpcClient = new RestClient(RpcUrl) {UserAgent = "Niantic App"};

	        RequestEnvelope requestEnvelope = new RequestEnvelope
            {
                StatusCode = 2,
                RequestId = 1469378659230941192,
                Unknown12 = 989,
                AuthInfo = _authInfo
            };

            requestEnvelope.Requests.Add(new Request()
            {
                RequestType = RequestType.GetPlayer
            });

            RestRequest rpcRequest = new RestRequest(RpcInitialEndpoint, Method.POST);
            rpcRequest.AddParameter(
                "application/x-www-form-urlencoded",
                requestEnvelope.ToByteArray(),
                ParameterType.RequestBody);
            IRestResponse response = _rpcClient.Execute(rpcRequest);
            CodedInputStream cis = new CodedInputStream(response.RawBytes);
            ResponseEnvelope envelope = new ResponseEnvelope();
            envelope.MergeFrom(cis);
            
	        _authTicket = envelope.AuthTicket;
	        _rpcEndpoint = envelope.ApiUrl.Replace("pgorelease.nianticlabs.com", "")+"/rpc";

            Debug.Log("RPC Endpoint: "+_rpcEndpoint);
            Debug.Log("ExpireTimestampMs " + envelope.AuthTicket.ExpireTimestampMs);
        }


	    public TResponse PerformApiRequest<TResponse>(RequestType type, IMessage message) where TResponse : IMessage, new()
	    {
	        ResponseEnvelope envelope = PerformApiRequest(Utils.CreateRequest(type, message));
	        return envelope.Get<TResponse>(0);
        }
        
        public ResponseEnvelope PerformApiRequest(params Request[] requests)
	    {
	        RequestEnvelope requestEnvelope = new RequestEnvelope
	        {
	            StatusCode = 2,
	            RequestId = 1469378659230941192,
	            Longitude = Utils.FloatToULong(0),
	            Latitude = Utils.FloatToULong(0),
	            Altitude = Utils.FloatToULong(50f),
	            Unknown12 = 989,
	            AuthTicket = _authTicket
	        };
	        foreach (Request request in requests)
            { 
                requestEnvelope.Requests.Add(request);
	        }
	        RestRequest rpcRequest = new RestRequest(_rpcEndpoint, Method.POST);
	        rpcRequest.AddParameter(
	            "application/x-www-form-urlencoded",
	            requestEnvelope.ToByteArray(),
	            ParameterType.RequestBody);
	        IRestResponse response = _rpcClient.Execute(rpcRequest);
	        CodedInputStream cis = new CodedInputStream(response.RawBytes);
	        ResponseEnvelope envelope = new ResponseEnvelope();
	        envelope.MergeFrom(cis);
	        return envelope;
	    }


	}
}

