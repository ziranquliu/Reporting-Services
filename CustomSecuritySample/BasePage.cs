using Microsoft.Samples.ReportingServices.CustomSecurity._10._86._65._20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomSecuritySampleWeb
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            if (Service2010 == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected ReportingService2010 Service2010 { get
            {
                return Session["LoginInfo_ReportingService2010"] as ReportingService2010;
            }
        }

        public string GetSecurityScopes()
        {
            return String.Join(",",Service2010.ListSecurityScopes());
        }
        public string GetModelItemTypes()
        {
            return String.Join(",", Service2010.ListModelItemTypes());
        }

        public string GetItemTypes()
        {
            return String.Join(",", Service2010.ListItemTypes());
        }
        protected List<CatalogItemExt> GetCatalog()
        {
            List<CatalogItemExt> catalogItemExts = new List<CatalogItemExt>();
            foreach(CatalogItem item in Service2010.ListChildren("/", true))
            {
                catalogItemExts.Add(new CatalogItemExt
                {
                    CreatedBy=item.CreatedBy,
                    ModifiedDateSpecified=item.ModifiedDateSpecified,
                    ModifiedDate=item.ModifiedDate,
                    CreationDateSpecified=item.CreationDateSpecified,
                    CreationDate=item.CreationDate,
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

    public class CatalogItemExt: CatalogItem
    {
        public string CreatedBy { get; set; }
        public bool ModifiedDateSpecified { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool CreationDateSpecified { get; set; }
        public DateTime CreationDate { get; set; }
        public bool HiddenSpecified { get; set; }
        public bool Hidden { get; set; }
        public string Description { get; set; }
        public bool SizeSpecified { get; set; }
        public int Size { get; set; }
        public string TypeName { get; set; }
        public string VirtualPath { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string ModifiedBy { get; set; }
        public Property[] ItemMetadata { get; set; }
    }
}