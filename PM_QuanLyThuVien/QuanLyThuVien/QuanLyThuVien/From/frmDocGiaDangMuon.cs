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
    public partial class frmDocGiaDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGiaDangMuon()
        {
            InitializeComponent();
        }
        connection con = new connection();
        string sqlSach = "select pm.MAPM as[Mã phiếu mượn], s.TENSACH as[Mã sách],NGAYMUON as [Ngày mượn],HENTRA as[Hẹn trả], nv.TENNV as [Họ và tên] " +
                         "from CTPM ct, PHIEUMUON pm, NHANVIEN nv, SACH s where pm.MAPM= ct.MAPM     and s.MASACH= ct.MASACH     and nv.MANV= pm.MANV";
        string sqlDG = "select madg as [Mã độc giả],HOTEN as [Họ và tên], sdt as [Số điện thoại] from DOCGIA";
        private void LoadSach()
        {
            DataTable dt = con.readData(sqlSach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }

        private void loadDG()
        {
            DataTable dt = con.readData(sqlDG);
            if (dt != null)
            {
                gcDG.DataSource = dt;
            }
        }

        private void frmDocGiaDangMuon_Load(object sender, EventArgs e)
        {
            loadDG();
            LoadSach();
        }
    }
}