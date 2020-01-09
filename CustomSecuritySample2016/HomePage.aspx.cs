using Microsoft.Samples.ReportingServices.CustomSecurity.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected ReportingService2010 Service2010
        {
            get
            {
                return new ReportingService2010()
                {
                    Credentials = new NetworkCredential(RedisHelper.Get<string>("TxtUser"), RedisHelper.Get<string>("TxtPwd"), "")
                };
            }
        }
        protected void btnAddFolder_Click(object sender, EventArgs e)
        {
            Service2010.CreateFolder(this.tb.Text.Trim(), "/", null);
        }

        protected void btnDelFolder_Click(object sender, EventArgs e)
        {
            Service2010.DeleteItem(this.tb.Text.Trim());
        }

        public string GetSecurityScopes()
        {
            return String.Join(",", Service2010.ListSecurityScopes());
        }
        public string GetModelItemTypes()
        {
            return String.Join(",", Service2010.ListModelItemTypes());
        }

        public string GetItemTypes()
        {
            return String.Join(",", Service2010.ListItemTypes());
        }
        public List<CatalogItemExt> GetCatalog()
        {
            List<CatalogItemExt> catalogItemExts = new List<CatalogItemExt>();
            foreach (CatalogItem item in Service2010.ListChildren("/", true))
            {
                catalogItemExts.Add(new CatalogItemExt
                {
                    CreatedBy = item.CreatedBy,
                    ModifiedDateSpecified = item.ModifiedDateSpecified,
                    ModifiedDate = item.ModifiedDate,
                    CreationDateSpecified = item.CreationDateSpecified,
                    CreationDate = item.CreationDate,
                    HiddenSpecified = item.HiddenSpecified,
                    Hidden = item.Hidden,
                    Description = item.Description,
                    SizeSpecified = item.SizeSpecified,
                    Size = item.Size,
                    TypeName = item.TypeName,
                    VirtualPath = item.VirtualPath,
                    Path = item.Path,
                    Name = item.Name,
                    ID = item.ID,
                    ModifiedBy = item.ModifiedBy,
                    ItemMetadata = item.ItemMetadata,
                });
            }
            return catalogItemExts;
        }
    }
}