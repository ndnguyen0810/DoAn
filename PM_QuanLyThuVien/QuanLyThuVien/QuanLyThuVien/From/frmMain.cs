using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyThuVien.From;
using DevExpress.XtraEditors;
using System.Threading;

namespace QuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form formCheck(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmPhieuMuon));
            if (frm == null)
            {
                frmPhieuMuon f = new frmPhieuMuon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDocGia));
            if (frm == null)
            {
                frmDocGia f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTrasach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmTraSach));
            if (frm == null)
            {
                frmTraSach f = new frmTraSach();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSachTrongTV_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form frm = formCheck(typeof(frmPhieuMuon));
            //if (frm == null)
            //{
            //    frmPhieuMuon f = new frmPhieuMuon();
            //    f.MdiParent = this;
            //    f.Show();
            //}
            //else
            //{
            //    frm.Activate();
            //}
        }

        private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSach_NXB));
            if (frm == null)
            {
                frmSach_NXB f = new frmSach_NXB();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnLoaiSach_VT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmLoaiSach_ViTri));
            if (frm == null)
            {
                frmLoaiSach_ViTri f = new frmLoaiSach_ViTri();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(openLoginForm));
            t.SetApartmentState(ApartmentState.STA);
            this.FormClosing -= frmMain_FormClosing;
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                t.Start();
            }
        }

        public static void openLoginForm()
        {
            Application.Run(new frmLogin());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}