using System;

namespace PGODesktop.Network
{
	public interface INetworkInterface
	{
		PtcLoginResult LoginPtc(string username, string password);

        bool LoginGoogle(string email, string password);
	}
}

