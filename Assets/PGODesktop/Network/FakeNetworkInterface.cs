using System;
using System.Threading;
using Google.Protobuf;
using POGOProtos.Networking.Envelopes;
using POGOProtos.Networking.Requests;

namespace PGODesktop.Network
{
    public class FakeNetworkInterface : INetworkInterface
    {
        public PtcLoginResult LoginPtc(string username, string password)
        {
            Thread.Sleep(2000);

            if (username.Equals("testuser") && password.Equals("123"))
            {
                //Any data needed??
                return PtcLoginResult.Success;
            }
            return PtcLoginResult.InvalidCredentials;
        }

        public bool LoginGoogle(string email, string password)
        {
            Thread.Sleep(2000);

            if (email.Equals("test@gmail.com") && password.Equals("123"))
            {
                //Any data needed??
                return true;
            }
            return false;
        }

        public TResponse PerformApiRequest<TResponse>(RequestType type, IMessage message)
            where TResponse : IMessage, new()
        {
            throw new NotImplementedException();
        }

        public ResponseEnvelope PerformApiRequest(params Request[] requests)
        {
            throw new NotImplementedException();
        }
    }
}