using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using PGODesktop.Network;
using POGOProtos.Networking.Requests;
using POGOProtos.Networking.Requests.Messages;
using POGOProtos.Networking.Responses;
using SimpleCoroutines;

namespace PGODesktop
{

    public class GameManager : MonoBehaviour
	{
		public GameObject LoginPanel;
		public InputField UsernameField;
		public InputField PasswordField;
		public Button LoginButton;
		public GameObject LoginMessagePanel;
		public Text LoginMessage;
		public GameObject LoggingInPanel;
		private INetworkInterface _network;
		private bool _loggedIn;

		private void Start ()
		{
            //To use the real live pokemmon go servers, swop to DesktopNetworkInterface
            //network = new FakeNetworkInterface ();
            _network = new DesktopNetworkInterface();

			LoginPanel.SetActive (true);
			LoginMessagePanel.SetActive (false);
			LoginButton.onClick.AddListener(delegate {
				CoroutineManager.Start ("login", BeginLogin ());
			});
		}

        private IEnumerator BeginLogin()
        {
            if (_loggedIn)
            {
                throw new Exception("Already logged in?");
            }

            yield return new EnterForeground();
            LoginPanel.SetActive(false);
            LoginMessagePanel.SetActive(false);
            LoggingInPanel.SetActive(true);

            //TODO: Show logging in dialog

            yield return new EnterBackground();
            PtcLoginResult result = _network.LoginPtc(UsernameField.text, PasswordField.text);

            if (result == PtcLoginResult.Success)
            {
                _loggedIn = true;
                Debug.Log("Logged in!");
                yield return new EnterForeground();
                LoggingInPanel.SetActive(false);
                //TODO: Start gameplay
                GetPlayerResponse response = _network.PerformApiRequest<GetPlayerResponse>(RequestType.GetPlayer, new GetPlayerMessage());
                Debug.Log("Player Data: "+ response.PlayerData);
            }
            else
            {
                Debug.Log("Login failed!");
                yield return new EnterForeground();
                LoggingInPanel.SetActive(false);
                LoginPanel.SetActive(true);
                LoginMessagePanel.SetActive(true);
                LoginMessage.text = result.ToString();
                LoginMessagePanel.GetComponent<AutoDestroy>().ResetTime();
            }
        }

        private void Update ()
		{


		}
	}

}