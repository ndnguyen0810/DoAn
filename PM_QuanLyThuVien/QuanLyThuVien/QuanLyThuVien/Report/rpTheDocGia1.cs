using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rpTheDocGia1 : DevExpress.XtraReports.UI.XtraReport
    {
        public rpTheDocGia1()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
        }

        public void rpTheDG(string madg, string hoten, string namsinh, string ngaycap, string hethan)
        {
            this.madg.Value = madg;
            this.hoten.Value = hoten;
            this.namsinh.Value = namsinh;
            this.hethan.Value = hethan;
            this.ngaycap.Value = ngaycap;
        }
    }
}
