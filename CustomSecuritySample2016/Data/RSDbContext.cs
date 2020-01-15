using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
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

        public virtual DbSet<BiOper> BiOpers { get; set; }
        public virtual DbSet<BiUserOper> BiUserOpers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        internal void SaveAcl(AceCollection acl)
        {
            if (acl.Count == 0) return;
            foreach (AceStruct ace in acl)
            {
                User user = Users.Where(item => item.UserName == ace.PrincipalName).FirstOrDefault();
                if (user != null
                    && (
                        ace.CatalogOperations.Count > 0
                        || ace.DatasourceOperations.Count > 0
                        || ace.FolderOperations.Count > 0
                        || ace.ModelItemOperations.Count > 0
                        || ace.ModelOperations.Count > 0
                        || ace.ReportOperations.Count > 0
                        || ace.ResourceOperations.Count > 0
                    )
                  )
                {
                    List<Guid> lstOpers = new List<Guid>();
                    foreach (CatalogOperation catalogOperation in ace.CatalogOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.CatalogOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    foreach (DatasourceOperation catalogOperation in ace.DatasourceOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.DatasourceOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    foreach (FolderOperation catalogOperation in ace.FolderOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.FolderOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    foreach (ModelItemOperation catalogOperation in ace.ModelItemOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.ModelItemOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    foreach (ModelOperation catalogOperation in ace.ModelOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.ModelOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    foreach (ReportOperation catalogOperation in ace.ReportOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.ReportOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    foreach (ResourceOperation catalogOperation in ace.ResourceOperations)
                    {
                        Guid OperId = BiOpers.First(item => item.OperType == OperType.ResourceOperation && item.OperTypeDesc == catalogOperation.ToString()).OperId;
                        lstOpers.Add(OperId);
                    }
                    this.Database.ExecuteSqlCommand("delete from [dbo].[BiUserOpers] where [UserId]='" + user.UserID + "'");
                    BiUserOpers.AddRange(lstOpers.Distinct().Select(operId => new BiUserOper() { UserId = user.UserID, OperId = operId }));
                    this.SaveChanges();
                }
            }
        }
    }
}
