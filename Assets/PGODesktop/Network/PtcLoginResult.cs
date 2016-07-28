using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PGODesktop.Network
{
    public enum PtcLoginResult
    {
        Success,
        VerificationNeeded,
        InvalidCredentials,
        Error
    }
}