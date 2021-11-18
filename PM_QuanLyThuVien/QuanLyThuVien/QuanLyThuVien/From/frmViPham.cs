﻿using System;
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
    public partial class frmViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmViPham()
        {
            InitializeComponent();
        }

        private void frmViPham_Load(object sender, EventArgs e)
        {
            load();           
        }

        connection con =  new connection();
        string sqlLoad = string.Format("select s.MASACH [Mã sách], s.TENSACH [Tên sách], p.NGAYMUON [Ngày mượn], c.HENTRA [Hẹn trả] from CTPM c, SACH s, " +
            "PHIEUMUON p where c.MAPM= p.MAPM and c.MASACH= s.MASACH and c.MAPM= '{0}' ",frmTraSach.MAPM );

        private void load()
        {
            DataTable dt = con.readData(sqlLoad);
            if (dt != null)
            {
                gcViPham.DataSource = dt;
            }
        }

        DataTable dtViPham = new DataTable();
        private void CreateCTVP()
        {
            dtViPham = new DataTable();
            dtViPham.Columns.Add("MASACH");
            dtViPham.Columns.Add("TENSACH");
            dtViPham.Columns.Add("TACGIA");
            // dtViPham.Columns.Add("NGAYMUON");
            dtViPham.Columns.Add("HENTRA");
            dtViPham.Columns.Add("SoLuong");
            dtViPham.Columns["SoLuong"].DataType = typeof(Int32);
            //foreach (DataRow item in dtSachMuon.Rows)
            //{
            //    DataRow row = dtViPham.NewRow();
            //    row["MASACH"] = item["MASACH"];
            //    row["TENSACH"] = item["TENSACH"];
            //    row["TACGIA"] = item["TACGIA"];
            //    // row["NGAYMUON"] = item["NGAYMUON"];
            //    row["HENTRA"] = item["HENTRA"];
            //    row["SoLuong"] = item["SoLuong"];
            //    dtViPham.Rows.Add(row);
            //}
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvViPham.DeleteSelectedRows();

            }
        }

        private void btnLapPhieuPhat_Click(object sender, EventArgs e)
        {

        }


    }
}