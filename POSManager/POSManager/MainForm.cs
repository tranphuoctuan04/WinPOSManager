using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using Model.BusinessObject;
using Form;
using POSManager.UserControls;
using DevExpress.XtraEditors;


namespace POSManager
{
    public partial class MainForm : RibbonForm, IMainFormView
    {
        MainFormPresenter _presenter;
        HanghoaModel _hanghoaCurrent;
        Lambda.ClientModel.ModelCore model;
        private BanModel _banCurrent;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            model = new Lambda.ClientModel.ModelCore();
            Lambda.ClientModel.ModelCore.SetDefaultLocalConfig();
            model.Login("admin", "admin");

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _presenter = new MainFormPresenter(this);
            _presenter.LoadData();
            SdateEdit.DateTime = EdateEdit.DateTime = DateTime.Now;
        }


        public void RefreshData()
        {
            chitietHoadonModelGridControl.RefreshDataSource();
        }

        public List<BanModel> BanItems
        {
            get
            {
                return listTableUserControl1.DataSource as List<BanModel>;
            }
            set
            {
                listTableUserControl1.DataSource = value;
            }
        }

        private void HanghoabarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new HanghoaForm())
            {
                f.ShowDialog();
            }
        }


        public List<HanghoaModel> HanghoaItems
        {
            get
            {
                return listProductUserControl1.DataSource as List<HanghoaModel>;
            }
            set
            {
                listProductUserControl1.DataSource = value;
                hanghoaModelBindingSource.DataSource = value;
            }
        }

        private void listTableUserControl1_TableItemClick(object sender, EventArgs e)
        {
            try
            {
                var p = sender as TableUserControl;
                listTableUserControl1.ResetBorderStype();
                p.BorderStyle = BorderStyle.Fixed3D;
                p.labelName.ForeColor = Color.Red;
                _banCurrent = p.BanItem;
                _presenter.LoadHoadonByBan();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void listProductUserControl1_ProductItemClick(object sender, EventArgs e)
        {
            try
            {
                var p = sender as ProductUserControl;
                _hanghoaCurrent = p.HanghoaItem;
                listProductUserControl1.ResetBorderStype();
                p.panelControl.BackColor = Color.Gold;
                p.Namelabel.ForeColor = Color.Red;
                p.BorderStyle = BorderStyle.Fixed3D;
                _presenter.AddProduct();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        public HanghoaModel HanghoaCurrent
        {
            get
            {
                return _hanghoaCurrent;
            }
            set
            {
                _hanghoaCurrent = value;
            }
        }

        public HoadonModel HoaDonCurrent
        {
            get
            {
                return hoadonModelBindingSource.DataSource as HoadonModel;
            }
            set
            {
                hoadonModelBindingSource.DataSource = value;
            }
        }

        public List<ChitietHoadonModel> ChitietHoadonItems
        {
            get
            {
                return chitietHoadonModelBindingSource.DataSource as List<ChitietHoadonModel>;
            }
            set
            {
                chitietHoadonModelBindingSource.DataSource = value;
            }
        }


        public BanModel BanCurrent
        {
            get
            {
                return _banCurrent;
            }
            set
            {
                _banCurrent = value;
            }
        }


        public ChitietHoadonModel ChitietHoadonCurrent
        {
            get { return chitietHoadonModelBindingSource.Current as ChitietHoadonModel; }
        }

        private void ItemButtonDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _presenter.DeleteProduct();
        }


        public List<HoadonModel> HoadonChuathanhtoanItems
        {
            get
            {
                return listHoadonChuathanhtoanBindingSource.DataSource as List<HoadonModel>;
            }
            set
            {
                listHoadonChuathanhtoanBindingSource.DataSource = value;
            }
        }

        public HoadonModel HoadonChuathanhtoanCurrent
        {
            get { return listHoadonChuathanhtoanBindingSource.Current as HoadonModel; }
        }

        public List<HoadonModel> HoadonTrongngayItems
        {
            get
            {
                return listHoadonTrongngaybindingSource.DataSource as List<HoadonModel>;
            }
            set
            {
                listHoadonTrongngaybindingSource.DataSource = value;
            }
        }

        public HoadonModel HoadonTrongngayCurrent
        {
            get
            {
                return listHoadonTrongngaybindingSource.Current as HoadonModel;
            }
        }

        private void listHoadonChuathanhtoanBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.LoadHoadonByHoadonId();
        }


        public DateTime SNgay
        {
            get { return SdateEdit.DateTime; }
        }

        public DateTime ENgay
        {
            get { return EdateEdit.DateTime; }
        }

        private void LocButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadHoadonByNgay();
        }
    }
}