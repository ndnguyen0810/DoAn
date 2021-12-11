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
    public partial class frmLoaiSach_ViTri : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiSach_ViTri()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string queryLoaiSach = "select * from Loaisach"; //= "select * from booktype";
        string queryViTri= "select *  from VITRI";

 
        private void loadLoaiSach()
        {
            DataTable dt = con.readData(connection.P_LoadLoaiSach);
            if (dt != null)
            {
                gwLoaiSach.DataSource = dt;
                
            }
        }

        private void loadViTri()
        {
            DataTable dt = con.readData(connection.P_LoadViTri);
            if (dt != null)
            {
                gwVT.DataSource = dt;
            }
        }

        private void loadVTOnLS()
        {
            DataTable dt = con.readData(queryViTri);
            if (dt != null)
            {
                lkupLS.Properties.DataSource = dt;
                lkupLS.Properties.DisplayMember = "TENVITRI";
                lkupLS.Properties.ValueMember = "MAVT";
            }
        }
      

        private void frmLoaiSach_ViTri_Load(object sender, EventArgs e)
        {
            loadLoaiSach();
            loadViTri();
            loadVTOnLS();
            
        }

        #region Loai sach Edit
        private void btnThemLS_Click(object sender, EventArgs e)
        {
            if ((txtTenLoaiSach.EditValue == null) || (txtTenLoaiSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sách\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSach.Focus();
                return;
            }
            if ((lkupLS.EditValue == null) || (lkupLS.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn vị trí\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSach.Focus();
                return;
            }

            string tensach = txtTenLoaiSach.EditValue.ToString();
            string vitri = lkupLS.EditValue.ToString();

            string queryInsert = string.Format("insert into loaisach values('{0}',N'{1}','{2}')", con.creatId("LS", queryLoaiSach), tensach,vitri);
            if (connection.checkName(queryLoaiSach, txtTenLoaiSach, "tenloai") == true)
            {
                XtraMessageBox.Show("Loại sách có tên \"" + txtTenLoaiSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiLS.PerformClick();
                return;
            }

            if (con.exeData(queryInsert))
            {
                loadLoaiSach();
                XtraMessageBox.Show("Thêm loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiLS.PerformClick();              
            }
            else
            {
                XtraMessageBox.Show("Thêm loại sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private void btnSuaLS_Click(object sender, EventArgs e)
        {
            if ((txtMaLoaiSach.EditValue == null) || (txtMaLoaiSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiSach.Focus();
                return;
            }

            if ((txtTenLoaiSach.EditValue == null) || (txtTenLoaiSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sách\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSach.Focus();
                return;
            }
            if ((lkupLS.EditValue == null) || (lkupLS.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn vị trí\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSach.Focus();
                return;
            }
            string masach = txtMaLoaiSach.EditValue.ToString();
            string tensach = txtTenLoaiSach.EditValue.ToString();
           string vitri = lkupLS.EditValue.ToString();
            if (connection.checkName(queryLoaiSach, txtTenLoaiSach, "tenloai") == true)
            {
                XtraMessageBox.Show("Loại sách có tên \"" + txtTenLoaiSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiLS.PerformClick();
                return;
            }
            string queryInsert = string.Format("update sach set tensach = N'{0}', mavt='{2}' where masach ='{1}'", tensach, masach, vitri);
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa loại sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (con.exeData(queryInsert))
                {
                    loadLoaiSach();
                    XtraMessageBox.Show("Sửa loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiLS.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa loại sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(queryInsert);
                }
            }
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoaiSach.EditValue.ToString();

            if ((txtMaLoaiSach.EditValue == null) || (txtMaLoaiSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiSach.Focus();
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá loại sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("delete from LoaiSach where maloai='{0}'", maloai);

                if (con.exeData(queryUpdate))
                {
                    loadLoaiSach();
                    XtraMessageBox.Show("Xoá loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiLS.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá loại sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }

            }
        }

        private void btnLamMoiLS_Click(object sender, EventArgs e)
        {
            txtMaLoaiSach.EditValue = null;
            txtTenLoaiSach.EditValue = null;
            lkupLS.EditValue = "";
            txtTenLoaiSach.Focus();
        }

        #endregion

        #region Vị trí Edit

        private void btnThemVT_Click(object sender, EventArgs e)
        {        
            if ((txtTenVT.EditValue == null) || (txtTenVT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên vị trí\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVT.Focus();
                return;
            }
             string tenvt = txtTenVT.EditValue.ToString();
            string queryInsert = string.Format("insert into vitri values('{0}',N'{1}')", con.creatId("VT", queryViTri), tenvt);
            if(connection.checkName(queryViTri, txtTenVT, "TenViTri")== true)
            {
                XtraMessageBox.Show("Vị trí có tên \"" + txtTenVT.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiVT.PerformClick();
                return;
            }
               
            if (con.exeData(queryInsert))
            {
                loadViTri();
                XtraMessageBox.Show("Thêm vị trí thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiVT.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm vị trí thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(queryInsert);
            }
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            string mavt = txtMaVT.EditValue.ToString();

            if ((txtMaVT.EditValue == null) || (txtMaVT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn vị trí\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVT.Focus();
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá vị trí đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("delete from vitri where mavt='{0}'", mavt);

                if (con.exeData(queryUpdate))
                {
                    loadViTri();
                    XtraMessageBox.Show("Xoá vị trí thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiVT.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá vị trí thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(queryUpdate);
                }

            }
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            string mavt = txtMaVT.EditValue.ToString();
            string tenvt = txtTenVT.EditValue.ToString();

            if ((txtMaVT.EditValue == null) || (txtMaVT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chọn vị trí\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVT.Focus();
                return;
            }

            if ((txtTenVT.EditValue == null) || (txtTenVT.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên vị trí không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVT.Focus();
                return;
            }
            if (connection.checkName(queryViTri, txtTenVT, "TenViTri") == true)
            {
                XtraMessageBox.Show("Vị trí có tên \"" + txtTenVT.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiVT.PerformClick();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa vị trí đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string queryUpdate = string.Format("update vitri set tenvitri=N'{0}' where mavt='{1}'", tenvt, mavt);

                if (con.exeData(queryUpdate))
                {
                    loadViTri();
                    XtraMessageBox.Show("Sửa vị trí thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiVT.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa vị trí thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }

            }
        }

        private void btnLamMoiVT_Click(object sender, EventArgs e)
        {
            txtTenVT.EditValue = null;
            txtMaVT.EditValue = null;
            txtTenVT.Focus();
        }

        #endregion

        #region show data gridview lên textbox
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) //loai sach
        {
            txtMaLoaiSach.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenLoaiSach.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();
            lkupLS.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString()).ToString();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) //vi tri
        {
            txtMaVT.EditValue = gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[0].ToString()).ToString();
            txtTenVT.EditValue= gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[1].ToString()).ToString();
        }





        #endregion
    }
}