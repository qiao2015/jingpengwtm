using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using jingpengwtm.Models;


namespace jingpengwtm.userRFIDArea.ViewModels.UserRFIDVMs
{
    public partial class UserRFIDSearcher : BaseSearcher
    {
        public String ID { get; set; }
        [Display(Name = "RFIDCode")]
        public String RFIDCode { get; set; }
        [Display(Name = "用户id")]
        public String UserGuid { get; set; }
        [Display(Name = "状态")]
        public Int32? IsDel { get; set; }
        [Display(Name = "备注")]
        public String Note { get; set; }

        protected override void InitVM()
        {
        }

    }
}
