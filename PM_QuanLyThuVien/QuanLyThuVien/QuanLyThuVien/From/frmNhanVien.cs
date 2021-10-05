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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string queryNV = "select * from NhanVien"; //= "select * from booktype";
        string queryCV = "select *  from ChucVu";


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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadChucVu();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtTenNV.EditValue == null) || (txtTenNV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên nhân viên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            if ((txtNgaySinh.EditValue == null) || (txtNgaySinh.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày sinh\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinh.Focus();
                return;
            }
            if ((txtDiaChi.EditValue == null) || (txtDiaChi.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập địa chỉ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if ((txtSDT.EditValue == null) || (txtSDT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập số điện thoại\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            int soDienThoai = 0;
            try
            {
                soDienThoai = Convert.ToInt32(txtSDT.EditValue.ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số điện thoại phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            if (connection.checkSDT(txtSDT.Text) == false)
            {
                XtraMessageBox.Show("Số điện thoại bạn nhập chưa đúng\r\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((txtEmail.EditValue == null) || (txtEmail.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else
            {
                if (connection.CheckEmail(txtEmail.Text) == false)
                {
                    XtraMessageBox.Show("Bạn đã nhập sai email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    return;
                }
            }

            string tennv = txtTenNV.EditValue.ToString();
            string namsinh = Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("dd/MM/yyy");
            string diachi = txtDiaChi.EditValue.ToString();
            string sdt = txtSDT.EditValue.ToString();
            string email = txtEmail.EditValue.ToString();
            string ngayvaolam = Convert.ToDateTime(txtNgayVaoLam.EditValue.ToString()).ToString("dd/MM/yyyy");

            string queryInsert = string.Format("insert into nhanvien values('{0}',N'{1}','{2}',N'{3}','{4}','{5}', '{6}')", con.creatId("NV", queryNV), tennv, namsinh, diachi, sdt, email,ngayvaolam);

            if (con.exeData(queryInsert))
            {
                loadNhanVien();
                XtraMessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(queryInsert);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.EditValue.ToString();
            string tendg = txtTenNV.EditValue.ToString();
            string namsinh = Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("dd/MM/yyy");
            string diachi = txtDiaChi.EditValue.ToString();
            string sdt = txtSDT.EditValue.ToString();
            string email = txtEmail.EditValue.ToString();
            string ngayvaolam = Convert.ToDateTime(txtNgayVaoLam.EditValue.ToString()).ToString("dd/MM/yyy");

            #region check null          
            if ((txtMaNV.EditValue == null) || (txtMaNV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chọn nhân viên\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtTenNV.Focus();
                return;
            }

            if ((txtTenNV.EditValue == null) || (txtTenNV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên nhân viên không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }

            if ((txtNgaySinh.EditValue == null) || (txtNgaySinh.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Ngày sinh không được phép để trống\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinh.Focus();
                return;
            }

            if ((txtDiaChi.EditValue == null) || (txtDiaChi.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Địa chỉ không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            if ((txtSDT.EditValue == null) || (txtSDT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Số điện thoại không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            int soDienThoai = 0;
            try
            {
                soDienThoai = Convert.ToInt32(txtSDT.EditValue.ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số điện thoại phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            if (connection.checkSDT(txtSDT.Text) == false)
            {
                XtraMessageBox.Show("Số điện thoại bạn nhập chưa đúng\r\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((txtEmail.EditValue == null) || (txtEmail.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else
            {
                if (connection.CheckEmail(txtEmail.Text) == false)
                {
                    XtraMessageBox.Show("Bạn đã nhập sai email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    return;
                }
            }
            if ((txtNgayVaoLam.EditValue == null) || (txtNgayVaoLam.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Ngày sinh không được phép để trống\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayVaoLam.Focus();
                return;
            }

            #endregion

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa nhân viên đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("update nhanvien set tennv=N'{0}', namsinh='{1}',diachi=N'{2}',sdt='{3}', email='{4}', ngayvaolam= '{5}' where manv='{6}'", tendg, namsinh, diachi, sdt, email, ngayvaolam, manv);

                if (con.exeData(queryUpdate))
                {
                    loadNhanVien();
                    XtraMessageBox.Show("Sửa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(queryUpdate);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.EditValue.ToString();

            if ((txtMaNV.EditValue == null) || (txtMaNV.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("delete from nhanvien where manv='{0}'", manv);

                if (con.exeData(queryUpdate))
                {
                    loadNhanVien();
                    XtraMessageBox.Show("Xoá nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(queryUpdate);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.EditValue = null;
            txtTenNV.EditValue = null;
            txtNgaySinh.EditValue = null;
            txtDiaChi.EditValue = null;
            txtNgayVaoLam.EditValue = null;
            txtSDT.EditValue = null;
            txtEmail.EditValue = null;
            txtTenNV.Focus();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaNV.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenNV.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();
            txtNgaySinh.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString())).ToString("dd/MM/yyyy");
            txtDiaChi.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            txtSDT.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
            txtEmail.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5].ToString()).ToString();
            txtNgayVaoLam.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6].ToString())).ToString("dd/MM/yyyy");
        }
    }
}