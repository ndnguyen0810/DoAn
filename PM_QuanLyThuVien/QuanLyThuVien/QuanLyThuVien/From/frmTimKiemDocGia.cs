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
    public partial class frmTimKiemDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemDocGia()
        {
            InitializeComponent();
        }

        private void frmTimKiemDocGia_Load(object sender, EventArgs e)
        {
            loadDG();
            LoadSach();
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
            DataTable dt = con.readData(connection.P_LoadDocGia);
            if (dt != null)
            {
                gcDG.DataSource = dt;
            }
        }

        private void showDGmuonSach(string madg)
        {
            string sqlload = string.Format("select pm.MAPM as[Mã phiếu mượn], s.TENSACH as[Mã sách],NGAYMUON as [Ngày mượn],HENTRA as[Hẹn trả], nv.TENNV as [Họ và tên] " +
                         "from CTPM ct, PHIEUMUON pm, NHANVIEN nv, SACH s where pm.MAPM= ct.MAPM     and s.MASACH= ct.MASACH     and nv.MANV= pm.MANV and madg='{0}'", madg);
            DataTable dt = con.readData(sqlload);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }
        private void gvDG_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row_index = gvDG.FocusedRowHandle;
            string dg = gvDG.GetRowCellValue(row_index, gvDG.Columns[0].ToString()).ToString();
            if (dg != null)
            {
                showDGmuonSach(dg);

            }
            else
            {
                LoadSach();
            }
        }
    }
}