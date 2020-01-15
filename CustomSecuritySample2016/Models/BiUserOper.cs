using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    class BiUserOper
    {
        [Key]
        public System.Guid RelationId { get; set; }
        public System.Guid UserId { get; set; }
        public System.Guid OperId { get; set; }

        public virtual BiOper BiOper { get; set; }
        public virtual User User { get; set; }
    }
}
