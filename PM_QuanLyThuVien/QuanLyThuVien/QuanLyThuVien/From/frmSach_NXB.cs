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
    public partial class frmSach_NXB : DevExpress.XtraEditors.XtraForm
    {
        public frmSach_NXB()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string querySach="select * from sach";// = "select * from book";
        string queryVT = "select * from vitri";
        string queryNXB="select MaNXB as[Mã nhà xuất bản],tenNXB as[Tên nhà xuất bản] from NXB"; //= "select * from booktype";


        private void loadNXBOnSach()
        {
            DataTable dt = con.readData(queryNXB);
            if (dt != null)
            {
                txtNXB.Properties.DataSource = dt;
                txtNXB.Properties.DisplayMember = "TenNXB";
                txtNXB.Properties.ValueMember = "MaNXB";
            }
        }

        private void Loadvitri()
        {
            DataTable dt = con.readData(queryVT);
            if (dt != null)
            {
                txtVitri.Properties.DataSource = dt;
                txtVitri.Properties.DisplayMember = "TenVT";
                txtVitri.Properties.ValueMember = "MaVT";
            }
        }

        private void loadSach()
        {
            DataTable dt = con.readData(connection.P_LoadSach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }
        private void loadNXB()
        {
            DataTable dt = con.readData(connection.P_LoadNXB);
            if (dt != null)
            {
                gcNXB.DataSource = dt;
            }
        }

        private void frmSach_NXB_Load(object sender, EventArgs e)
        {
            loadNXB();
            loadSach();
            loadNXBOnSach();
            Loadvitri();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaSach.EditValue= gridView1.GetRowCellValue(e.RowHandle, "Mã sách").ToString();
            txtNXB.EditValue = gridView1.GetRowCellValue(e.RowHandle, "Nhà xuất bản").ToString();
            txtTenSach.EditValue = gridView1.GetRowCellValue(e.RowHandle, "Tên sách").ToString();
            txtTacGia.EditValue = gridView1.GetRowCellValue(e.RowHandle, "Tác giả").ToString();
            txtNamXB.EditValue = gridView1.GetRowCellValue(e.RowHandle, "Năm xuất bản").ToString();

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaNXB.EditValue=gridView2.GetRowCellValue(e.RowHandle, "Mã nhà xuất bản").ToString(); 
            txtTenNXB.EditValue=gridView2.GetRowCellValue(e.RowHandle, "Tên nhà xuất bản").ToString(); 
            txtDiaChi.EditValue= gridView2.GetRowCellValue(e.RowHandle, "Địa chỉ").ToString(); 
            txtSDT.EditValue= gridView2.GetRowCellValue(e.RowHandle, "Số điện thoại").ToString(); 
            txtWeb.EditValue = gridView2.GetRowCellValue(e.RowHandle, "Websize").ToString();
            txtEmail.EditValue = gridView2.GetRowCellValue(e.RowHandle, "Email").ToString();
        }
        #region Sach Edit

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string masach = txtMaSach.EditValue.ToString();
            string nxb= (txtNXB.EditValue.ToString()) ;
            string tensach= txtTenSach.EditValue.ToString();
            string tacgia= txtTacGia.EditValue.ToString() ;
            int namxb= Convert.ToInt32(txtNamXB.EditValue.ToString()) ;
            string vitri =txtVitri.EditValue.ToString() ;
            
            #region checknull
            if ((txtNXB.EditValue == null) || (txtNXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên độc giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNXB.Focus();
                return;
            }

            if ((txtTacGia.EditValue == null) || (txtTacGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn tác giả\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTacGia.Focus();
                return;
            }

            if ((txtDiaChi.EditValue == null) || (txtDiaChi.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập địa chỉ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            namxb = -1;
            
            try
            {               
                if ((namxb < 1) || (namxb > DateTime.Now.Year))
                {
                    XtraMessageBox.Show("Năm xuất bản không được nhỏ hơn 1 hoặc lớn hơn năm hiện tại\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNamXB.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Năm xuất bản phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXB.Focus();
                return;
            }


            #endregion

            string queryInsert = string.Format("insert into sach values('{0}',N'{1}',N'{2}','{3}',{4},'{5}' )", con.creatId("MS", querySach), tensach, tacgia, nxb, namxb, vitri);

            if (con.exeData(queryInsert))
            {
                loadSach();
                XtraMessageBox.Show("Thêm sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiSach.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(queryInsert);
            }
        }
    

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string masach = txtMaSach.EditValue.ToString();           
            string tensach = txtTenSach.EditValue.ToString();         
            string tacgia = txtTacGia.EditValue.ToString();
            string nxb = (txtNXB.EditValue.ToString());
            int namxb = Convert.ToInt32(txtNamXB.EditValue.ToString());
            string vitri = txtVitri.EditValue.ToString();

            #region check null          
            if ((txtMaSach.EditValue == null) || (txtMaSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chọn chưa chọn sách\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }

            if ((txtTenSach.EditValue == null) || (txtTenSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên sách không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return;
            }

            if ((txtTacGia.EditValue == null) || (txtTacGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên tác giả không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTacGia.Focus();
                return;
            }

            if ((txtNXB.EditValue == null) || (txtDiaChi.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Nhà xuất bản không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNXB.Focus();
                return;
            }

            if ((txtNamXB.EditValue == null) || (txtNamXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Năm xuất bản không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            namxb = -1;

            try
            {
                if ((namxb < 1) || (namxb > DateTime.Now.Year))
                {
                    XtraMessageBox.Show("Năm xuất bản không được nhỏ hơn 1 hoặc lớn hơn năm hiện tại\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNamXB.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Năm xuất bản phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXB.Focus();
                return;
            }

            if ((txtVitri.EditValue == null) )
            {
                XtraMessageBox.Show("Bạn chưa nhập vị trí\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
           
            #endregion

            string queryUpdate = string.Format("update sach set tensach=N'{0}',tacgia=N'{1}', nxb='{2}', namxb={3},vitri='{4}' where masach='{5}' ", tensach, tacgia, nxb, namxb, vitri, masach);


        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string masach=txtMaSach.EditValue.ToString();

            if (txtMaSach.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string querySach = string.Format("delete from sach where masach='{0}'",masach);
                if (con.exeData(querySach))
                {
                    loadSach();
                    XtraMessageBox.Show("Xoá sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiSach.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnLamMoiSach_Click(object sender, EventArgs e)
        {
            txtMaSach.EditValue =null;
            txtNXB.EditValue = null;
            txtTenSach.EditValue = null;
            txtTacGia.EditValue = null;
            txtNamXB.EditValue = null;
            txtVitri.EditValue = null;
            txtTenSach.Focus();
        }

        #endregion


        #region Nhà xuất bản Edit

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
           // string manxb = txtMaNXB.EditValue.ToString();
            string tennxb = txtTenNXB.EditValue.ToString();
            string diachi = txtDiaChi.EditValue.ToString();
            string sdt = txtSDT.EditValue.ToString();
            string web = txtWeb.EditValue.ToString();
            string email = txtEmail.EditValue.ToString();

            #region check null          
            if ((txtTenNXB.EditValue == null) || (txtTenNXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên nhà xuất bản\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNXB.Focus();
                return;
            }

            if ((txtWeb.EditValue == null) || (txtWeb.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập trang web\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeb.Focus();
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

            #endregion

            string queryInsert = string.Format("insert into NXB values('{0}',N'{1}',N'{2}',{3},'{4}','{5}')", con.creatId("XB", queryNXB), tennxb, diachi, sdt,web, email);

            if (con.exeData(queryInsert))
            {
                loadNXB();
                XtraMessageBox.Show("Thêm độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiNXB.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(queryInsert);
            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.EditValue.ToString();
            string tennxb = txtTenNXB.EditValue.ToString();
            string diachi = txtDiaChi.EditValue.ToString();
            string sdt = txtSDT.EditValue.ToString();
            string web = txtWeb.EditValue.ToString();
            string email = txtEmail.EditValue.ToString();

            #region check null          
            if ((txtMaNXB.EditValue == null) || (txtMaNXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chọn nhà xuất bản\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNXB.Focus();
                return;
            }

            if ((txtTenNXB.EditValue == null) || (txtTenNXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên nhà xuất bản không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNXB.Focus();
                return;
            }

            if ((txtWeb.EditValue == null) || (txtWeb.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Trang web không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeb.Focus();
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

                string queryUpdate = string.Format("update nxb set tennxb=N'{0}', diachi='{1}',sdt=N'{2}',websize='{3}', email='{4}' where manxb='{5}'", tennxb,  diachi, sdt, email,web, manxb);

                if (con.exeData(queryUpdate))
                {
                    loadNXB();
                    XtraMessageBox.Show("Sửa độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiNXB.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(queryUpdate);
                }

            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.EditValue.ToString();

            if (txtMaNXB.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá nhà xuất bản đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string querySach = string.Format("delete from nxb where manxb='{0}'", manxb);
                if (con.exeData(querySach))
                {
                    loadSach();
                    XtraMessageBox.Show("Xoá nhà xuất bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiSach.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá nhà xuất bản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoiNXB_Click(object sender, EventArgs e)
        {
            txtMaNXB.EditValue = null;
            txtTenNXB.EditValue = null;
            txtDiaChi.EditValue = null;
            txtSDT.EditValue = null;
            txtWeb.EditValue = null;
            txtEmail.EditValue = null;
            txtTenNXB.Focus();
        }

        #endregion
    }
}