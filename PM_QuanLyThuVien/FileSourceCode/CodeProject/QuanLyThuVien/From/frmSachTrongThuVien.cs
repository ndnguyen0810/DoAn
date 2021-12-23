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
    public partial class frmSachTrongThuVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSachTrongThuVien()
        {
            InitializeComponent();
        }

       
        public static rpSachTrongThuVien rps = new rpSachTrongThuVien();
        connection con = new connection();


        private void frmSachTrongThuVien_Load(object sender, EventArgs e)
        {
            string sql = "select SACH.MASACH, SACH.TENSACH, SACH.TACGIA, NXB.TENNXB, LOAISACH.TENLOAI, SACH.NAMXB,       SACH.GIATIEN, SACH.SOLUONG  from ((SACH SACH  inner join NXB NXB on (NXB.MANXB = SACH.MANXB))  inner join LOAISACH LOAISACH on (LOAISACH.MALOAI = SACH.MALOAI))";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            string sl = dt.Compute("SUM(SOLUONG)", string.Empty).ToString();
            rps.DataSource = dt;
            rps.LoadKKK(frmLogin.fullname, sl);

            documentViewer1.PrintingSystem = rps.PrintingSystem;
            rps.CreateDocument();

           
        }

    }
}