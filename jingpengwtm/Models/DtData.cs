using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace jingpengwtm.Models
{
    
     public class DtData
    {
        [Key]
        public DateTime?    DT {get;set;}
        public int? UserCount { get; set; }
        public int? RFIDCount { get; set; }
        public int? IsDel { get; set; }

    }
}
