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
    public partial class frmSach_NXB : DevExpress.XtraEditors.XtraForm
    {
        public frmSach_NXB()
        {
            InitializeComponent();
        }

        connection con = new connection();
        string querySach="select * from sach";// = "select * from book";
        string queryNXB="select * from NXB"; //= "select * from booktype";


        private void loadNXBOnSach()
        {
            //DataTable dt = con.readData(sqlRBT);
            //if (dt != null)
            //{
            //    lueLoaiSach.Properties.DataSource = dt;
            //    lueLoaiSach.Properties.DisplayMember = "booktypename";
            //    lueLoaiSach.Properties.ValueMember = "id_booktype";
            //}
        }

        private void loadSach()
        {
            DataTable dt = con.readData(connection.P_LoadSach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }
        private void loadNXB()
        {
            DataTable dt = con.readData(connection.P_LoadNXB);
            if (dt != null)
            {
                gcNXB.DataSource = dt;
            }
        }

        private void frmSach_NXB_Load(object sender, EventArgs e)
        {
            loadNXB();
            loadSach();
        }
    }
}