using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.BusinessObject;
using System.IO;

namespace POSManager.UserControls
{
    public partial class ProductUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }
        public ProductUserControl(HanghoaModel _HanghoaItem)
        {
            InitializeComponent();
            HanghoaItem = _HanghoaItem;
        }
        public HanghoaModel HanghoaItem
        {
            get { return HanghoabindingSource.DataSource as HanghoaModel; }
            set
            {
                HanghoabindingSource.DataSource = value;
                OnPropertyChanged("HanghoaItem");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handle = this.PropertyChanged;
            if (handle != null)
                handle(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        bool flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                RefereshGui();
            }
        }

        private void RefereshGui()
        {
            try
            {
                this.Namelabel.Text = string.Format("{0}", HanghoaItem.Ten);
                this.BackgroundImage = byteArrayToImage(HanghoaItem.Image);
                this.PriceLable.Text = String.Format("{0:#,#}", HanghoaItem.Giaban);
            }
            catch { }
        }

        private void HanghoabindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (flag == false)
                flag = true;
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public event EventHandler ProductClick;
        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            EventHandler handler = ProductClick;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
