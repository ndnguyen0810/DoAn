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
        private const string MATK = "MATK";
        private const string TENNV = "TENNV";
        private const string TENTK = "TENTK";
        private const string PASS = "MATKHAU";
        
        public static string TEN = "TENNV";
        public static string matk = "";
        public static string username = "";
        public static string pass = "";
        //public static int mod = 0;

        public static string fullname;

        private void btnXoa_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }



        private void txtReNewPass_Properties_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
          //   Dispose(); //show thử
            

           MessageBox.Show(getInfo(TEN));

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (txtPass.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
                return;
            }
            //if (getInfo(STATE).ToString().Equals("True"))
            //{
            //    XtraMessageBox.Show("Tài khoản của bạn hiện đang bị cấm\r\nVui lòng liên hệ admin để biết thêm thông tin!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtUsername.EditValue = null;
            //    txtPassword.EditValue = null;
            //    txtUsername.Focus();
            //    return;
            //}

            try
            {
                matk = getInfo(MATK);
                if (matk != "")
                {
                    username = getInfo(TENTK);
                    pass = getInfo(PASS);
                    fullname = getInfo(TEN);
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    XtraMessageBox.Show("Thông tin tài khoản hoặc mật khẩu không đúng \r\nVui lòng đăng nhập lại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.EditValue = null;
                    txtPass.EditValue = null;
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi!" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       

        public  string getInfo(string info)
        {
            string tentk = txtUsername.EditValue.ToString();
            string pass = txtPass.EditValue.ToString();

            string id = "";
            try
            {
                //
                string sqlR = string.Format("select * from TAIKHOAN as tk, nhanvien as nv, chucvu as cv where tentk='{0}' and matkhau= '{1}' and tk.manv= nv.manv and tk.macv= cv.macv ", tentk, pass );
                DataTable dt = new DataTable();
                dt = con.readData(sqlR);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr[info].ToString();
                    }
                }
            }
            catch (Exception)
            {
                id = "";
            }
            return id;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtPass.Properties.UseSystemPasswordChar)
            {
                txtPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}