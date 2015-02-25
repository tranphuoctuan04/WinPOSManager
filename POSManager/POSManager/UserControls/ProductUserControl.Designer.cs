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
            this.NameLable = new DevExpress.XtraEditors.LabelControl();
            this.PriceLable = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
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
            // NameLable
            // 
            this.NameLable.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLable.Location = new System.Drawing.Point(10, 46);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(32, 13);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "Name";
            // 
            // PriceLable
            // 
            this.PriceLable.Location = new System.Drawing.Point(10, 65);
            this.PriceLable.Name = "PriceLable";
            this.PriceLable.Size = new System.Drawing.Size(23, 13);
            this.PriceLable.TabIndex = 1;
            this.PriceLable.Text = "Price";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriceLable);
            this.Controls.Add(this.NameLable);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(111, 85);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection;
        private System.Windows.Forms.ContextMenuStrip ProductcontextMenuStrip;
        private DevExpress.XtraEditors.LabelControl NameLable;
        private DevExpress.XtraEditors.LabelControl PriceLable;
    }
}
