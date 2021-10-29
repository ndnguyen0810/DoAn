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
    public partial class frmTimKiemSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            loadSach();
        }
        string sqlSach = "select MASACH as [Mã sách], TENSACH as [Tên sách], TACGIA as[Tác giả], n.TENNXB as[Nhà xuất bản], " +
                        "v.TENVITRI as [Vị trí], ls.TENLOAI as [Loại sách], SOLUONG as [Số lượng], NAMXB as [Năm xuất bản] from SACH s, NXB n, VITRI v , " +
                        "LOAISACH ls where n.MANXB= s.MANXB and v.MAVT=s.MAVT and v.MALOAI= ls.MALOAI";
        connection con = new connection();
        private void loadSach()
        {
            DataTable dt = con.readData(sqlSach);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }
    }
}