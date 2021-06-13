using QuanLyBaoChi.DAO;
using QuanLyBaoChi.DTO;
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

namespace QuanLyBaoChi.FORM
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            LoadTK_NB();
            LoadTK_TL();
            LoadTK_PH();
            LoadTK_NBBB();
            LoadBB_Time();

            LoadListNhaBaoInToCombobox(cbbNB);
        }

        string chuoi = DataProvider.chuoikn;
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;


        private void frmReport_Load(object sender, EventArgs e)
        {
            //cbbNB.Enabled = true;
        }

        #region Load  
        void LoadTK_NB()
        {           
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = "USP_RPNhaBao";
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTK_NB.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadTK_TL()
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = "USP_RP_TheLoai";
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTK_TL.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadTK_PH()
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = "USP_PR_PhatHanh";
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTK_PH.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadTK_NBBB()
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = "USP_RP_NB_BB";
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTKNB_BB.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadListNhaBaoInToCombobox(ComboBox cb)
        {
            cb.DataSource = NhaBaoDAO.Instance.GetListNhaBao();
            cb.DisplayMember = "TenNhaBao";
        }

        private void cbbNB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            NhaBao selected = cb.SelectedItem as NhaBao;
            id = selected.IDNhaBao;
        }

        void LoadBB_Time()
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = "USP_RP_NB_BB";
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTK_BB_Time.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

#endregion

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTK_NBBB();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string nv = (cbbNB.SelectedItem as NhaBao).TenNhaBao;
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = string.Format("select	ROW_NUMBER() over (order by TENNHABAO) AS [Số thứ tự],nb.TENNHABAO as [Tên Nhà Báo] , " +
                    "TENBAIBAO as [Tên Bài Báo] ,NGAYDANG as[Ngày Đăng] , btc.TENTAPCHI as[Tên Tạp Chí] , tl.TENTHELOAI  as[Tên Thể Loại] " +
                    "from BAOTAPCHI as btc, THELOAI as tl, NHABAO as nb, BAIVIET as bv, BAIBAO as bb where btc.ID_TAPCHI = bb.ID_TAPCHI and " +
                    "tl.ID_THELOAI = bb.ID_THELOAI and nb.ID_NHABAO = bb.ID_NHABAO and bv.ID_BAIVIET = bb.ID_BAIVIET   and TENNHABAO = N'{0}'", nv);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTKNB_BB.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dptTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dati = dptTime.Value;
            
        }

        private void btnXemm_Click(object sender, EventArgs e)
        {
            LoadBB_Time();
        }

        private void btnLocc_Click(object sender, EventArgs e)
        {
            DateTime dati = dptTime.Value;
            //string formatted = dati.ToString("dd/mm/yyyy");
            string.Format("mm/dd/yyyy", dati);
            string dateti = dptTime.Text;
            try
            {

                con = new SqlConnection(chuoi);
                con.Open();
                if (rdbNgay.Checked == true)
                {
                    string query = string.Format("select	ROW_NUMBER() over (order by TENNHABAO) AS [Số thứ tự],nb.TENNHABAO as [Tên Nhà Báo] , " +
                    "TENBAIBAO as [Tên Bài Báo] ,NGAYDANG as[Ngày Đăng] , btc.TENTAPCHI as[Tên Tạp Chí] , tl.TENTHELOAI  as[Tên Thể Loại] " +
                    "from BAOTAPCHI as btc, THELOAI as tl, NHABAO as nb, BAIVIET as bv, BAIBAO as bb where btc.ID_TAPCHI = bb.ID_TAPCHI and " +
                    "tl.ID_THELOAI = bb.ID_THELOAI and nb.ID_NHABAO = bb.ID_NHABAO and bv.ID_BAIVIET = bb.ID_BAIVIET   and NGAYDANG = '{0}'", dptTime.Value.ToShortDateString());

                    adapt = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dgvTK_BB_Time.DataSource = dt;
                }
                else if (rdbThang.Checked == true)
                {
                    int nam = Int32.Parse(dateti.Substring(dateti.Length - 4, 4));
                   int thang= Int32.Parse(dateti.Substring(3,2));

                    string query = string.Format("select	ROW_NUMBER() over (order by TENNHABAO) AS [Số thứ tự],nb.TENNHABAO as [Tên Nhà Báo] , " +
                    "TENBAIBAO as [Tên Bài Báo] ,NGAYDANG as[Ngày Đăng] , btc.TENTAPCHI as[Tên Tạp Chí] , tl.TENTHELOAI  as[Tên Thể Loại] " +
                    "from BAOTAPCHI as btc, THELOAI as tl, NHABAO as nb, BAIVIET as bv, BAIBAO as bb where btc.ID_TAPCHI = bb.ID_TAPCHI and " +
                    "tl.ID_THELOAI = bb.ID_THELOAI and nb.ID_NHABAO = bb.ID_NHABAO and bv.ID_BAIVIET = bb.ID_BAIVIET   and month(NGAYDANG) = {0}" +
                    " and year(ngaydang)={1}", thang, nam);               

                    adapt = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dgvTK_BB_Time.DataSource = dt;
                }
                else if (rdbNam.Checked == true)
                {
                    int nam = Int32.Parse(dateti.Substring(dateti.Length - 4, 4));
                    

                    string query = string.Format("select	ROW_NUMBER() over (order by TENNHABAO) AS [Số thứ tự],nb.TENNHABAO as [Tên Nhà Báo] , " +
                    "TENBAIBAO as [Tên Bài Báo] ,NGAYDANG as[Ngày Đăng] , btc.TENTAPCHI as[Tên Tạp Chí] , tl.TENTHELOAI  as[Tên Thể Loại] " +
                    "from BAOTAPCHI as btc, THELOAI as tl, NHABAO as nb, BAIVIET as bv, BAIBAO as bb where btc.ID_TAPCHI = bb.ID_TAPCHI and " +
                    "tl.ID_THELOAI = bb.ID_THELOAI and nb.ID_NHABAO = bb.ID_NHABAO and bv.ID_BAIVIET = bb.ID_BAIVIET   and year(NGAYDANG) = {0}", nam);

                    adapt = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dgvTK_BB_Time.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
