using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    [Serializable]
    public class SSOAccessToken
    {
        public SSOAccessToken()
        {

        }

        public string AccessToken { get; set; }
        public long ExpiresIn { get; set; }
        public string RefreshToken { get; set; }
        public string OpenId { get; set; }
        public string Scope { get; set; }
        public string Source { get; set; }
    }
}
