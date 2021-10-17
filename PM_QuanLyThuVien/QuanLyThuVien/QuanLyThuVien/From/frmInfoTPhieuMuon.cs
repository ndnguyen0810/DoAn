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
    public partial class frmInfoTPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmInfoTPhieuMuon()
        {
            InitializeComponent();
        }


        connection con = new connection();
        string sqlCTPM = "select  * from CTPM";
        string sqlPM = "select * from Phieumuon";

        #region load data
        private void loadPhieuMuon()
        {
            DataTable dt = con.readData(sqlPM);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        private void loadCTPM()
        {
            DataTable dt = con.readData(sqlCTPM);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        private void loadDocGia()
        {
            DataTable dt = con.readData(connection.P_LoadDocGia);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        #endregion
        private void frmInfoTPhieuMuon_Load(object sender, EventArgs e)
        {
            loadDocGia();
            loadPhieuMuon();
            loadCTPM();
        }
    }
}