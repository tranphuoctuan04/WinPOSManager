using Lambda.ClientModel;
using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManager
{
    public interface IMainFormView:IView
    {
        List<BanModel> BanItems { get; set; }
        List<HanghoaModel> HanghoaItems { get; set; }
        HanghoaModel HanghoaCurrent { get; set; }
        BanModel BanCurrent { get; set; }
        HoadonModel HoaDonCurrent { get; set; }
        List<ChitietHoadonModel> ChitietHoadonItems { get; set; }
        ChitietHoadonModel ChitietHoadonCurrent { get; }

        List<HoadonModel> HoadonChuathanhtoanItems { get; set; }
        HoadonModel HoadonChuathanhtoanCurrent { get; }

        List<HoadonModel> HoadonTrongngayItems { get; set; }
        HoadonModel HoadonTrongngayCurrent { get; }
    }
}
