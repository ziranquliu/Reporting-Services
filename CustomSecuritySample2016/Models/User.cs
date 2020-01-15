using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.BiUserOpers = new HashSet<BiUserOper>();
        }

        [Key]
        public System.Guid UserID { get; set; }
        public byte[] Sid { get; set; }
        public int UserType { get; set; }
        public int AuthType { get; set; }
        public string UserName { get; set; }
        public string ServiceToken { get; set; }
        public string Setting { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BiUserOper> BiUserOpers { get; set; }
    }
}
