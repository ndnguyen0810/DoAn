
namespace QLDA
{
    partial class FrmNhanVien
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
            this.tbxSDTNV = new System.Windows.Forms.TextBox();
            this.lblSDTNV = new System.Windows.Forms.Label();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.tbxTNV = new System.Windows.Forms.TextBox();
            this.lblTNV = new System.Windows.Forms.Label();
            this.lblMDA = new System.Windows.Forms.Label();
            this.tbxMNV = new System.Windows.Forms.TextBox();
            this.lblMNV = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMNV = new System.Windows.Forms.Label();
            this.tbxTKMNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QLDA.QLDADataSetTableAdapters.NHANVIENTableAdapter();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHINVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMDA = new System.Windows.Forms.ComboBox();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new QLDA.QLDADataSetTableAdapters.DUANTableAdapter();
            this.DateTNamSinh = new System.Windows.Forms.DateTimePicker();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.DateTNamSinh);
            this.grbThongTin.Controls.Add(this.cbxMDA);
            this.grbThongTin.Controls.Add(this.lblDiaChi);
            this.grbThongTin.Controls.Add(this.tbxSDTNV);
            this.grbThongTin.Controls.Add(this.lblSDTNV);
            this.grbThongTin.Controls.Add(this.tbxDiaChi);
            this.grbThongTin.Controls.Add(this.lblNamSinh);
            this.grbThongTin.Controls.Add(this.tbxTNV);
            this.grbThongTin.Controls.Add(this.lblTNV);
            this.grbThongTin.Controls.Add(this.lblMDA);
            this.grbThongTin.Controls.Add(this.tbxMNV);
            this.grbThongTin.Controls.Add(this.lblMNV);
            this.grbThongTin.Location = new System.Drawing.Point(608, 87);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 410);
            this.grbThongTin.TabIndex = 34;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // tbxSDTNV
            // 
            this.tbxSDTNV.Location = new System.Drawing.Point(108, 169);
            this.tbxSDTNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSDTNV.Name = "tbxSDTNV";
            this.tbxSDTNV.Size = new System.Drawing.Size(272, 30);
            this.tbxSDTNV.TabIndex = 21;
            // 
            // lblSDTNV
            // 
            this.lblSDTNV.AutoSize = true;
            this.lblSDTNV.Location = new System.Drawing.Point(11, 172);
            this.lblSDTNV.Name = "lblSDTNV";
            this.lblSDTNV.Size = new System.Drawing.Size(90, 22);
            this.lblSDTNV.TabIndex = 20;
            this.lblSDTNV.Text = "SĐT NV :";
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(108, 205);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(272, 30);
            this.tbxDiaChi.TabIndex = 19;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(1, 133);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(98, 22);
            this.lblNamSinh.TabIndex = 18;
            this.lblNamSinh.Text = "Năm Sinh :";
            // 
            // tbxTNV
            // 
            this.tbxTNV.Location = new System.Drawing.Point(108, 94);
            this.tbxTNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTNV.Name = "tbxTNV";
            this.tbxTNV.Size = new System.Drawing.Size(272, 30);
            this.tbxTNV.TabIndex = 17;
            // 
            // lblTNV
            // 
            this.lblTNV.AutoSize = true;
            this.lblTNV.Location = new System.Drawing.Point(18, 97);
            this.lblTNV.Name = "lblTNV";
            this.lblTNV.Size = new System.Drawing.Size(83, 22);
            this.lblTNV.TabIndex = 16;
            this.lblTNV.Text = "Tên NV :";
            // 
            // lblMDA
            // 
            this.lblMDA.AutoSize = true;
            this.lblMDA.Location = new System.Drawing.Point(22, 62);
            this.lblMDA.Name = "lblMDA";
            this.lblMDA.Size = new System.Drawing.Size(79, 22);
            this.lblMDA.TabIndex = 12;
            this.lblMDA.Text = "Mã DA :";
            // 
            // tbxMNV
            // 
            this.tbxMNV.Location = new System.Drawing.Point(108, 23);
            this.tbxMNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxMNV.Name = "tbxMNV";
            this.tbxMNV.Size = new System.Drawing.Size(272, 30);
            this.tbxMNV.TabIndex = 11;
            // 
            // lblMNV
            // 
            this.lblMNV.AutoSize = true;
            this.lblMNV.Location = new System.Drawing.Point(26, 26);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(73, 22);
            this.lblMNV.TabIndex = 10;
            this.lblMNV.Text = "Mã NV:";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMNV);
            this.grpTK.Controls.Add(this.tbxTKMNV);
            this.grpTK.Location = new System.Drawing.Point(83, 87);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 70);
            this.grpTK.TabIndex = 33;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMNV
            // 
            this.lblTKMNV.AutoSize = true;
            this.lblTKMNV.Location = new System.Drawing.Point(25, 31);
            this.lblTKMNV.Name = "lblTKMNV";
            this.lblTKMNV.Size = new System.Drawing.Size(134, 22);
            this.lblTKMNV.TabIndex = 9;
            this.lblTKMNV.Text = "Mã Nhân Viên :";
            // 
            // tbxTKMNV
            // 
            this.tbxTKMNV.Location = new System.Drawing.Point(179, 28);
            this.tbxTKMNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMNV.Name = "tbxTKMNV";
            this.tbxTKMNV.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMNV.TabIndex = 1;
            this.tbxTKMNV.TextChanged += new System.EventHandler(this.tbxTKMNV_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(478, 470);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(85, 469);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(282, 469);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.mADUANDataGridViewTextBoxColumn,
            this.tENNVDataGridViewTextBoxColumn,
            this.nAMSINHDataGridViewTextBoxColumn,
            this.sDTNVDataGridViewTextBoxColumn,
            this.dIACHINVDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.nHANVIENBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(83, 163);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(519, 301);
            this.DataQLDA.TabIndex = 29;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(452, 22);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(150, 34);
            this.lbltitle.TabIndex = 28;
            this.lbltitle.Text = "Nhân Viên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(18, 208);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(83, 22);
            this.lblDiaChi.TabIndex = 23;
            this.lblDiaChi.Text = "Địa Chỉ :";
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLDADataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // mADUANDataGridViewTextBoxColumn
            // 
            this.mADUANDataGridViewTextBoxColumn.DataPropertyName = "MADUAN";
            this.mADUANDataGridViewTextBoxColumn.HeaderText = "Mã Dự Án";
            this.mADUANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mADUANDataGridViewTextBoxColumn.Name = "mADUANDataGridViewTextBoxColumn";
            this.mADUANDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENNVDataGridViewTextBoxColumn
            // 
            this.tENNVDataGridViewTextBoxColumn.DataPropertyName = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tENNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNVDataGridViewTextBoxColumn.Name = "tENNVDataGridViewTextBoxColumn";
            this.tENNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMSINHDataGridViewTextBoxColumn
            // 
            this.nAMSINHDataGridViewTextBoxColumn.DataPropertyName = "NAMSINH";
            this.nAMSINHDataGridViewTextBoxColumn.HeaderText = "Năm Sinh";
            this.nAMSINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMSINHDataGridViewTextBoxColumn.Name = "nAMSINHDataGridViewTextBoxColumn";
            this.nAMSINHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTNVDataGridViewTextBoxColumn
            // 
            this.sDTNVDataGridViewTextBoxColumn.DataPropertyName = "SDTNV";
            this.sDTNVDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTNVDataGridViewTextBoxColumn.Name = "sDTNVDataGridViewTextBoxColumn";
            this.sDTNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIACHINVDataGridViewTextBoxColumn
            // 
            this.dIACHINVDataGridViewTextBoxColumn.DataPropertyName = "DIACHINV";
            this.dIACHINVDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dIACHINVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHINVDataGridViewTextBoxColumn.Name = "dIACHINVDataGridViewTextBoxColumn";
            this.dIACHINVDataGridViewTextBoxColumn.Width = 125;
            // 
            // cbxMDA
            // 
            this.cbxMDA.DataSource = this.dUANBindingSource;
            this.cbxMDA.DisplayMember = "MADUAN";
            this.cbxMDA.FormattingEnabled = true;
            this.cbxMDA.Location = new System.Drawing.Point(108, 58);
            this.cbxMDA.Name = "cbxMDA";
            this.cbxMDA.Size = new System.Drawing.Size(272, 30);
            this.cbxMDA.TabIndex = 24;
            this.cbxMDA.ValueMember = "MADUAN";
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
            // DateTNamSinh
            // 
            this.DateTNamSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTNamSinh.Location = new System.Drawing.Point(108, 133);
            this.DateTNamSinh.Name = "DateTNamSinh";
            this.DateTNamSinh.Size = new System.Drawing.Size(272, 30);
            this.DateTNamSinh.TabIndex = 25;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 596);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox tbxSDTNV;
        private System.Windows.Forms.Label lblSDTNV;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox tbxTNV;
        private System.Windows.Forms.Label lblTNV;
        private System.Windows.Forms.Label lblMDA;
        private System.Windows.Forms.TextBox tbxMNV;
        private System.Windows.Forms.Label lblMNV;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMNV;
        private System.Windows.Forms.TextBox tbxTKMNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblDiaChi;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLDADataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADUANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHINVDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxMDA;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private QLDADataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.DateTimePicker DateTNamSinh;
    }
}