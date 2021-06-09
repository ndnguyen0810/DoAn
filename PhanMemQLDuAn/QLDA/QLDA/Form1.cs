using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoi = "Server=MSI;Database=QLDA;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;
        private void DisplayData()
        {
            con = new SqlConnection(chuoi);
            con.Open();
            dt = new DataTable();
            adapt = new SqlDataAdapter("select da.MADUAN,da.TENDUAN,da.THANHPHO_DUAN,ct.TENCTTC,da.TGBD,da.DUKIENHT,da.TGHT,nv.TENNV,ndt.TENNDT from DUAN da, CTYTHICONG ct, NHANVIEN nv, NHADAUTU ndt, DAUTU dt where da.MACTTC = ct.MACTTC and nv.MADUAN = da.MADUAN and dt.MADUAN = da.MADUAN and ndt.MANDT = dt.MANDT", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuAn frm = new FrmDuAn();
            frm.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaCC frm = new FrmNhaCC();
            frm.Show();
        }

        private void nhàĐầuTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaDT frm = new FrmNhaDT();
            frm.Show();
        }

        private void côngTyThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCTTC frm = new FrmCTTC();
            frm.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHangHoa frm = new FrmHangHoa();
            frm.Show();
        }

        private void cungỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCungUng frm = new FrmCungUng();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
        }

        private void cungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCungCap frm = new FrmCungCap();
            frm.Show();
        }

        private void ĐầuTưToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDauTu frm = new FrmDauTu();
            frm.Show();
        }
    }
}
