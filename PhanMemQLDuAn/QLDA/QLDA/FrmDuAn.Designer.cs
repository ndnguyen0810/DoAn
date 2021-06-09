
namespace QLDA
{
    partial class FrmDuAn
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
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCTTC = new System.Windows.Forms.ComboBox();
            this.cTYTHICONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.lblCTTC = new System.Windows.Forms.Label();
            this.tbxTDA = new System.Windows.Forms.TextBox();
            this.lblTDA = new System.Windows.Forms.Label();
            this.tbxMDA = new System.Windows.Forms.TextBox();
            this.lblMDA = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMDA = new System.Windows.Forms.Label();
            this.tbxTKMDA = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.MaDUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHPHODUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUKIENHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new QLDA.QLDADataSetTableAdapters.DUANTableAdapter();
            this.lbltitle = new System.Windows.Forms.Label();
            this.cTYTHICONGTableAdapter = new QLDA.QLDADataSetTableAdapters.CTYTHICONGTableAdapter();
            this.DateTTGBD = new System.Windows.Forms.DateTimePicker();
            this.DateTDKHT = new System.Windows.Forms.DateTimePicker();
            this.DateTTGHT = new System.Windows.Forms.DateTimePicker();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTYTHICONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.DateTTGHT);
            this.grbThongTin.Controls.Add(this.DateTDKHT);
            this.grbThongTin.Controls.Add(this.DateTTGBD);
            this.grbThongTin.Controls.Add(this.label10);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.tbxTP);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.cbxCTTC);
            this.grbThongTin.Controls.Add(this.lblCTTC);
            this.grbThongTin.Controls.Add(this.tbxTDA);
            this.grbThongTin.Controls.Add(this.lblTDA);
            this.grbThongTin.Controls.Add(this.tbxMDA);
            this.grbThongTin.Controls.Add(this.lblMDA);
            this.grbThongTin.Location = new System.Drawing.Point(548, 94);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(432, 428);
            this.grbThongTin.TabIndex = 19;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 22);
            this.label10.TabIndex = 36;
            this.label10.Text = "Thời gian HT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Thời gian BĐ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dự kiến HT :";
            // 
            // tbxTP
            // 
            this.tbxTP.Location = new System.Drawing.Point(108, 87);
            this.tbxTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTP.Name = "tbxTP";
            this.tbxTP.Size = new System.Drawing.Size(298, 30);
            this.tbxTP.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thành Phố :";
            // 
            // cbxCTTC
            // 
            this.cbxCTTC.DataSource = this.cTYTHICONGBindingSource;
            this.cbxCTTC.DisplayMember = "MACTTC";
            this.cbxCTTC.FormattingEnabled = true;
            this.cbxCTTC.Location = new System.Drawing.Point(309, 23);
            this.cbxCTTC.Name = "cbxCTTC";
            this.cbxCTTC.Size = new System.Drawing.Size(98, 30);
            this.cbxCTTC.TabIndex = 15;
            this.cbxCTTC.ValueMember = "TENCTTC";
            // 
            // cTYTHICONGBindingSource
            // 
            this.cTYTHICONGBindingSource.DataMember = "CTYTHICONG";
            this.cTYTHICONGBindingSource.DataSource = this.qLDADataSetBindingSource;
            // 
            // qLDADataSetBindingSource
            // 
            this.qLDADataSetBindingSource.DataSource = this.qLDADataSet;
            this.qLDADataSetBindingSource.Position = 0;
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCTTC
            // 
            this.lblCTTC.AutoSize = true;
            this.lblCTTC.Location = new System.Drawing.Point(210, 26);
            this.lblCTTC.Name = "lblCTTC";
            this.lblCTTC.Size = new System.Drawing.Size(102, 22);
            this.lblCTTC.TabIndex = 14;
            this.lblCTTC.Text = "Mã CTTC :";
            // 
            // tbxTDA
            // 
            this.tbxTDA.Location = new System.Drawing.Point(108, 55);
            this.tbxTDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTDA.Name = "tbxTDA";
            this.tbxTDA.Size = new System.Drawing.Size(298, 30);
            this.tbxTDA.TabIndex = 13;
            // 
            // lblTDA
            // 
            this.lblTDA.AutoSize = true;
            this.lblTDA.Location = new System.Drawing.Point(2, 59);
            this.lblTDA.Name = "lblTDA";
            this.lblTDA.Size = new System.Drawing.Size(109, 22);
            this.lblTDA.TabIndex = 12;
            this.lblTDA.Text = "Tên Dự Án :";
            // 
            // tbxMDA
            // 
            this.tbxMDA.Location = new System.Drawing.Point(108, 23);
            this.tbxMDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxMDA.Name = "tbxMDA";
            this.tbxMDA.Size = new System.Drawing.Size(96, 30);
            this.tbxMDA.TabIndex = 11;
            // 
            // lblMDA
            // 
            this.lblMDA.AutoSize = true;
            this.lblMDA.Location = new System.Drawing.Point(6, 27);
            this.lblMDA.Name = "lblMDA";
            this.lblMDA.Size = new System.Drawing.Size(105, 22);
            this.lblMDA.TabIndex = 10;
            this.lblMDA.Text = "Mã Dự Án :";
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMDA);
            this.grpTK.Controls.Add(this.tbxTKMDA);
            this.grpTK.Location = new System.Drawing.Point(23, 94);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(519, 88);
            this.grpTK.TabIndex = 18;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMDA
            // 
            this.lblTKMDA.AutoSize = true;
            this.lblTKMDA.Location = new System.Drawing.Point(21, 23);
            this.lblTKMDA.Name = "lblTKMDA";
            this.lblTKMDA.Size = new System.Drawing.Size(105, 22);
            this.lblTKMDA.TabIndex = 9;
            this.lblTKMDA.Text = "Mã Dự Án :";
            // 
            // tbxTKMDA
            // 
            this.tbxTKMDA.Location = new System.Drawing.Point(131, 19);
            this.tbxTKMDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMDA.Name = "tbxTKMDA";
            this.tbxTKMDA.Size = new System.Drawing.Size(382, 30);
            this.tbxTKMDA.TabIndex = 1;
            this.tbxTKMDA.TextChanged += new System.EventHandler(this.tbxTKMDA_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(418, 495);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(25, 494);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(222, 494);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDUAN,
            this.mACTTCDataGridViewTextBoxColumn,
            this.tENDUANDataGridViewTextBoxColumn,
            this.tHANHPHODUANDataGridViewTextBoxColumn,
            this.tGBDDataGridViewTextBoxColumn,
            this.dUKIENHTDataGridViewTextBoxColumn,
            this.tGHTDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.dUANBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(23, 188);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(519, 301);
            this.DataQLDA.TabIndex = 14;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // MaDUAN
            // 
            this.MaDUAN.DataPropertyName = "MADUAN";
            this.MaDUAN.HeaderText = "Mã Dự Án";
            this.MaDUAN.MinimumWidth = 6;
            this.MaDUAN.Name = "MaDUAN";
            this.MaDUAN.Width = 125;
            // 
            // mACTTCDataGridViewTextBoxColumn
            // 
            this.mACTTCDataGridViewTextBoxColumn.DataPropertyName = "MACTTC";
            this.mACTTCDataGridViewTextBoxColumn.HeaderText = "Mã CTTC";
            this.mACTTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mACTTCDataGridViewTextBoxColumn.Name = "mACTTCDataGridViewTextBoxColumn";
            this.mACTTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENDUANDataGridViewTextBoxColumn
            // 
            this.tENDUANDataGridViewTextBoxColumn.DataPropertyName = "TENDUAN";
            this.tENDUANDataGridViewTextBoxColumn.HeaderText = "Tên Dự Án";
            this.tENDUANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENDUANDataGridViewTextBoxColumn.Name = "tENDUANDataGridViewTextBoxColumn";
            this.tENDUANDataGridViewTextBoxColumn.Width = 140;
            // 
            // tHANHPHODUANDataGridViewTextBoxColumn
            // 
            this.tHANHPHODUANDataGridViewTextBoxColumn.DataPropertyName = "THANHPHO_DUAN";
            this.tHANHPHODUANDataGridViewTextBoxColumn.HeaderText = "Thành Phố";
            this.tHANHPHODUANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHANHPHODUANDataGridViewTextBoxColumn.Name = "tHANHPHODUANDataGridViewTextBoxColumn";
            this.tHANHPHODUANDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGBDDataGridViewTextBoxColumn
            // 
            this.tGBDDataGridViewTextBoxColumn.DataPropertyName = "TGBD";
            this.tGBDDataGridViewTextBoxColumn.HeaderText = "Thời Gian BĐ";
            this.tGBDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGBDDataGridViewTextBoxColumn.Name = "tGBDDataGridViewTextBoxColumn";
            this.tGBDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dUKIENHTDataGridViewTextBoxColumn
            // 
            this.dUKIENHTDataGridViewTextBoxColumn.DataPropertyName = "DUKIENHT";
            this.dUKIENHTDataGridViewTextBoxColumn.HeaderText = "Dự Kiến HT";
            this.dUKIENHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dUKIENHTDataGridViewTextBoxColumn.Name = "dUKIENHTDataGridViewTextBoxColumn";
            this.dUKIENHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGHTDataGridViewTextBoxColumn
            // 
            this.tGHTDataGridViewTextBoxColumn.DataPropertyName = "TGHT";
            this.tGHTDataGridViewTextBoxColumn.HeaderText = "Thời gian HT";
            this.tGHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGHTDataGridViewTextBoxColumn.Name = "tGHTDataGridViewTextBoxColumn";
            this.tGHTDataGridViewTextBoxColumn.Width = 125;
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
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(452, 9);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(100, 34);
            this.lbltitle.TabIndex = 20;
            this.lbltitle.Text = "Dự Án";
            // 
            // cTYTHICONGTableAdapter
            // 
            this.cTYTHICONGTableAdapter.ClearBeforeFill = true;
            // 
            // DateTTGBD
            // 
            this.DateTTGBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTTGBD.Location = new System.Drawing.Point(153, 124);
            this.DateTTGBD.Name = "DateTTGBD";
            this.DateTTGBD.Size = new System.Drawing.Size(253, 30);
            this.DateTTGBD.TabIndex = 37;
            // 
            // DateTDKHT
            // 
            this.DateTDKHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTDKHT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTDKHT.Location = new System.Drawing.Point(154, 161);
            this.DateTDKHT.Name = "DateTDKHT";
            this.DateTDKHT.Size = new System.Drawing.Size(253, 30);
            this.DateTDKHT.TabIndex = 38;
            // 
            // DateTTGHT
            // 
            this.DateTTGHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTTGHT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTTGHT.Location = new System.Drawing.Point(153, 197);
            this.DateTTGHT.Name = "DateTTGHT";
            this.DateTTGHT.Size = new System.Drawing.Size(253, 30);
            this.DateTTGHT.TabIndex = 39;
            // 
            // FrmDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 539);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.DataQLDA);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDuAn";
            this.Text = "Dự án";
            this.Load += new System.EventHandler(this.FrmDuAn_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTYTHICONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCTTC;
        private System.Windows.Forms.Label lblCTTC;
        private System.Windows.Forms.TextBox tbxTDA;
        private System.Windows.Forms.Label lblTDA;
        private System.Windows.Forms.TextBox tbxMDA;
        private System.Windows.Forms.Label lblMDA;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMDA;
        private System.Windows.Forms.TextBox tbxTKMDA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.BindingSource qLDADataSetBindingSource;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private QLDADataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.BindingSource cTYTHICONGBindingSource;
        private QLDADataSetTableAdapters.CTYTHICONGTableAdapter cTYTHICONGTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACTTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDUANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHPHODUANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUKIENHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker DateTTGHT;
        private System.Windows.Forms.DateTimePicker DateTDKHT;
        private System.Windows.Forms.DateTimePicker DateTTGBD;
    }
}