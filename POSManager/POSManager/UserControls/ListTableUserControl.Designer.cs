namespace POSManager.UserControls
{
    partial class ListTableUserControl
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
            this.tableUserControl1 = new POSManager.UserControls.TableUserControl();
            this.BanbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BanbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableUserControl1
            // 
            this.tableUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableUserControl1.BanItem = null;
            this.tableUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableUserControl1.Location = new System.Drawing.Point(0, 0);
            this.tableUserControl1.Name = "tableUserControl1";
            this.tableUserControl1.Size = new System.Drawing.Size(90, 87);
            this.tableUserControl1.TabIndex = 0;
            // 
            // BanbindingSource
            // 
            this.BanbindingSource.DataSource = typeof(Model.BusinessObject.BanModel);
            this.BanbindingSource.DataSourceChanged += new System.EventHandler(this.BanbindingSource_DataSourceChanged);
            // 
            // ListTableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableUserControl1);
            this.Name = "ListTableUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.BanbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableUserControl tableUserControl1;
        private System.Windows.Forms.BindingSource BanbindingSource;
    }
}
