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
    public partial class frmPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        DataTable dtSachMuon;
        DataTable dtPhieuMuon;

        connection con = new connection();
        string querySach = "select MASACH, TENSACH, TACGIA, SoLuong from SACH";
        string queryDocGia = "select * from docgia";
        string queryPM = "select * from PhieuMuon";
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


        private void LoadCreateCTPM()
        {
            dtSachMuon = new DataTable();
            dtSachMuon.Columns.Add("MASACH");
            dtSachMuon.Columns.Add("TENSACH");
            dtSachMuon.Columns.Add("TACGIA");
            dtSachMuon.Columns.Add("NGAYMUON");
            dtSachMuon.Columns.Add("HENTRA");
            //  dtSachMuon.Columns.Add("SOLUONG);
            dtSachMuon.Columns.Add("SoLuong"); //.DataType = typeof(Int32);
          //  dtSachMuon.Columns.Add("id_provided");
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
            Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, "Năm sinh").ToString()).ToString("dd/MM/yyyy");

            txtDiaChi.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            txtMaDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();

            txtNgaySinh.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString())).ToString("dd/MM/yyyy");

            txtEmail.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5].ToString()).ToString();
            txtSDT.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
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


            bool checkB = false;
            string sql = string.Format("select madg from PHieumuon where masach='{0}' and madg='{1}'", gvSach.GetRowCellValue(row_index, "MASACH"), txtMaDG.EditValue.ToString());

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

          //  MessageBox.Show("MaSach: "+ gvSach.GetRowCellValue(row_index, "MASACH") + "SoLuong: "+ gvSach.GetRowCellValue(row_index, "SoLuong").ToString());
         

            if (checkB)
            {
                XtraMessageBox.Show("Độc giả đã mượn sách này và chưa trả\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  MessageBox.Show(checkB.ToString());
         
            foreach (DataRow item in dtSachMuon.Rows)
            {
                if (item["MASACH"].ToString().Equals(gvSach.GetRowCellValue(row_index, "MASACH").ToString()))
                {
                    check = true;
                    break;
                }

            }
            //string sqlU = string.Format("update Sach set soluong={0} where masach='{1}'", gvSach.GetRowCellValue(row_index, "MASACH"), Int32.Parse(gvSach.GetRowCellValue(row_index, "SoLuong").ToString()) - 1);
            //if (con.exeData(sqlU))
            //{
            //    loadSach();
            //}

            if (check)
            {
                XtraMessageBox.Show("Bạn đã thêm sách này rồi\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                row["HENTRA"] = Convert.ToDateTime(frmDatePitker.date).ToString("dd/MM/yyyy");
                row["SoLuong"] = 1;
                // row["deposit"] = Convert.ToInt32(gvSach.GetRowCellValue(row_index, "deposit"));
                // row["id_provided"] = gvSach.GetRowCellValue(row_index, "id_provided").ToString();
                dtSachMuon.Rows.Add(row);
                loadSachMuon();
            }

        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvCTPM.DeleteSelectedRows();
            }


        }

        //
        string sqlICTPM;
        List<String> vp = new List<string>();
        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
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

            //insert vào bảng phiếu mượn
            string sqlInsertPM = string.Format("insert into PHIEUMUON values( '{0}', '{1}', '{2}' ) ", con.creatId("PM", queryPM), manv, madg);

           // con.exeData(sqlInsertPM);
            string mapm = con.creatId("PM", queryPM);
           
            if (con.exeData(sqlInsertPM))
            {
            //    MessageBox.Show(sqlInsertPM);
                foreach (DataRow item in dtSachMuon.Rows)
                {
                    string ngaymuon = Convert.ToDateTime(item["NGAYMUON"].ToString()).ToString("dd/MM/yyyy");
                    string hentra = Convert.ToDateTime(item["HENTRA"].ToString()).ToString("dd/MM/yyyy");
                     sqlICTPM = string.Format("insert into CTPM values ('{0}', '{1}','{2}', '{3}',{4})", mapm, item["MASACH"], ngaymuon, hentra, item["SoLuong"]);
                    vp.Add(sqlICTPM);
                }              
                MessageBox.Show(vp.Count.ToString());
                foreach (string item in vp)
                {
                    con.Ex_vp(item);
                }


            }
            vp.Clear();
            check = false;

           

            //if (check)
            //{
            //    XtraMessageBox.Show("Lập phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (XtraMessageBox.Show("Bạn có muốn xuất phiếu mượn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    creatDTPhieuMuon();
            //    int tong = 0;
            //    foreach (DataRow item in dtPhieuMuon.Rows)
            //    {
            //        tong += Convert.ToInt32(item["deposit"]);
            //    }
            //    rptPhieuMuon rp = new rptPhieuMuon();
            //    rp.DataSource = dtPhieuMuon;
            //    rp.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user, txtMaDocGia.EditValue.ToString(), txtHoTen.EditValue.ToString(), tong);
            //    rpt = rp;
            //    frmPhieuMuon frm = new frmPhieuMuon();
            //    frm.Show();
            //}
            //btnLamMoi.PerformClick();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Lập phiếu mượn thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    btnLamMoi.PerformClick();
            //}
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.EditValue= null;
            txtMaDG.EditValue = null;
            txtTenDG.EditValue = null;
            txtNgaySinh.EditValue = null;
            txtEmail.EditValue = null;
            txtSDT.EditValue = null;
            gcCTPM.DataSource = null;
            check = false;
           // gcSach.DataSource = null;
        }
    }
}