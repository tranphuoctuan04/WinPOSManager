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


namespace POSManager
{
    public partial class MainForm : RibbonForm, IMainFormView
    {
        MainFormPresenter _presenter;
        Lambda.ClientModel.ModelCore model;
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
        }


        public void RefreshData()
        {
            throw new NotImplementedException();
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
    }
}