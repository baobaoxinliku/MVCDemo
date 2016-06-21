using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCDemo.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext() 
            : base("AccountContext")//指定一个连接字符串
        {

        }
        public DbSet<Models.UserInfo> UserInfo { get; set; }
        public DbSet<Models.ScenicInfo> ScenicInfo { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//指定单数形式的表名
        }
    }
}