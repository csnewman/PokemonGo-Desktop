// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesktopNetworkInterface.cs" company="">
//   
// </copyright>
// <summary>
//   The desktop network interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using POGOProtos.Networking.Envelopes;
using POGOProtos.Networking.Requests;
using RestSharp;
using UnityEngine;
using Random = System.Random;

namespace PGODesktop.Network
{
	/// <summary>
	/// The desktop network interface.
	/// </summary>
	public class DesktopNetworkInterface : INetworkInterface
	{
		#region Static Fields and Constants

		/// <summary>
		/// The user agent.
		/// </summary>
		private const string UserAgent = "niantic";

		/// <summary>
		/// The login url.
		/// </summary>
		private const string LoginUrl = "https://sso.pokemon.com";

		/// <summary>
		/// The login endpoint.
		/// </summary>
		private const string LoginEndpoint =
			"/sso/login?service=https%3A%2F%2Fsso.pokemon.com%2Fsso%2Foauth2.0%2FcallbackAuthorize";

		/// <summary>
		/// The oauth endpoint.
		/// </summary>
		private const string OauthEndpoint = "/sso/oauth2.0/accessToken";

		/// <summary>
		/// The client id.
		/// </summary>
		private const string ClientId = "mobile-app_pokemon-go";

		/// <summary>
		/// The redirect uri.
		/// </summary>
		private const string RedirectUri = "https://www.nianticlabs.com/pokemongo/error";

		/// <summary>
		/// The client secret.
		/// </summary>
		private const string ClientSecret = "w8ScCUXJQc6kXKw8FiOhd8Fixzht18Dq3PEVkUCP5ZPxtgyWsbTvWHFLm2wNY0JR";

		#endregion

		#region  Fields

		/// <summary>
		/// The _random.
		/// </summary>
		private readonly Random _random;

		/// <summary>
		/// The authorization info.
		/// </summary>
		private RequestEnvelope.Types.AuthInfo _authInfo;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DesktopNetworkInterface"/> class.
		/// </summary>
		public DesktopNetworkInterface()
		{
			this._random = new Random();
			ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The login to Pokemon Trainer Club.
		/// </summary>
		/// <param name="username">
		/// The username.
		/// </param>
		/// <param name="password">
		/// The password.
		/// </param>
		/// <returns>
		/// The <see cref="PtcLoginResult"/>.
		/// </returns>
		public PtcLoginResult LoginPtc(string username, string password)
		{
			IRestClient loginClient = new RestClient(LoginUrl);
			loginClient.CookieContainer = new CookieContainer();
			loginClient.UserAgent = UserAgent;
			loginClient.FollowRedirects = false;

			IRestResponse inital = loginClient.Execute(new RestRequest(LoginEndpoint, Method.GET));

// TODO: Error check
			JObject data = JObject.Parse(inital.Content);

			RestRequest request = new RestRequest(LoginEndpoint, Method.POST);
			request.AddParameter("lt", (string)data["lt"]);
			request.AddParameter("execution", (string)data["execution"]);
			request.AddParameter("_eventId", "submit");
			request.AddParameter("username", username);
			request.AddParameter("password", password);

			IRestResponse response = loginClient.Execute(request);

// TODO: Error check
			string location = response.GetHeader("location");
			if (location == null)
			{
				Debug.LogError(
					"No location header returned! " + response.StatusCode + "(" + response.StatusDescription + ")  " + response.Content);
				JObject errorData = JObject.Parse(response.Content);
				if ((string)errorData["error_code"] == "users.login.activation_required")
				{
					return PtcLoginResult.VerificationNeeded;
				}
				else
				{
					return PtcLoginResult.InvalidCredentials;
				}
			}

			IDictionary<string, string> query = location.GetQuerySection().ParseQueryString(true);
			if (!query.ContainsKey("ticket"))
			{
				Debug.LogError("No ticket returned");
				return PtcLoginResult.Error;
			}

			Debug.Log("Ticket: " + query["ticket"]);

			RestRequest renew = new RestRequest(OauthEndpoint, Method.POST);
			renew.AddParameter("client_id", ClientId);
			renew.AddParameter("redirect_uri", RedirectUri);
			renew.AddParameter("client_secret", ClientSecret);
			renew.AddParameter("grant_type", "refresh_token");
			renew.AddParameter("code", query["ticket"]);

			IRestResponse renewResponse = loginClient.Execute(renew);
			string token = renewResponse.Content.ParseQueryString(true)["access_token"];
			Debug.Log("Token: " + token);

			this._authInfo = new RequestEnvelope.Types.AuthInfo()
			{
				Provider = "ptc",
				Token = new RequestEnvelope.Types.AuthInfo.Types.JWT() { Contents = token, Unknown2 = 59 }
			};

			return PtcLoginResult.Success;
		}

		/// <summary>
		/// The login google.
		/// </summary>
		/// <param name="email">
		/// The email.
		/// </param>
		/// <param name="password">
		/// The password.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		public bool LoginGoogle(string email, string password)
		{
			Debug.LogError("Google login is not supported yet");
			return false;
		}

		#endregion

		#region  Methods - Private

		/// <summary>
		/// The perform API request.
		/// </summary>
		/// <param name="useTicket">
		/// The use ticket.
		/// </param>
		/// <param name="requests">
		/// The requests.
		/// </param>
		private void PerformApiRequest(bool useTicket, params Request[] requests)
		{
			RequestEnvelope requestEnvelope = new RequestEnvelope
			{
				StatusCode = 2,
				RequestId = this._random.NextULong(),
				Longitude = Utils.FloatToULong(0),
				Latitude = Utils.FloatToULong(0),
				Altitude = 10d,
				Unknown12 = 989,
				Requests = { requests }
			};

			if (useTicket)
			{
				requestEnvelope.AuthInfo = this._authInfo;
			}
			else
			{
				// TODO: Use ticket
			}

			// TODO: Call RPC

			// TODO: Decode response
		}

		#endregion
	}
}