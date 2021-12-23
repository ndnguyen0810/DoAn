using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyThuVien.Report;

namespace QuanLyThuVien.From
{
    public partial class frmDocGiaDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGiaDangMuon()
        {
            InitializeComponent();
        }
        connection con = new connection();
        public static rpDocGiaDangMuon rps = new rpDocGiaDangMuon();

        private void frmDocGiaDangMuon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select PHIEUMUON.MADG , DOCGIA.HOTEN, PHIEUMUON.NGAYMUON, sum(PHIEUMUON.SOLUONG) as Sum_SOLUONG  from(PHIEUMUON  inner join DOCGIA  on(DOCGIA.MADG = PHIEUMUON.MADG)) group by DOCGIA.HOTEN, PHIEUMUON.MADG, PHIEUMUON.NGAYMUON";
            dt = con.readData(sql);

            
            string sl = dt.Compute("SUM(SUM_SOLUONG)", string.Empty).ToString();
            rps.DataSource = dt;
            rps.LoadKKK(frmLogin.fullname, sl);
            documentViewer1.PrintingSystem = rps.PrintingSystem;
            rps.CreateDocument();
            
        }

        
    }
}