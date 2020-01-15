using System;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    [Serializable]
    internal class SessionInfo
    {
        public SessionInfo(SSOAccessToken token, SessionUser sessionUser)
        {
            this.Token = token;
            this.SessionUser = sessionUser;
        }

        public SSOAccessToken Token { get; set; }
        internal SessionUser SessionUser { get; set; }
    }
}