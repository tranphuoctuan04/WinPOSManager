using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using View;
using Presenter;
using Model.BusinessObject;

namespace Form
{
    public partial class HanghoaForm : DevExpress.XtraEditors.XtraForm, IHanghoaView
    {
        HanghoaPresenter _presenter;
        public HanghoaForm()
        {
            InitializeComponent();
        }

        private void HanghoaForm_Load(object sender, EventArgs e)
        {
            _presenter = new HanghoaPresenter(this);
            _presenter.LoadData();
        }

        public List<NhomHanghoaModel> NhomHanghoaItems
        {
            set { nhomHanghoaModelBindingSource.DataSource = value; }
        }

        public List<HanghoaModel> HanghoaItems
        {
            get
            {
                return hanghoaModelBindingSource.DataSource as List<HanghoaModel>;
            }
            set
            {
                hanghoaModelBindingSource.DataSource = value;
            }
        }

        public HanghoaModel HanghoaCurrent
        {
            get { return hanghoaModelBindingSource.Current as HanghoaModel; }
        }

        public void RefreshData()
        {
            hanghoaModelGridControl.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
            if (hanghoaModelBindingSource.Count >= 1)
                gridView1.FocusedRowHandle = hanghoaModelBindingSource.Count - 1;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void ThietlapgiaButton_Click(object sender, EventArgs e)
        {
            if (HanghoaCurrent == null)
                return;
            _presenter.Save();
            using (var f = new GiaHanghoaForm(HanghoaCurrent))
            {
                f.ShowDialog();
            }
            _presenter.LoadData();
        }
    }
}