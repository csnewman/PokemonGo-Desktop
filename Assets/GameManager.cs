using UnityEngine;
using UnityEngine.Experimental.Networking;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Security;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Contrib;

public class GameManager : MonoBehaviour {
	private const string LOGIN_URL = "https://sso.pokemon.com/sso/login?service=https%3A%2F%2Fsso.pokemon.com%2Fsso%2Foauth2.0%2FcallbackAuthorize";
	private const string USER_AGENT = "niantic";


	// Use this for initialization
	void Start () {
		ServicePointManager.ServerCertificateValidationCallback = delegate {
			return true;
		};

		BeginLogin ();
	}

	private void BeginLogin(){

		RestClient client = new RestClient ();
		client.CookieContainer = new CookieContainer ();
		client.UserAgent = "niantic";
		client.FollowRedirects = false;

		RestRequest request = new RestRequest (LOGIN_URL, Method.GET);


		client.ExecuteAsync(request, response => {
			
			JObject data = JObject.Parse(response.Content);


			Debug.Log("1> "+response.Content);

			RestRequest second = new RestRequest(LOGIN_URL, Method.POST);
			second.AddParameter("lt", (string) data["lt"]);
			second.AddParameter("execution", (string) data["execution"]);
			second.AddParameter("_eventId", "submit");
			second.AddParameter("username", "[USERNAME]");
			second.AddParameter("password", "[PASSWORD]");


			Debug.Log("sending...");
			client.ExecuteAsync(second, resp => {
				Debug.Log("2> "+resp.Content+"  "+resp.ResponseUri);

				String redirect = null;
				foreach(Parameter param in resp.Headers){
					if(param.Name.ToLower() == "location"){
						redirect = param.Value.ToString();
					}
					//Debug.Log(param.Name+"="+param.Value );
				}



				Debug.Log("Location header: "+redirect);

				Debug.Log("Login ok? "+(redirect != null && redirect.Contains("ticket")));


			});


		});
	}

	// Update is called once per frame
	void Update () {
	
	}
}

