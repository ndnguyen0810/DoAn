using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rpPhieuMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuMuon()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
        }
        public void initData(string ngay, string thang, string nam, string ngaymuon, string madg, string tendg, string tennv, int tong)
        {
            this.ngay.Value = ngay;
            this.thang.Value = thang;
            this.nam.Value = nam;
            this.ngay.Value = ngaymuon;
            this.madg.Value = madg;
            this.tendg.Value = tendg;
            this.tennv.Value = tennv;

            txtSoluong.Text = String.Format("{0:N0}", tong);
            txtMaSach.DataBindings.Add("Text", DataSource, "MASACH");
            txtTenSach.DataBindings.Add("Text", DataSource, "TENSACH");
            txtTacGia.DataBindings.Add("Text", DataSource, "TACGIA");
            txtNgayHenTra.DataBindings.Add("Text", DataSource, "HENTRA");
            txtSoluong.DataBindings.Add("Text", DataSource, "SOLUONG");
            
        }
    }
}
