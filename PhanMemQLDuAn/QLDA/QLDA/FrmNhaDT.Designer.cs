
namespace QLDA
{
    partial class FrmNhaDT
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSOTIEN = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.tbxTNDT = new System.Windows.Forms.TextBox();
            this.lblTNDT = new System.Windows.Forms.Label();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbxNDT = new System.Windows.Forms.TextBox();
            this.lblTKMNDT = new System.Windows.Forms.Label();
            this.tbxTKMNDT = new System.Windows.Forms.TextBox();
            this.lblNDT = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.nHADAUTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHADAUTUTableAdapter = new QLDA.QLDADataSetTableAdapters.NHADAUTUTableAdapter();
            this.mANDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHADAUTUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(74, 535);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "TrĐ";
            // 
            // tbxSOTIEN
            // 
            this.tbxSOTIEN.Location = new System.Drawing.Point(108, 94);
            this.tbxSOTIEN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSOTIEN.Name = "tbxSOTIEN";
            this.tbxSOTIEN.Size = new System.Drawing.Size(265, 30);
            this.tbxSOTIEN.TabIndex = 17;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(22, 97);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(82, 22);
            this.lblSoTien.TabIndex = 16;
            this.lblSoTien.Text = "Số Tiền :";
            // 
            // tbxTNDT
            // 
            this.tbxTNDT.Location = new System.Drawing.Point(108, 59);
            this.tbxTNDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTNDT.Name = "tbxTNDT";
            this.tbxTNDT.Size = new System.Drawing.Size(265, 30);
            this.tbxTNDT.TabIndex = 13;
            // 
            // lblTNDT
            // 
            this.lblTNDT.AutoSize = true;
            this.lblTNDT.Location = new System.Drawing.Point(9, 62);
            this.lblTNDT.Name = "lblTNDT";
            this.lblTNDT.Size = new System.Drawing.Size(96, 22);
            this.lblTNDT.TabIndex = 12;
            this.lblTNDT.Text = "Tên NCC :";
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(271, 535);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbxNDT
            // 
            this.tbxNDT.Location = new System.Drawing.Point(108, 23);
            this.tbxNDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNDT.Name = "tbxNDT";
            this.tbxNDT.Size = new System.Drawing.Size(265, 30);
            this.tbxNDT.TabIndex = 11;
            // 
            // lblTKMNDT
            // 
            this.lblTKMNDT.AutoSize = true;
            this.lblTKMNDT.Location = new System.Drawing.Point(6, 31);
            this.lblTKMNDT.Name = "lblTKMNDT";
            this.lblTKMNDT.Size = new System.Drawing.Size(154, 22);
            this.lblTKMNDT.TabIndex = 9;
            this.lblTKMNDT.Text = "Mã Nhà Đầu Tư  :";
            // 
            // tbxTKMNDT
            // 
            this.tbxTKMNDT.Location = new System.Drawing.Point(179, 28);
            this.tbxTKMNDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMNDT.Name = "tbxTKMNDT";
            this.tbxTKMNDT.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMNDT.TabIndex = 1;
            this.tbxTKMNDT.TextChanged += new System.EventHandler(this.tbxTKMNDT_TextChanged);
            // 
            // lblNDT
            // 
            this.lblNDT.AutoSize = true;
            this.lblNDT.Location = new System.Drawing.Point(18, 26);
            this.lblNDT.Name = "lblNDT";
            this.lblNDT.Size = new System.Drawing.Size(86, 22);
            this.lblNDT.TabIndex = 10;
            this.lblNDT.Text = "Mã NDT:";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.tbxSOTIEN);
            this.grbThongTin.Controls.Add(this.lblSoTien);
            this.grbThongTin.Controls.Add(this.tbxTNDT);
            this.grbThongTin.Controls.Add(this.lblTNDT);
            this.grbThongTin.Controls.Add(this.tbxNDT);
            this.grbThongTin.Controls.Add(this.lblNDT);
            this.grbThongTin.Location = new System.Drawing.Point(597, 135);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 428);
            this.grbThongTin.TabIndex = 34;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMNDT);
            this.grpTK.Controls.Add(this.tbxTKMNDT);
            this.grpTK.Location = new System.Drawing.Point(72, 135);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 88);
            this.grpTK.TabIndex = 33;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(467, 536);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANDTDataGridViewTextBoxColumn,
            this.tENNDTDataGridViewTextBoxColumn,
            this.sOTIENDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.nHADAUTUBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(72, 229);
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
            this.lbltitle.Location = new System.Drawing.Point(428, 31);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(175, 34);
            this.lbltitle.TabIndex = 28;
            this.lbltitle.Text = "Nhà Đầu Tư";
            // 
            // nHADAUTUBindingSource
            // 
            this.nHADAUTUBindingSource.DataMember = "NHADAUTU";
            this.nHADAUTUBindingSource.DataSource = this.qLDADataSet;
            // 
            // nHADAUTUTableAdapter
            // 
            this.nHADAUTUTableAdapter.ClearBeforeFill = true;
            // 
            // mANDTDataGridViewTextBoxColumn
            // 
            this.mANDTDataGridViewTextBoxColumn.DataPropertyName = "MANDT";
            this.mANDTDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Đầu Tư";
            this.mANDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANDTDataGridViewTextBoxColumn.Name = "mANDTDataGridViewTextBoxColumn";
            this.mANDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // tENNDTDataGridViewTextBoxColumn
            // 
            this.tENNDTDataGridViewTextBoxColumn.DataPropertyName = "TENNDT";
            this.tENNDTDataGridViewTextBoxColumn.HeaderText = "Tên Nhà Đầu Tư";
            this.tENNDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNDTDataGridViewTextBoxColumn.Name = "tENNDTDataGridViewTextBoxColumn";
            this.tENNDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // sOTIENDataGridViewTextBoxColumn
            // 
            this.sOTIENDataGridViewTextBoxColumn.DataPropertyName = "SOTIEN";
            this.sOTIENDataGridViewTextBoxColumn.HeaderText = "Số Tiền";
            this.sOTIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOTIENDataGridViewTextBoxColumn.Name = "sOTIENDataGridViewTextBoxColumn";
            this.sOTIENDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmNhaDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 587);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNhaDT";
            this.Text = "Nhà Đầu Tư";
            this.Load += new System.EventHandler(this.FrmNhaDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHADAUTUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSOTIEN;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox tbxTNDT;
        private System.Windows.Forms.Label lblTNDT;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox tbxNDT;
        private System.Windows.Forms.Label lblTKMNDT;
        private System.Windows.Forms.TextBox tbxTKMNDT;
        private System.Windows.Forms.Label lblNDT;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.BindingSource nHADAUTUBindingSource;
        private QLDADataSetTableAdapters.NHADAUTUTableAdapter nHADAUTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTIENDataGridViewTextBoxColumn;
    }
}