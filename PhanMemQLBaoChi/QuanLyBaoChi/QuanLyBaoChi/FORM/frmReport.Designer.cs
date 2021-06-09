namespace QuanLyBaoChi.FORM
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyBaoChi_DataSet_Report = new QuanLyBaoChi.QuanLyBaoChi_DataSet_Report();
            this.uPSRPNhaBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uPS_RPNhaBaoTableAdapter = new QuanLyBaoChi.QuanLyBaoChi_DataSet_ReportTableAdapters.UPS_RPNhaBaoTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_RP_TheLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_PR_PhatHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSPRPTheLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_RP_TheLoaiTableAdapter = new QuanLyBaoChi.QuanLyBaoChi_DataSet_ReportTableAdapters.USP_RP_TheLoaiTableAdapter();
            this.uSPPRPhatHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_PR_PhatHanhTableAdapter = new QuanLyBaoChi.QuanLyBaoChi_DataSet_ReportTableAdapters.USP_PR_PhatHanhTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBaoChi_DataSet_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPSRPNhaBaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_RP_TheLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_PR_PhatHanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRPTheLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPPRPhatHanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(797, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống Kê Nhà Báo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(797, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống Kê Thể Loại";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống Kê Phát Hành";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.uPSRPNhaBaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBaoChi.Report.RP_NhaBao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyBaoChi_DataSet_Report
            // 
            this.quanLyBaoChi_DataSet_Report.DataSetName = "QuanLyBaoChi_DataSet_Report";
            this.quanLyBaoChi_DataSet_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uPSRPNhaBaoBindingSource
            // 
            this.uPSRPNhaBaoBindingSource.DataMember = "UPS_RPNhaBao";
            this.uPSRPNhaBaoBindingSource.DataSource = this.quanLyBaoChi_DataSet_Report;
            // 
            // uPS_RPNhaBaoTableAdapter
            // 
            this.uPS_RPNhaBaoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.uSPRPTheLoaiBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyBaoChi.Report.RP_TheLoai.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 5);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(789, 414);
            this.reportViewer2.TabIndex = 0;
            // 
            // USP_RP_TheLoaiBindingSource
            // 
            this.USP_RP_TheLoaiBindingSource.DataMember = "USP_RP_TheLoai";
            this.USP_RP_TheLoaiBindingSource.DataSource = this.quanLyBaoChi_DataSet_Report;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.uSPPRPhatHanhBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QuanLyBaoChi.Report.RP_PhatHanh.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(791, 418);
            this.reportViewer3.TabIndex = 0;
            // 
            // USP_PR_PhatHanhBindingSource
            // 
            this.USP_PR_PhatHanhBindingSource.DataMember = "USP_PR_PhatHanh";
            this.USP_PR_PhatHanhBindingSource.DataSource = this.quanLyBaoChi_DataSet_Report;
            // 
            // uSPRPTheLoaiBindingSource
            // 
            this.uSPRPTheLoaiBindingSource.DataMember = "USP_RP_TheLoai";
            this.uSPRPTheLoaiBindingSource.DataSource = this.quanLyBaoChi_DataSet_Report;
            // 
            // uSP_RP_TheLoaiTableAdapter
            // 
            this.uSP_RP_TheLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // uSPPRPhatHanhBindingSource
            // 
            this.uSPPRPhatHanhBindingSource.DataMember = "USP_PR_PhatHanh";
            this.uSPPRPhatHanhBindingSource.DataSource = this.quanLyBaoChi_DataSet_Report;
            // 
            // uSP_PR_PhatHanhTableAdapter
            // 
            this.uSP_PR_PhatHanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 485);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReport";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBaoChi_DataSet_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPSRPNhaBaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_RP_TheLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_PR_PhatHanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRPTheLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPPRPhatHanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
     
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyBaoChi_DataSet_Report quanLyBaoChi_DataSet_Report;
        private System.Windows.Forms.BindingSource uPSRPNhaBaoBindingSource;
        private QuanLyBaoChi_DataSet_ReportTableAdapters.UPS_RPNhaBaoTableAdapter uPS_RPNhaBaoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource USP_RP_TheLoaiBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource USP_PR_PhatHanhBindingSource;
        private System.Windows.Forms.BindingSource uSPRPTheLoaiBindingSource;
        private QuanLyBaoChi_DataSet_ReportTableAdapters.USP_RP_TheLoaiTableAdapter uSP_RP_TheLoaiTableAdapter;
        private System.Windows.Forms.BindingSource uSPPRPhatHanhBindingSource;
        private QuanLyBaoChi_DataSet_ReportTableAdapters.USP_PR_PhatHanhTableAdapter uSP_PR_PhatHanhTableAdapter;
    }
}