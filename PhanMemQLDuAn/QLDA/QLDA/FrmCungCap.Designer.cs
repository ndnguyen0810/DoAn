
namespace QLDA
{
    partial class FrmCungCap
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
            this.components = new System.ComponentModel.Container();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cbxMDA = new System.Windows.Forms.ComboBox();
            this.lblMNCC = new System.Windows.Forms.Label();
            this.lblMHH = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMHH = new System.Windows.Forms.Label();
            this.tbxTKMNCC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTKMDA = new System.Windows.Forms.Label();
            this.tbxTKMDA = new System.Windows.Forms.TextBox();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.cbxMNCC = new System.Windows.Forms.ComboBox();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new QLDA.QLDADataSetTableAdapters.DUANTableAdapter();
            this.nHACCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHACCAPTableAdapter = new QLDA.QLDADataSetTableAdapters.NHACCAPTableAdapter();
            this.cUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUNGCAPTableAdapter = new QLDA.QLDADataSetTableAdapters.CUNGCAPTableAdapter();
            this.mANCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUNGCAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cbxMNCC);
            this.grbThongTin.Controls.Add(this.cbxMDA);
            this.grbThongTin.Controls.Add(this.lblMNCC);
            this.grbThongTin.Controls.Add(this.lblMHH);
            this.grbThongTin.Location = new System.Drawing.Point(606, 58);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 428);
            this.grbThongTin.TabIndex = 55;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // cbxMDA
            // 
            this.cbxMDA.DataSource = this.dUANBindingSource;
            this.cbxMDA.DisplayMember = "MADUAN";
            this.cbxMDA.FormattingEnabled = true;
            this.cbxMDA.Location = new System.Drawing.Point(120, 55);
            this.cbxMDA.Name = "cbxMDA";
            this.cbxMDA.Size = new System.Drawing.Size(265, 30);
            this.cbxMDA.TabIndex = 15;
            this.cbxMDA.ValueMember = "MADUAN";
            // 
            // lblMNCC
            // 
            this.lblMNCC.AutoSize = true;
            this.lblMNCC.Location = new System.Drawing.Point(35, 61);
            this.lblMNCC.Name = "lblMNCC";
            this.lblMNCC.Size = new System.Drawing.Size(79, 22);
            this.lblMNCC.TabIndex = 14;
            this.lblMNCC.Text = "Mã DA :";
            // 
            // lblMHH
            // 
            this.lblMHH.AutoSize = true;
            this.lblMHH.Location = new System.Drawing.Point(22, 26);
            this.lblMHH.Name = "lblMHH";
            this.lblMHH.Size = new System.Drawing.Size(92, 22);
            this.lblMHH.TabIndex = 10;
            this.lblMHH.Text = "Mã NCC :";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMDA);
            this.grpTK.Controls.Add(this.tbxTKMDA);
            this.grpTK.Controls.Add(this.lblTKMHH);
            this.grpTK.Controls.Add(this.tbxTKMNCC);
            this.grpTK.Location = new System.Drawing.Point(81, 58);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 88);
            this.grpTK.TabIndex = 54;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMHH
            // 
            this.lblTKMHH.AutoSize = true;
            this.lblTKMHH.Location = new System.Drawing.Point(85, 23);
            this.lblTKMHH.Name = "lblTKMHH";
            this.lblTKMHH.Size = new System.Drawing.Size(87, 22);
            this.lblTKMHH.TabIndex = 9;
            this.lblTKMHH.Text = "Mã NCC:";
            // 
            // tbxTKMNCC
            // 
            this.tbxTKMNCC.Location = new System.Drawing.Point(179, 18);
            this.tbxTKMNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMNCC.Name = "tbxTKMNCC";
            this.tbxTKMNCC.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMNCC.TabIndex = 1;
            this.tbxTKMNCC.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(476, 459);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANCCDataGridViewTextBoxColumn,
            this.mADUANDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.cUNGCAPBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(81, 152);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(519, 301);
            this.DataQLDA.TabIndex = 50;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(454, 21);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(142, 34);
            this.lbltitle.TabIndex = 49;
            this.lbltitle.Text = "Cung Cấp";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(280, 458);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(83, 458);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTKMDA
            // 
            this.lblTKMDA.AutoSize = true;
            this.lblTKMDA.Location = new System.Drawing.Point(97, 55);
            this.lblTKMDA.Name = "lblTKMDA";
            this.lblTKMDA.Size = new System.Drawing.Size(75, 22);
            this.lblTKMDA.TabIndex = 11;
            this.lblTKMDA.Text = "Mã DA:";
            // 
            // tbxTKMDA
            // 
            this.tbxTKMDA.Location = new System.Drawing.Point(179, 52);
            this.tbxTKMDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMDA.Name = "tbxTKMDA";
            this.tbxTKMDA.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMDA.TabIndex = 10;
            this.tbxTKMDA.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxMNCC
            // 
            this.cbxMNCC.DataSource = this.nHACCAPBindingSource;
            this.cbxMNCC.DisplayMember = "MANCC";
            this.cbxMNCC.FormattingEnabled = true;
            this.cbxMNCC.Location = new System.Drawing.Point(120, 20);
            this.cbxMNCC.Name = "cbxMNCC";
            this.cbxMNCC.Size = new System.Drawing.Size(265, 30);
            this.cbxMNCC.TabIndex = 16;
            this.cbxMNCC.ValueMember = "MANCC";
            // 
            // dUANBindingSource
            // 
            this.dUANBindingSource.DataMember = "DUAN";
            this.dUANBindingSource.DataSource = this.qLDADataSet;
            // 
            // dUANTableAdapter
            // 
            this.dUANTableAdapter.ClearBeforeFill = true;
            // 
            // nHACCAPBindingSource
            // 
            this.nHACCAPBindingSource.DataMember = "NHACCAP";
            this.nHACCAPBindingSource.DataSource = this.qLDADataSet;
            // 
            // nHACCAPTableAdapter
            // 
            this.nHACCAPTableAdapter.ClearBeforeFill = true;
            // 
            // cUNGCAPBindingSource
            // 
            this.cUNGCAPBindingSource.DataMember = "CUNGCAP";
            this.cUNGCAPBindingSource.DataSource = this.qLDADataSet;
            // 
            // cUNGCAPTableAdapter
            // 
            this.cUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // mANCCDataGridViewTextBoxColumn
            // 
            this.mANCCDataGridViewTextBoxColumn.DataPropertyName = "MANCC";
            this.mANCCDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Cung Cấp";
            this.mANCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANCCDataGridViewTextBoxColumn.Name = "mANCCDataGridViewTextBoxColumn";
            this.mANCCDataGridViewTextBoxColumn.Width = 170;
            // 
            // mADUANDataGridViewTextBoxColumn
            // 
            this.mADUANDataGridViewTextBoxColumn.DataPropertyName = "MADUAN";
            this.mADUANDataGridViewTextBoxColumn.HeaderText = "Mã Dự Án";
            this.mADUANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mADUANDataGridViewTextBoxColumn.Name = "mADUANDataGridViewTextBoxColumn";
            this.mADUANDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 504);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCungCap";
            this.Text = "Cung Cấp";
            this.Load += new System.EventHandler(this.FrmCungCap_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUNGCAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cbxMDA;
        private System.Windows.Forms.Label lblMNCC;
        private System.Windows.Forms.Label lblMHH;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMHH;
        private System.Windows.Forms.TextBox tbxTKMNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTKMDA;
        private System.Windows.Forms.TextBox tbxTKMDA;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.ComboBox cbxMNCC;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private QLDADataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.BindingSource nHACCAPBindingSource;
        private QLDADataSetTableAdapters.NHACCAPTableAdapter nHACCAPTableAdapter;
        private System.Windows.Forms.BindingSource cUNGCAPBindingSource;
        private QLDADataSetTableAdapters.CUNGCAPTableAdapter cUNGCAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADUANDataGridViewTextBoxColumn;
    }
}