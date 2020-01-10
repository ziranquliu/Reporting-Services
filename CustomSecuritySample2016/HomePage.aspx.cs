using Microsoft.Samples.ReportingServices.CustomSecurity.localhost;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        private string clientId = ConfigurationManager.AppSettings["client_id"];
        private string clientSecret = ConfigurationManager.AppSettings["client_secret"];
        private string domain = ConfigurationManager.AppSettings["domain"];
        private string automaker_domain = ConfigurationManager.AppSettings["automaker_domain"];
        private string homepage = ConfigurationManager.AppSettings["homepage"];

        private void Page_Load(object sender, System.EventArgs e)
        {
            if (!IsPostBack)
            {
                string sessionId = "";
                string code = Request["code"];
                if (null == code || code.Length == 0)
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
                    //获取token
                    SSOAccessToken token = GetAccessToken(Request);
                    if (token != null)
                    {
                        //SessionInfo sessionInfo = new SessionInfo(token, getUserInfo(token));
                        //获取当前用户的权限编码列表
                        List<string> codes = GetCurrentPrivileges(token.AccessToken);
                        //sessionInfo.getSessionUser().setUserPermissionCode(codes);
                        //List<UserPermission> list = getUserPermission((Privilege)session.getServletContext().getAttribute("privilege"), codes);
                        //sessionInfo.getSessionUser().setUserPermission(list);
                        //session.setAttribute(SESSION_INFO, sessionInfo);
                        FormsAuthentication.SetAuthCookie(token.OpenId, false);
                    }
                }
            }
        }
        //private SessionUser getUserInfo(AccessToken token)
        //{
        //    String accountId = token.getOpenId();
        //    return mdmEmployeeMapper.selectSessionUser(Long.valueOf(accountId));
        //}
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

        private SSOAccessToken GetAccessToken(HttpRequest request)
        {
            Dictionary<string, string> paramsMap = new Dictionary<string, string>();
            paramsMap.Add("client_id", clientId);
            paramsMap.Add("client_secret", clientSecret);
            paramsMap.Add("code", Request["code"]);
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
                throw ex;
            }
        }

        //protected ReportingService2010 Service2010
        //{
        //    get
        //    {
        //        return new ReportingService2010()
        //        {
        //            Credentials = new NetworkCredential(RedisHelper.Get<string>("TxtUser"), RedisHelper.Get<string>("TxtPwd"), "")
        //        };
        //    }
        //}
        protected void btnAddFolder_Click(object sender, EventArgs e)
        {
            //Service2010.CreateFolder(this.tb.Text.Trim(), "/", null);
        }

        protected void btnDelFolder_Click(object sender, EventArgs e)
        {
            //Service2010.DeleteItem(this.tb.Text.Trim());
        }

        //public string GetSecurityScopes()
        //{
        //    return String.Join(",", Service2010.ListSecurityScopes());
        //}
        //public string GetModelItemTypes()
        //{
        //    return String.Join(",", Service2010.ListModelItemTypes());
        //}

        //public string GetItemTypes()
        //{
        //    return String.Join(",", Service2010.ListItemTypes());
        //}
        //public List<CatalogItemExt> GetCatalog()
        //{
        //    List<CatalogItemExt> catalogItemExts = new List<CatalogItemExt>();
        //    foreach (CatalogItem item in Service2010.ListChildren("/", true))
        //    {
        //        catalogItemExts.Add(new CatalogItemExt
        //        {
        //            CreatedBy = item.CreatedBy,
        //            ModifiedDateSpecified = item.ModifiedDateSpecified,
        //            ModifiedDate = item.ModifiedDate,
        //            CreationDateSpecified = item.CreationDateSpecified,
        //            CreationDate = item.CreationDate,
        //            HiddenSpecified = item.HiddenSpecified,
        //            Hidden = item.Hidden,
        //            Description = item.Description,
        //            SizeSpecified = item.SizeSpecified,
        //            Size = item.Size,
        //            TypeName = item.TypeName,
        //            VirtualPath = item.VirtualPath,
        //            Path = item.Path,
        //            Name = item.Name,
        //            ID = item.ID,
        //            ModifiedBy = item.ModifiedBy,
        //            ItemMetadata = item.ItemMetadata,
        //        });
        //    }
        //    return catalogItemExts;
        //}
    }
}