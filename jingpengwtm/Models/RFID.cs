using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace jingpengwtm.Models
{
    public class RFID : TopBasePoco
    {
        [Key]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Column("RFIDCode")]
        public new string ID { get; set; }
        [Display(Name = "预留")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Remark { get; set; }

        [Display(Name = "预留1")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Remark1 { get; set; }
        [Display(Name = "预留2")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Remark2 { get; set; }

        [Display(Name = "设置时间")]
        public DateTime? OptTime { get; set; }

        [Display(Name = "类型")]

        public int? CardType { get; set; }

        [Display(Name = "状态")]
        public int? IsDel { get; set; }


    }
}
