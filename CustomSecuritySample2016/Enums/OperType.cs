using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    internal enum OperType : int
    {
        CatalogOperation = 1,
        DatasourceOperation = 2,
        FolderOperation = 3,
        ModelItemOperation = 4,
        ModelOperation = 5,
        ReportOperation = 6,
        ResourceOperation = 7
    }
}
