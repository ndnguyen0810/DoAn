
namespace QLDA
{
    partial class FrmCTTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCTTC));
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.tbxTCCTC = new System.Windows.Forms.TextBox();
            this.lblTCCTC = new System.Windows.Forms.Label();
            this.tbxMCTTC = new System.Windows.Forms.TextBox();
            this.lblCTTC = new System.Windows.Forms.Label();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMCTTC = new System.Windows.Forms.Label();
            this.tbxTKMCTTC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.mACTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENCTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTYTHICONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cTYTHICONGTableAdapter = new QLDA.QLDADataSetTableAdapters.CTYTHICONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTYTHICONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbThongTin
            // 
            this.grbThongTin.BackColor = System.Drawing.Color.Transparent;
            this.grbThongTin.Controls.Add(this.tbxTCCTC);
            this.grbThongTin.Controls.Add(this.lblTCCTC);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.btnSua);
            this.grbThongTin.Controls.Add(this.tbxMCTTC);
            this.grbThongTin.Controls.Add(this.lblCTTC);
            this.grbThongTin.Font = new System.Drawing.Font("UTM Guanine", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.ForeColor = System.Drawing.Color.FloralWhite;
            this.grbThongTin.Location = new System.Drawing.Point(406, 19);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(301, 230);
            this.grbThongTin.TabIndex = 41;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // tbxTCCTC
            // 
            this.tbxTCCTC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTCCTC.Location = new System.Drawing.Point(7, 56);
            this.tbxTCCTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTCCTC.Name = "tbxTCCTC";
            this.tbxTCCTC.Size = new System.Drawing.Size(200, 22);
            this.tbxTCCTC.TabIndex = 13;
            // 
            // lblTCCTC
            // 
            this.lblTCCTC.AutoSize = true;
            this.lblTCCTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTCCTC.Font = new System.Drawing.Font("UTM Guanine", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCCTC.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTCCTC.Location = new System.Drawing.Point(209, 57);
            this.lblTCCTC.Name = "lblTCCTC";
            this.lblTCCTC.Size = new System.Drawing.Size(86, 21);
            this.lblTCCTC.TabIndex = 12;
            this.lblTCCTC.Text = "Tên CTTC ";
            // 
            // tbxMCTTC
            // 
            this.tbxMCTTC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMCTTC.Location = new System.Drawing.Point(7, 28);
            this.tbxMCTTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxMCTTC.Name = "tbxMCTTC";
            this.tbxMCTTC.Size = new System.Drawing.Size(200, 22);
            this.tbxMCTTC.TabIndex = 11;
            // 
            // lblCTTC
            // 
            this.lblCTTC.AutoSize = true;
            this.lblCTTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCTTC.Font = new System.Drawing.Font("UTM Guanine", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTTC.ForeColor = System.Drawing.Color.LightCyan;
            this.lblCTTC.Location = new System.Drawing.Point(214, 25);
            this.lblCTTC.Name = "lblCTTC";
            this.lblCTTC.Size = new System.Drawing.Size(76, 21);
            this.lblCTTC.TabIndex = 10;
            this.lblCTTC.Text = "Mã CTTC";
            // 
            // grpTK
            // 
            this.grpTK.BackColor = System.Drawing.Color.Transparent;
            this.grpTK.Controls.Add(this.lblTKMCTTC);
            this.grpTK.Controls.Add(this.tbxTKMCTTC);
            this.grpTK.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTK.ForeColor = System.Drawing.Color.White;
            this.grpTK.Location = new System.Drawing.Point(0, 19);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(400, 88);
            this.grpTK.TabIndex = 40;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMCTTC
            // 
            this.lblTKMCTTC.AutoSize = true;
            this.lblTKMCTTC.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKMCTTC.ForeColor = System.Drawing.Color.White;
            this.lblTKMCTTC.Location = new System.Drawing.Point(6, 31);
            this.lblTKMCTTC.Name = "lblTKMCTTC";
            this.lblTKMCTTC.Size = new System.Drawing.Size(141, 19);
            this.lblTKMCTTC.TabIndex = 9;
            this.lblTKMCTTC.Text = "Mã Công Ty TC :";
            // 
            // tbxTKMCTTC
            // 
            this.tbxTKMCTTC.Location = new System.Drawing.Point(179, 28);
            this.tbxTKMCTTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMCTTC.Name = "tbxTKMCTTC";
            this.tbxTKMCTTC.Size = new System.Drawing.Size(214, 27);
            this.tbxTKMCTTC.TabIndex = 1;
            this.tbxTKMCTTC.TextChanged += new System.EventHandler(this.tbxTKMCTTC_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("UTM Ambrose", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnThem.Location = new System.Drawing.Point(7, 92);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.AutoGenerateColumns = false;
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACTTCDataGridViewTextBoxColumn,
            this.tENCTTCDataGridViewTextBoxColumn});
            this.DataQLDA.DataSource = this.cTYTHICONGBindingSource;
            this.DataQLDA.Location = new System.Drawing.Point(0, 113);
            this.DataQLDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(400, 301);
            this.DataQLDA.TabIndex = 36;
            this.DataQLDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQLDA_CellClick);
            // 
            // mACTTCDataGridViewTextBoxColumn
            // 
            this.mACTTCDataGridViewTextBoxColumn.DataPropertyName = "MACTTC";
            this.mACTTCDataGridViewTextBoxColumn.HeaderText = "Mã Công Ty Thi Công";
            this.mACTTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mACTTCDataGridViewTextBoxColumn.Name = "mACTTCDataGridViewTextBoxColumn";
            this.mACTTCDataGridViewTextBoxColumn.Width = 170;
            // 
            // tENCTTCDataGridViewTextBoxColumn
            // 
            this.tENCTTCDataGridViewTextBoxColumn.DataPropertyName = "TENCTTC";
            this.tENCTTCDataGridViewTextBoxColumn.HeaderText = "Tên Công Ty Thi Công";
            this.tENCTTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENCTTCDataGridViewTextBoxColumn.Name = "tENCTTCDataGridViewTextBoxColumn";
            this.tENCTTCDataGridViewTextBoxColumn.Width = 170;
            // 
            // cTYTHICONGBindingSource
            // 
            this.cTYTHICONGBindingSource.DataMember = "CTYTHICONG";
            this.cTYTHICONGBindingSource.DataSource = this.qLDADataSet;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("UTM Ambrose", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSua.Location = new System.Drawing.Point(7, 141);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 28);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("UTM Ambrose", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnXoa.Location = new System.Drawing.Point(7, 188);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 28);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cTYTHICONGTableAdapter
            // 
            this.cTYTHICONGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCTTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 474);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.DataQLDA);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCTTC";
            this.Text = "Công Ty Thi Công";
            this.Load += new System.EventHandler(this.FrmCTTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTYTHICONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox tbxTCCTC;
        private System.Windows.Forms.Label lblTCCTC;
        private System.Windows.Forms.TextBox tbxMCTTC;
        private System.Windows.Forms.Label lblCTTC;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMCTTC;
        private System.Windows.Forms.TextBox tbxTKMCTTC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource cTYTHICONGBindingSource;
        private QLDADataSetTableAdapters.CTYTHICONGTableAdapter cTYTHICONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACTTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENCTTCDataGridViewTextBoxColumn;
    }
}