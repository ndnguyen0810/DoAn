using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rpDocGiaDangMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDocGiaDangMuon()
        {
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }

    }
}
