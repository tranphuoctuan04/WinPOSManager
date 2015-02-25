using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lambda.BusinessObject;
using Lambda.ClientModel;
using Model.BusinessObject;

namespace POSManager
{
    public class MainFormPresenter:Presenter<IMainFormView>
    {
        public MainFormPresenter(IMainFormView view) : base(view) { }

        internal void LoadData()
        {
            View.BanItems = Model.Get<BanModel>("Pos_Danh_GetBanItem");
        }
    }
}
