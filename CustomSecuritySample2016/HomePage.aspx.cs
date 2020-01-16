using Microsoft.ReportingServices.Library.Soap;
using Microsoft.ReportingServices.Library.Soap2010;
using Microsoft.ReportingServices.WebServer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected string clientId = ConfigurationManager.AppSettings["client_id"];
        protected string clientSecret = ConfigurationManager.AppSettings["client_secret"];
        protected string domain = ConfigurationManager.AppSettings["domain"];
        protected string automaker_domain = ConfigurationManager.AppSettings["automaker_domain"];
        protected string homepage = ConfigurationManager.AppSettings["homepage"];
        protected ReportingService2010 Service2010 = new ReportingService2010();
        protected string securitycode = "";
        protected Logger logger;
        protected string session_info;
        protected string session_code;

        private void Page_Load(object sender, System.EventArgs e)
        {
            logger = LogManager.GetCurrentClassLogger(typeof(HomePage));
            session_info = string.Format("{0}_{1}", Consts.SESSION_INFO, Session.SessionID);
            session_code = string.Format("{0}_{1}", Consts.SESSION_CODE, Session.SessionID);
            if (!IsPostBack)
            {
                string sessionId = "";
                securitycode = Request["code"];
                if ((null == securitycode || securitycode.Length == 0)
                    && !RedisHelper.Exists(session_code)
                    && !RedisHelper.Exists(session_info))
                {
                    //跳转到登录页
                    Response.Redirect(
                        domain
                        + "?client_id=" + clientId
                        + "&redirect_uri=" + HttpUtility.UrlEncode(homepage, Encoding.UTF8)
                        + "&response_type=code&scope=openid&state=" + sessionId, false);
                }
                else
                {
                    securitycode = !RedisHelper.Exists(session_info) ? Request["code"] : RedisHelper.Get<string>(session_code);
                    //获取token
                    SSOAccessToken token = GetAccessToken();
                    long accountId = 0;
                    if (token != null&& long.TryParse(token.OpenId,out accountId))
                    {
                        SessionUser sessionUser = SqlHelper.GetUserInfoByAccount(accountId);
                        SessionInfo sessionInfo = new SessionInfo(token, sessionUser);
                        //获取当前用户的权限编码列表
                        //List<string> codes = GetCurrentPrivileges(token.AccessToken);
                        if (!RedisHelper.Exists(session_info))
                        {
                            RedisHelper.Set(session_info, sessionInfo);
                        }
                        if (!RedisHelper.Exists(session_code))
                        {
                            RedisHelper.Set(session_code, securitycode);
                        }

                        FormsAuthentication.SetAuthCookie(String.Format("{0}", sessionUser.Email), false);
                    }
                }
            }
        }

        private List<string> GetCurrentPrivileges(string accessToken)
        {
            try
            {
                string url = automaker_domain + "/api/user/currentPrivileges?access_token=" + accessToken;
                string retString = HttpUtils.Get(url);
                List<string> lst = (JsonConvert.DeserializeObject(retString) as JArray).ToObject<List<string>>();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SSOAccessToken GetAccessToken()
        {
            Dictionary<string, string> paramsMap = new Dictionary<string, string>();
            paramsMap.Add("client_id", clientId);
            paramsMap.Add("client_secret", clientSecret);
            paramsMap.Add("code", securitycode);
            paramsMap.Add("grant_type", "authorization_code");
            paramsMap.Add("redirect_uri", HttpUtility.UrlEncode(homepage, Encoding.UTF8));

            try
            {
                string url = domain + "/oauth2/token";
                string retString = HttpUtils.GetPostString(url, paramsMap);

                SSOAccessToken token = null;
                if (retString != null)
                {
                    //获取token
                    JObject jo = JsonConvert.DeserializeObject(retString) as JObject;
                    if (jo != null)
                    {
                        token = new SSOAccessToken();
                        token.AccessToken = jo["access_token"].ToObject<string>();
                        token.RefreshToken = jo["refresh_token"].ToObject<string>();
                        token.Scope = jo["scope"].ToObject<string>();
                        token.ExpiresIn = jo["expire_in"].ToObject<long>();
                        token.OpenId = jo["openid"].ToObject<string>();
                        token.Source = jo["source"].ToObject<string>();
                    }
                }
                return token;
            }
            catch (Exception ex)
            {
                logger.ErrorEx(ex);
                return null;
            }
        }
    }
}