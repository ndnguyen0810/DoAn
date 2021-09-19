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
    public partial class frmMau : DevExpress.XtraEditors.XtraForm
    {
        public frmMau()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmDocGia f = new frmDocGia();
            f.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmLoaiSach_ViTri f = new frmLoaiSach_ViTri();
            f.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmSach_NXB f = new frmSach_NXB();
            f.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
           
        }
    }
}