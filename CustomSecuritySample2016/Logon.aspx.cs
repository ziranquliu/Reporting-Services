#region
// Copyright (c) 2016 Microsoft Corporation. All Rights Reserved.
// Licensed under the MIT License (MIT)
/*============================================================================
  File:     Logon.aspx.cs
  Summary:  The code-behind for a logon page that supports Forms
            Authentication in a custom security extension    
--------------------------------------------------------------------
  This file is part of Microsoft SQL Server Code Samples.
    
 This source code is intended only as a supplement to Microsoft
 Development Tools and/or on-line documentation. See these other
 materials for detailed information regarding Microsoft code 
 samples.

 THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF 
 ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
 THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
 PARTICULAR PURPOSE.
===========================================================================*/
#endregion

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Web.Security;
using Microsoft.ReportingServices.Interfaces;
using Microsoft.Samples.ReportingServices.CustomSecurity.App_LocalResources;
using System.Globalization;
using Microsoft.Samples.ReportingServices.CustomSecurity.localhost;
using System.Net;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    public class Logon : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.Label LblUser;
        protected System.Web.UI.WebControls.TextBox TxtPwd;
        protected System.Web.UI.WebControls.TextBox TxtUser;
        protected System.Web.UI.WebControls.Button BtnRegister;
        protected System.Web.UI.WebControls.Button BtnLogon;
        protected System.Web.UI.WebControls.Label lblMessage;
        protected System.Web.UI.WebControls.Label Label1;
        protected System.Web.UI.WebControls.Label LblPwd;

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

        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            InitializeComponent();
            base.OnInit(e);
        }

        private void InitializeComponent()
        {
            this.BtnLogon.Click += new System.EventHandler(this.ServerBtnLogon_Click);
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            string salt = AuthenticationUtilities.CreateSalt(5);
            string passwordHash = AuthenticationUtilities.CreatePasswordHash(TxtPwd.Text, salt);
            if (AuthenticationUtilities.ValidateUserName(TxtUser.Text))
            {
                try
                {
                    AuthenticationUtilities.StoreAccountDetails(TxtUser.Text, passwordHash, salt);
                }
                catch (Exception ex)
                {
                    lblMessage.Text = string.Format(CultureInfo.InvariantCulture, ex.Message);
                }
            }
            else
            {
                lblMessage.Text = string.Format(CultureInfo.InvariantCulture, Logon_aspx.UserNameError);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void ServerBtnLogon_Click(object sender, System.EventArgs e)
        {
            bool passwordVerified = false;
            try
            {
                passwordVerified = AuthenticationUtilities.VerifyPassword(TxtUser.Text, TxtPwd.Text);
                if (passwordVerified)
                {
                    RedisHelper.Set("TxtUser", TxtUser.Text, 30);
                    RedisHelper.Set("TxtPwd", TxtPwd.Text, 30);
                    FormsAuthentication.SetAuthCookie(TxtUser.Text, false);
                    Response.Redirect("HomePage.aspx", false);
                    //FormsAuthentication.RedirectFromLoginPage(TxtUser.Text, false);
                }
                else
                {
                    Response.Redirect("logon.aspx");
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = string.Format(CultureInfo.InvariantCulture, ex.Message);
                return;
            }
            if (passwordVerified == true)
            {
                // The user is authenticated
                // At this point, an authentication ticket is normally created
                // This can subsequently be used to generate a GenericPrincipal
                // object for .NET authorization purposes
                // For details, see "How To: Use Forms authentication with 
                // GenericPrincipal objects
                lblMessage.Text = string.Format(CultureInfo.InvariantCulture, Logon_aspx.LoginSuccess);
                BtnRegister.Enabled = false;
            }
            else
            {
                lblMessage.Text = string.Format(CultureInfo.InvariantCulture, Logon_aspx.InvalidUsernamePassword);
            }
        }
        //protected void BtnAdminLogin_Click(object sender, EventArgs e)
        //{
        //    TxtUser.Text = "ruifeng.chang";
        //    TxtPwd.Text = "";
        //    try
        //    {
        //        ReportingService2010 service2010 = new ReportingService2010();
        //        service2010.Credentials = new NetworkCredential(TxtUser.Text, TxtPwd.Text, "Geely");
        //        RedisHelper.Set("TxtUser", TxtUser.Text, 30);
        //        RedisHelper.Set("TxtPwd", TxtPwd.Text, 30);
        //        FormsAuthentication.SetAuthCookie(TxtUser.Text, false);
        //        Response.Redirect("HomePage.aspx", false);
        //    }
        //    catch (Exception ex) { throw ex; }
        //    finally { }
        //}
    }
}
