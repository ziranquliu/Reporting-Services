using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    class SqlHelper
    {
        internal static Database DbCepOne
        {
            get
            {
                return CepOneDbContext.GetInstance().Database;
            }
        }

        internal static Database DbRS
        {
            get
            {
                return RSDbContext.GetInstance().Database;
            }
        }

        private const string SqlGetUserInfo = @"SELECT 
                            ME.AccountId,
                            ME.UserId,
							UA.DisplayName AS UserDisplayName,
							UA.Email,
							UA.Mobile,
                            MD.Id AS DealerId,
                            SO.DealerCode,
							MD.ShortName,
							MD.FullName,
                            SO.Id AS OrgId,
                            SO.Name AS OrgName
                        FROM dbo.MdmEmployee ME
                        LEFT JOIN dbo.SysOrg SO ON ME.OrgId = SO.Id
                        LEFT JOIN dbo.MdmDealer MD ON MD.DealerCode = SO.DealerCode
						LEFT JOIN dbo.UsAccount UA ON UA.Id=ME.AccountId";

        internal static SessionUser GetUserInfoByAccount(long accountId)
        {
            string sql = String.Format("{0} WHERE ME.AccountId = '{1}'", SqlGetUserInfo, accountId);
            SessionUser sessionUser = DbCepOne.SqlQuery<SessionUser>(sql).FirstOrDefault();
            return sessionUser;
        }
        
        internal static SessionUser GetUserInfoByEmail(string strEmail)
        {
            string sql = String.Format("{0} WHERE UA.Email = '{1}'", SqlGetUserInfo, strEmail);
            SessionUser sessionUser = DbCepOne.SqlQuery<SessionUser>(sql).FirstOrDefault();
            return sessionUser;
        }
    }
}
