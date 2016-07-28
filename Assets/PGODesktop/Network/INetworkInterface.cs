using System;
using Google.Protobuf;
using POGOProtos.Networking.Envelopes;
using POGOProtos.Networking.Requests;

namespace PGODesktop.Network
{
	public interface INetworkInterface
	{
	    PtcLoginResult LoginPtc(string username, string password);

        bool LoginGoogle(string email, string password);

        TResponse PerformApiRequest<TResponse>(RequestType type, IMessage message) where TResponse : IMessage, new();

        ResponseEnvelope PerformApiRequest(params Request[] requests);
	}
}

