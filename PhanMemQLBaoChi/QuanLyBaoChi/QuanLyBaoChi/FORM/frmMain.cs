using QuanLyBaoChi.DAO;
using QuanLyBaoChi.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoChi
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
            LoadBaiBaoOnDGV();      
        }

        string chuoi = @"Data Source=admin\dinhnguyen;Initial Catalog=QuanLyBaoChi_New;Integrated Security=True";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
		{
            timer1.Enabled = true;
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString();                    

            lbName.Text =frmDangNhap.displ;

            if (frmDangNhap.status == 1)
            {
                qtv.Enabled = false;
                thongke.Enabled = false;
               
            }
            else if(frmDangNhap.status==0)
            {
                quanly.Enabled = true;
                thongke.Enabled = true;
                
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanTriAdmin frm = new frmQuanTriAdmin();     
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void nhàBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyBao frm = new frmQuanLyBao();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        #region
        public object Main { get; private set; }

        void LoadBaiBaoOnDGV()
        {
            string query = "USP_LoadMain";
            dgvMain.DataSource = DataProvider.Instance.ExcuteQuery(query);
            
        }
        #endregion

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLienHe frm = new frmLienHe();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thống báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();

                string query = string.Format("select ROW_NUMBER() OVER (ORDER BY ID_BAIBAO) as [Số Thứ Tự] , TENBAIBAO as[Tên Bài Báo], NGAYDANG as[Ngày Đăng Bài],   btc.TENTAPCHI as[Báo Tạp Chí], tl.TENTHELOAI as[Thể Loại], nb.BUTHIEU as[Bút Hiệu]    from BAOTAPCHI as btc, THELOAI as tl, NHABAO as nb, BAIBAO as bb   where btc.ID_TAPCHI = bb.ID_TAPCHI  and tl.ID_THELOAI = bb.ID_THELOai  and nb.ID_NHABAO = bb.ID_NHABAO  " +
                                "and( dbo.FuncConvert(bb.tenbaibao) like N'%'+ dbo.FuncConvert(N'{0}')+ N'%' " +
                                "or dbo.FuncConvert(btc.tentapchi) like N'%'+ dbo.FuncConvert(N'{0}')+ N'%' " +
                                "or dbo.FuncConvert(tl.tentheloai) like N'%'+ dbo.FuncConvert(N'{0}')+ N'%' " +
                                "or dbo.FuncConvert(nb.buthieu) like N'%'+ dbo.FuncConvert(N'{0}') + N'%')", txtSeach.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvMain.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSeach_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadBaiBaoOnDGV();
        }



        private void txtSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
