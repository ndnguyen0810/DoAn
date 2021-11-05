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
    public partial class frmInfoTPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmInfoTPhieuMuon()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string sqlDG = "select  DISTINCT docgia.MADG as[Mã độc giả] , HOTEN as [Họ và tên], NAMSINH [Năm sinh],GIOITINH [Giới tính] ," +
                       "DIACHI [Địa chỉ], SDT [Số điện thoại], EMAIL as[Email] from docgia, phieumuon where DOCGIA.MADG= PHIEUMUON.MADG";

        string sqlPM = "select MAPM [Mã Phiếu mượn], MANV [Mã nhân viên],MADG [Mã độc giả], NGAYMUON [Ngày mượn], SOLUONG [Số lượng], " +
                       "TRANGTHAI [Trạng thái] from PHIEUMUON";

        string sqlCTPM = "select s.MASACH as [Mã sách], s.TENSACH as [Tên sách],n.TENNXB as[Tên nhà xuất bản],s.NAMXB as[Năm xuất bản], " +
                         "p.NGAYMUON as[Ngày mượn], c.HENTRA as[Hẹn trả], c.SOLUONG as[Số lượng], c.TRANGTHAI as[Trạng thái] from DOCGIA d, " +
                         "PHIEUMUON p,CTPM c, SACH s, NXB n where d.MADG= p.MADG and p.MAPM= c.MAPM and s.MANXB= n.MANXB and s.MASACH= c.MASACH ";
        private void FullLoad()
        {
            loadCTPM();
            loadDocGia();
            loadPhieuMuon();
        }

        public void loadPhieuMuon()
        {
            DataTable dt = con.readData(sqlPM);
            if (dt != null)
            {
                gcPM.DataSource = dt;
            }
        }

        public void loadCTPM()
        {
            DataTable dt = con.readData(sqlCTPM);
            if (dt != null)
            {
                gcCTPM.DataSource = dt;
            }
        }

        public void loadDocGia()
        {
            DataTable dt = con.readData(sqlDG);
            if (dt != null)
            {
                gcDocGiaa.DataSource = dt;
            }
        }

        private void frmInfoTPhieuMuon_Load(object sender, EventArgs e)
        {
            FullLoad();
        }

        private void ShowCTPMonClickPM(string mapm)
        {
            string sqlload = string.Format("select s.MASACH as [Mã sách], s.TENSACH as [Tên sách],n.TENNXB as[Tên nhà xuất bản],s.NAMXB as[Năm xuất bản], " +
                " p.NGAYMUON as[Ngày mượn], c.HENTRA as[Hẹn trả], c.SOLUONG as[Số lượng], c.TRANGTHAI as[Trạng thái] from DOCGIA d, PHIEUMUON p,CTPM c, " +
                "SACH s, NXB n where d.MADG= p.MADG and p.MAPM= c.MAPM and s.MANXB= n.MANXB and s.MASACH= c.MASACH and p.MAPM='{0}'", mapm);
            DataTable dt = con.readData(sqlload);
            if (dt != null)
            {
                gcCTPM.DataSource = dt;
            }
        }

        private void ShowDGonClickPM(string madg)
        {
            string sqlload = string.Format("select DISTINCT MADG as [Mã độc giả],HOTEN as [Họ và tên], NAMSINH as [Năm sinh],GIOITINH as [Giới tính]," +
                "DIACHI as [Địa chỉ],SDT as [Số điện thoại],Email from DOCGIA where MADG='{0}'", madg);
            DataTable dt = con.readData(sqlload);
            if (dt != null)
            {
                gcDocGiaa.DataSource = dt;
            }
        }

        private void gvPM_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row_index = gvPM.FocusedRowHandle;
            string dg = gvPM.GetRowCellValue(row_index, gvPM.Columns[0].ToString()).ToString();
            string dg1 = gvPM.GetRowCellValue(row_index, gvPM.Columns[2].ToString()).ToString();
            if (dg != null)
            {
                ShowCTPMonClickPM(dg);
                ShowDGonClickPM(dg1);
            }           
        }



        private void gvPM_DoubleClick(object sender, EventArgs e)
        {
            FullLoad();
        }

        private void gvDocGia_DoubleClick(object sender, EventArgs e)
        {
            FullLoad();
        }

        private void gcPM_DoubleClick(object sender, EventArgs e)
        {
            FullLoad();
        }
    }
}