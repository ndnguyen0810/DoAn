
namespace QLDA
{
    partial class FrmCungUng
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
            this.cbxMHH = new System.Windows.Forms.ComboBox();
            this.cbxMDA = new System.Windows.Forms.ComboBox();
            this.lblMDA = new System.Windows.Forms.Label();
            this.lblMHH = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKSTT = new System.Windows.Forms.Label();
            this.tbxTKSTT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new QLDA.QLDADataSetTableAdapters.DUANTableAdapter();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new QLDA.QLDADataSetTableAdapters.HANGHOATableAdapter();
            this.cUNGUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUNGUNGTableAdapter = new QLDA.QLDADataSetTableAdapters.CUNGUNGTableAdapter();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSTT = new System.Windows.Forms.Label();
            this.tbxSTT = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUNGUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.tbxSoLuong);
            this.grbThongTin.Controls.Add(this.lblSoLuong);
            this.grbThongTin.Controls.Add(this.tbxSTT);
            this.grbThongTin.Controls.Add(this.lblSTT);
            this.grbThongTin.Controls.Add(this.cbxMHH);
            this.grbThongTin.Controls.Add(this.cbxMDA);
            this.grbThongTin.Controls.Add(this.lblMDA);
            this.grbThongTin.Controls.Add(this.lblMHH);
            this.grbThongTin.Location = new System.Drawing.Point(590, 81);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 400);
            this.grbThongTin.TabIndex = 62;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // cbxMHH
            // 
            this.cbxMHH.DataSource = this.hANGHOABindingSource;
            this.cbxMHH.DisplayMember = "MAHANG";
            this.cbxMHH.FormattingEnabled = true;
            this.cbxMHH.Location = new System.Drawing.Point(159, 52);
            this.cbxMHH.Name = "cbxMHH";
            this.cbxMHH.Size = new System.Drawing.Size(265, 30);
            this.cbxMHH.TabIndex = 16;
            this.cbxMHH.ValueMember = "MAHANG";
            // 
            // cbxMDA
            // 
            this.cbxMDA.DataSource = this.dUANBindingSource;
            this.cbxMDA.DisplayMember = "MADUAN";
            this.cbxMDA.FormattingEnabled = true;
            this.cbxMDA.Location = new System.Drawing.Point(159, 87);
            this.cbxMDA.Name = "cbxMDA";
            this.cbxMDA.Size = new System.Drawing.Size(265, 30);
            this.cbxMDA.TabIndex = 15;
            this.cbxMDA.ValueMember = "MADUAN";
            // 
            // lblMDA
            // 
            this.lblMDA.AutoSize = true;
            this.lblMDA.Location = new System.Drawing.Point(74, 90);
            this.lblMDA.Name = "lblMDA";
            this.lblMDA.Size = new System.Drawing.Size(79, 22);
            this.lblMDA.TabIndex = 14;
            this.lblMDA.Text = "Mã DA :";
            // 
            // lblMHH
            // 
            this.lblMHH.AutoSize = true;
            this.lblMHH.Location = new System.Drawing.Point(22, 55);
            this.lblMHH.Name = "lblMHH";
            this.lblMHH.Size = new System.Drawing.Size(131, 22);
            this.lblMHH.TabIndex = 10;
            this.lblMHH.Text = "Mã Hàng Hóa :";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKSTT);
            this.grpTK.Controls.Add(this.tbxTKSTT);
            this.grpTK.Location = new System.Drawing.Point(65, 81);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 60);
            this.grpTK.TabIndex = 61;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKSTT
            // 
            this.lblTKSTT.AutoSize = true;
            this.lblTKSTT.Location = new System.Drawing.Point(116, 23);
            this.lblTKSTT.Name = "lblTKSTT";
            this.lblTKSTT.Size = new System.Drawing.Size(56, 22);
            this.lblTKSTT.TabIndex = 9;
            this.lblTKSTT.Text = "STT :";
            // 
            // tbxTKSTT
            // 
            this.tbxTKSTT.Location = new System.Drawing.Point(179, 18);
            this.tbxTKSTT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKSTT.Name = "tbxTKSTT";
            this.tbxTKSTT.Size = new System.Drawing.Size(333, 30);
            this.tbxTKSTT.TabIndex = 1;
            this.tbxTKSTT.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(460, 454);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mAHANGDataGridViewTextBoxColumn,
            this.mADUANDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.cUNGUNGBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(65, 147);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(519, 301);
            this.DataQLDA.TabIndex = 57;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(461, 19);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(147, 34);
            this.lbltitle.TabIndex = 56;
            this.lbltitle.Text = "Cung Ứng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(264, 453);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(67, 453);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.qLDADataSet;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // cUNGUNGBindingSource
            // 
            this.cUNGUNGBindingSource.DataMember = "CUNGUNG";
            this.cUNGUNGBindingSource.DataSource = this.qLDADataSet;
            // 
            // cUNGUNGTableAdapter
            // 
            this.cUNGUNGTableAdapter.ClearBeforeFill = true;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAHANGDataGridViewTextBoxColumn
            // 
            this.mAHANGDataGridViewTextBoxColumn.DataPropertyName = "MAHANG";
            this.mAHANGDataGridViewTextBoxColumn.HeaderText = "Mã Hàng Hóa";
            this.mAHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAHANGDataGridViewTextBoxColumn.Name = "mAHANGDataGridViewTextBoxColumn";
            this.mAHANGDataGridViewTextBoxColumn.Width = 170;
            // 
            // mADUANDataGridViewTextBoxColumn
            // 
            this.mADUANDataGridViewTextBoxColumn.DataPropertyName = "MADUAN";
            this.mADUANDataGridViewTextBoxColumn.HeaderText = "Mã Dự Án";
            this.mADUANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mADUANDataGridViewTextBoxColumn.Name = "mADUANDataGridViewTextBoxColumn";
            this.mADUANDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.sOLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(97, 21);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(56, 22);
            this.lblSTT.TabIndex = 17;
            this.lblSTT.Text = "STT :";
            // 
            // tbxSTT
            // 
            this.tbxSTT.Location = new System.Drawing.Point(159, 18);
            this.tbxSTT.Name = "tbxSTT";
            this.tbxSTT.Size = new System.Drawing.Size(265, 30);
            this.tbxSTT.TabIndex = 18;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(159, 123);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(265, 30);
            this.tbxSoLuong.TabIndex = 20;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(55, 126);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(98, 22);
            this.lblSoLuong.TabIndex = 19;
            this.lblSoLuong.Text = "Số Lượng :";
            // 
            // FrmCungUng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 557);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCungUng";
            this.Text = "Cung Ứng";
            this.Load += new System.EventHandler(this.FrmCungUng_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUNGUNGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cbxMHH;
        private System.Windows.Forms.ComboBox cbxMDA;
        private System.Windows.Forms.Label lblMDA;
        private System.Windows.Forms.Label lblMHH;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKSTT;
        private System.Windows.Forms.TextBox tbxTKSTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private QLDADataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private QLDADataSetTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.BindingSource cUNGUNGBindingSource;
        private QLDADataSetTableAdapters.CUNGUNGTableAdapter cUNGUNGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADUANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox tbxSTT;
        private System.Windows.Forms.Label lblSTT;
    }
}