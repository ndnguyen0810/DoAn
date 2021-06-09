
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.qLDADataSet = new QLDA.QLDADataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngTyThiCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàĐầuTưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cungỨngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ĐầuTưToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dựÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataQLDA = new System.Windows.Forms.DataGridView();
            this.qLDADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.lblTKMDA = new System.Windows.Forms.Label();
            this.tbxTKMDA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).BeginInit();
            this.grpTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Blue;
            this.lbltitle.Location = new System.Drawing.Point(329, 31);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(423, 34);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Project Management Application";
            // 
            // qLDADataSet
            // 
            this.qLDADataSet.DataSetName = "QLDADataSet";
            this.qLDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 31);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem,
            this.côngTyThiCôngToolStripMenuItem,
            this.nhàĐầuTưToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.cungỨngToolStripMenuItem,
            this.ĐầuTưToolStripMenuItem1,
            this.nhânViênToolStripMenuItem,
            this.dựÁnToolStripMenuItem,
            this.cungCấpToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.fileToolStripMenuItem.Text = "Cập nhật";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // côngTyThiCôngToolStripMenuItem
            // 
            this.côngTyThiCôngToolStripMenuItem.Name = "côngTyThiCôngToolStripMenuItem";
            this.côngTyThiCôngToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.côngTyThiCôngToolStripMenuItem.Text = "Công Ty Thi Công";
            this.côngTyThiCôngToolStripMenuItem.Click += new System.EventHandler(this.côngTyThiCôngToolStripMenuItem_Click);
            // 
            // nhàĐầuTưToolStripMenuItem
            // 
            this.nhàĐầuTưToolStripMenuItem.Name = "nhàĐầuTưToolStripMenuItem";
            this.nhàĐầuTưToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.nhàĐầuTưToolStripMenuItem.Text = "Nhà Đầu Tư";
            this.nhàĐầuTưToolStripMenuItem.Click += new System.EventHandler(this.nhàĐầuTưToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // cungỨngToolStripMenuItem
            // 
            this.cungỨngToolStripMenuItem.Name = "cungỨngToolStripMenuItem";
            this.cungỨngToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.cungỨngToolStripMenuItem.Text = "Cung Ứng";
            this.cungỨngToolStripMenuItem.Click += new System.EventHandler(this.cungỨngToolStripMenuItem_Click);
            // 
            // ĐầuTưToolStripMenuItem1
            // 
            this.ĐầuTưToolStripMenuItem1.Name = "ĐầuTưToolStripMenuItem1";
            this.ĐầuTưToolStripMenuItem1.Size = new System.Drawing.Size(230, 28);
            this.ĐầuTưToolStripMenuItem1.Text = "Đầu Tư";
            this.ĐầuTưToolStripMenuItem1.Click += new System.EventHandler(this.ĐầuTưToolStripMenuItem1_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // dựÁnToolStripMenuItem
            // 
            this.dựÁnToolStripMenuItem.Name = "dựÁnToolStripMenuItem";
            this.dựÁnToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.dựÁnToolStripMenuItem.Text = "Dự Án";
            this.dựÁnToolStripMenuItem.Click += new System.EventHandler(this.dựÁnToolStripMenuItem_Click);
            // 
            // cungCấpToolStripMenuItem
            // 
            this.cungCấpToolStripMenuItem.Name = "cungCấpToolStripMenuItem";
            this.cungCấpToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.cungCấpToolStripMenuItem.Text = "Cung Cấp";
            this.cungCấpToolStripMenuItem.Click += new System.EventHandler(this.cungCấpToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // DataQLDA
            // 
            this.DataQLDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLDA.Location = new System.Drawing.Point(43, 120);
            this.DataQLDA.Name = "DataQLDA";
            this.DataQLDA.RowHeadersWidth = 51;
            this.DataQLDA.RowTemplate.Height = 24;
            this.DataQLDA.Size = new System.Drawing.Size(597, 382);
            this.DataQLDA.TabIndex = 8;
            // 
            // qLDADataSetBindingSource
            // 
            this.qLDADataSetBindingSource.DataSource = this.qLDADataSet;
            this.qLDADataSetBindingSource.Position = 0;
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.lblTKMDA);
            this.grpTK.Controls.Add(this.tbxTKMDA);
            this.grpTK.Location = new System.Drawing.Point(659, 120);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(418, 382);
            this.grpTK.TabIndex = 19;
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
            this.tbxTKMDA.Size = new System.Drawing.Size(280, 30);
            this.tbxTKMDA.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 618);
            this.Controls.Add(this.grpTK);
            this.Controls.Add(this.DataQLDA);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDADataSetBindingSource)).EndInit();
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngTyThiCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàĐầuTưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cungỨngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ĐầuTưToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private QLDADataSet qLDADataSet;
        private System.Windows.Forms.ToolStripMenuItem dựÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataQLDA;
        private System.Windows.Forms.BindingSource qLDADataSetBindingSource;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.Label lblTKMDA;
        private System.Windows.Forms.TextBox tbxTKMDA;
    }
}

