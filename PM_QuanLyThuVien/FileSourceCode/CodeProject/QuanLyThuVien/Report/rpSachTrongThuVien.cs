using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rpSachTrongThuVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rpSachTrongThuVien()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }

        public void LoadKKK(string fullname, string sl)
        {
            xrTableCell1.DataBindings.Add("Text", DataSource, "MASACH");
            xrTableCell2.DataBindings.Add("Text", DataSource, "TENSACH");
            xrTableCell3.DataBindings.Add("Text", DataSource, "TACGIA").FormatString = "{0:dd/MM/yyyy}";
            xrTableCell4.DataBindings.Add("Text", DataSource, "TENNXB");
            xrTableCell5.DataBindings.Add("Text", DataSource, "TENLOAI");
            xrTableCell6.DataBindings.Add("Text", DataSource, "NAMXB");
            xrTableCell7.DataBindings.Add("Text", DataSource, "GIATIEN");
            xrTableCell8.DataBindings.Add("Text", DataSource, "SOLUONG");

            label3.Text = sl;
            xrLabel4.Text = fullname;
        }

    }
}
