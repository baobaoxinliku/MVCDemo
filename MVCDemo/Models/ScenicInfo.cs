using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class ScenicInfo
    {
        [Key]
        public int ScenicID { get; set; }

        [Required(ErrorMessage ="请输入景点名称")]
        public string ScenicName { get; set; }//景点名称

        [Required(ErrorMessage = "请输入所属国家")]
        public string ScenicCountry { get; set; }//所属国家

        [Required(ErrorMessage = "请输入景所在城市")]
        public string ScenicCity { get; set; }//所在城市

        public string ScenicAddress { get; set; }//地理位置

        public string ScenicLevel { get; set; }//景点级别

        [Required(ErrorMessage = "请输入景点类型")]
        public string ScenicType { get; set; }//景点类型

        public string ScenicIntro { get; set; }//景点介绍
    }
}