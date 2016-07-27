// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Error22" file="PtcLoginResult.cs">
//   Copyright (c) 2016 Error22 All Rights Reserved. 
//   See License.txt for License Information.
// </copyright>
// <summary>
//   The Pokemon Trainer Club login result.
// </summary>
//  
// --------------------------------------------------------------------------------------------------------------------

namespace PGODesktop.Network
{
	/// <summary>
	/// The Pokemon Trainer Club login result.
	/// </summary>
	public enum PtcLoginResult
	{
		/// <summary>
		/// The success.
		/// </summary>
		Success,

		/// <summary>
		/// The verification needed.
		/// </summary>
		VerificationNeeded,

		/// <summary>
		/// The invalid credentials.
		/// </summary>
		InvalidCredentials,

		/// <summary>
		/// The error.
		/// </summary>
		Error
	}
}