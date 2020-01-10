//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    //{"access_token":"UBTX4E4wQvxIAAAAAADYOrIf9s34elAi","refresh_token":"6V6mG8olSexIAAAAAADYOo5NUymWxRK_","scope":"openid","expire_in":86399,"openid":"5188146770730866746","source":1}
    [Serializable]
    public class SSOAccessToken
    {
        public SSOAccessToken()
        {

        }

        //[JsonProperty("access_token")]
        public string AccessToken { get; set; }
        //[JsonProperty("expire_in")]
        public long ExpiresIn { get; set; }
        //[JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        //[JsonProperty("openid")]
        public string OpenId { get; set; }
        //[JsonProperty("scope")]
        public string Scope { get; set; }
        //[JsonProperty("source")]
        public string Source { get; set; }
    }
}
