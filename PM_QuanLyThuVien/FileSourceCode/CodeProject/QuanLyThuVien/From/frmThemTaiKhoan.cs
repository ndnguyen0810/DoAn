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
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }
        connection con = new connection();
        string queryTK = "select * from TAIKHOAN";
        public void loadNhanVien()
        {
            DataTable dt = con.readData(connection.P_LoadNhanVien);
            if (dt != null)
            {
                gcNhanVien.DataSource = dt;
            }
        }

        private void loadChucVu()
        {
            DataTable dt = con.readData(connection.P_LoadChucVu);
            if (dt != null)
            {
                gcChucVu.DataSource = dt;
            }
        }

        private void loadTaiKhoan()
        {
            DataTable dt = con.readData(connection.P_TaiKhoan);
            if (dt != null)
            {
                gcTaiKhoan.DataSource = dt;
            }
        }

        private void LoadNVonText()
        {
            DataTable dt = con.readData("select MANV, TENNV from NhanVien");
            if(dt!= null)
            {
                lookUpEditNV.Properties.DataSource = dt;
                lookUpEditNV.Properties.ValueMember = "MANV";
                lookUpEditNV.Properties.DisplayMember = "TENNV";
            }
        }

        private void loadCVonText()
        {
            DataTable dt = con.readData("select * from ChucVU");
            if (dt != null)
            {
                lookUpEditCV.Properties.DataSource = dt;
                lookUpEditCV.Properties.ValueMember = "MACV";
                lookUpEditCV.Properties.DisplayMember = "TENCV";
            }
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            loadNhanVien();          
            loadTaiKhoan();
            loadChucVu();
            LoadNVonText();
            loadCVonText();
        }


        #region Tài khoản Edit
        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtTaiKhoan.EditValue == null) || (txtTaiKhoan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên tài khoản không được bỏ trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if ((txtMatKhau.EditValue == null) || (txtMatKhau.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Mật khẩu không được bỏ trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            if ((lookUpEditNV.EditValue == null) || (lookUpEditNV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Nhân viên không được bỏ trống\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditNV.Focus();
                return;
            }
            if ((lookUpEditCV.EditValue == null) || (lookUpEditCV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Chức vụ không được bỏ trống\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditCV.Focus();
                return;
            }


            if (connection.checkName(queryTK, txtTaiKhoan, "TENTK") == true)
            {
                XtraMessageBox.Show("Tài khoản có tên \"" + txtTaiKhoan.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
                return;
            }
            if(connection.checkTK(queryTK, lookUpEditNV.EditValue.ToString(), "MANV") == true)
            {
                XtraMessageBox.Show("Nhân viên \"" + lookUpEditNV.Text + "\" đã tồn tại\r\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
                return;
            }


            string tentk = txtTaiKhoan.EditValue.ToString();
            string mk = txtMatKhau.EditValue.ToString();
            string nv = lookUpEditNV.EditValue.ToString();
            string cv = lookUpEditCV.EditValue.ToString();

            if (tentk.Length < 10)
            {
                XtraMessageBox.Show("Tên tài khoản quá ngắn\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tentk.Length > 30)
            {
                XtraMessageBox.Show("Tên tài khoản quá dài\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mk.Length < 8)
            {
                XtraMessageBox.Show("Mật khẩu quá ngắn\r\nVui lòng nhập mật khẩu dài hơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }

            
              
            string queryInsert = string.Format("insert into TAIKHOAN values('{0}', '{1}', '{2}', '{3}', '{4}')", con.creatId("TK", queryTK), tentk, con.CreateMD5(mk), nv, cv);
            if (con.exeData(queryInsert))
            {
                loadTaiKhoan();
                XtraMessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();

            }
            else
            {
                XtraMessageBox.Show("Thêm tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // XtraMessageBox.Show(queryInsert);
            }

        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matk = txtMaTK.EditValue.ToString();
            if (txtMaTK.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn tài khoản để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string queryD = string.Format("delete from taikhoan where matk='{0}'", matk);
                if (matk != "TK00000001")
                {
                    if (con.exeData(queryD))
                    {
                        loadTaiKhoan();
                        XtraMessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLamMoi.PerformClick();
                    }
                    else
                    {
                        XtraMessageBox.Show("Xoá tài khoản thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không thể xoá tài khoản quản trị viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matk = txtMaTK.EditValue.ToString();
            string tentk = txtTaiKhoan.EditValue.ToString();
            string mk = txtMatKhau.EditValue.ToString();
            string nv = lookUpEditNV.EditValue.ToString();
            string cv = lookUpEditCV.EditValue.ToString();

            if ((txtMaTK.EditValue == null) || (txtMaTK.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên tài khoản không được bỏ trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTK.Focus();
                return;
            }
            if ((txtTaiKhoan.EditValue == null) || (txtTaiKhoan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên tài khoản không được bỏ trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if ((txtMatKhau.EditValue == null) || (txtMatKhau.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Mật khẩu không được bỏ trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            if ((lookUpEditNV.EditValue == null) || (lookUpEditNV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Nhân viên không được bỏ trống\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditNV.Focus();
                return;
            }
            if ((lookUpEditCV.EditValue == null) || (lookUpEditCV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Chức vụ không được bỏ trống\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditCV.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa tài khoản đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("update taikhoan set tentk='{0}', matkhau='{1}',manv='{2}',macv='{3}' where matk='{4}'", tentk, con.CreateMD5(mk), nv, cv, matk);

                if (con.exeData(queryUpdate))
                {
                    loadTaiKhoan();
                    XtraMessageBox.Show("Sửa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // XtraMessageBox.Show(queryUpdate);
                }

            }

        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(lookUpEditNV.EditValue.ToString());
            txtMaTK.EditValue = "";
            txtMatKhau.Text = "";
            txtTaiKhoan.EditValue = "";
            lookUpEditCV.EditValue = "";
            lookUpEditNV.EditValue = "";
        }

        #endregion

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            lookUpEditNV.Text = gridView3.GetRowCellValue(e.RowHandle, gridView3.Columns[1].ToString()).ToString();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            lookUpEditCV.Text = gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[1].ToString()).ToString();

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaTK.EditValue= gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTaiKhoan.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();
            txtMatKhau.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString()).ToString();
            lookUpEditNV.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            lookUpEditCV.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
        }

        private void txtMatKhau_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtMatKhau.Properties.UseSystemPasswordChar)
            {
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}