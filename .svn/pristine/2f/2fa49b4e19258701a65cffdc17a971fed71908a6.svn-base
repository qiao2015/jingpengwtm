using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace jingpengwtm.Models
{
    public class UserInfo:TopBasePoco
    {
        [Key]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Column("GUID")]
        public new string ID { get; set; }

        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
     //   [Column("PhoneNO")]
        [Display(Name = "电话")]
        public  string PhoneNO { get; set; }
        [Display(Name = "邮件")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Email { get; set; }
        [Display(Name = "密码")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string PWD { get; set; }
        [Display(Name = "用户名")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(120, ErrorMessage = "{0}最多输入{1}个字符")]
        public string UserName { get; set; }
        [Display(Name = "图片")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(150, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ImagePath { get; set; }
        [Display(Name = "签名")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(200, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Signature { get; set; }


        [Display(Name = "显示全部")]

        public int? ShowAll { get; set; }

        [Display(Name = "设置时间")]
        public DateTime? OptTime { get; set; }
        [Display(Name = "状态")]
        public int? IsDel { get; set; }
        [Display(Name = "年龄")]
        public int? Age { get; set; }
         [Display(Name = "地点")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(120, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Address { get; set; } 
        [Display(Name = "性别")]
        public int? Sex { get; set; }

        [Display(Name = "最新令牌")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(300, ErrorMessage = "{0}最多输入{1}个字符")]
        public string LastToken { get; set; }

        [Display(Name = "开启碰一碰")]
        //[Required(ErrorMessage = "{0}是必填项")]
       // [StringLength(300, ErrorMessage = "{0}最多输入{1}个字符")]
        public bool? IsShare { get; set; }
    }
}
