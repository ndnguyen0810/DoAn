using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rpSachDangMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public rpSachDangMuon()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }
        public void LoadKKK(string fullname, string sl)
        {
            tableCell5.DataBindings.Add("Text", DataSource, "MASACH");
            tableCell6.DataBindings.Add("Text", DataSource, "TENSACH");
            tableCell7.DataBindings.Add("Text", DataSource, "TRANGTHAI");
            tableCell8.DataBindings.Add("Text", DataSource, "SUM_SOLUONG");

            xrLabel3.Text = sl;
            xrNV.Text = fullname;
        }
    }
}
