// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Error22" file="INetworkInterface.cs">
//   Copyright (c) 2016 Error22 All Rights Reserved. 
//   See License.txt for License Information.
// </copyright>
// <summary>
//   The NetworkInterface interface.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------
 
namespace PGODesktop.Network
{
	/// <summary>
	/// The NetworkInterface interface.
	/// </summary>
	public interface INetworkInterface
	{
		#region  Methods - Public

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
		PtcLoginResult LoginPtc(string username, string password);

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
		bool LoginGoogle(string email, string password);

		#endregion
	}
}