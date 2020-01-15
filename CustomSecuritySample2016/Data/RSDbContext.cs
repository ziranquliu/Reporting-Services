using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    class RSDbContext : DbContext
    {
        // 定义一个静态变量来保存类的实例
        private static RSDbContext instance = null;

        // 定义一个标识确保线程同步
        private static readonly object padlock = new object();

        private RSDbContext() : base("name=ReportServer")
        {

        }

        public static RSDbContext GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            if (instance == null)
            {
                lock (padlock)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (instance == null)
                    {
                        instance = new RSDbContext();
                    }
                }
            }
            return instance;
        }
    }
}
