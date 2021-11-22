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


        public void Data(string ngay, string thang, string nam, string tennv, int tong)
        {
            this.ngay.Value = ngay;
            this.thang.Value = thang;
            this.nam.Value = nam;
            this.tennv.Value = tennv;
            this.tong.Value = tong;

            
            txtMaSach.DataBindings.Add("Text", DataSource, "MASACH");
            txtTenSach.DataBindings.Add("Text", DataSource, "TENSACH");
            txtTacGia.DataBindings.Add("Text", DataSource, "TACGIA");
            txtNXB.DataBindings.Add("Text", DataSource, "NAMXB");
            txtGia.DataBindings.Add("Text", DataSource, "GIATIEN");
            txtSoluong.DataBindings.Add("Text", DataSource, "SOLUONG");
            
        }

    }
}
