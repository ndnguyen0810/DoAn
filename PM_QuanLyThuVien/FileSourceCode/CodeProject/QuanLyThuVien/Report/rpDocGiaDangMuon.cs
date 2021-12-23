using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace QuanLyThuVien.Report
{
    public partial class rpDocGiaDangMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDocGiaDangMuon()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }

        

        public void LoadKKK(string fullname, string sl)
        {
            xrTableCell1.DataBindings.Add("Text", DataSource, "MADG");
            xrTableCell2.DataBindings.Add("Text", DataSource, "HOTEN");
            xrTableCell3.DataBindings.Add("Text", DataSource, "NGAYMUON").FormatString = "{0:dd/MM/yyyy}";
            xrTableCell4.DataBindings.Add("Text", DataSource, "SUM_SOLUONG");

            txtSum.Text = sl;
            txtNV.Text = fullname;
        }
    }
}
