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
        connection con = new connection();

        public string fullname = frmLogin.fullname;// = frmLogin;
       // string chucvu = frmLogin.CHUCVU;

        private void loadFrom()
        {
            barHeaderItem1.Caption = "Xin chào: " + fullname;
            barHeaderItem4.Caption = DateTime.Now.ToLongDateString();
            
            //bool check = false;
            //string sql = "select mod from users where id_user = '" + id + "'";
            //DataTable dt = new DataTable();
            //dt = con.readData(sql);
            //if (dt != null)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        check = Convert.ToBoolean(dr["mod"]);
            //    }
            //}
            //if (!check)
            //{
            //    rbNhanVien.Visible = false;
            //    rbThuVien.Visible = false;
            //}
            //frmHome frm = new frmHome();
            //frm.MdiParent = this;
            //frm.Show();
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

        #region Chức năng - sách
        private void btnMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmMuonSach));
            if (frm == null)
            {
                frmMuonSach f = new frmMuonSach();
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

        private void barBtnTTPM_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmInfoTPhieuMuon));
            if (frm == null)
            {
                frmInfoTPhieuMuon f = new frmInfoTPhieuMuon();
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
        #endregion


        #region Chức năng - Thống kê

        private void btnSachTrongTV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachTrongThuVien));
            if (frm == null)
            {
                frmSachTrongThuVien f = new frmSachTrongThuVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSachDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachDangMuon));
            if (frm == null)
            {
                frmSachDangMuon f = new frmSachDangMuon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDocGiaDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDocGiaDangMuon));
            if (frm == null)
            {
                frmDocGiaDangMuon f = new frmDocGiaDangMuon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        #endregion


        # region Chức năng - Tìm kiếm

        private void btnTimSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmTimKiemSach));
            if (frm == null)
            {
                frmTimKiemSach f = new frmTimKiemSach();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTimDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmTimKiemDocGia));
            if (frm == null)
            {
                frmTimKiemDocGia f = new frmTimKiemDocGia();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTimNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmTimKiemNhanVien));
            if (frm == null)
            {
                frmTimKiemNhanVien f = new frmTimKiemNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        #endregion


        #region Hệ thống - Thêm tài khoản
        private void btnThemTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmThemTaiKhoan));
            if (frm == null)
            {
                frmThemTaiKhoan f = new frmThemTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDoiMatKhau));
            if (frm == null)
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDoiTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSuaTT));
            if (frm == null)
            {
                frmSuaTT f = new frmSuaTT();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
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
        #endregion


        #region Hệ thống - Sách
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
        #endregion


        #region Hệ thống - Nhân viên
        private void btnNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmNhanVien));
            if (frm == null)
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }


        #endregion


        #region Hỗ trợ

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmThongTinPhanMem));
            if (frm == null)
            {
                frmThongTinPhanMem f = new frmThongTinPhanMem();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmThanhVien));
            if (frm == null)
            {
                frmThanhVien f = new frmThanhVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        #endregion


        #region Event From
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadFrom();
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
      
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


        #endregion

        
    }
}