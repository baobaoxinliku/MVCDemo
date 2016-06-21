using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="请输入账号")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        public string UserPwd { get; set; }

        public string UserEmail { get; set; }

        public string Address { get; set; }
    }
}