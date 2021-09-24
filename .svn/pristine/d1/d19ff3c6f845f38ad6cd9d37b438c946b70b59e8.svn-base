using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using jingpengwtm.Models;


namespace jingpengwtm.userRFIDArea.ViewModels.UserRFIDVMs
{
    public partial class UserRFIDListVM : BasePagedListVM<UserRFID_View, UserRFIDSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.Create, Localizer["Create"],"userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.Edit, Localizer["Edit"], "userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.Delete, Localizer["Delete"], "userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.Details, Localizer["Details"], "userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.BatchEdit, Localizer["BatchEdit"], "userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.BatchDelete, Localizer["BatchDelete"], "userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.Import, Localizer["Import"], "userRFIDArea", dialogWidth: 800),
                this.MakeStandardAction("UserRFID", GridActionStandardTypesEnum.ExportExcel, Localizer["Export"], "userRFIDArea"),
            };
        }


        protected override IEnumerable<IGridColumn<UserRFID_View>> InitGridHeader()
        {
            return new List<GridColumn<UserRFID_View>>{
                this.MakeGridHeader(x => x.ID),
                this.MakeGridHeader(x => x.RFIDCode),
                this.MakeGridHeader(x => x.UserGuid),
                this.MakeGridHeader(x => x.Times),
                this.MakeGridHeader(x => x.OptTime),
                this.MakeGridHeader(x => x.IsDel),
                this.MakeGridHeader(x => x.Note),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<UserRFID_View> GetSearchQuery()
        {
            var query = DC.Set<UserRFID>()
                .CheckContain(Searcher.ID, x=>x.ID)
                .CheckContain(Searcher.RFIDCode, x=>x.RFIDCode)
                .CheckContain(Searcher.UserGuid, x=>x.UserGuid)
                .CheckEqual(Searcher.IsDel, x=>x.IsDel)
                .CheckContain(Searcher.Note, x=>x.Note)
                .Select(x => new UserRFID_View
                {
				    ID = x.ID,
                    RFIDCode = x.RFIDCode,
                    UserGuid = x.UserGuid,
                    Times = x.Times,
                    OptTime = x.OptTime,
                    IsDel = x.IsDel,
                    Note = x.Note,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class UserRFID_View : UserRFID{

    }
}
