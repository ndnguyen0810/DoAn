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
    public partial class frmPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string querySach = "select * from sach";
        string queryDocGia = "select * from docgia"; 

        private void loadSach()
        {
            DataTable dt = con.readData(querySach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
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

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            loadDocGia();
            loadSach();
        }
    }
}