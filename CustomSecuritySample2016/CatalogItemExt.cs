using Microsoft.Samples.ReportingServices.CustomSecurity.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    public class CatalogItemExt : CatalogItem
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