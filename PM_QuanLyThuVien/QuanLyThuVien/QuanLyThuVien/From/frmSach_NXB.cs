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
            DataTable dt = con.readData("select MANXB, TENNXB  from NXB");
            if (dt != null)
            {
                lookUpEditNXB.Properties.DataSource = dt;
                lookUpEditNXB.Properties.DisplayMember = "TENNXB";
                lookUpEditNXB.Properties.ValueMember = "MANXB";
            }
        }

        private void Loadvitri()
        {
            DataTable dt = con.readData("select MAVT, TENVITRI from VITRI");
            if (dt != null)
            {
                lookUpEditVT.Properties.DataSource = dt;
                lookUpEditVT.Properties.DisplayMember = "TENVITRI";
                lookUpEditVT.Properties.ValueMember = "MAVT";
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
            txtMaSach.EditValue= gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenSach.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();   
            txtTacGia.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString()).ToString();
            txtSoLuong.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            lookUpEditNXB.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
            txtNamXB.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5].ToString()).ToString();
            lookUpEditVT.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6].ToString()).ToString();
           

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaNXB.EditValue=gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[0].ToString()).ToString();
            txtTenNXB.EditValue= gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[1].ToString()).ToString();
            txtDiaChi.EditValue= gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[2].ToString()).ToString();
            txtSDT.EditValue=gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[3].ToString()).ToString();
            txtEmail.EditValue= gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[4].ToString()).ToString();
            txtWeb.EditValue = gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[5].ToString()).ToString();
        }
       
        
        #region Sach Edit

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            #region checknull/ lỗi
            if ((lookUpEditNXB.EditValue == null) || (lookUpEditNXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên độc giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lookUpEditNXB.Focus();
                return;
            }

            if ((txtTacGia.EditValue == null) || (txtTacGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn tác giả\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtTacGia.Focus();
                return;
            }

            if ((txtTenSach.EditValue == null) || (txtTenSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sách\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtTenSach.Focus();
                return;
            }


            try
            {               
                if ((Int32.Parse(txtNamXB.EditValue.ToString()) < 1) || (Int32.Parse(txtNamXB.EditValue.ToString()) > DateTime.Now.Year))
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

            try
            {
                if (Int32.Parse(txtSoLuong.EditValue.ToString()) < 0)
                {
                    XtraMessageBox.Show("Số lượng không được nhỏ hơn 0\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtNamXB.Focus();
                    return;
                }
            }
            catch(Exception)
            {
                XtraMessageBox.Show("Số lượng phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXB.Focus();
                return;
            }

            if ((lookUpEditVT.EditValue == null) || (lookUpEditVT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn vị trí\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditNXB.Focus();
                return;
            }
            string nxb = lookUpEditNXB.EditValue.ToString();
            string tensach = txtTenSach.EditValue.ToString();
            string tacgia = txtTacGia.EditValue.ToString();
            int soluong = Int32.Parse(txtSoLuong.EditValue.ToString());
            int namxb = Int32.Parse(txtNamXB.EditValue.ToString());
            string vitri = lookUpEditVT.EditValue.ToString();

            #endregion

            string queryInsert = string.Format("insert into SACH values('{0}',N'{1}',N'{2}',{3},{4},'{5}','{6}')", con.creatId("MS", querySach), tensach, tacgia,soluong,namxb, nxb, vitri);
            if (connection.checkName(querySach, txtTenSach, "tensach") == true)
            {
                XtraMessageBox.Show("Tên sách có tên \"" + txtTenSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiSach.PerformClick();
                return;
            }

            if (con.exeData(queryInsert))
            {
                loadSach();
                XtraMessageBox.Show("Thêm sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiSach.PerformClick();
                XtraMessageBox.Show(queryInsert);
            }
            else
            {
                XtraMessageBox.Show("Thêm sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(queryInsert);
            }
        }
    

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            

            #region check null          
            if ((txtMaSach.EditValue == null) || (txtMaSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chọn chưa chọn sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if ((lookUpEditNXB.SelectedText == null) || (lookUpEditNXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Nhà xuất bản không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditNXB.Focus();
                return;
            }

            if ((txtNamXB.EditValue == null) || (txtNamXB.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Năm xuất bản không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            string masach = txtMaSach.EditValue.ToString();
            string tensach = txtTenSach.EditValue.ToString();
            string tacgia = txtTacGia.EditValue.ToString();
            string nxb = lookUpEditNXB.EditValue.ToString();
            int namxb = Convert.ToInt32(txtNamXB.EditValue.ToString());
            string vitri = lookUpEditVT.EditValue.ToString();
            int soluong = Int32.Parse(txtSoLuong.EditValue.ToString());
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

            try
            {
                if (soluong < 0)
                {
                    XtraMessageBox.Show("Số lượng không được nhỏ hơn 0\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNamXB.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số lượng phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXB.Focus();
                return;
            }

            if ((lookUpEditVT.EditValue == null) )
            {
                XtraMessageBox.Show("Bạn chưa chọn vị trí\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
           
            #endregion

            string queryUpdate = string.Format("update sach set tensach=N'{0}',tacgia=N'{1}', manxb='{2}', namxb={3}, soluong= {4},mavt='{5}' where masach='{6}' ", tensach, tacgia, nxb, namxb,soluong, vitri, masach);
            if (connection.checkName(querySach, txtTenSach, "tensach") == true)
            {
                XtraMessageBox.Show("Tên sách có tên \"" + txtTenSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiSach.PerformClick();
                return;
            }          
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (con.exeData(queryUpdate))
                {
                    loadSach();
                    XtraMessageBox.Show("Sửa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiSach.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }

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
            lookUpEditNXB.EditValue = null;
            txtTenSach.EditValue = null;
            txtTacGia.EditValue = null;
            txtNamXB.EditValue = null;
            lookUpEditVT.EditValue = null;
            txtTenSach.Focus();
            txtSoLuong.EditValue = null;
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