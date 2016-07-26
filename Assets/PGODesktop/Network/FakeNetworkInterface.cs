using System;
using System.Threading;

namespace PGODesktop.Network
{
	public class FakeNetworkInterface : INetworkInterface
	{

		public PtcLoginResult LoginPtc(string username, string password){
			Thread.Sleep (2000);

			if(username.Equals("testuser") && password.Equals("123")){
				//Any data needed??
				return PtcLoginResult.Success;
			}
			return PtcLoginResult.InvalidCredentials;
		}

		public bool LoginGoogle(string email, string password){
			Thread.Sleep (2000);

			if(email.Equals("test@gmail.com") && password.Equals("123")){
				//Any data needed??
				return true;
			}
			return false;
		}

	}
}

