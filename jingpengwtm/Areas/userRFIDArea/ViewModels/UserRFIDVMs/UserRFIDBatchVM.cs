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
    public partial class UserRFIDBatchVM : BaseBatchVM<UserRFID, UserRFID_BatchEdit>
    {
        public UserRFIDBatchVM()
        {
            ListVM = new UserRFIDListVM();
            LinkedVM = new UserRFID_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class UserRFID_BatchEdit : BaseVM
    {
        [Display(Name = "用户id")]
        public String UserGuid { get; set; }
        [Display(Name = "状态")]
        public Int32? IsDel { get; set; }

        protected override void InitVM()
        {
        }

    }

}
