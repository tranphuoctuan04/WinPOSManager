using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using View;
using Model.BusinessObject;
using Presenter;

namespace Form
{
    public partial class GiaHanghoaForm : DevExpress.XtraEditors.XtraForm, IGiaHanghoaView
    {
        private HanghoaModel _hanghoaCurrent;
        GiaHanghoaPresenter _presenter;
        public GiaHanghoaForm(HanghoaModel hanghoaItem)
        {
            InitializeComponent();
            this._hanghoaCurrent = hanghoaItem;
        }

        private void GiaHanghoaForm_Load(object sender, EventArgs e)
        {
            this.Text = _hanghoaCurrent.Ten;
            _presenter = new GiaHanghoaPresenter(this);
            _presenter.LoadData();
        }

        public HanghoaModel HanghoaCurrent
        {
            get
            {
                return this._hanghoaCurrent;
            }
            set
            {
                _hanghoaCurrent = value;
            }
        }

        public List<BanggiaModel> BanggiaItems
        {
            get
            {
                return banggiaModelBindingSource.DataSource as List<BanggiaModel>;
            }
            set
            {
                banggiaModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            banggiaModelGridControl.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }


        public BanggiaModel BanggiaCurrent
        {
            get { return banggiaModelBindingSource.Current as BanggiaModel; }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }
    }
}