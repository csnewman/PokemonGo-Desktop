using System;

namespace PGODesktop.Network
{
	public interface INetworkInterface
	{
		bool loginPTC(string username, string password);

		bool loginGoogle(string email, string password);
	}
}

