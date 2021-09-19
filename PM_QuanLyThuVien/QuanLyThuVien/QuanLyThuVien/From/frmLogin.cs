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

        private void btnXoa_Click(object sender, EventArgs e)
        {

            txtTK.Text = "";
            txtMK.Text = "";
            txtTK.Focus();
        }

        private void txtMK_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtMK.Properties.UseSystemPasswordChar)
            {
                txtMK.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}