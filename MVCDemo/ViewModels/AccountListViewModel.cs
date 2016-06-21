using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class AccountListViewModel
    {
        public List<ScenicInfo> ScenicInfo { get; set; }

        public List<UserInfo> UserInfo { get; set; }
    }
}