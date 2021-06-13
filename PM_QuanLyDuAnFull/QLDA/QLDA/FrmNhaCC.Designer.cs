
namespace QLDA
{
    partial class FrmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCC));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.tbxSDTNCC = new System.Windows.Forms.TextBox();
            this.lblSDTNCC = new System.Windows.Forms.Label();
            this.tbxTP = new System.Windows.Forms.TextBox();
            this.lblTP = new System.Windows.Forms.Label();
            this.tbxVon = new System.Windows.Forms.TextBox();
            this.lblVon = new System.Windows.Forms.Label();
            this.tbxTNCC = new System.Windows.Forms.TextBox();
            this.lblTNCC = new System.Windows.Forms.Label();
            this.tbxNCC = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMNCC = new System.Windows.Forms.Label();
            this.tbxTKMNCC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.mANCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHPHODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHACCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.nHACCAPTableAdapter = new QLDA.QLDADataSetTableAdapters.NHACCAPTableAdapter();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.BackColor = System.Drawing.Color.Transparent;
            this.grbThongTin.Controls.Add(this.tbxSDTNCC);
            this.grbThongTin.Controls.Add(this.lblSDTNCC);
            this.grbThongTin.Controls.Add(this.tbxTP);
            this.grbThongTin.Controls.Add(this.lblTP);
            this.grbThongTin.Controls.Add(this.tbxVon);
            this.grbThongTin.Controls.Add(this.lblVon);
            this.grbThongTin.Controls.Add(this.tbxTNCC);
            this.grbThongTin.Controls.Add(this.lblTNCC);
            this.grbThongTin.Controls.Add(this.tbxNCC);
            this.grbThongTin.Controls.Add(this.lblNCC);
            this.grbThongTin.Font = new System.Drawing.Font("UTM Colossalis", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.ForeColor = System.Drawing.Color.Coral;
            this.grbThongTin.Location = new System.Drawing.Point(405, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(311, 489);
            this.grbThongTin.TabIndex = 27;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // tbxSDTNCC
            // 
            this.tbxSDTNCC.Location = new System.Drawing.Point(80, 166);
            this.tbxSDTNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSDTNCC.Name = "tbxSDTNCC";
            this.tbxSDTNCC.Size = new System.Drawing.Size(224, 25);
            this.tbxSDTNCC.TabIndex = 21;
            this.tbxSDTNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSDTNCC_KeyPress);
            // 
            // lblSDTNCC
            // 
            this.lblSDTNCC.AutoSize = true;
            this.lblSDTNCC.Location = new System.Drawing.Point(1, 169);
            this.lblSDTNCC.Name = "lblSDTNCC";
            this.lblSDTNCC.Size = new System.Drawing.Size(77, 18);
            this.lblSDTNCC.TabIndex = 20;
            this.lblSDTNCC.Text = "SĐT NCC :";
            // 
            // tbxTP
            // 
            this.tbxTP.Location = new System.Drawing.Point(80, 130);
            this.tbxTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTP.Name = "tbxTP";
            this.tbxTP.Size = new System.Drawing.Size(224, 25);
            this.tbxTP.TabIndex = 19;
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(1, 133);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(89, 18);
            this.lblTP.TabIndex = 18;
            this.lblTP.Text = "Thành Phố :";
            // 
            // tbxVon
            // 
            this.tbxVon.Location = new System.Drawing.Point(80, 94);
            this.tbxVon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxVon.Name = "tbxVon";
            this.tbxVon.Size = new System.Drawing.Size(224, 25);
            this.tbxVon.TabIndex = 17;
            this.tbxVon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVon_KeyPress);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(5, 97);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(43, 18);
            this.lblVon.TabIndex = 16;
            this.lblVon.Text = "Vốn :";
            // 
            // tbxTNCC
            // 
            this.tbxTNCC.Location = new System.Drawing.Point(80, 59);
            this.tbxTNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTNCC.Name = "tbxTNCC";
            this.tbxTNCC.Size = new System.Drawing.Size(224, 25);
            this.tbxTNCC.TabIndex = 13;
            // 
            // lblTNCC
            // 
            this.lblTNCC.AutoSize = true;
            this.lblTNCC.Location = new System.Drawing.Point(5, 62);
            this.lblTNCC.Name = "lblTNCC";
            this.lblTNCC.Size = new System.Drawing.Size(75, 18);
            this.lblTNCC.TabIndex = 12;
            this.lblTNCC.Text = "Tên NCC :";
            // 
            // tbxNCC
            // 
            this.tbxNCC.Location = new System.Drawing.Point(80, 23);
            this.tbxNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNCC.Name = "tbxNCC";
            this.tbxNCC.Size = new System.Drawing.Size(224, 25);
            this.tbxNCC.TabIndex = 11;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(6, 26);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(66, 18);
            this.lblNCC.TabIndex = 10;
            this.lblNCC.Text = "Mã NCC:";
            // 
            // grpTK
            // 
            this.grpTK.BackColor = System.Drawing.Color.Transparent;
            this.grpTK.Controls.Add(this.lblTKMNCC);
            this.grpTK.Controls.Add(this.tbxTKMNCC);
            this.grpTK.Font = new System.Drawing.Font("UTM Banque", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTK.ForeColor = System.Drawing.Color.Cornsilk;
            this.grpTK.Location = new System.Drawing.Point(12, 12);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(386, 88);
            this.grpTK.TabIndex = 26;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMNCC
            // 
            this.lblTKMNCC.AutoSize = true;
            this.lblTKMNCC.Location = new System.Drawing.Point(6, 31);
            this.lblTKMNCC.Name = "lblTKMNCC";
            this.lblTKMNCC.Size = new System.Drawing.Size(156, 18);
            this.lblTKMNCC.TabIndex = 9;
            this.lblTKMNCC.Text = "Mã Nhà Cung Cấp :";
            // 
            // tbxTKMNCC
            // 
            this.tbxTKMNCC.Location = new System.Drawing.Point(179, 28);
            this.tbxTKMNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMNCC.Name = "tbxTKMNCC";
            this.tbxTKMNCC.Size = new System.Drawing.Size(200, 25);
            this.tbxTKMNCC.TabIndex = 1;
            this.tbxTKMNCC.TextChanged += new System.EventHandler(this.tbxTKMNCC_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(287, 474);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 28);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(13, 473);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 28);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(141, 473);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANCCDataGridViewTextBoxColumn,
            this.tENNCCDataGridViewTextBoxColumn,
            this.vONDataGridViewTextBoxColumn,
            this.tHPHODataGridViewTextBoxColumn,
            this.sDTNCCDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.nHACCAPBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(12, 106);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(386, 361);
            this.DataQLDA.TabIndex = 22;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // mANCCDataGridViewTextBoxColumn
            // 
            this.mANCCDataGridViewTextBoxColumn.DataPropertyName = "MANCC";
            this.mANCCDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Cung Cấp";
            this.mANCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANCCDataGridViewTextBoxColumn.Name = "mANCCDataGridViewTextBoxColumn";
            this.mANCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENNCCDataGridViewTextBoxColumn
            // 
            this.tENNCCDataGridViewTextBoxColumn.DataPropertyName = "TENNCC";
            this.tENNCCDataGridViewTextBoxColumn.HeaderText = "Tên Nhà Cung Cấp";
            this.tENNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNCCDataGridViewTextBoxColumn.Name = "tENNCCDataGridViewTextBoxColumn";
            this.tENNCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // vONDataGridViewTextBoxColumn
            // 
            this.vONDataGridViewTextBoxColumn.DataPropertyName = "VON";
            this.vONDataGridViewTextBoxColumn.HeaderText = "Vốn";
            this.vONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vONDataGridViewTextBoxColumn.Name = "vONDataGridViewTextBoxColumn";
            this.vONDataGridViewTextBoxColumn.Width = 125;
            // 
            // tHPHODataGridViewTextBoxColumn
            // 
            this.tHPHODataGridViewTextBoxColumn.DataPropertyName = "THPHO";
            this.tHPHODataGridViewTextBoxColumn.HeaderText = "Thành Phố";
            this.tHPHODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHPHODataGridViewTextBoxColumn.Name = "tHPHODataGridViewTextBoxColumn";
            this.tHPHODataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTNCCDataGridViewTextBoxColumn
            // 
            this.sDTNCCDataGridViewTextBoxColumn.DataPropertyName = "SDTNCC";
            this.sDTNCCDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTNCCDataGridViewTextBoxColumn.Name = "sDTNCCDataGridViewTextBoxColumn";
            this.sDTNCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // nHACCAPBindingSource
            // 
            this.nHACCAPBindingSource.DataMember = "NHACCAP";
            this.nHACCAPBindingSource.DataSource = this.qLDADataSet;
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHACCAPTableAdapter
            // 
            this.nHACCAPTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 503);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.DataQLDA);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmNhaCC";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.FrmNhaCC_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox tbxVon;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.TextBox tbxTNCC;
        private System.Windows.Forms.Label lblTNCC;
        private System.Windows.Forms.TextBox tbxNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMNCC;
        private System.Windows.Forms.TextBox tbxTKMNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.TextBox tbxSDTNCC;
        private System.Windows.Forms.Label lblSDTNCC;
        private System.Windows.Forms.TextBox tbxTP;
        private System.Windows.Forms.Label lblTP;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.BindingSource nHACCAPBindingSource;
        private QLDADataSetTableAdapters.NHACCAPTableAdapter nHACCAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHPHODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTNCCDataGridViewTextBoxColumn;
    }
}