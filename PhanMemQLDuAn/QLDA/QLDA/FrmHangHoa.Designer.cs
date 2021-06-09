
namespace QLDA
{
    partial class FrmHangHoa
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
            this.tbxTHH = new System.Windows.Forms.TextBox();
            this.lblTHH = new System.Windows.Forms.Label();
            this.tbxMHH = new System.Windows.Forms.TextBox();
            this.lblMHH = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMHH = new System.Windows.Forms.Label();
            this.tbxTKMHH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.qLDADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new QLDA.QLDADataSetTableAdapters.HANGHOATableAdapter();
            this.mAHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRONGLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMNCC = new System.Windows.Forms.Label();
            this.cbxMNCC = new System.Windows.Forms.ComboBox();
            this.nHACCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHACCAPTableAdapter = new QLDA.QLDADataSetTableAdapters.NHACCAPTableAdapter();
            this.tbxMau = new System.Windows.Forms.TextBox();
            this.lblMau = new System.Windows.Forms.Label();
            this.tbxTrongLuong = new System.Windows.Forms.TextBox();
            this.lblTrongLuong = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.tbxTrongLuong);
            this.grbThongTin.Controls.Add(this.lblTrongLuong);
            this.grbThongTin.Controls.Add(this.tbxMau);
            this.grbThongTin.Controls.Add(this.lblMau);
            this.grbThongTin.Controls.Add(this.cbxMNCC);
            this.grbThongTin.Controls.Add(this.lblMNCC);
            this.grbThongTin.Controls.Add(this.tbxTHH);
            this.grbThongTin.Controls.Add(this.lblTHH);
            this.grbThongTin.Controls.Add(this.tbxMHH);
            this.grbThongTin.Controls.Add(this.lblMHH);
            this.grbThongTin.Location = new System.Drawing.Point(591, 77);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 428);
            this.grbThongTin.TabIndex = 48;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // tbxTHH
            // 
            this.tbxTHH.Location = new System.Drawing.Point(156, 94);
            this.tbxTHH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTHH.Name = "tbxTHH";
            this.tbxTHH.Size = new System.Drawing.Size(265, 30);
            this.tbxTHH.TabIndex = 13;
            // 
            // lblTHH
            // 
            this.lblTHH.AutoSize = true;
            this.lblTHH.Location = new System.Drawing.Point(18, 97);
            this.lblTHH.Name = "lblTHH";
            this.lblTHH.Size = new System.Drawing.Size(135, 22);
            this.lblTHH.TabIndex = 12;
            this.lblTHH.Text = "Tên Hàng Hóa :";
            // 
            // tbxMHH
            // 
            this.tbxMHH.Location = new System.Drawing.Point(156, 23);
            this.tbxMHH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxMHH.Name = "tbxMHH";
            this.tbxMHH.Size = new System.Drawing.Size(265, 30);
            this.tbxMHH.TabIndex = 11;
            // 
            // lblMHH
            // 
            this.lblMHH.AutoSize = true;
            this.lblMHH.Location = new System.Drawing.Point(22, 26);
            this.lblMHH.Name = "lblMHH";
            this.lblMHH.Size = new System.Drawing.Size(131, 22);
            this.lblMHH.TabIndex = 10;
            this.lblMHH.Text = "Mã Hàng Hóa :";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMHH);
            this.grpTK.Controls.Add(this.tbxTKMHH);
            this.grpTK.Location = new System.Drawing.Point(66, 77);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 88);
            this.grpTK.TabIndex = 47;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMHH
            // 
            this.lblTKMHH.AutoSize = true;
            this.lblTKMHH.Location = new System.Drawing.Point(6, 31);
            this.lblTKMHH.Name = "lblTKMHH";
            this.lblTKMHH.Size = new System.Drawing.Size(126, 22);
            this.lblTKMHH.TabIndex = 9;
            this.lblTKMHH.Text = "Mã Hàng Hóa:";
            // 
            // tbxTKMHH
            // 
            this.tbxTKMHH.Location = new System.Drawing.Point(139, 28);
            this.tbxTKMHH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMHH.Name = "tbxTKMHH";
            this.tbxTKMHH.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMHH.TabIndex = 1;
            this.tbxTKMHH.TextChanged += new System.EventHandler(this.tbxTKMHH_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(461, 478);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHANGDataGridViewTextBoxColumn,
            this.mANCCDataGridViewTextBoxColumn,
            this.tENHANGDataGridViewTextBoxColumn,
            this.mAUDataGridViewTextBoxColumn,
            this.tRONGLUONGDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.hANGHOABindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(66, 171);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(519, 301);
            this.DataQLDA.TabIndex = 43;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(410, 20);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(146, 34);
            this.lbltitle.TabIndex = 42;
            this.lbltitle.Text = "Hàng Hóa";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(265, 477);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(68, 477);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDADataSetBindingSource
            // 
            this.qLDADataSetBindingSource.DataSource = this.qLDADataSet;
            this.qLDADataSetBindingSource.Position = 0;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.qLDADataSetBindingSource;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // mAHANGDataGridViewTextBoxColumn
            // 
            this.mAHANGDataGridViewTextBoxColumn.DataPropertyName = "MAHANG";
            this.mAHANGDataGridViewTextBoxColumn.HeaderText = "Mã Hàng Hóa";
            this.mAHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAHANGDataGridViewTextBoxColumn.Name = "mAHANGDataGridViewTextBoxColumn";
            this.mAHANGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mANCCDataGridViewTextBoxColumn
            // 
            this.mANCCDataGridViewTextBoxColumn.DataPropertyName = "MANCC";
            this.mANCCDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Cung Cấp";
            this.mANCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANCCDataGridViewTextBoxColumn.Name = "mANCCDataGridViewTextBoxColumn";
            this.mANCCDataGridViewTextBoxColumn.Width = 170;
            // 
            // tENHANGDataGridViewTextBoxColumn
            // 
            this.tENHANGDataGridViewTextBoxColumn.DataPropertyName = "TENHANG";
            this.tENHANGDataGridViewTextBoxColumn.HeaderText = "Tên Hàng Hóa";
            this.tENHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENHANGDataGridViewTextBoxColumn.Name = "tENHANGDataGridViewTextBoxColumn";
            this.tENHANGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAUDataGridViewTextBoxColumn
            // 
            this.mAUDataGridViewTextBoxColumn.DataPropertyName = "MAU";
            this.mAUDataGridViewTextBoxColumn.HeaderText = "Màu";
            this.mAUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAUDataGridViewTextBoxColumn.Name = "mAUDataGridViewTextBoxColumn";
            this.mAUDataGridViewTextBoxColumn.Width = 125;
            // 
            // tRONGLUONGDataGridViewTextBoxColumn
            // 
            this.tRONGLUONGDataGridViewTextBoxColumn.DataPropertyName = "TRONGLUONG";
            this.tRONGLUONGDataGridViewTextBoxColumn.HeaderText = "Trọng Lượng";
            this.tRONGLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRONGLUONGDataGridViewTextBoxColumn.Name = "tRONGLUONGDataGridViewTextBoxColumn";
            this.tRONGLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblMNCC
            // 
            this.lblMNCC.AutoSize = true;
            this.lblMNCC.Location = new System.Drawing.Point(61, 61);
            this.lblMNCC.Name = "lblMNCC";
            this.lblMNCC.Size = new System.Drawing.Size(92, 22);
            this.lblMNCC.TabIndex = 14;
            this.lblMNCC.Text = "Mã NCC :";
            // 
            // cbxMNCC
            // 
            this.cbxMNCC.DataSource = this.nHACCAPBindingSource;
            this.cbxMNCC.DisplayMember = "MANCC";
            this.cbxMNCC.FormattingEnabled = true;
            this.cbxMNCC.Location = new System.Drawing.Point(156, 58);
            this.cbxMNCC.Name = "cbxMNCC";
            this.cbxMNCC.Size = new System.Drawing.Size(265, 30);
            this.cbxMNCC.TabIndex = 15;
            this.cbxMNCC.ValueMember = "MANCC";
            // 
            // nHACCAPBindingSource
            // 
            this.nHACCAPBindingSource.DataMember = "NHACCAP";
            this.nHACCAPBindingSource.DataSource = this.qLDADataSetBindingSource;
            // 
            // nHACCAPTableAdapter
            // 
            this.nHACCAPTableAdapter.ClearBeforeFill = true;
            // 
            // tbxMau
            // 
            this.tbxMau.Location = new System.Drawing.Point(156, 130);
            this.tbxMau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxMau.Name = "tbxMau";
            this.tbxMau.Size = new System.Drawing.Size(265, 30);
            this.tbxMau.TabIndex = 17;
            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.Location = new System.Drawing.Point(97, 133);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(56, 22);
            this.lblMau.TabIndex = 16;
            this.lblMau.Text = "Màu :";
            // 
            // tbxTrongLuong
            // 
            this.tbxTrongLuong.Location = new System.Drawing.Point(156, 166);
            this.tbxTrongLuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTrongLuong.Name = "tbxTrongLuong";
            this.tbxTrongLuong.Size = new System.Drawing.Size(265, 30);
            this.tbxTrongLuong.TabIndex = 19;
            // 
            // lblTrongLuong
            // 
            this.lblTrongLuong.AutoSize = true;
            this.lblTrongLuong.Location = new System.Drawing.Point(30, 169);
            this.lblTrongLuong.Name = "lblTrongLuong";
            this.lblTrongLuong.Size = new System.Drawing.Size(123, 22);
            this.lblTrongLuong.TabIndex = 18;
            this.lblTrongLuong.Text = "Trọng Lượng :";
            // 
            // FrmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 526);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.FrmHangHoa_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox tbxTHH;
        private System.Windows.Forms.Label lblTHH;
        private System.Windows.Forms.TextBox tbxMHH;
        private System.Windows.Forms.Label lblMHH;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMHH;
        private System.Windows.Forms.TextBox tbxTKMHH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource qLDADataSetBindingSource;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private QLDADataSetTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRONGLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxMNCC;
        private System.Windows.Forms.Label lblMNCC;
        private System.Windows.Forms.BindingSource nHACCAPBindingSource;
        private QLDADataSetTableAdapters.NHACCAPTableAdapter nHACCAPTableAdapter;
        private System.Windows.Forms.TextBox tbxTrongLuong;
        private System.Windows.Forms.Label lblTrongLuong;
        private System.Windows.Forms.TextBox tbxMau;
        private System.Windows.Forms.Label lblMau;
    }
}