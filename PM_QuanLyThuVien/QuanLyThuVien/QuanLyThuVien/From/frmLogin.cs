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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        connection con = new connection();
        //private const string ID_USER = "id_user";
        //private const string PASSWORD = "password";
        //private const string FULLNAME = "fullname";
        //private const string STATE = "state";
        //public static string id_user = "";
        //public static string name_user = "";
        //public static string password_user = "";
        //public static int mod = 0;

        private void btnXoa_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }

        private void txtMK_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtUsername.Properties.UseSystemPasswordChar)
            {
                txtUsername.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtUsername.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtReNewPass_Properties_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if (txtUsername.EditValue == null)
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtUsername.Focus();
            //    return;
            //}
            //if (txtPassword.EditValue == null)
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập mật khẩu \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtPassword.Focus();
            //    return;
            //}
            //if (getInfo(STATE).ToString().Equals("True"))
            //{
            //    XtraMessageBox.Show("Tài khoản của bạn hiện đang bị cấm\r\nVui lòng liên hệ admin để biết thêm thông tin!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtUsername.EditValue = null;
            //    txtPassword.EditValue = null;
            //    txtUsername.Focus();
            //    return;
            //}
            //try
            //{
            //    id_user = getInfo(ID_USER);
            //    if (id_user != "")
            //    {
            //        name_user = getInfo(FULLNAME);
            //        password_user = getInfo(PASSWORD);
            //        frmMain frm = new frmMain();
            //        this.Hide();
            //        frm.ShowDialog();
            //        this.Dispose();
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("Thông tin tài khoản hoặc mật khẩu không đúng \r\nVui lòng đăng nhập lại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtUsername.EditValue = null;
            //        txtPassword.EditValue = null;
            //        txtUsername.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi!" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //private string getInfo(string info)
        //{
        //    string id = "";
        //    try
        //    {
        //        string sqlR;// = "select * from users where username = '" + txtUsername.EditValue.ToString() + "' and password = '" + encrypt(txtPassword.EditValue.ToString()).ToString() + "'";
        //        DataTable dt = new DataTable();
        //        dt = con.readData(sqlR);
        //        if (dt != null)
        //        {
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                id = dr[info].ToString();
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        id = "";
        //    }
        //    return id;
        //}

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}