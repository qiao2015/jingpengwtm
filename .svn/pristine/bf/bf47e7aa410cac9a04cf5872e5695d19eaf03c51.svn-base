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
    public partial class UserInfoTemplateVM : BaseTemplateVM
    {
        public ExcelPropety ID_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.ID);
        [Display(Name = "电话")]
        public ExcelPropety PhoneNO_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.PhoneNO);
        [Display(Name = "邮件")]
        public ExcelPropety Email_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.Email);
        [Display(Name = "密码")]
        public ExcelPropety PWD_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.PWD);
        [Display(Name = "用户名")]
        public ExcelPropety UserName_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.UserName);
        [Display(Name = "图片")]
        public ExcelPropety ImagePath_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.ImagePath);
        [Display(Name = "签名")]
        public ExcelPropety Signature_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.Signature);
        [Display(Name = "显示全部")]
        public ExcelPropety ShowAll_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.ShowAll);
        [Display(Name = "设置时间")]
        public ExcelPropety OptTime_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.OptTime);
        [Display(Name = "状态")]
        public ExcelPropety IsDel_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.IsDel);
        [Display(Name = "年龄")]
        public ExcelPropety Age_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.Age);
        [Display(Name = "地点")]
        public ExcelPropety Address_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.Address);
        [Display(Name = "性别")]
        public ExcelPropety Sex_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.Sex);
        [Display(Name = "最新令牌")]
        public ExcelPropety LastToken_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.LastToken);
        [Display(Name = "开启碰一碰")]
        public ExcelPropety IsShare_Excel = ExcelPropety.CreateProperty<UserInfo>(x => x.IsShare);

	    protected override void InitVM()
        {
        }

    }

    public class UserInfoImportVM : BaseImportVM<UserInfoTemplateVM, UserInfo>
    {

    }

}
