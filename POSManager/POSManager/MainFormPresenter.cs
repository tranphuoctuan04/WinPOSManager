using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lambda.BusinessObject;
using Lambda.ClientModel;
using Model.BusinessObject;
using System.Threading;

namespace POSManager
{
    public class MainFormPresenter:Presenter<IMainFormView>
    {
        public MainFormPresenter(IMainFormView view) : base(view) { }
        System.Windows.Forms.Timer timer;
        Thread t1, t2, t3;
        bool flag1 = false, flag2 = false, flag3 = false;
        List<BanModel> _tableList;
        List<HanghoaModel> _hanghoaList;
        List<HoadonModel> _hoadonChuathanhtoan;
        internal void LoadData()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshTable();
            RefreshProduct();
            RefreshHoadonChuaThanhtoan();
            var thoigianDateTime = DateTime.Now;
            if (thoigianDateTime.Second % 2 == 0)
            {
                if (flag1 == true)
                {
                    try
                    {
                        View.BanItems = _tableList;
                        flag1 = false;
                    }
                    catch { flag1 = false; }
                }
            }
            if (thoigianDateTime.Second % 2 == 1)
            {
                if (flag2 == true)
                {
                    try
                    {
                        View.HanghoaItems = _hanghoaList;
                        flag2 = false;
                    }
                    catch { flag2 = false; }
                }
            }
            if (_hoadonChuathanhtoan != null)
                View.HoadonChuathanhtoanItems = _hoadonChuathanhtoan;
        }

        private void RefreshProduct()
        {
            if (t2 != null && t2.ThreadState == ThreadState.Running)
                return;
            t2 = new Thread(new ThreadStart(RefProduct));
            t2.Start();

        }

        private void RefreshTable()
        {
            if (t1 != null && t1.ThreadState == ThreadState.Running)
                return;
            t1 = new Thread(new ThreadStart(RefTable));
            t1.Start();            
        }
        private void RefreshHoadonChuaThanhtoan()
        {
            if ((t3 != null && t3.ThreadState == ThreadState.Running) || flag3 == true)
                return;
            t3 = new Thread(new ThreadStart(RefHoadonChuaThanhtoan));
            t3.Start();
        }
        private void RefTable()
        {
            try
            {
                _tableList = Model.Get<BanModel>("Pos_Danh_GetBanItem");
                if (View.BanItems == null)
                {
                    flag1 = true;
                    return;
                }
                Model.Set(View.BanItems);
                if (_tableList.Count != View.BanItems.Count)
                {
                    this.flag1 = true;
                    return;
                }
                for (int i = 0; i < View.BanItems.Count; i++)
                {
                    var a = View.BanItems[i];
                    var b = _tableList[i];
                    if (a.HoadonId != b.HoadonId || a.Hoatdong != b.Hoatdong || a.KhuvucId != b.KhuvucId
                        || a.Ten != b.Ten || a.TenKhuvuc != b.TenKhuvuc || a.Candon != b.Candon)
                        flag1 = true;
                }
                t1 = null;
            }
            catch
            {
                flag1 = false;
                t2.Abort();
                t2 = null;
            }
        }
        private void RefProduct()
        {
            try
            {
                _hanghoaList = Model.Get<HanghoaModel>("Pos_Danh_GetHanghoaItem");
                if (View.HanghoaItems == null)
                {
                    flag2 = true;
                    return;
                }
                Model.Set(View.HanghoaItems);
                if (_hanghoaList.Count != View.HanghoaItems.Count)
                {
                    this.flag2 = true;
                    return;
                }
                for (int i = 0; i < View.HanghoaItems.Count; i++)
                {
                    var a = View.HanghoaItems[i];
                    var b = _hanghoaList[i];
                    if (a.Code != b.Code || a.Hoatdong != b.Hoatdong || a.Image.LongLength != b.Image.LongLength
                        || a.Ten != b.Ten || a.NhomHanghoaId != b.NhomHanghoaId || a.Giaban != b.Giaban)
                        flag2 = true;
                }
                t2 = null;
                
            }
            catch
            {
                //flag2 = false;
            }
        }
        private void RefHoadonChuaThanhtoan()
        {
            try
            {
                flag3 = true;
                _hoadonChuathanhtoan = Model.Get<HoadonModel>("Pos_Danh_GetHoadonChuathanhtoan");
                flag3 = false;
            }
            catch { }
        }

