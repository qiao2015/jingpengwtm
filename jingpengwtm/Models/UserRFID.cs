using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace jingpengwtm.Models
{
    public class UserRFID : TopBasePoco
    {
        [Key]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Column("GUID")]
        public new string ID { get; set; }
        [Display(Name = "RFIDCode")]
      //  [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string RFIDCode { get; set; }

        [Display(Name = "用户id")]
        //[Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string UserGuid { get; set; }
        [Display(Name = "使用次数")]
       
        public int? Times { get; set; }

        [Display(Name = "设置时间")]
        public DateTime? OptTime { get; set; }

        

        [Display(Name = "状态")]
        public int? IsDel { get; set; }

        [Display(Name = "备注")]
        //  [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Note { get; set; }
    }
}
