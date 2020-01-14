using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    public class Global : Microsoft.ReportingServices.WebServer.Global
    {
        protected void Application_Start()
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }
    }
}
