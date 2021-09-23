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
    public partial class frmLoaiSach_ViTri : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiSach_ViTri()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string queryLoaiSach = "select * from Loaisach"; //= "select * from booktype";
        string queryViTri= "select *  from VITRI";

 
        private void loadLoaiSach()
        {
            DataTable dt = con.readData(connection.P_LoadDocGia);
            if (dt != null)
            {
                gwLoaiSach.DataSource = dt;
                
            }
        }

        private void loadViTri()
        {
            DataTable dt = con.readData(connection.P_LoadViTri);
            if (dt != null)
            {
                gwVT.DataSource = dt;
            }
        }

        private void frmLoaiSach_ViTri_Load(object sender, EventArgs e)
        {
            loadLoaiSach();
            loadViTri();
        }
    }
}