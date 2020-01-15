using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    class BiOper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BiOper()
        {
            this.BiUserOpers = new HashSet<BiUserOper>();
        }
        [Key]
        public System.Guid OperId { get; set; }
        public OperType OperType { get; set; }
        public string OperTypeName { get; set; }
        public string OperTypeDesc { get; set; }
        public string OperationName { get; set; }
        public string OperationDesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BiUserOper> BiUserOpers { get; set; }
    }
}
