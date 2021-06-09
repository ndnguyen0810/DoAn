
namespace QLDA
{
    partial class FrmDauTu
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
            this.btnThem = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbxMDA = new System.Windows.Forms.ComboBox();
            this.lblMDA = new System.Windows.Forms.Label();
            this.lblMHH = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.qLDADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTUTableAdapter = new QLDA.QLDADataSetTableAdapters.DAUTUTableAdapter();
            this.mANDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMNDT = new System.Windows.Forms.ComboBox();
            this.lblTKMDA = new System.Windows.Forms.Label();
            this.tbxTKMDA = new System.Windows.Forms.TextBox();
            this.lblTKMNDT = new System.Windows.Forms.Label();
            this.tbxTKMDT = new System.Windows.Forms.TextBox();
            this.nHADAUTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHADAUTUTableAdapter = new QLDA.QLDADataSetTableAdapters.NHADAUTUTableAdapter();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new QLDA.QLDADataSetTableAdapters.DUANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHADAUTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(472, 495);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 67;
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
            this.mADUANDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.dAUTUBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(77, 188);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(519, 301);
            this.DataQLDA.TabIndex = 64;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(276, 494);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(79, 494);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbxMDA
            // 
            this.cbxMDA.DataSource = this.dUANBindingSource;
            this.cbxMDA.DisplayMember = "MADUAN";
            this.cbxMDA.FormattingEnabled = true;
            this.cbxMDA.Location = new System.Drawing.Point(179, 64);
            this.cbxMDA.Name = "cbxMDA";
            this.cbxMDA.Size = new System.Drawing.Size(247, 30);
            this.cbxMDA.TabIndex = 15;
            this.cbxMDA.ValueMember = "MADUAN";
            // 
            // lblMDA
            // 
            this.lblMDA.AutoSize = true;
            this.lblMDA.Location = new System.Drawing.Point(68, 67);
            this.lblMDA.Name = "lblMDA";
            this.lblMDA.Size = new System.Drawing.Size(105, 22);
            this.lblMDA.TabIndex = 14;
            this.lblMDA.Text = "Mã Dự Án :";
            // 
            // lblMHH
            // 
            this.lblMHH.AutoSize = true;
            this.lblMHH.Location = new System.Drawing.Point(24, 32);
            this.lblMHH.Name = "lblMHH";
            this.lblMHH.Size = new System.Drawing.Size(149, 22);
            this.lblMHH.TabIndex = 10;
            this.lblMHH.Text = "Mã Nhà Đầu Tư :";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cbxMNDT);
            this.grbThongTin.Controls.Add(this.cbxMDA);
            this.grbThongTin.Controls.Add(this.lblMDA);
            this.grbThongTin.Controls.Add(this.lblMHH);
            this.grbThongTin.Location = new System.Drawing.Point(602, 74);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 448);
            this.grbThongTin.TabIndex = 69;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(473, 18);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(113, 34);
            this.lbltitle.TabIndex = 63;
            this.lbltitle.Text = "Đầu Tư";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMDA);
            this.grpTK.Controls.Add(this.tbxTKMDA);
            this.grpTK.Controls.Add(this.lblTKMNDT);
            this.grpTK.Controls.Add(this.tbxTKMDT);
            this.grpTK.Location = new System.Drawing.Point(77, 74);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 108);
            this.grpTK.TabIndex = 68;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
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
            // dAUTUBindingSource
            // 
            this.dAUTUBindingSource.DataMember = "DAUTU";
            this.dAUTUBindingSource.DataSource = this.qLDADataSetBindingSource;
            // 
            // dAUTUTableAdapter
            // 
            this.dAUTUTableAdapter.ClearBeforeFill = true;
            // 
            // mANDTDataGridViewTextBoxColumn
            // 
            this.mANDTDataGridViewTextBoxColumn.DataPropertyName = "MANDT";
            this.mANDTDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Đầu Tư";
            this.mANDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANDTDataGridViewTextBoxColumn.Name = "mANDTDataGridViewTextBoxColumn";
            this.mANDTDataGridViewTextBoxColumn.Width = 170;
            // 
            // mADUANDataGridViewTextBoxColumn
            // 
            this.mADUANDataGridViewTextBoxColumn.DataPropertyName = "MADUAN";
            this.mADUANDataGridViewTextBoxColumn.HeaderText = "Mã Dự Án";
            this.mADUANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mADUANDataGridViewTextBoxColumn.Name = "mADUANDataGridViewTextBoxColumn";
            this.mADUANDataGridViewTextBoxColumn.Width = 125;
            // 
            // cbxMNDT
            // 
            this.cbxMNDT.DataSource = this.nHADAUTUBindingSource;
            this.cbxMNDT.DisplayMember = "MANDT";
            this.cbxMNDT.FormattingEnabled = true;
            this.cbxMNDT.Location = new System.Drawing.Point(179, 29);
            this.cbxMNDT.Name = "cbxMNDT";
            this.cbxMNDT.Size = new System.Drawing.Size(247, 30);
            this.cbxMNDT.TabIndex = 16;
            this.cbxMNDT.ValueMember = "MANDT";
            // 
            // lblTKMDA
            // 
            this.lblTKMDA.AutoSize = true;
            this.lblTKMDA.Location = new System.Drawing.Point(94, 61);
            this.lblTKMDA.Name = "lblTKMDA";
            this.lblTKMDA.Size = new System.Drawing.Size(75, 22);
            this.lblTKMDA.TabIndex = 15;
            this.lblTKMDA.Text = "Mã DA:";
            // 
            // tbxTKMDA
            // 
            this.tbxTKMDA.Location = new System.Drawing.Point(176, 58);
            this.tbxTKMDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMDA.Name = "tbxTKMDA";
            this.tbxTKMDA.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMDA.TabIndex = 14;
            this.tbxTKMDA.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // lblTKMNDT
            // 
            this.lblTKMNDT.AutoSize = true;
            this.lblTKMNDT.Location = new System.Drawing.Point(82, 29);
            this.lblTKMNDT.Name = "lblTKMNDT";
            this.lblTKMNDT.Size = new System.Drawing.Size(86, 22);
            this.lblTKMNDT.TabIndex = 13;
            this.lblTKMNDT.Text = "Mã NDT:";
            // 
            // tbxTKMDT
            // 
            this.tbxTKMDT.Location = new System.Drawing.Point(176, 24);
            this.tbxTKMDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMDT.Name = "tbxTKMDT";
            this.tbxTKMDT.Size = new System.Drawing.Size(333, 30);
            this.tbxTKMDT.TabIndex = 12;
            this.tbxTKMDT.TextChanged += new System.EventHandler(this.DataFilter);
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
            // dUANBindingSource
            // 
            this.dUANBindingSource.DataMember = "DUAN";
            this.dUANBindingSource.DataSource = this.qLDADataSetBindingSource;
            // 
            // dUANTableAdapter
            // 
            this.dUANTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDauTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 554);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.grpTK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDauTu";
            this.Text = "Đầu Tư";
            this.Load += new System.EventHandler(this.FrmDauTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHADAUTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbxMDA;
        private System.Windows.Forms.Label lblMDA;
        private System.Windows.Forms.Label lblMHH;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.BindingSource qLDADataSetBindingSource;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.BindingSource dAUTUBindingSource;
        private QLDADataSetTableAdapters.DAUTUTableAdapter dAUTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADUANDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxMNDT;
        private System.Windows.Forms.Label lblTKMDA;
        private System.Windows.Forms.TextBox tbxTKMDA;
        private System.Windows.Forms.Label lblTKMNDT;
        private System.Windows.Forms.TextBox tbxTKMDT;
        private System.Windows.Forms.BindingSource nHADAUTUBindingSource;
        private QLDADataSetTableAdapters.NHADAUTUTableAdapter nHADAUTUTableAdapter;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private QLDADataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
    }
}