        internal void LoadHoadonByBan()
        {
            if (View.ChitietHoadonItems != null && View.ChitietHoadonItems.Count != 0)
            {
                Model.Set(View.HoaDonCurrent);
                Model.Set(View.ChitietHoadonItems);
            }
            
            View.HoaDonCurrent = new HoadonModel();
            if (View.BanCurrent.HoadonId != null)
            {
                var item = new List<AutoItem>();
                item.Add(new AutoItem { Name = "HoadonId", Value = View.BanCurrent.HoadonId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                var x = Model.Get<HoadonModel>(new AutoObject { Items = item, SpName = "Pos_Danh_GetHoadonByHoadonId" }).FirstOrDefault();
                if (View.HoaDonCurrent != null)
                {
                    x.TenBan = View.BanCurrent.Ten;
                    View.HoaDonCurrent = x;
                }
                View.ChitietHoadonItems = Model.Get<ChitietHoadonModel>(new AutoObject { Items = item, SpName = "Pos_Danh_GetChitietHoadonByHoadonId" });
            }
            else
            {
                var x = new HoadonModel { TenBan = View.BanCurrent.Ten, BanId = View.BanCurrent.BanId };
                View.HoaDonCurrent = x;
                View.ChitietHoadonItems = new List<ChitietHoadonModel>();

            }
            View.RefreshData();
        }

        internal void AddProduct()
        {
            if (View.BanCurrent == null)
                return;
            if (View.HoaDonCurrent.BanId == null)
                return;
            if(View.BanCurrent.HoadonId == null)
            {
                var x = new HoadonModel { TenBan = View.BanCurrent.Ten, BanId = View.BanCurrent.BanId, Ngaygio = DateTime.Now, Step = 0, Tongtien = 0 };
                View.HoaDonCurrent = x;
                View.ChitietHoadonItems = new List<ChitietHoadonModel>();

            }
            View.ChitietHoadonItems.Add(new ChitietHoadonModel { HoadonId = View.HoaDonCurrent.HoadonId, HanghoaId = View.HanghoaCurrent.HanghoaId, Soluong = 1, Dongia = View.HanghoaCurrent.Giaban, Thanhtien = View.HanghoaCurrent.Giaban });
            View.BanCurrent.HoadonId = View.HoaDonCurrent.HoadonId;
            Model.Set(View.HoaDonCurrent);
            Model.Set(View.ChitietHoadonItems);
            View.RefreshData();
        }

        internal void DeleteProduct()
        {
            if (View.ChitietHoadonCurrent != null)
                View.ChitietHoadonCurrent.MakeDelete();
            Model.Set(View.ChitietHoadonItems);
            if (View.ChitietHoadonItems.Count == 0)
            {
                View.HoaDonCurrent.MakeDelete();
                var item = new List<AutoItem>();
                item.Add(new AutoItem { Name = "BanId", Value = View.BanCurrent.BanId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                Model.SetAutoObject(new AutoObject { Items = item, SpName = "Pos_Danh_UpdateHoadonBanIdToNull" });
                Model.Set(View.HoaDonCurrent);
                View.HoaDonCurrent = new HoadonModel();
            }
            View.RefreshData();
        }

        internal void LoadHoadonByHoadonId()
        {
            View.HoaDonCurrent = View.HoadonChuathanhtoanCurrent;
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "HoadonId", Value = View.HoaDonCurrent.HoadonId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChitietHoadonItems = Model.Get<ChitietHoadonModel>(new AutoObject { Items = item, SpName = "Pos_Danh_GetChitietHoadonByHoadonId" });
            var item2 = new List<AutoItem>();
            item2.Add(new AutoItem { Name = "BanId", Value = View.HoaDonCurrent.BanId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.BanCurrent = Model.Get<BanModel>(new AutoObject { Items = item2, SpName = "Pos_Danh_GetBanByBanId" }).FirstOrDefault();
        }

        internal void LoadHoadonByNgay()
        {
            DateTime s = View.SNgay;
            DateTime e = View.ENgay;
            if (s == DateTime.MinValue)
                s = new DateTime(2014, 1, 1);
            if (e == DateTime.MinValue)
                e = DateTime.MaxValue;
            else
                e = e.AddHours(23.99);
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "SDate", Value = s, SqlType = System.Data.SqlDbType.DateTime });
            item.Add(new AutoItem { Name = "EDate", Value = e, SqlType = System.Data.SqlDbType.DateTime });
            View.HoadonTrongngayItems = Model.Get<HoadonModel>(new AutoObject { Items = item, SpName = "Pos_Danh_GetHoadonByNgay" });
        }
    }
}
