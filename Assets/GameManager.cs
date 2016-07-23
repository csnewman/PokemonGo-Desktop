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
using PGODesktop.Network;
using SimpleCoroutines;

namespace PGODesktop
{

	public class GameManager : MonoBehaviour
	{
		
		private INetworkInterface network;

		// Use this for initialization
		void Start ()
		{
			ServicePointManager.ServerCertificateValidationCallback = delegate {
				return true;
			};

			network = new DesktopNetworkInterface ();

			CoroutineManager.Start ("login", BeginLogin ());
		}


		private IEnumerator BeginLogin ()
		{
			yield return new EnterBackground ();

			network.loginPTC ("[USERNAME]", "[PASSWORD]");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	}

}