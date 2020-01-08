using Microsoft.Samples.ReportingServices.CustomSecurity;
using Microsoft.Samples.ReportingServices.CustomSecurity._10._86._65._20;
using Microsoft.Samples.ReportingServices.CustomSecurity.App_LocalResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomSecuritySampleWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtUser.Text = "ruifeng.chang";
            TxtPwd.Text = "chang@20200106";
        }

        protected void ServerBtnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                ReportingService2010 service2010 = new ReportingService2010();
                service2010.Credentials = new NetworkCredential(TxtUser.Text, TxtPwd.Text, "");
                Session.Add("LoginInfo_ReportingService2010", service2010);
                Response.Redirect("~/HomePage.aspx");
            }
            catch (Exception ex) { throw ex; }
            finally { }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        //protected void BtnRegister_Click(object sender, System.EventArgs e)
        //{
        //    string salt = AuthenticationUtilities.CreateSalt(5);
        //    string passwordHash = AuthenticationUtilities.CreatePasswordHash(TxtPwd.Text, salt);
        //    if (AuthenticationUtilities.ValidateUserName(TxtUser.Text))
        //    {
        //        try
        //        {
        //            AuthenticationUtilities.StoreAccountDetails(
        //               TxtUser.Text, passwordHash, salt);
        //        }
        //        catch (Exception ex)
        //        {
        //            lblMessage.Text = string.Format(CultureInfo.InvariantCulture, ex.Message);
        //        }
        //    }
        //    else
        //    {

        //        lblMessage.Text = string.Format(CultureInfo.InvariantCulture,
        //            Logon_aspx.UserNameError);
        //    }
        //}

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        //protected void ServerBtnLogon_Click(object sender,
        //  System.EventArgs e)
        //{
        //    TxtUser.Text = "ruifeng.chang";
        //    TxtPwd.Text = "chang@20200106";
        //    bool passwordVerified = false;
        //    try
        //    {
        //        passwordVerified =
        //           AuthenticationUtilities.VerifyPassword(TxtUser.Text, TxtPwd.Text);
        //        if (passwordVerified)
        //        {
        //            FormsAuthentication.RedirectFromLoginPage(
        //               TxtUser.Text, false);
        //        }
        //        else
        //        {
        //            Response.Redirect("logon.aspx");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblMessage.Text = string.Format(CultureInfo.InvariantCulture, ex.Message);
        //        return;
        //    }
        //    if (passwordVerified == true)
        //    {
        //        // The user is authenticated
        //        // At this point, an authentication ticket is normally created
        //        // This can subsequently be used to generate a GenericPrincipal
        //        // object for .NET authorization purposes
        //        // For details, see "How To: Use Forms authentication with 
        //        // GenericPrincipal objects
        //        lblMessage.Text = string.Format(CultureInfo.InvariantCulture,
        //           Logon_aspx.LoginSuccess);
        //        BtnRegister.Enabled = false;
        //    }
        //    else
        //    {
        //        lblMessage.Text = string.Format(CultureInfo.InvariantCulture,
        //          Logon_aspx.InvalidUsernamePassword);
        //    }
        //}
    }
}