using Microsoft.ReportingServices.Library.Soap;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    static class NLogHelper
    {
        public static void WarnEx(this Logger logger, params Warning[] warns)
        {
            if (warns != null && warns.Length > 0)
            {
                logger.Warn(Consts.NLogStart);
                foreach (Warning w in warns)
                {
                    logger.Warn(w);
                }
                logger.Warn(Consts.NLogEnd);
            }
        }
        public static void ErrorEx(this Logger logger, params Exception[] ex)
        {
            logger.Error(Consts.NLogStart);
            logger.Error(ex);
            logger.Error(Consts.NLogEnd);
        }
    }
}
