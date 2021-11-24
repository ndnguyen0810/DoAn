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


        

    }
}
