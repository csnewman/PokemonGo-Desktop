// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PtcLoginResult.cs" company="">
//   
// </copyright>
// <summary>
//   The ptc login result.
// </summary>
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