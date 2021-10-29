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
    public partial class frmTimKiemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        connection con = new connection();
        string sql = "select nv.MANV as [Mã nhân viên], TENNV as[Họ và tên], NAMSINH as [Ngày tháng năm sinh],DIACHI as [Địa chỉ]," +
                    "EMAIL as [Email], SDT as [Số điện thoại], NGAYVAOLAM as [Ngày vào làm], TENCV as [Chức vụ], TENTK as[Tên đăng nhập], MATKHAU as[Mật khẩu]" +
                    "from NHANVIEN nv, CHUCVU cv, TAIKHOAN tk where nv.MANV= tk.MANV and cv.MACV= tk.MACV";
        private void loadNV()
        {
            DataTable dt = con.readData(sql);
            if (dt != null)
            {
                gcNV.DataSource = dt;
            }
        }
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
        }
    }
}