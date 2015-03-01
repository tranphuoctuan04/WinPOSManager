using Lambda.ClientModel;
using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IGiaHanghoaView:IView
    {
        HanghoaModel HanghoaCurrent { get; set; }
        List<BanggiaModel> BanggiaItems { get; set; }
        BanggiaModel BanggiaCurrent { get; }
    }
}
