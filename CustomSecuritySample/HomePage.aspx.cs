using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomSecuritySampleWeb
{
    public partial class HomePage : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAddFolder_Click(object sender, EventArgs e)
        {
            Service2010.CreateFolder(this.tb.Text.Trim(), "/", null);
        }

        protected void btnDelFolder_Click(object sender, EventArgs e)
        {
            Service2010.DeleteItem(this.tb.Text.Trim());
        }
    }
}