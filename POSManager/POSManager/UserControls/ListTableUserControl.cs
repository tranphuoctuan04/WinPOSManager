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
    public partial class ListTableUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ListTableUserControl()
        {
            InitializeComponent();
        }
        public List<BanModel> DataSource
        {
            get { return BanbindingSource.DataSource as List<BanModel>; }
            set
            {
                BanbindingSource.DataSource = value;
            }
        }

        List<TableUserControl> listTableLayout = new List<TableUserControl>();
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

        string labelKhuvuc = "";
        public string LabelKhuvuc
        {
            get { return labelKhuvuc; }
            set { labelKhuvuc = value; }
        }
        #endregion

        void XepBan()
        {
            try
            {
                this.Visible = false;
                if (DataSource == null)
                    return;
                if (DataSource.Count <= 0)
                    return;
                listTableLayout.Clear();
                this.Controls.Clear();
                int top = topMargin;
                int left = leftMargin;
                Label l = new Label();
                l.Text = string.Format("{0}{1:00}", labelKhuvuc, DataSource[0].TenKhuvuc);
                l.Location = new Point(left, top - 30);
                this.Controls.Add(l);
                TableUserControl p;

                for (int i = 0; i < DataSource.Count; i++)
                {
                    p = new TableUserControl(DataSource[i]);
                    p.Location = new Point(left, top);
                    //p.DatPhongClick += new EventHandler(OnDatPhongItem_Click);
                    //p.CheckinClick += new EventHandler(OnCheckinItem_Click);
                    //p.CheckoutClick += new EventHandler(OnCheckoutItem_Click);
                    //p.ThanhtoanClick += new EventHandler(OnThanhtoanItem_Click);
                    //p.DanhsachkhachClick += new EventHandler(OnDanhsachkhachItem_Click);
                    //p.PhongUserControlDoubleClick += new EventHandler(OnPhongUserControl_DoubleClick);

                    listTableLayout.Add(p);

                    left += p.Width + 20;
                    if (!((i < DataSource.Count - 1) && (DataSource[i].KhuvucId != DataSource[i + 1].KhuvucId)) && (left + p.Width + hSpacing >= this.Width))
                    {
                        top += p.Height + vSpacing;
                        left = leftMargin;
                    }

                    if ((i < DataSource.Count - 1) && (DataSource[i].KhuvucId != DataSource[i + 1].KhuvucId))
                    {
                        l = new Label();
                        l.Text = string.Format("{0}{1:00}", labelKhuvuc, DataSource[i + 1].TenKhuvuc);
                        left = leftMargin;
                        top += layerSpacing;
                        l.Location = new Point(leftMargin, top - 30);
                        this.Controls.Add(l);
                    }
                }

                foreach (var item in listTableLayout)
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

        private void BanbindingSource_PositionChanged(object sender, EventArgs e)
        {
            XepBan();
        }
    }
}
