using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rpPhieuPhat : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuPhat()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
        }

        public void Data(string ngay, string thang, string nam, string ngayphat, string madg, string tendg, string tennv, int tong, string mapm)
        {
            this.ngay.Value = ngay;
            this.thang.Value = thang;
            this.nam.Value = nam;
            this.ngayphat.Value = ngayphat;
            this.madg.Value = madg;
            this.tendg.Value = tendg;
            this.tennv.Value = tennv;
            this.tong.Value = tong;
            this.mapm.Value = mapm;
            txtSoluong.Text = String.Format("{0:N0}", tong);
            txtMaSach.DataBindings.Add("Text", DataSource, "MASACH");
            txtTenSach.DataBindings.Add("Text", DataSource, "TENSACH");
            txtTacGia.DataBindings.Add("Text", DataSource, "TACGIA");
            txtNgayHenTra.DataBindings.Add("Text", DataSource, "HENTRA");
            txtSoluong.DataBindings.Add("Text", DataSource, "SOLUONG");


        }
    }
}
