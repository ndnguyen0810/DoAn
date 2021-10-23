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
    public partial class frmSachDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmSachDangMuon()
        {
            InitializeComponent();
        }
        connection con = new connection();
        string sql = "select  s.MASACH as [Mã sách], s.TENSACH as [Tên sách], s.TACGIA as[Tác giả], ct.[Số lượng] from SACH s join(select masach, COUNT(masach) as [Số lượng] from CTPM ct group by MASACH) ct on ct.MASACH= s.MASACH";
        private void load()
        {
            DataTable dt = con.readData(sql);
            if(dt!= null)
            {
                gcSachDangMuon.DataSource = dt;
            }
        }

        private void frmSachDangMuon_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}