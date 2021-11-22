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
using QuanLyThuVien.Report;

namespace QuanLyThuVien.From
{
    public partial class frmSachTrongThuVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSachTrongThuVien()
        {
            InitializeComponent();
        }
        connection con = new connection();
        DataTable dtSachTTV;
        
       
        public static rpSachTrongThuVien rps = new rpSachTrongThuVien();

        string sql = "select MASACH, TENSACH, TACGIA,  NAMXB, GIATIEN,SOLUONG from SACH";

        private void frmSachTrongThuVien_Load(object sender, EventArgs e)
        {
            //this.rpt = rppm;
            documentViewer1.PrintingSystem = rps.PrintingSystem;
            rps.CreateDocument();

            DataTable dtLuu = con.readData(sql);

           // int TongSL = Convert.ToInt32(dtLuu.Compute("SUM(SOLUONG)", string.Empty));
            rpSachTrongThuVien rp = new rpSachTrongThuVien();
           // rp.DataSource = dtLuu;
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            
            rp.Data("21","12","1222","abc",1111);
            rps = rp;
            

        }
        //private void loadRP()
        //{
        //    //createSTTV();

        //    int TongSL = Convert.ToInt32(dtLuu.Compute("SUM(SOLUONG)", string.Empty));
        //    rpSachTrongThuVien rp = new rpSachTrongThuVien();
        //    rp.DataSource = dtLuu;
        //    string ngay = DateTime.Now.Day.ToString();
        //    string thang = DateTime.Now.Month.ToString();
        //    string nam = DateTime.Now.Year.ToString();
        //    rp.Data(ngay, thang, nam, frmLogin.fullname, TongSL);
        //    rppm = rp;
        //}

        //private void createSTTV()
        //{
        //    dtLuu = new DataTable();
        //    dtLuu.Columns.Add("MASACH");
        //    dtLuu.Columns.Add("TENSACH");
        //    dtLuu.Columns.Add("TACGIA");
        //    dtLuu.Columns.Add("NAMXB");
        //    dtLuu.Columns.Add("GIATIEN");
        //    dtLuu.Columns["GIATIEN"].DataType = typeof(Int32);
        //    dtLuu.Columns.Add("SOLUONG");
        //    dtLuu.Columns["SOLUONG"].DataType = typeof(Int32);

        //    foreach (DataRow item in dtSachTTV.Rows)
        //    {
        //        DataRow row = dtLuu.NewRow();
        //        row["MASACH"] = item["MASACH"];
        //        row["TENSACH"] = item["TENSACH"];
        //        row["TACGIA"] = item["TACGIA"];
        //        row["NAMXB"] = item["NAMXB"];
        //        row["GIATIEN"] = item["GIATIEN"];
        //        row["SOLUONG"] = item["SOLUONG"];
        //        dtLuu.Rows.Add(row);
        //    }
        //}
        
    }
}