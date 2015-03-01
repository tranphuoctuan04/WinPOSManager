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
    public class HanghoaPresenter:Presenter<IHanghoaView>
    {
        public HanghoaPresenter(IHanghoaView view) : base(view) { }
        public void LoadData()
        {
            View.NhomHanghoaItems = Model.Get<NhomHanghoaModel>("sys_NhomHanghoaSelect");
            View.HanghoaItems = Model.Get<HanghoaModel>("Pos_Danh_GetHanghoa");
        }

        public void Add()
        {
            View.HanghoaItems.Add(new HanghoaModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.HanghoaCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.HanghoaItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.HanghoaItems);
            View.RefreshData();
        }
    }
}
