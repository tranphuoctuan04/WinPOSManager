namespace POSManager.UserControls
{
    partial class ListProductUserControl
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
            this.HanghoabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productUserControl1 = new POSManager.UserControls.ProductUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.HanghoabindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HanghoabindingSource
            // 
            this.HanghoabindingSource.DataSource = typeof(Model.BusinessObject.HanghoaModel);
            this.HanghoabindingSource.DataSourceChanged += new System.EventHandler(this.HanghoabindingSource_DataSourceChanged);
            // 
            // productUserControl1
            // 
            this.productUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productUserControl1.HanghoaItem = null;
            this.productUserControl1.Location = new System.Drawing.Point(3, 3);
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Size = new System.Drawing.Size(111, 92);
            this.productUserControl1.TabIndex = 0;
            // 
            // ListProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productUserControl1);
            this.Name = "ListProductUserControl";
            this.Size = new System.Drawing.Size(240, 196);
            ((System.ComponentModel.ISupportInitialize)(this.HanghoabindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProductUserControl productUserControl1;
        private System.Windows.Forms.BindingSource HanghoabindingSource;
    }
}
