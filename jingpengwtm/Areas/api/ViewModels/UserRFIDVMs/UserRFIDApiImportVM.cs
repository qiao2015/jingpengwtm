using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using jingpengwtm.Models;


namespace jingpengwtm.api.ViewModels.UserRFIDVMs
{
    public partial class UserRFIDApiTemplateVM : BaseTemplateVM
    {
        public ExcelPropety ID_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.ID);
        [Display(Name = "RFIDCode")]
        public ExcelPropety RFIDCode_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.RFIDCode);
        [Display(Name = "用户id")]
        public ExcelPropety UserGuid_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.UserGuid);
        [Display(Name = "使用次数")]
        public ExcelPropety Times_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.Times);
        [Display(Name = "设置时间")]
        public ExcelPropety OptTime_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.OptTime);
        [Display(Name = "状态")]
        public ExcelPropety IsDel_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.IsDel);
        [Display(Name = "备注")]
        public ExcelPropety Note_Excel = ExcelPropety.CreateProperty<UserRFID>(x => x.Note);

	    protected override void InitVM()
        {
        }

    }

    public class UserRFIDApiImportVM : BaseImportVM<UserRFIDApiTemplateVM, UserRFID>
    {

    }

}
