// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Error22" file="FakeNetworkInterface.cs">
//   Copyright (c) 2016 Error22 All Rights Reserved. 
//   See License.txt for License Information.
// </copyright>
// <summary>
//   The fake network interface.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

using System.Threading;

namespace PGODesktop.Network
{
	/// <summary>
	/// The fake network interface.
	/// </summary>
	public class FakeNetworkInterface : INetworkInterface
	{
		#region  Interface Implementations

		/// <summary>
		/// The login to the fake Pokemon Trainer Club.
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
			Thread.Sleep(2000);

			if (username.Equals("testuser") && password.Equals("123"))
			{
				// Any data needed??
				return PtcLoginResult.Success;
			}

			return PtcLoginResult.InvalidCredentials;
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
			Thread.Sleep(2000);

			if (email.Equals("test@gmail.com") && password.Equals("123"))
			{
				// Any data needed??
				return true;
			}

			return false;
		}

		#endregion
	}
}