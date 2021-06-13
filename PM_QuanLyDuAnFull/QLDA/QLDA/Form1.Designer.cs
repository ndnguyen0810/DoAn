
namespace QLDA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.qLDADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMDA = new System.Windows.Forms.Label();
            this.tbxTKMDA = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TolNCC = new System.Windows.Forms.ToolStripButton();
            this.TolDA = new System.Windows.Forms.ToolStripButton();
            this.TolCTTC = new System.Windows.Forms.ToolStripButton();
            this.TolNDT = new System.Windows.Forms.ToolStripButton();
            this.TolHH = new System.Windows.Forms.ToolStripButton();
            this.TolNV = new System.Windows.Forms.ToolStripButton();
            this.TolCU = new System.Windows.Forms.ToolStripButton();
            this.TolDT = new System.Windows.Forms.ToolStripButton();
            this.TolCC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.TolBaoCao = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).BeginInit();
            this.grpTK.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataQLDA
            // 
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Location = new System.Drawing.Point(0, 144);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(968, 382);
            this.DataQLDA.TabIndex = 8;
            // 
            // qLDADataSetBindingSource
            // 
            this.qLDADataSetBindingSource.DataSource = this.qLDADataSet;
            this.qLDADataSetBindingSource.Position = 0;
            // 
            // grpTK
            // 
            this.grpTK.BackColor = System.Drawing.Color.Transparent;
            this.grpTK.Controls.Add(this.lblTKMDA);
            this.grpTK.Controls.Add(this.tbxTKMDA);
            this.grpTK.ForeColor = System.Drawing.Color.Cornsilk;
            this.grpTK.Location = new System.Drawing.Point(184, 74);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(516, 64);
            this.grpTK.TabIndex = 19;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm Kiếm";
            // 
            // lblTKMDA
            // 
            this.lblTKMDA.AutoSize = true;
            this.lblTKMDA.Location = new System.Drawing.Point(21, 32);
            this.lblTKMDA.Name = "lblTKMDA";
            this.lblTKMDA.Size = new System.Drawing.Size(105, 22);
            this.lblTKMDA.TabIndex = 9;
            this.lblTKMDA.Text = "Mã Dự Án :";
            // 
            // tbxTKMDA
            // 
            this.tbxTKMDA.Location = new System.Drawing.Point(133, 29);
            this.tbxTKMDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTKMDA.Name = "tbxTKMDA";
            this.tbxTKMDA.Size = new System.Drawing.Size(359, 30);
            this.tbxTKMDA.TabIndex = 1;
            this.tbxTKMDA.TextChanged += new System.EventHandler(this.tbxTKMDA_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TolNCC,
            this.TolDA,
            this.TolCTTC,
            this.TolNDT,
            this.TolHH,
            this.TolNV,
            this.TolCU,
            this.TolDT,
            this.TolCC,
            this.toolStripButton1,
            this.TolBaoCao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(980, 60);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TolNCC
            // 
            this.TolNCC.ForeColor = System.Drawing.Color.Cornsilk;
            this.TolNCC.Image = ((System.Drawing.Image)(resources.GetObject("TolNCC.Image")));
            this.TolNCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolNCC.Name = "TolNCC";
            this.TolNCC.Size = new System.Drawing.Size(147, 57);
            this.TolNCC.Text = "Nhà Cung Cấp";
            this.TolNCC.Click += new System.EventHandler(this.TolNCC_Click);
            // 
            // TolDA
            // 
            this.TolDA.ForeColor = System.Drawing.Color.Cornsilk;
            this.TolDA.Image = ((System.Drawing.Image)(resources.GetObject("TolDA.Image")));
            this.TolDA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolDA.Name = "TolDA";
            this.TolDA.Size = new System.Drawing.Size(82, 57);
            this.TolDA.Text = "Dự Án";
            this.TolDA.Click += new System.EventHandler(this.TolDA_Click);
            // 
            // TolCTTC
            // 
            this.TolCTTC.ForeColor = System.Drawing.Color.Cornsilk;
            this.TolCTTC.Image = global::QLDA.Properties.Resources.ICTTC;
            this.TolCTTC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolCTTC.Name = "TolCTTC";
            this.TolCTTC.Size = new System.Drawing.Size(137, 57);
            this.TolCTTC.Text = "CTY Thi Công";
            this.TolCTTC.Click += new System.EventHandler(this.TolCTTC_Click);
            // 
            // TolNDT
            // 
            this.TolNDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolNDT.Image = global::QLDA.Properties.Resources.NDT;
            this.TolNDT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolNDT.Name = "TolNDT";
            this.TolNDT.Size = new System.Drawing.Size(126, 57);
            this.TolNDT.Text = "Nhà Đầu Tư";
            this.TolNDT.Click += new System.EventHandler(this.TolNDT_Click);
            // 
            // TolHH
            // 
            this.TolHH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolHH.Image = global::QLDA.Properties.Resources.HH;
            this.TolHH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolHH.Name = "TolHH";
            this.TolHH.Size = new System.Drawing.Size(111, 57);
            this.TolHH.Text = "Hàng Hóa";
            this.TolHH.Click += new System.EventHandler(this.TolHH_Click);
            // 
            // TolNV
            // 
            this.TolNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolNV.Image = ((System.Drawing.Image)(resources.GetObject("TolNV.Image")));
            this.TolNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolNV.Name = "TolNV";
            this.TolNV.Size = new System.Drawing.Size(110, 57);
            this.TolNV.Text = "NhânViên";
            this.TolNV.Click += new System.EventHandler(this.TolNV_Click);
            // 
            // TolCU
            // 
            this.TolCU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolCU.Image = global::QLDA.Properties.Resources.CU;
            this.TolCU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolCU.Name = "TolCU";
            this.TolCU.Size = new System.Drawing.Size(112, 57);
            this.TolCU.Text = "Cung Ứng";
            this.TolCU.Click += new System.EventHandler(this.TolCU_Click);
            // 
            // TolDT
            // 
            this.TolDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolDT.Image = global::QLDA.Properties.Resources.DT;
            this.TolDT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolDT.Name = "TolDT";
            this.TolDT.Size = new System.Drawing.Size(89, 57);
            this.TolDT.Text = "Đầu Tư";
            this.TolDT.Click += new System.EventHandler(this.TolDT_Click);
            // 
            // TolCC
            // 
            this.TolCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolCC.Image = global::QLDA.Properties.Resources.CC;
            this.TolCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolCC.Name = "TolCC";
            this.TolCC.Size = new System.Drawing.Size(110, 27);
            this.TolCC.Text = "Cung Cấp";
            this.TolCC.Click += new System.EventHandler(this.TolCC_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            // 
            // TolBaoCao
            // 
            this.TolBaoCao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TolBaoCao.Image = global::QLDA.Properties.Resources.ex;
            this.TolBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TolBaoCao.Name = "TolBaoCao";
            this.TolBaoCao.Size = new System.Drawing.Size(98, 27);
            this.TolBaoCao.Text = "Báo Cáo";
            this.TolBaoCao.Click += new System.EventHandler(this.TolBaoCao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 534);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.DataQLDA);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).EndInit();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.BindingSource qLDADataSetBindingSource;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMDA;
        private System.Windows.Forms.TextBox tbxTKMDA;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TolNCC;
        private System.Windows.Forms.ToolStripButton TolDA;
        private System.Windows.Forms.ToolStripButton TolCTTC;
        private System.Windows.Forms.ToolStripButton TolNDT;
        private System.Windows.Forms.ToolStripButton TolHH;
        private System.Windows.Forms.ToolStripButton TolCC;
        private System.Windows.Forms.ToolStripButton TolDT;
        private System.Windows.Forms.ToolStripButton TolCU;
        private System.Windows.Forms.ToolStripButton TolNV;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton TolBaoCao;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

