namespace POSManager.UserControls
{
    partial class TableUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableUserControl));
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.CleanpictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.BancontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BanbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nhapBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roiBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CleanpictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.BancontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(10, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // CleanpictureEdit
            // 
            this.CleanpictureEdit.Location = new System.Drawing.Point(51, 43);
            this.CleanpictureEdit.Name = "CleanpictureEdit";
            this.CleanpictureEdit.Properties.AllowFocused = false;
            this.CleanpictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.CleanpictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.CleanpictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CleanpictureEdit.Properties.ShowMenu = false;
            this.CleanpictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.CleanpictureEdit.Size = new System.Drawing.Size(34, 31);
            this.CleanpictureEdit.TabIndex = 1;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(52, 52);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "table3.png");
            this.imageCollection.Images.SetKeyName(1, "1422745325_Person-group.png");
            this.imageCollection.Images.SetKeyName(2, "cleaning_20-24.png");
            this.imageCollection.Images.SetKeyName(3, "table.png");
            this.imageCollection.Images.SetKeyName(4, "table2.png");
            // 
            // BancontextMenuStrip
            // 
            this.BancontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapBanToolStripMenuItem,
            this.roiBanToolStripMenuItem,
            this.canDonToolStripMenuItem});
            this.BancontextMenuStrip.Name = "BancontextMenuStrip";
            this.BancontextMenuStrip.Size = new System.Drawing.Size(127, 70);
            // 
            // BanbindingSource
            // 
            this.BanbindingSource.DataSource = typeof(Model.BusinessObject.BanModel);
            this.BanbindingSource.PositionChanged += new System.EventHandler(this.BanbindingSource_PositionChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nhapBanToolStripMenuItem
            // 
            this.nhapBanToolStripMenuItem.Name = "nhapBanToolStripMenuItem";
            this.nhapBanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.nhapBanToolStripMenuItem.Text = "Nhập bàn";
            // 
            // roiBanToolStripMenuItem
            // 
            this.roiBanToolStripMenuItem.Name = "roiBanToolStripMenuItem";
            this.roiBanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.roiBanToolStripMenuItem.Text = "Rời bàn";
            // 
            // canDonToolStripMenuItem
            // 
            this.canDonToolStripMenuItem.Name = "canDonToolStripMenuItem";
            this.canDonToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.canDonToolStripMenuItem.Text = "Cần dọn";
            // 
            // TableUserControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.BancontextMenuStrip;
            this.Controls.Add(this.CleanpictureEdit);
            this.Controls.Add(this.labelName);
            this.DoubleBuffered = true;
            this.Name = "TableUserControl";
            this.Size = new System.Drawing.Size(85, 85);
            ((System.ComponentModel.ISupportInitialize)(this.CleanpictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.BancontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BanbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.PictureEdit CleanpictureEdit;
        private DevExpress.Utils.ImageCollection imageCollection;
        private System.Windows.Forms.BindingSource BanbindingSource;
        private System.Windows.Forms.ContextMenuStrip BancontextMenuStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem nhapBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roiBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canDonToolStripMenuItem;
    }
}
