using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using jingpengwtm.Models;


namespace jingpengwtm.userInfoArea.ViewModels.UserInfoVMs
{
    public partial class UserInfoBatchVM : BaseBatchVM<UserInfo, UserInfo_BatchEdit>
    {
        public UserInfoBatchVM()
        {
            ListVM = new UserInfoListVM();
            LinkedVM = new UserInfo_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class UserInfo_BatchEdit : BaseVM
    {
        [Display(Name = "状态")]
        public Int32? IsDel { get; set; }

        protected override void InitVM()
        {
        }

    }

}
