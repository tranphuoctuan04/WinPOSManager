using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessObject
{
    public partial class ChitietHoadonModel
    {
        partial void OnSoluongChanged()
        {
            Thanhtien = Soluong * Dongia;
        }
        partial void OnSoluongChanging(int? value)
        {
            if (value.Value <= 0)
                throw new Exception("Số lượng phải lớn hơn 0");
        }
    }
}
