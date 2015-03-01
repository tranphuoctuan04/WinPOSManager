using Lambda.BusinessObject;
using Lambda.ClientModel;
using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Presenter
{
    public class GiaHanghoaPresenter:Presenter<IGiaHanghoaView>
    {
        public GiaHanghoaPresenter(IGiaHanghoaView view) : base(view) { }
        public void LoadData()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "HanghoaId", Value = View.HanghoaCurrent.HanghoaId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.BanggiaItems = Model.Get<BanggiaModel>(new AutoObject { Items = item, SpName = "Pos_Danh_GetBanggiaByHanghoaId" });
        }

        public void Add()
        {
            View.BanggiaItems.Add(new BanggiaModel { Gia = 0, HanghoaId = View.HanghoaCurrent.HanghoaId, NgayApdung = DateTime.Now });
            View.RefreshData();
        }

        public void Save()
        {
            Model.Set(View.BanggiaItems);
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.BanggiaCurrent;
            if (cur == null)
                return;
            if (cur.State == RowState.Insert)
            {
                View.BanggiaItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }
    }
}
