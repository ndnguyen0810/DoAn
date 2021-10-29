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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }

        DataTable dtSachMuon;
        DataTable dtPhieuMuon;
        DataTable dtSach;
        public static rpPhieuMuon rppm = new rpPhieuMuon();

        connection con = new connection();
        string querySach = "select MASACH, TENSACH, TACGIA, SoLuong from SACH";
        string queryDocGia = "select * from docgia";
        string queryPM = "select * from PhieuMuon";
        string queryCTMP = "select * from CTPM";
        private void loadSach()
        {
            DataTable dt = con.readData(querySach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }
        private void loadSachMuon()
        {
            gcCTPM.DataSource = dtSachMuon;
        }

        private void CreateCTPM()
        {
            dtPhieuMuon = new DataTable();
            dtPhieuMuon.Columns.Add("MASACH");
            dtPhieuMuon.Columns.Add("TENSACH");
            dtPhieuMuon.Columns.Add("TACGIA");
           // dtPhieuMuon.Columns.Add("NGAYMUON");
            dtPhieuMuon.Columns.Add("HENTRA");
            dtPhieuMuon.Columns.Add("SoLuong");
            dtPhieuMuon.Columns["SoLuong"].DataType = typeof(Int32);
            foreach (DataRow item in dtSachMuon.Rows)
            {
                DataRow row = dtPhieuMuon.NewRow();
                row["MASACH"] = item["MASACH"];
                row["TENSACH"] = item["TENSACH"];
                row["TACGIA"] = item["TACGIA"];
               // row["NGAYMUON"] = item["NGAYMUON"];
                row["HENTRA"] = item["HENTRA"];
                row["SoLuong"] = item["SoLuong"];
                dtPhieuMuon.Rows.Add(row);
            }
        }

        private void LoadCreateCTPM()
        {
            dtSachMuon = new DataTable();
            dtSachMuon.Columns.Add("MASACH");
            dtSachMuon.Columns.Add("TENSACH");
            dtSachMuon.Columns.Add("TACGIA");
            dtSachMuon.Columns.Add("NGAYMUON");
            dtSachMuon.Columns.Add("HENTRA");
            dtSachMuon.Columns.Add("SoLuong"); //.DataType = typeof(Int32);
        }
        private void loadDocGia()
        {
            DataTable dt = con.readData(connection.P_LoadDocGia);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            loadDocGia();
            loadSach();
            loadSachMuon();
            LoadCreateCTPM();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
 
            txtMaDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();

            txtNgaySinh.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString())).ToString("dd/MM/yyyy");
            cbbGioiTinh.Text= gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            txtDiaChi.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
           
            txtSDT.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5].ToString()).ToString();
            txtEmail.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6].ToString()).ToString();
        }
        bool check; // Mặc định là f rồi
        private void btnAddSach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row_index = gvSach.FocusedRowHandle;
            if ((txtMaDG.EditValue == null) || (txtMaDG.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool checkB= false ;
            string sql = string.Format("select madg from PHieumuon where masach='{0}' and madg='{1}'", gvSach.GetRowCellValue(row_index, "MASACH"), txtMaDG.EditValue.ToString());
            int sl = Int32.Parse(gvSach.GetRowCellValue(row_index, "SoLuong").ToString()); //lấy số lượng để cập nhật
            string ms = gvSach.GetRowCellValue(row_index, "MASACH").ToString(); //lấy mã sách
            DataTable dt = new DataTable();
            dt = con.readData(sql);
           // kiem tra doc gia da muon sach A hay chua
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (gvSach.GetRowCellValue(row_index, "MASACH").ToString().Equals(dr["MASACH"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
               
            }

            if (checkB)
            {
                XtraMessageBox.Show("Độc giả đã mượn sách này và chưa trả\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkB = false;
                return;
            }
         
            foreach (DataRow item in dtSachMuon.Rows)
            {
                if (item["MASACH"].ToString().Equals(gvSach.GetRowCellValue(row_index, "MASACH").ToString()))
                {
                    check = true;                   
                    break;
                }                
            }

            if (check)
            {
                XtraMessageBox.Show("Bạn đã thêm sách này rồi\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
                return;
            }
            
            

            frmDatePitker frm = new frmDatePitker();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow row = dtSachMuon.NewRow();
                row["MASACH"] = gvSach.GetRowCellValue(row_index, "MASACH").ToString();
                row["TENSACH"] = gvSach.GetRowCellValue(row_index, "TENSACH").ToString();
                row["TACGIA"] = gvSach.GetRowCellValue(row_index, "TACGIA").ToString();
                row["NGAYMUON"] = DateTime.Now.ToString("dd/MM/yyyy");
                row["HENTRA"] =  Convert.ToDateTime(frmDatePitker.date).ToString("dd/MM/yyyy");
                row["SoLuong"] = 1;
                dtSachMuon.Rows.Add(row);
                loadSachMuon();  
            }
            int soluongs = Int32.Parse(gvSach.GetRowCellValue(row_index, "SoLuong").ToString());

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MASACH"].ToString() == ms)
                {
                    //MessageBox.Show("cccc");
                    dr["SoLuong"] =soluongs-1 ;
                }
                dt.AcceptChanges();
                dr.SetModified();
            }

        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvCTPM.DeleteSelectedRows();
            }


        }


        string sqlICTPM;
        List<String> vp = new List<string>();
       
        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            string trangthai = "Đang mượn";
            if ((txtMaDG.EditValue == null) || (txtMaDG.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtSachMuon.Rows.Count == 0)
            {
                XtraMessageBox.Show("Bạn chưa sách để mượn\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int row_index = gvCTPM.FocusedRowHandle;
            bool check = false;
            string manv = frmLogin.manv;
            string madg = txtMaDG.EditValue.ToString();
            string ngaymuon = DateTime.Now.ToString("MM/dd/yyyy").ToString();
           
            string sqlInsertPM = string.Format("insert into PHIEUMUON values( '{0}', '{1}', '{2}', '{3}', {4}, N'{5}' ) ", con.creatId("PM", queryPM), manv, madg, ngaymuon,0, trangthai);
            string mapm = con.creatId("PM", queryPM);
            int soluong;
            if (con.exeData(sqlInsertPM))
            {                             
                foreach (DataRow item in dtSachMuon.Rows)
                {
                    string hentra = Convert.ToDateTime(item["HENTRA"].ToString()).ToString("MM/dd/yyyy");
                    sqlICTPM = string.Format("insert into CTPM values ('{0}', '{1}','{2}', {3}, N'{4}')", mapm, item["MASACH"], hentra, item["SoLuong"], trangthai);
                   
                    con.Ex_vp(sqlICTPM);
                }
                soluong = Int32.Parse(dtSachMuon.Rows.Count.ToString());
                string upPM = string.Format("update phieumuon set soluong={0} where mapm= '{1}'", soluong, mapm);

                con.exeData(upPM);
                check = true;
            }
            else
            {
                check = false;
            }

            if (check)
            {
                XtraMessageBox.Show("Lập phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (XtraMessageBox.Show("Bạn có muốn xuất phiếu mượn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CreateCTPM();                  
                    int TongSL = Int32.Parse(dtSachMuon.Rows.Count.ToString());
                    rpPhieuMuon rp = new rpPhieuMuon();
                    rp.DataSource = dtPhieuMuon;
                    string ngay = DateTime.Now.Day.ToString();
                    string thang = DateTime.Now.Month.ToString();
                    string nam = DateTime.Now.Year.ToString();
                    rp.initData(ngay,thang,nam,DateTime.Now.ToString("dd/MM/yyyy").ToString(), txtMaDG.EditValue.ToString(), txtTenDG.EditValue.ToString(), frmLogin.fullname, TongSL, mapm);
                    rppm = rp;
                   
                    frmPhieuMuon frm = new frmPhieuMuon();
                    frm.Show();
                }
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Lập phiếu mượn thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.EditValue= null;
            txtMaDG.EditValue = null;
            txtTenDG.EditValue = null;
            txtNgaySinh.EditValue = null;
            txtEmail.EditValue = null;
            txtSDT.EditValue = null;
            dtSachMuon.Rows.Clear();
        }

       
    }
}