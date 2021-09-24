using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using jingpengwtm.Models;


namespace jingpengwtm.userInfoArea.ViewModels.UserInfoVMs
{
    public partial class UserInfoListVM : BasePagedListVM<UserInfo_View, UserInfoSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.Create, Localizer["Create"],"userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.Edit, Localizer["Edit"], "userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.Delete, Localizer["Delete"], "userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.Details, Localizer["Details"], "userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.BatchEdit, Localizer["BatchEdit"], "userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.BatchDelete, Localizer["BatchDelete"], "userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.Import, Localizer["Import"], "userInfoArea", dialogWidth: 800),
                this.MakeStandardAction("UserInfo", GridActionStandardTypesEnum.ExportExcel, Localizer["Export"], "userInfoArea"),
            };
        }


        protected override IEnumerable<IGridColumn<UserInfo_View>> InitGridHeader()
        {
            return new List<GridColumn<UserInfo_View>>{
                this.MakeGridHeader(x => x.ID),
                this.MakeGridHeader(x => x.PhoneNO),
                this.MakeGridHeader(x => x.Email),
                this.MakeGridHeader(x => x.PWD),
                this.MakeGridHeader(x => x.UserName),
                this.MakeGridHeader(x => x.ImagePath),
                this.MakeGridHeader(x => x.Signature),
                this.MakeGridHeader(x => x.ShowAll),
                this.MakeGridHeader(x => x.OptTime),
                this.MakeGridHeader(x => x.IsDel),
                this.MakeGridHeader(x => x.Age),
                this.MakeGridHeader(x => x.Address),
                this.MakeGridHeader(x => x.Sex),
                this.MakeGridHeader(x => x.LastToken),
                this.MakeGridHeader(x => x.IsShare),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<UserInfo_View> GetSearchQuery()
        {
            var query = DC.Set<UserInfo>()
                .CheckContain(Searcher.ID, x=>x.ID)
                .CheckContain(Searcher.PhoneNO, x=>x.PhoneNO)
                .CheckContain(Searcher.UserName, x=>x.UserName)
                .CheckEqual(Searcher.IsDel, x=>x.IsDel)
                .CheckEqual(Searcher.Age, x=>x.Age)
                .CheckContain(Searcher.Address, x=>x.Address)
                .CheckEqual(Searcher.IsShare, x=>x.IsShare)
                .Select(x => new UserInfo_View
                {
				    ID = x.ID,
                    PhoneNO = x.PhoneNO,
                    Email = x.Email,
                    PWD = x.PWD,
                    UserName = x.UserName,
                    ImagePath = x.ImagePath,
                    Signature = x.Signature,
                    ShowAll = x.ShowAll,
                    OptTime = x.OptTime,
                    IsDel = x.IsDel,
                    Age = x.Age,
                    Address = x.Address,
                    Sex = x.Sex,
                    LastToken = x.LastToken,
                    IsShare = x.IsShare,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class UserInfo_View : UserInfo{

    }
}
