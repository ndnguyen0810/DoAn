using QuanLyBaoChi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoChi.FORM
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

        static public int status;
        static public string displ;
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();
            
            string query = string.Format("select status from TaiKhoan where username='{0}' and password='{1}' ", username, password);
            status = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

            string dis = string.Format("select display from TaiKhoan where status={0}", status);
            displ = DataProvider.Instance.ExcuteScalar(dis).ToString();

            if (username!=""|| password != "")
            {
                DataTable dt = DataProvider.Instance.ExcuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản, mật khẩu", "Thông Báo");
                    txtPassWord.Clear();
                    txtUserName.Clear();
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Lỗi");
            }

        }




        private int kiemtra(string user, string pass)
        {
            int status;
            string query = string.Format("select status from DangNhap where username='{0}' and password='{1}' ", txtUserName.Text.Trim(), txtPassWord.Text.Trim());
            status = DataProvider.Instance.ExcuteNonQuery(query);

            return status;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Focus();
                
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
