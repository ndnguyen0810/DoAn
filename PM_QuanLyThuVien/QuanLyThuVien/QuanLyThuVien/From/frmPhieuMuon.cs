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
            DataTable dt = con.readData(connection.P_LoadSach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
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

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            loadDocGia();
            loadSach();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, "Năm sinh").ToString()).ToString("dd/MM/yyyy");

            txtDiaChi.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3].ToString()).ToString();
            txtMaDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0].ToString()).ToString();
            txtTenDG.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1].ToString()).ToString();

            txtNgaySinh.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2].ToString())).ToString("dd/MM/yyyy");

            txtEmail.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[5].ToString()).ToString();
            txtSDT.EditValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[4].ToString()).ToString();
        }
    }
}