// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameManager.cs" company="">
//   
// </copyright>
// <summary>
//   The game manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections;
using PGODesktop.Network;
using SimpleCoroutines;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace PGODesktop
{
	/// <summary>
	/// The game manager.
	/// </summary>
	public class GameManager : MonoBehaviour
	{
		#region  Fields

		/// <summary>
		/// The _logged in.
		/// </summary>
		private bool _loggedIn;

		/// <summary>
		/// The logging in panel.
		/// </summary>
		[SerializeField]
		private GameObject _loggingInPanel;

		/// <summary>
		/// The _network.
		/// </summary>
		private INetworkInterface _network;

		/// <summary>
		/// The login button.
		/// </summary>
		[SerializeField]
		private Button _loginButton;

		/// <summary>
		/// The login message.
		/// </summary>
		[SerializeField]
		private Text _loginMessage;

		/// <summary>
		/// The login message panel.
		/// </summary>
		[SerializeField]
		private GameObject _loginMessagePanel;

		/// <summary>
		/// The login panel.
		/// </summary>
		[SerializeField]
		private GameObject _loginPanel;

		/// <summary>
		/// The password field.
		/// </summary>
		[SerializeField]
		private InputField _passwordField;

		/// <summary>
		/// The username field.
		/// </summary>
		[SerializeField]
		private InputField _usernameField;

		#endregion

		#region  Methods - Private

		/// <summary>
		/// The start.
		/// </summary>
		private void Start()
		{
			// To use the real live pokemmon go servers, swop to DesktopNetworkInterface
			// network = new FakeNetworkInterface ();
			this._network = new DesktopNetworkInterface();

			this._loginPanel.SetActive(true);
			this._loginMessagePanel.SetActive(false);
			this._loginButton.onClick.AddListener(delegate { CoroutineManager.Start("login", this.BeginLogin()); });
		}

		/// <summary>
		/// The begin login.
		/// </summary>
		/// <returns>
		/// The <see cref="IEnumerator"/>.
		/// </returns>
		/// <exception cref="Exception">
		/// Already Logged in Exception.
		/// </exception>
		private IEnumerator BeginLogin()
		{
			Assert.IsTrue(this._loggedIn, "Already logged in?");

			yield return new EnterForeground();
			this._loginPanel.SetActive(false);
			this._loginMessagePanel.SetActive(false);
			this._loggingInPanel.SetActive(true);

			// TODO: Show logging in dialog
			yield return new EnterBackground();
			PtcLoginResult result = this._network.LoginPtc(this._usernameField.text, this._passwordField.text);

			if (result == PtcLoginResult.Success)
			{
				this._loggedIn = true;
				Debug.Log("Logged in!");
				yield return new EnterForeground();
				this._loggingInPanel.SetActive(false);

				// TODO [csnewman 26-07-2016] : Start gameplay
			}
			else
			{
				Debug.Log("Login failed!");
				yield return new EnterForeground();
				this._loggingInPanel.SetActive(false);
				this._loginPanel.SetActive(true);
				this._loginMessagePanel.SetActive(true);
				this._loginMessage.text = result.ToString();
				this._loginMessagePanel.GetComponent<AutoDestroy>().ResetTime();
			}
		}

		/// <summary>
		/// The update.
		/// </summary>
		private void Update()
		{
		}

		#endregion
	}
}