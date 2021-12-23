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
    public partial class frmSachDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmSachDangMuon()
        {
            InitializeComponent();
        }
        connection con = new connection();
        public static rpSachDangMuon rps = new rpSachDangMuon();
        private void frmSachDangMuon_Load(object sender, EventArgs e)
        {
            string sql = "select C.MASACH, SACH.TENSACH, C.TRANGTHAI, sum(C.SOLUONG) as Sum_SOLUONG  " +
                "from(CTPM C  inner join SACH SACH on(SACH.MASACH = C.MASACH))group by C.MASACH, SACH.TENSACH, C.TRANGTHAI";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            string sl = dt.Compute("SUM(Sum_SOLUONG)", string.Empty).ToString();
            rps.DataSource = dt;
            rps.LoadKKK(frmLogin.fullname, sl);

            documentViewer1.PrintingSystem = rps.PrintingSystem;
            rps.CreateDocument();
        }
    }
}