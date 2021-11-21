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
    public partial class frmViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmViPham()
        {
            InitializeComponent();
        }

        public static rpPhieuPhat rppm = new rpPhieuPhat();
        DataTable dtSachPhat;  //ds sách mượn để phạt
        DataTable dtPhat; //ds phạt
        //DataTable dtViPham = new DataTable(); //ds vi phạm

        private void frmViPham_Load(object sender, EventArgs e)
        {
            loadSachDePhat();
            loadPhat();
            int row_index = gvViPham.FocusedRowHandle;
            dtSachPhat = con.readData(sqlLoad);
            foreach (DataRow dr in dtSachPhat.Rows)
            {
                DateTime hantra = DateTime.Parse(dr["Hẹn trả"].ToString());
                DateTime now = DateTime.Today;
                TimeSpan time = now - hantra;
                int songay = Int32.Parse(time.Days.ToString());
                if (songay>0)
                {
                    DataRow row = dtPhat.NewRow();
                    row["Mã sách"] = dr["Mã sách"];
                    row["Tên sách"] = dr["Tên sách"];
                    row["Lý do phạt"] = "Quá hạn";
                    row["Đơn vị tính"] = "Ngày";
                    row["Số lượng"] = songay;
                    row["Thành tiền"] = songay * 2000;
                    dtPhat.Rows.Add(row);
                    gcCTPhat.DataSource = dtPhat;
                }
            }            
        }


        connection con =  new connection();
        string sqlLoad = string.Format("select s.MASACH [Mã sách], s.TENSACH [Tên sách], s.NAMXB, p.NGAYMUON [Ngày mượn], c.HENTRA [Hẹn trả], s.GIATIEN from CTPM c, SACH s, " +
            "PHIEUMUON p where c.MAPM= p.MAPM and c.MASACH= s.MASACH and c.MAPM= '{0}' ",frmTraSach.MAPM );

        string sqlPP = "select * from phieuphat";
        private void loadSachDePhat()
        {
            dtSachPhat = con.readData(sqlLoad);
            if (dtSachPhat != null)
            {
                gcViPham.DataSource = dtSachPhat;
            }
        }

        DataTable dtphieuphat;
        private void CreateCTVP()
        {
            dtphieuphat = new DataTable();
            dtphieuphat.Columns.Add("MASACH");
            dtphieuphat.Columns.Add("TENSACH");
            dtphieuphat.Columns.Add("LYDOPHAT");
            dtphieuphat.Columns.Add("DONVITINH");
            dtphieuphat.Columns.Add("SOLUONG");
            dtphieuphat.Columns["SOLUONG"].DataType = typeof(Int32);
            dtphieuphat.Columns.Add("TIEN");
            dtphieuphat.Columns["TIEN"].DataType = typeof(Int32);

            foreach (DataRow item in dtPhat.Rows)
            {
                DataRow row = dtphieuphat.NewRow();
                row["MASACH"] = item["Mã sách"];
                row["TENSACH"] = item["Tên sách"];
                row["LYDOPHAT"] = item["Lý do phạt"];
                row["DONVITINH"] = item["Đơn vị tính"];
                row["SOLUONG"] = item["Số lượng"];
                row["TIEN"] = item["Thành tiền"];

                dtphieuphat.Rows.Add(row);              
            }
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvCTPhat.DeleteSelectedRows();

            }
        }

        private void loadPhat()
        {
            dtPhat = new DataTable();
            dtPhat.Columns.Add("Mã sách");
            dtPhat.Columns.Add("Tên sách");
            dtPhat.Columns.Add("Lý do phạt");
            dtPhat.Columns.Add("Đơn vị tính");
            dtPhat.Columns.Add("Số lượng");          
            dtPhat.Columns.Add("Thành tiền");          
        }

        private void btnLydo_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row_index = gvViPham.FocusedRowHandle;
            frmLyDoVP frm = new frmLyDoVP();

            DateTime now = DateTime.Today;
            DateTime ngaymuon = DateTime.Parse(gvViPham.GetRowCellValue(row_index, "Ngày mượn").ToString());
            DateTime hantra = DateTime.Parse(gvViPham.GetRowCellValue(row_index, "Hẹn trả").ToString());

            TimeSpan time = now- hantra;
            TimeSpan quahan = hantra - ngaymuon;
            
            int songayquahan = int.Parse(time.Days.ToString());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string lydo= frmLyDoVP.Lydo.ToString();
                DataRow row = dtPhat.NewRow();
                int namxb = Int32.Parse(gvViPham.GetRowCellValue(row_index, "NAMXB").ToString());
                int giasach= Int32.Parse(gvViPham.GetRowCellValue(row_index, "GIATIEN").ToString());
                row["Mã sách"] = gvViPham.GetRowCellValue(row_index, "Mã sách").ToString();
                row["Tên sách"] = gvViPham.GetRowCellValue(row_index, "Tên sách").ToString();
                row["Lý do phạt"] = frmLyDoVP.Lydo.ToString();
                row["Số lượng"] = frmLyDoVP.SLTrang;
                int soluong = Int32.Parse(row["Số lượng"].ToString());
                if (lydo=="Quá hạn")
                {                  
                    row["Đơn vị tính"] = "Ngày";                  
                }
                else
                {
                    row["Đơn vị tính"] = "Trang";
                }
                //thành tiền
                if(lydo=="Mất sách")
                {
                    if (namxb <= 1998)
                    {
                        row["Thành tiền"] = giasach * 3;
                    }
                    else
                    {
                        row["Thành tiền"] = giasach;
                    }
                }
                if (lydo == "Hư hỏng tài liệu khổ 13x19")
                {
                    row["Thành tiền"] = 1500*soluong;
                }

                if(lydo== "Hư hỏng tài liệu khổ 17x24")
                {
                    row["Thành tiền"] = 3000*soluong;
                }

                if(lydo== "Hư hỏng tài liệu khổ 19x27")
                {
                    row["Thành tiền"] = 3400*soluong;
                }

                dtPhat.Rows.Add(row);           
                gcCTPhat.DataSource = dtPhat;

            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            CreateCTVP();
            int row_index = gvCTPhat.FocusedRowHandle;
            bool check = false;
            string ngayphat = DateTime.Now.ToString("MM/dd/yyyy").ToString();
            string insertPP = string.Format("insert into phieuphat values ('{0}', '{1}', '{2}', {3})", con.creatId("PP", sqlPP), frmTraSach.MAPM, ngayphat, 0);
            
            string mapp = con.creatId("PP", sqlPP);
            int tongtien;
            try
            {
                if (con.exeData(insertPP))
                {
                    foreach (DataRow dr in dtphieuphat.Rows)
                    {
                        string sqlCPPP = string.Format("insert into ctpp values('{0}', '{1}', N'{2}', {3}, N'{4}', {5})", mapp, dr["MASACH"], dr["LYDOPHAT"], dr["SOLUONG"], dr["DONVITINH"], dr["TIEN"]);

                        con.Ex_vp(sqlCPPP);
                        if (dr["LYDOPHAT"].ToString() != "Quá hạn")
                        {
                            string upSach = string.Format("update sach set soluong= soluong-1 where masach='{0}'", dr["MASACH"]);
                            con.exeData(upSach);
                        }
                    }
                    XtraMessageBox.Show("TC");
                    string upTT = string.Format("update phieuphat set tongtienphat={0}", Convert.ToInt32(dtphieuphat.Compute("SUM(TIEN)", string.Empty)));
                    con.exeData(upTT);
                    check = true;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            if (check)
            {
                XtraMessageBox.Show("Lập phiếu phạt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (XtraMessageBox.Show("Bạn có muốn xuất phiếu phạt không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int TongSL = Convert.ToInt32(dtphieuphat.Compute("SUM(TIEN)", string.Empty));
                    rpPhieuPhat rp = new rpPhieuPhat();
                    rp.DataSource = dtphieuphat;
                    string ngay = DateTime.Now.Day.ToString();
                    string thang = DateTime.Now.Month.ToString();
                    string nam = DateTime.Now.Year.ToString();
                    rp.Data(ngay, thang, nam, DateTime.Now.ToString("dd/MM/yyyy").ToString(), frmTraSach.MADG, frmTraSach.TENDG, frmLogin.fullname, TongSL, frmTraSach.MAPM);

                    rppm = rp;

                    frmPhieuPhat frm = new frmPhieuPhat();
                    frm.Show();
                }
            }
            else
            {
                XtraMessageBox.Show("Lập phiếu phạt thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}