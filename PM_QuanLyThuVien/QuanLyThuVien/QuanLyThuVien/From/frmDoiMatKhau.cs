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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        //connection con = new connection();
        //string id = frmLogin.id_user;
        //string password = frmLogin.password_user;


        private void txtOldPass_Properties_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPass_Properties_Click(object sender, EventArgs e)
        {

        }

        private void txtReNewPass_Properties_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //if ((txtOldPass.EditValue == null) || (txtOldPass.EditValue.ToString().Equals("")))
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập mật khẩu cũ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtOldPass.Focus();
            //    return;
            //}
            //if ((txtNewPass.EditValue == null) || (txtNewPass.EditValue.ToString().Equals("")))
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập mật khẩu mới\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtNewPass.Focus();
            //    return;
            //}
            //if ((txtReNewPass.EditValue == null) || (txtReNewPass.EditValue.ToString().Equals("")))
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập lại mật khẩu mới\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtReNewPass.Focus();
            //    return;
            //}
            //if (!txtNewPass.EditValue.ToString().Equals(txtReNewPass.EditValue.ToString()))
            //{
            //    XtraMessageBox.Show("Hai mật khẩu mới không trùng nhau\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtReNewPass.Focus();
            //    return;
            //}
            //if (!encrypt(txtOldPass.EditValue.ToString()).ToString().Equals(password))
            //{
            //    XtraMessageBox.Show("Mật khẩu cũ không đúng\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtOldPass.Focus();
            //    return;
            //}
            //string sqlU = "update users set password = '" + encrypt(txtNewPass.EditValue.ToString()).ToString() + "' where id_user = '" + id + "'";
            //if (con.exeData(sqlU))
            //{
            //    XtraMessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    btnLamMoi.PerformClick();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void txtOldPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtOldPass.Properties.UseSystemPasswordChar)
            {
                txtOldPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtNewPass.Properties.UseSystemPasswordChar)
            {
                txtNewPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtReNewPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtReNewPass.Properties.UseSystemPasswordChar)
            {
                txtReNewPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtReNewPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtOldPass.EditValue = null;
            txtNewPass.EditValue = null;
            txtReNewPass.EditValue = null;
            txtOldPass.Focus();
        }
    }
}