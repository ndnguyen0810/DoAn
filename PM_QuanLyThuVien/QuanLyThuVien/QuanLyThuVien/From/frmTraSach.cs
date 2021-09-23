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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTraSach()
        {
            InitializeComponent();
        }
        connection con = new connection();
        string queryDocGia = "select * from docgia"; //= "select * from booktype";
        string querySachMuon;
        private void loadSachDangMuon()
        {
            DataTable dt = con.readData(querySachMuon);
            if (dt != null)
            {
                gcSachDangMuon.DataSource = dt;
            }
        }

        private void loadDocGia()
        {
            DataTable dt = con.readData(queryDocGia);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            loadSachDangMuon();
            loadDocGia();
        }
    }
}