using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    [Serializable]
    internal class SessionUser
    {
        public long AccountId { get; set; }
        public long UserId { get; set; }
        public string UserDisplayName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public long DealerId { get; set; }
        public string DealerCode { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        //public List<string> UserPermissionCode { get; set; }
        /// <summary>
        /// 用户权限列表
        /// </summary>
        //public List<UserPermission> UserPermission { get; set; }

        override
        public string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}