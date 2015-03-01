namespace POSManager.UserControls
{
    partial class ProductUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ProductcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PriceLable = new DevExpress.XtraEditors.LabelControl();
            this.HanghoabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.Namelabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HanghoabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // ProductcontextMenuStrip
            // 
            this.ProductcontextMenuStrip.Name = "ProductcontextMenuStrip";
            this.ProductcontextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // PriceLable
            // 
            this.PriceLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PriceLable.Location = new System.Drawing.Point(66, 3);
            this.PriceLable.Name = "PriceLable";
            this.PriceLable.Size = new System.Drawing.Size(34, 13);
            this.PriceLable.TabIndex = 1;
            this.PriceLable.Text = "15,000";
            // 
            // HanghoabindingSource
            // 
            this.HanghoabindingSource.DataSource = typeof(Model.BusinessObject.HanghoaModel);
            this.HanghoabindingSource.PositionChanged += new System.EventHandler(this.HanghoabindingSource_PositionChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.Namelabel);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 69);
            this.panelControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(109, 21);
            this.panelControl.TabIndex = 3;
            // 
            // Namelabel
            // 
            this.Namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Namelabel.Location = new System.Drawing.Point(5, 3);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(27, 13);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.PriceLable);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(109, 90);
            this.DoubleClick += new System.EventHandler(this.ProductUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HanghoabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection;
        private System.Windows.Forms.ContextMenuStrip ProductcontextMenuStrip;
        private DevExpress.XtraEditors.LabelControl PriceLable;
        private System.Windows.Forms.BindingSource HanghoabindingSource;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.PanelControl panelControl;
        public DevExpress.XtraEditors.LabelControl Namelabel;
    }
}
