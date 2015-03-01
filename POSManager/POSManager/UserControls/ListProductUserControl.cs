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
    public partial class ListProductUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ListProductUserControl()
        {
            InitializeComponent();
        }
        public List<HanghoaModel> DataSource
        {
            get { return HanghoabindingSource.DataSource as List<HanghoaModel>; }
            set
            {
                HanghoabindingSource.DataSource = value;
            }
        }
        List<ProductUserControl> listProductLayout = new List<ProductUserControl>();
        #region Properties
        int topMargin = 30;
        public int TopMargin
        {
            get { return topMargin; }
            set { topMargin = value; }
        }

        int leftMargin = 20;
        public int LeftMargin
        {
            get { return leftMargin; }
            set { leftMargin = value; }
        }

        int hSpacing = 50;
        public int HSpacing
        {
            get { return hSpacing; }
            set { hSpacing = value; }
        }

        int vSpacing = 10;
        public int VSpacing
        {
            get { return vSpacing; }
            set { vSpacing = value; }
        }

        int layerSpacing = 150;
        public int LayerSpacing
        {
            get { return layerSpacing; }
            set { layerSpacing = value; }
        }

        string labelNhomHanghoa = "";
        public string LabelKhuvuc
        {
            get { return labelNhomHanghoa; }
            set { labelNhomHanghoa = value; }
        }
        #endregion

        void XepHanghoa()
        {
            try
            {
                this.Visible = false;
                if (DataSource == null)
                    return;
                if (DataSource.Count <= 0)
                    return;
                listProductLayout.Clear();
                this.Controls.Clear();
                int top = topMargin;
                int left = leftMargin;
                Label l = new Label();
                l.Text = string.Format("{0}{1:00}", labelNhomHanghoa, DataSource[0].TenNhomHanghoa);
                l.ForeColor = Color.Blue;
                l.Location = new Point(left, top - 30);
                this.Controls.Add(l);
                ProductUserControl p;

                for (int i = 0; i < DataSource.Count; i++)
                {
                    p = new ProductUserControl(DataSource[i]);
                    p.Location = new Point(left, top);
                    p.ProductClick += new EventHandler(OnProductItem_Click);

                    listProductLayout.Add(p);

                    left += p.Width + 20;
                    if (!((i < DataSource.Count - 1) && (DataSource[i].NhomHanghoaId != DataSource[i + 1].NhomHanghoaId)) && (left + p.Width + hSpacing >= this.Width))
                    {
                        top += p.Height + vSpacing;
                        left = leftMargin;
                    }

                    if ((i < DataSource.Count - 1) && (DataSource[i].NhomHanghoaId != DataSource[i + 1].NhomHanghoaId))
                    {
                        l = new Label();
                        l.Text = string.Format("{0}{1:00}", labelNhomHanghoa, DataSource[i + 1].TenNhomHanghoa);
                        l.ForeColor = Color.Blue;
                        left = leftMargin;
                        top += layerSpacing;
                        l.Location = new Point(leftMargin, top - 30);
                        this.Controls.Add(l);
                    }
                }

                foreach (var item in listProductLayout)
                {

                    this.Controls.Add(item);
                }
                this.Visible = true;
                this.Refresh();
            }
            catch
            {
                this.Visible = true;
            }
        }

        public event EventHandler ProductItemClick;
        private void OnProductItem_Click(object sender, EventArgs e)
        {
            EventHandler handler = ProductItemClick;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        private void HanghoabindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            XepHanghoa();
        }

        internal void ResetBorderStype()
        {
            foreach (var item in listProductLayout)
            {
                item.Namelabel.ForeColor = Color.Black;
                item.panelControl.BackColor = Color.Gainsboro;
                item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(item);
            }
        }
    }
}
