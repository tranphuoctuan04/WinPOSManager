namespace Form
{
    partial class HanghoaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label nhomHanghoaIdLabel;
            System.Windows.Forms.Label hoatdongLabel;
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HanghoaForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.hanghoaModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.hanghoaModelBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoatdong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomHanghoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.nhomHanghoaModelBindingSource = new System.Windows.Forms.BindingSource();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ThietlapgiaButton = new DevExpress.XtraEditors.SimpleButton();
            this.imagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.hoatdongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nhomHanghoaIdComboBox = new System.Windows.Forms.ComboBox();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DelButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            codeLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            nhomHanghoaIdLabel = new System.Windows.Forms.Label();
            hoatdongLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatdongCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(19, 47);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(21, 13);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "Mã";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(19, 89);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(25, 13);
            tenLabel.TabIndex = 3;
            tenLabel.Text = "Tên";
            // 
            // nhomHanghoaIdLabel
            // 
            nhomHanghoaIdLabel.AutoSize = true;
            nhomHanghoaIdLabel.Location = new System.Drawing.Point(19, 126);
            nhomHanghoaIdLabel.Name = "nhomHanghoaIdLabel";
            nhomHanghoaIdLabel.Size = new System.Drawing.Size(61, 13);
            nhomHanghoaIdLabel.TabIndex = 5;
            nhomHanghoaIdLabel.Text = "Nhóm hàng";
            // 
            // hoatdongLabel
            // 
            hoatdongLabel.AutoSize = true;
            hoatdongLabel.Location = new System.Drawing.Point(19, 313);
            hoatdongLabel.Name = "hoatdongLabel";
            hoatdongLabel.Size = new System.Drawing.Size(57, 13);
            hoatdongLabel.TabIndex = 7;
            hoatdongLabel.Text = "Hoạt động";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(19, 173);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(49, 13);
            imageLabel.TabIndex = 9;
            imageLabel.Text = "Hình ảnh";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(807, 501);
            this.splitContainerControl1.SplitterPosition = 335;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.hanghoaModelGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(467, 501);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách hàng hóa";
            // 
            // hanghoaModelGridControl
            // 
            this.hanghoaModelGridControl.DataSource = this.hanghoaModelBindingSource;
            this.hanghoaModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hanghoaModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.hanghoaModelGridControl.MainView = this.gridView1;
            this.hanghoaModelGridControl.Name = "hanghoaModelGridControl";
            this.hanghoaModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemPictureEdit,
            this.ItemLookUpEdit});
            this.hanghoaModelGridControl.Size = new System.Drawing.Size(463, 478);
            this.hanghoaModelGridControl.TabIndex = 0;
            this.hanghoaModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hanghoaModelBindingSource
            // 
            this.hanghoaModelBindingSource.DataSource = typeof(Model.BusinessObject.HanghoaModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colCode,
            this.colTen,
            this.colHoatdong,
            this.colState,
            this.colGiaban,
            this.colNhomHanghoaId});
            this.gridView1.GridControl = this.hanghoaModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.RowHeight = 70;
            // 
            // colImage
            // 
            this.colImage.Caption = "Ảnh";
            this.colImage.ColumnEdit = this.ItemPictureEdit;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            // 
            // ItemPictureEdit
            // 
            this.ItemPictureEdit.Name = "ItemPictureEdit";
            this.ItemPictureEdit.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.ItemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // colCode
            // 
            this.colCode.Caption = "Mã";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            // 
            // colHoatdong
            // 
            this.colHoatdong.Caption = "Hoạt động";
            this.colHoatdong.FieldName = "Hoatdong";
            this.colHoatdong.Name = "colHoatdong";
            this.colHoatdong.Visible = true;
            this.colHoatdong.VisibleIndex = 4;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            // 
            // colGiaban
            // 
            this.colGiaban.Caption = "Gía bán";
            this.colGiaban.DisplayFormat.FormatString = "#,#";
            this.colGiaban.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiaban.FieldName = "Giaban";
            this.colGiaban.Name = "colGiaban";
            this.colGiaban.Visible = true;
            this.colGiaban.VisibleIndex = 5;
            // 
            // colNhomHanghoaId
            // 
            this.colNhomHanghoaId.Caption = "Nhóm hàng";
            this.colNhomHanghoaId.ColumnEdit = this.ItemLookUpEdit;
            this.colNhomHanghoaId.FieldName = "NhomHanghoaId";
            this.colNhomHanghoaId.Name = "colNhomHanghoaId";
            this.colNhomHanghoaId.Visible = true;
            this.colNhomHanghoaId.VisibleIndex = 3;
            // 
            // ItemLookUpEdit
            // 
            this.ItemLookUpEdit.AutoHeight = false;
            this.ItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Nhóm")});
            this.ItemLookUpEdit.DataSource = this.nhomHanghoaModelBindingSource;
            this.ItemLookUpEdit.DisplayMember = "Ten";
            this.ItemLookUpEdit.Name = "ItemLookUpEdit";
            this.ItemLookUpEdit.ValueMember = "NhomHanghoaId";
            // 
            // nhomHanghoaModelBindingSource
            // 
            this.nhomHanghoaModelBindingSource.DataSource = typeof(Model.BusinessObject.NhomHanghoaModel);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ThietlapgiaButton);
            this.groupControl2.Controls.Add(imageLabel);
            this.groupControl2.Controls.Add(this.imagePictureEdit);
            this.groupControl2.Controls.Add(hoatdongLabel);
            this.groupControl2.Controls.Add(this.hoatdongCheckEdit);
            this.groupControl2.Controls.Add(nhomHanghoaIdLabel);
            this.groupControl2.Controls.Add(this.nhomHanghoaIdComboBox);
            this.groupControl2.Controls.Add(tenLabel);
            this.groupControl2.Controls.Add(this.tenTextEdit);
            this.groupControl2.Controls.Add(codeLabel);
            this.groupControl2.Controls.Add(this.codeTextEdit);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(335, 501);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin hàng hóa";
            // 
            // ThietlapgiaButton
            // 
            this.ThietlapgiaButton.Image = ((System.Drawing.Image)(resources.GetObject("ThietlapgiaButton.Image")));
            this.ThietlapgiaButton.Location = new System.Drawing.Point(22, 361);
            this.ThietlapgiaButton.Name = "ThietlapgiaButton";
            this.ThietlapgiaButton.Size = new System.Drawing.Size(105, 23);
            this.ThietlapgiaButton.TabIndex = 11;
            this.ThietlapgiaButton.Text = "Thiết lập giá";
            this.ThietlapgiaButton.Click += new System.EventHandler(this.ThietlapgiaButton_Click);
            // 
            // imagePictureEdit
            // 
            this.imagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Image", true));
            this.imagePictureEdit.Location = new System.Drawing.Point(95, 160);
            this.imagePictureEdit.Name = "imagePictureEdit";
            this.imagePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.imagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.imagePictureEdit.Size = new System.Drawing.Size(185, 130);
            this.imagePictureEdit.TabIndex = 10;
            // 
            // hoatdongCheckEdit
            // 
            this.hoatdongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Hoatdong", true));
            this.hoatdongCheckEdit.Location = new System.Drawing.Point(93, 307);
            this.hoatdongCheckEdit.Name = "hoatdongCheckEdit";
            this.hoatdongCheckEdit.Properties.Caption = "";
            this.hoatdongCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.hoatdongCheckEdit.TabIndex = 8;
            // 
            // nhomHanghoaIdComboBox
            // 
            this.nhomHanghoaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hanghoaModelBindingSource, "NhomHanghoaId", true));
            this.nhomHanghoaIdComboBox.DataSource = this.nhomHanghoaModelBindingSource;
            this.nhomHanghoaIdComboBox.DisplayMember = "Ten";
            this.nhomHanghoaIdComboBox.FormattingEnabled = true;
            this.nhomHanghoaIdComboBox.Location = new System.Drawing.Point(95, 123);
            this.nhomHanghoaIdComboBox.Name = "nhomHanghoaIdComboBox";
            this.nhomHanghoaIdComboBox.Size = new System.Drawing.Size(185, 21);
            this.nhomHanghoaIdComboBox.TabIndex = 6;
            this.nhomHanghoaIdComboBox.ValueMember = "NhomHanghoaId";
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Ten", true));
            this.tenTextEdit.Location = new System.Drawing.Point(95, 86);
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(185, 20);
            this.tenTextEdit.TabIndex = 4;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(95, 44);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(185, 20);
            this.codeTextEdit.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Controls.Add(this.DelButton);
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 447);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(331, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(246, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Image = ((System.Drawing.Image)(resources.GetObject("DelButton.Image")));
            this.DelButton.Location = new System.Drawing.Point(149, 19);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 0;
            this.DelButton.Text = "Xóa";
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(50, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HanghoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 501);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "HanghoaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HÀNG HÓA";
            this.Load += new System.EventHandler(this.HanghoaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatdongCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl hanghoaModelGridControl;
        private System.Windows.Forms.BindingSource hanghoaModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colHoatdong;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit ItemPictureEdit;
        private DevExpress.XtraEditors.PictureEdit imagePictureEdit;
        private DevExpress.XtraEditors.CheckEdit hoatdongCheckEdit;
        private System.Windows.Forms.ComboBox nhomHanghoaIdComboBox;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DelButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private System.Windows.Forms.BindingSource nhomHanghoaModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHanghoaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaban;
        private DevExpress.XtraEditors.SimpleButton ThietlapgiaButton;
    }
}