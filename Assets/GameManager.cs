using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using PGODesktop.Network;
using SimpleCoroutines;

namespace PGODesktop
{

	public class GameManager : MonoBehaviour
	{
		public GameObject LoginPanel;
		public InputField UsernameField;
		public InputField PasswordField;
		public Button LoginButton;
		private INetworkInterface network;
		private bool _loggedIn;

		private void Start ()
		{
			//To use the real live pokemmon go servers, swop to DesktopNetworkInterface
			//network = new FakeNetworkInterface ();
			network = new DesktopNetworkInterface();

			LoginPanel.SetActive (true);
			LoginButton.onClick.AddListener(delegate {
				CoroutineManager.Start ("login", BeginLogin ());
			});
		}

		private IEnumerator BeginLogin ()
		{
			yield return new EnterForeground ();
			LoginPanel.SetActive (false);
			//TODO: Show logging in dialog

			yield return new EnterBackground ();
			_loggedIn = network.loginPTC (UsernameField.text, PasswordField.text);

			if (_loggedIn) {
				Debug.Log ("Logged in!");
				//TODO: Start gameplay
			} else {
				Debug.Log ("Login failed!");
				yield return new EnterForeground ();
				//TODO: Show log in failed dialog
				LoginPanel.SetActive (true);
			}
		}

		private void Update ()
		{
	
		}
	}

}