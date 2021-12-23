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

namespace QuanLyThuVien.From
{
    public partial class frmLichSu : DevExpress.XtraEditors.XtraForm
    {
        public frmLichSu()
        {
            InitializeComponent();
        }
        connection con = new connection();
        DataTable dt;
        string sql = "select STT, d.MATK , n.TENNV , d.THOIGIAN, c.TENCV from NHANVIEN n, TAIKHOAN t, DANGNHAP d, CHUCVU c where n.MANV= t.MANV and t.MATK= d.MATK and c.MACV= t.MACV";
        private void Loadd()
        {
            dt = con.readData(sql);
            if (dt != null)
            {
                gcLS.DataSource = dt;
            }
        }
        private void frmLichSu_Load(object sender, EventArgs e)
        {
            Loadd();
        }
    }
}