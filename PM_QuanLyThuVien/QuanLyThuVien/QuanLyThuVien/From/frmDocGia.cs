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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        connection con =  new connection();
        string query = "select * from docgia";
       
        public  void loadDocGia()
        {
            DataTable dt = con.readData(connection.P_LoadDocGia);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            #region check null          
            if ((txtTenDG.EditValue == null) || (txtTenDG.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên độc giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDG.Focus();
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
                if (connection.CheckEmail(txtEmail.Text)==false)
                {
                    XtraMessageBox.Show("Bạn đã nhập sai email\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    return;
                }
            }

            #endregion
            //string madg = txtMaDG.EditValue.ToString();
            string tendg = txtTenDG.EditValue.ToString();
            string namsinh = Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("dd/MM/yyy");
            string diachi = txtDiaChi.EditValue.ToString();
            string sdt = txtSDT.EditValue.ToString();
            string email = txtEmail.EditValue.ToString();

            string queryInsert = string.Format("insert into docgia values('{0}',N'{1}','{2}',N'{3}','{4}','{5}')", con.creatId("DG", query), tendg, namsinh, diachi, sdt, email);

            if (con.exeData(queryInsert))
            {
                loadDocGia();
                XtraMessageBox.Show("Thêm độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(queryInsert);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madg = txtMaDG.EditValue.ToString();
            string tendg = txtTenDG.EditValue.ToString();
            string namsinh = Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("dd/MM/yyy");
            string diachi = txtDiaChi.EditValue.ToString();
            string sdt = txtSDT.EditValue.ToString();
            string email = txtEmail.EditValue.ToString();

            #region check null          
            if ((txtMaDG.EditValue == null) || (txtMaDG.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chọn độc giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDG.Focus();
                return;
            }

            if ((txtTenDG.EditValue == null) || (txtTenDG.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên độc giả không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDG.Focus();
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
            #endregion

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa độc giả đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("update docgia set hoten=N'{0}', namsinh='{1}',diachi=N'{2}',sdt='{3}', email='{4}' where madg='{5}'", tendg, namsinh, diachi, sdt, email,madg);

                if (con.exeData(queryUpdate))
                {
                    loadDocGia();
                    XtraMessageBox.Show("Sửa độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madg = txtMaDG.EditValue.ToString();
                   
            if ((txtMaDG.EditValue == null) || (txtMaDG.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDG.Focus();
                return;
            }
    
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá độc giả đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("delete from docgia where madg='{0}'",  madg);

                if (con.exeData(queryUpdate))
                {
                    loadDocGia();
                    XtraMessageBox.Show("Xoá độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(queryUpdate);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {          
            txtMaDG.EditValue = null;
            txtDiaChi.EditValue = null;
            txtNgaySinh.EditValue = null;
            txtSDT.EditValue = null;
            txtEmail.EditValue = null;
            txtTenDG.EditValue = null;
            txtTenDG.Focus();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();
            txtDiaChi.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            txtNgaySinh.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString())).ToString("dd/MM/yyyy");
            txtSDT.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
            txtEmail.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5].ToString()).ToString();

            //Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("dd/MM/yyy")
        }


    }
}