
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCungCap));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cbxMNCC = new System.Windows.Forms.ComboBox();
            this.nHACCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.cbxMDA = new System.Windows.Forms.ComboBox();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMNCC = new System.Windows.Forms.Label();
            this.lblMHH = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMDA = new System.Windows.Forms.Label();
            this.tbxTKMDA = new System.Windows.Forms.TextBox();
            this.lblTKMHH = new System.Windows.Forms.Label();
            this.tbxTKMNCC = new System.Windows.Forms.TextBox();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.mANCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADUANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new QLDA.QLDADataSetTableAdapters.DUANTableAdapter();
            this.nHACCAPTableAdapter = new QLDA.QLDADataSetTableAdapters.NHACCAPTableAdapter();
            this.cUNGCAPTableAdapter = new QLDA.QLDADataSetTableAdapters.CUNGCAPTableAdapter();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUNGCAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.BackColor = System.Drawing.Color.Transparent;
            this.grbThongTin.Controls.Add(this.cbxMNCC);
            this.grbThongTin.Controls.Add(this.cbxMDA);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.btnSua);
            this.grbThongTin.Controls.Add(this.lblMNCC);
            this.grbThongTin.Controls.Add(this.lblMHH);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.ForeColor = System.Drawing.Color.Cornsilk;
            this.grbThongTin.Location = new System.Drawing.Point(440, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(352, 144);
            this.grbThongTin.TabIndex = 55;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // cbxMNCC
            // 
            this.cbxMNCC.DataSource = this.nHACCAPBindingSource;
            this.cbxMNCC.DisplayMember = "MANCC";
            this.cbxMNCC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMNCC.FormattingEnabled = true;
            this.cbxMNCC.Location = new System.Drawing.Point(87, 25);
            this.cbxMNCC.Name = "cbxMNCC";
            this.cbxMNCC.Size = new System.Drawing.Size(259, 29);
            this.cbxMNCC.TabIndex = 16;
            this.cbxMNCC.ValueMember = "MANCC";
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
            // cbxMDA
            // 
            this.cbxMDA.DataSource = this.dUANBindingSource;
            this.cbxMDA.DisplayMember = "MADUAN";
            this.cbxMDA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMDA.FormattingEnabled = true;
            this.cbxMDA.Location = new System.Drawing.Point(87, 55);
            this.cbxMDA.Name = "cbxMDA";
            this.cbxMDA.Size = new System.Drawing.Size(259, 29);
            this.cbxMDA.TabIndex = 15;
            this.cbxMDA.ValueMember = "MADUAN";
            // 
            // dUANBindingSource
            // 
            this.dUANBindingSource.DataMember = "DUAN";
            this.dUANBindingSource.DataSource = this.qLDADataSet;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Black;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnThem.Location = new System.Drawing.Point(2, 94);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 28);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Black;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnXoa.Location = new System.Drawing.Point(252, 94);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 28);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Black;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSua.Location = new System.Drawing.Point(127, 94);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 28);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMNCC
            // 
            this.lblMNCC.AutoSize = true;
            this.lblMNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMNCC.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMNCC.Location = new System.Drawing.Point(6, 63);
            this.lblMNCC.Name = "lblMNCC";
            this.lblMNCC.Size = new System.Drawing.Size(84, 23);
            this.lblMNCC.TabIndex = 14;
            this.lblMNCC.Text = "Mã DA :";
            // 
            // lblMHH
            // 
            this.lblMHH.AutoSize = true;
            this.lblMHH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHH.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMHH.Location = new System.Drawing.Point(6, 27);
            this.lblMHH.Name = "lblMHH";
            this.lblMHH.Size = new System.Drawing.Size(98, 23);
            this.lblMHH.TabIndex = 10;
            this.lblMHH.Text = "Mã NCC :";
            // 
            // grpTK
            // 
            this.grpTK.BackColor = System.Drawing.Color.Transparent;
            this.grpTK.Controls.Add(this.lblTKMDA);
            this.grpTK.Controls.Add(this.tbxTKMDA);
            this.grpTK.Controls.Add(this.lblTKMHH);
            this.grpTK.Controls.Add(this.tbxTKMNCC);
            this.grpTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTK.ForeColor = System.Drawing.Color.Cornsilk;
            this.grpTK.Location = new System.Drawing.Point(12, 12);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(422, 88);
            this.grpTK.TabIndex = 54;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMDA
            // 
            this.lblTKMDA.AutoSize = true;
            this.lblTKMDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKMDA.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTKMDA.Location = new System.Drawing.Point(6, 52);
            this.lblTKMDA.Name = "lblTKMDA";
            this.lblTKMDA.Size = new System.Drawing.Size(72, 20);
            this.lblTKMDA.TabIndex = 11;
            this.lblTKMDA.Text = "Mã DA:";
            // 
            // tbxTKMDA
            // 
            this.tbxTKMDA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTKMDA.Location = new System.Drawing.Point(84, 49);
            this.tbxTKMDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMDA.Name = "tbxTKMDA";
            this.tbxTKMDA.Size = new System.Drawing.Size(331, 26);
            this.tbxTKMDA.TabIndex = 10;
            this.tbxTKMDA.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // lblTKMHH
            // 
            this.lblTKMHH.AutoSize = true;
            this.lblTKMHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKMHH.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTKMHH.Location = new System.Drawing.Point(6, 22);
            this.lblTKMHH.Name = "lblTKMHH";
            this.lblTKMHH.Size = new System.Drawing.Size(85, 20);
            this.lblTKMHH.TabIndex = 9;
            this.lblTKMHH.Text = "Mã NCC:";
            // 
            // tbxTKMNCC
            // 
            this.tbxTKMNCC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTKMNCC.Location = new System.Drawing.Point(84, 20);
            this.tbxTKMNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMNCC.Name = "tbxTKMNCC";
            this.tbxTKMNCC.Size = new System.Drawing.Size(331, 26);
            this.tbxTKMNCC.TabIndex = 1;
            this.tbxTKMNCC.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANCCDataGridViewTextBoxColumn,
            this.mADUANDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.cUNGCAPBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(12, 106);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(422, 301);
            this.DataQLDA.TabIndex = 50;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
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
            // cUNGCAPBindingSource
            // 
            this.cUNGCAPBindingSource.DataMember = "CUNGCAP";
            this.cUNGCAPBindingSource.DataSource = this.qLDADataSet;
            // 
            // dUANTableAdapter
            // 
            this.dUANTableAdapter.ClearBeforeFill = true;
            // 
            // nHACCAPTableAdapter
            // 
            this.nHACCAPTableAdapter.ClearBeforeFill = true;
            // 
            // cUNGCAPTableAdapter
            // 
            this.cUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.DataQLDA);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCungCap";
            this.Text = "Cung Cấp";
            this.Load += new System.EventHandler(this.FrmCungCap_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUNGCAPBindingSource)).EndInit();
            this.ResumeLayout(false);

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