using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using jingpengwtm.Models;


namespace jingpengwtm.api.ViewModels.UserRFIDVMs
{
    public partial class UserRFIDApiListVM : BasePagedListVM<UserRFIDApi_View, UserRFIDApiSearcher>
    {

        protected override IEnumerable<IGridColumn<UserRFIDApi_View>> InitGridHeader()
        {
            return new List<GridColumn<UserRFIDApi_View>>{
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

        public override IOrderedQueryable<UserRFIDApi_View> GetSearchQuery()
        {
            var query = DC.Set<UserRFID>()
                .CheckContain(Searcher.ID, x=>x.ID)
                .CheckContain(Searcher.RFIDCode, x=>x.RFIDCode)
                .CheckContain(Searcher.UserGuid, x=>x.UserGuid)
                .CheckEqual(Searcher.Times, x=>x.Times)
                .CheckBetween(Searcher.OptTime?.GetStartTime(), Searcher.OptTime?.GetEndTime(), x => x.OptTime, includeMax: false)
                .CheckEqual(Searcher.IsDel, x=>x.IsDel)
                .CheckContain(Searcher.Note, x=>x.Note)
                .Select(x => new UserRFIDApi_View
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

    public class UserRFIDApi_View : UserRFID{

    }
}
