using Microsoft.ReportingServices.Library.Soap;
using Microsoft.ReportingServices.Library.Soap2010;
using Microsoft.ReportingServices.WebServer;
using Microsoft.Samples.ReportingServices.CustomSecurity.Enums;
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
                securitycode = RedisHelper.Exists(session_code) ? RedisHelper.Get<string>(session_code) : Request["code"];
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
                    //获取token
                    SSOAccessToken token = GetAccessToken(Request);
                    if (token != null)
                    {
                        SessionUser sessionUser = GetUserInfo(token);
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

                        FormsAuthentication.SetAuthCookie(String.Format("{0}", sessionUser.UserDisplayName), false);
                    }
                }
            }
        }
        private SessionUser GetUserInfo(SSOAccessToken token)
        {
            string accountId = token.OpenId;
            string sql = String.Format(@"SELECT 
                            ME.AccountId,
                            ME.UserId,
							UA.DisplayName AS UserDisplayName,
							UA.Email,
							UA.Mobile,
                            MD.Id AS DealerId,
                            SO.DealerCode,
							MD.ShortName,
							MD.FullName,
                            SO.Id AS OrgId,
                            SO.Name AS OrgName
                        FROM MdmEmployee ME
                        LEFT JOIN SysOrg SO ON ME.OrgId = SO.Id
                        LEFT JOIN MdmDealer MD ON MD.DealerCode = SO.DealerCode
						LEFT JOIN UsAccount UA ON UA.Id=ME.AccountId
                        WHERE ME.AccountId = '{0}'", long.Parse(accountId));
            return DatatableToEntity<SessionUser>.FillModel(SqlHelper.ExecuteDataTable(sql)).FirstOrDefault();
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

        private SSOAccessToken GetAccessToken(HttpRequest request)
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

        protected void btnAddFolder_Click(object sender, EventArgs e)
        {
            CatalogItem ItemInfo = null;
            Service2010.CreateFolder(this.tbFolder.Text.Trim('/', '\\'), "/", null, out ItemInfo);
        }

        protected void btnDelFolder_Click(object sender, EventArgs e)
        {
            Service2010.DeleteItem("/" + this.tbFolder.Text.Trim('/', '\\'));
        }
     
        public string ExitLogon()
        {
            RedisHelper.Remove(session_code);
            RedisHelper.Remove(session_info);
            FormsAuthentication.SignOut();
            return "ok";
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
        //public string GetServerConfigInfo()
        //{
        //    string ServerConfigInfo = null;
        //    //try
        //    //{
        //    //    Service2010.GetReportServerConfigInfo(true, out ServerConfigInfo);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    logger.ErrorEx(ex);
        //    //}
        //    return ServerConfigInfo;
        //}
        //public List<CatalogItem> GetCatalog()
        //{
        //    CatalogItem[] CatalogItems = new CatalogItem[0];
        //    try
        //    {
        //        Service2010.ListChildren("/", true, out CatalogItems);
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.ErrorEx(ex);
        //    }
        //    return CatalogItems.ToList();
        //}

        //protected void btnUpFile_Click(object sender, EventArgs e)
        //{
        //    if (this.upFile.HasFile)
        //    {
        //        FileInfo fileInfo = new FileInfo(this.upFile.PostedFile.FileName);
        //        string itemtype = "";
        //        if (fileInfo.Extension == ".pbix")
        //        {
        //            itemtype = CatalogItemTypeEnum.Report.ToString();
        //        }
        //        if (fileInfo.Extension == ".rdl")
        //        {
        //            itemtype = CatalogItemTypeEnum.Report.ToString();
        //        }
        //        if (itemtype.Length > 0)
        //        {
        //            try
        //            {
        //                CatalogItem catalogItem = null;
        //                byte[] definition = null;
        //                Warning[] warns = null;

        //                try
        //                {
        //                    Stream stream = this.upFile.PostedFile.InputStream;
        //                    definition = new byte[stream.Length];
        //                    stream.Read(definition, 0, (int)stream.Length);
        //                    stream.Close();
        //                }
        //                catch (IOException ex)
        //                {
        //                    logger.ErrorEx(ex);
        //                }
        //                string parent = this.tbFolder.Text.Trim();
        //                if (string.IsNullOrEmpty(parent))
        //                {
        //                    parent = "/";
        //                }
        //                else
        //                {
        //                    if (!parent.StartsWith("/"))
        //                    {
        //                        parent = "/" + parent;
        //                    }
        //                }
        //                Service2010.CreateCatalogItem(
        //                    itemtype,
        //                    fileInfo.Name,
        //                    parent,
        //                    true, definition, null, out catalogItem, out warns
        //                    );
        //                logger.WarnEx(warns);
        //            }
        //            catch (Exception ex)
        //            {
        //                logger.ErrorEx(ex);
        //            }
        //        }
        //    }
        //}

        //protected void btnDelFile_Click(object sender, EventArgs e)
        //{

        //}
    }
}