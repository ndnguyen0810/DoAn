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
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }
        connection con = new connection();

        public void loadNhanVien()
        {
            DataTable dt = con.readData(connection.P_LoadNhanVien);
            if (dt != null)
            {
                gcNhanVien.DataSource = dt;
            }
        }

        private void loadChucVu()
        {
            DataTable dt = con.readData(connection.P_LoadChucVu);
            if (dt != null)
            {
                gcChucVu.DataSource = dt;
            }
        }

        private void loadTaiKhoan()
        {
            DataTable dt = con.readData(connection.P_TaiKhoan);
            if (dt != null)
            {
                gcTaiKhoan.DataSource = dt;
            }
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            loadNhanVien();          
            loadTaiKhoan();
            loadChucVu();
        }
    }
}