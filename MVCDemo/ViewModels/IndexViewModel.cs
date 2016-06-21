using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class IndexViewModel
    {
        public List<Models.ScenicInfo> ScenicInfos { get; set; }
        public List<Models.UserInfo> UserInfos { get; set; }
    }
}