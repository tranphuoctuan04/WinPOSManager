using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.BusinessObject;

namespace POSManager.UserControls
{
    public partial class TableUserControl : DevExpress.XtraEditors.XtraUserControl, INotifyPropertyChanged
    {
        public TableUserControl()
        {
            InitializeComponent();
        }
        public TableUserControl(BanModel banItem)
        {
            InitializeComponent();
            BanItem = banItem;
        }
        public BanModel BanItem
        {
            get { return BanbindingSource.DataSource as BanModel; }
            set
            {
                BanbindingSource.DataSource = value;
                OnPropertyChanged("BanItem");
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
                this.labelName.Text = string.Format("{0}", BanItem.Ten);
                this.BackgroundImage = imageCollection.DungDuoc(BanItem.HoadonId == null);
                this.CleanpictureEdit.Image = imageCollection.Quetdon();
                //if (BanItem.Candon == null)
                //    BanItem.Candon = false;
                canDonToolStripMenuItem.Checked = CleanpictureEdit.Visible = BanItem.Candon.Value;
                
            }
            catch { }
        }

        private void BanbindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (flag == false)
                flag = true;
        }

        public event EventHandler TableClick;
        private void TableUserControl_Click(object sender, EventArgs e)
        {
            EventHandler handler = TableClick;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
    public static class Extentions
    {
        public static Image DungDuoc(this DevExpress.Utils.ImageCollection imgs, bool DungduocValue = true)
        {
            if (DungduocValue == true)
                return imgs.Images[0];
            return imgs.Images[1];
        }
        public static Image Quetdon(this DevExpress.Utils.ImageCollection imgs, bool QuetdonValue = true)
        {
            return imgs.Images[2];
        }
        public static Image Suachua(this DevExpress.Utils.ImageCollection imgs, bool SuachuaValue = true)
        {
            return imgs.Images[3];
        }
    }
}
