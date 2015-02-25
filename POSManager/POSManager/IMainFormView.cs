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
    }
}
