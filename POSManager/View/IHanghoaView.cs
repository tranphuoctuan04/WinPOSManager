using Lambda.ClientModel;
using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IHanghoaView:IView
    {
        List<NhomHanghoaModel> NhomHanghoaItems { set; }
        List<HanghoaModel> HanghoaItems { get; set; }
        HanghoaModel HanghoaCurrent { get; }
    }
}
