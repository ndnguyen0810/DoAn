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
    public partial class frmViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmViPham()
        {
            InitializeComponent();
        }
        public static rpPhieuPhat rppm = new rpPhieuPhat();
        private void frmViPham_Load(object sender, EventArgs e)
        {
            load();           
        }
        DataTable dtSachPhat;
        connection con =  new connection();
        string sqlLoad = string.Format("select s.MASACH [Mã sách], s.TENSACH [Tên sách], p.NGAYMUON [Ngày mượn], c.HENTRA [Hẹn trả] from CTPM c, SACH s, " +
            "PHIEUMUON p where c.MAPM= p.MAPM and c.MASACH= s.MASACH and c.MAPM= '{0}' ",frmTraSach.MAPM );

        private void load()
        {
            dtSachPhat = con.readData(sqlLoad);
            if (dtSachPhat != null)
            {
                gcViPham.DataSource = dtSachPhat;
            }
        }

        DataTable dtViPham = new DataTable();
        private void CreateCTVP()
        {
            dtViPham = new DataTable();
            dtViPham.Columns.Add("MASACH");
            dtViPham.Columns.Add("TENSACH");
            dtViPham.Columns.Add("LYDOPHAT");
            dtViPham.Columns.Add("GHICHU");
            dtViPham.Columns.Add("SoLuong");
            dtViPham.Columns["SoLuong"].DataType = typeof(Int32);
            dtViPham.Columns.Add("Tien");
            dtViPham.Columns["Tien"].DataType = typeof(Int32);
            foreach (DataRow item in dtSachPhat.Rows)
            {
                DataRow row = dtViPham.NewRow();
                row["MASACH"] = item["MASACH"];
                row["TENSACH"] = item["TENSACH"];
                row["LYDOPHAT"] = item["LYDOPHAT"];                
                row["GHICHU"] = item["GHICHU"];
                row["SOLUONG"] = item["SOLUONG"];
                dtViPham.Rows.Add(row);
                row["TIEN"] = item["TIEN"];
            }
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvViPham.DeleteSelectedRows();

            }
        }

        private void btnLapPhieuPhat_Click(object sender, EventArgs e)
        {
            //if (XtraMessageBox.Show("Bạn có muốn xuất phiếu phạt không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    CreateCTVP();
            //    int TongSL = Int32.Parse(dtViPham.Rows.Count.ToString());
            //    rpPhieuMuon rp = new rpPhieuMuon();
            //    rp.DataSource = dtPhieuMuon;
            //    string ngay = DateTime.Now.Day.ToString();
            //    string thang = DateTime.Now.Month.ToString();
            //    string nam = DateTime.Now.Year.ToString();
            //    rp.initData(ngay, thang, nam, DateTime.Now.ToString("dd/MM/yyyy").ToString(), txtMaDG.EditValue.ToString(), txtTenDG.EditValue.ToString(), frmLogin.fullname, TongSL, mapm);
            //    rppm = rp;

            //    frmPhieuMuon frm = new frmPhieuMuon();
            //    frm.Show();
            //}
        }

        private void btnLydo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLyDoVP frm = new frmLyDoVP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //DataRow row = dtSachMuon.NewRow();
                //row["MASACH"] = gvSach.GetRowCellValue(row_index, "MASACH").ToString();
                //row["TENSACH"] = gvSach.GetRowCellValue(row_index, "TENSACH").ToString();
                //row["TACGIA"] = gvSach.GetRowCellValue(row_index, "TACGIA").ToString();
                //row["NGAYMUON"] = DateTime.Now.ToString("dd/MM/yyyy");
                //row["HENTRA"] = Convert.ToDateTime(frmDatePitker.date).ToString("dd/MM/yyyy");
                //row["SoLuong"] = 1;
                //dtSachMuon.Rows.Add(row);
                //loadSachMuon();
            }
        }
    }
}