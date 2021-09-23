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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        connection con = new connection();
        string queryLoaiSach = "select * from Loaisach"; //= "select * from booktype";
        string queryViTri = "select *  from VITRI";


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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadChucVu();
        }
    }
}