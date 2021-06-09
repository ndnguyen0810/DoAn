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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoChi.FORM
{
	public partial class frmQuanTriAdmin : Form
	{
		public frmQuanTriAdmin()
		{
			InitializeComponent();

			LoadTableTheLoai();
			LoadTableTapChi();
			LoadTablePhatHanh();
            LoadTableNhaBao();
            LoadTableTaiKhoan();
		}

        string chuoi = @"Data Source=admin\dinhnguyen;Initial Catalog=QuanLyBaoChi_New;Integrated Security=True";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;

        #region Thể Loại

        public object TheLoaiList { get; private set; }
		BindingSource TheloaiList = new BindingSource();

		void LoadTableTheLoai()
		{
			dgvTheLoai.DataSource = TheloaiList;
			LoadTheLoaiOnDGV();
        }

        void LoadTheLoaiOnDGV()
		{           
			//string query = "Select * from TheLoai";
            string query = "USP_LoadTheLoai";
            TheloaiList.DataSource = DataProvider.Instance.ExcuteQuery(query);
		}

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTheLoai.Rows[e.RowIndex];
                txtTL_ID.Text = row.Cells[0].Value.ToString();
                txtTL_TenTL.Text = row.Cells[1].Value.ToString();
                txtTL_DienGiai.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtTL_DienGiai_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btnTL_Them.PerformClick();
            }

        }

        private void btnTL_Them_Click(object sender, EventArgs e)
		{		
			string tenTL = txtTL_TenTL.Text;
            string dienGiai = txtTL_DienGiai.Text;

            try
            {
                if (TheLoaiDAO.Instance.ThemTheLoai(tenTL, dienGiai))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadTableTheLoai();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void btnTL_Sua_Click(object sender, EventArgs e)
		{
			int ID_TL = Int32.Parse(txtTL_ID.Text);
			string dienGiai = txtTL_TenTL.Text;
			string tenTL = txtTL_DienGiai.Text;

            try
            {
                if (TheLoaiDAO.Instance.SuaTheLoai(ID_TL, tenTL, dienGiai))
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    LoadTableTheLoai();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void btnTL_Xoa_Click(object sender, EventArgs e)
		{
			int ID_TL = Int32.Parse(txtTL_ID.Text);
			string dienGiai = txtTL_TenTL.Text;
			string tenTL = txtTL_DienGiai.Text;

            try
            {
                if (TheLoaiDAO.Instance.XoaTheLoai(ID_TL, tenTL, dienGiai))
                {
                    MessageBox.Show("Xoá Thành Công", "Thông Báo");
                    LoadTableTheLoai();
                }
                else
                {
                    MessageBox.Show("Xoá Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

        private void btnTL_Xem_Click(object sender, EventArgs e)
        {
            LoadTableTheLoai();
        }


        private void btnTL_Tim_Click(object sender, EventArgs e)
		{
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = string.Format("select ID_THELOAI as [ID Thể Loại], TENTHELOAI as[Tên Thể Loại], DIENGIAI_TL as[Mô Tả] from THELOAI where (dbo.FuncConvert(DienGiai_TL) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or  dbo.FuncConvert(TENTHELOAI) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or id_TheLoai={0})", txtTL_Tim.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTheLoai.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		#endregion

		#region Báo Tạp Chí

		public object TapChiList { get; private set; }
		BindingSource TapchiList = new BindingSource();

		void LoadTableTapChi()
		{
			dgvTapChi.DataSource =TapchiList;
			LoadTapChiOnDGV();
			LoadListPhatHanhInToCombobox(cbbTC_ThoiGian);
        }	

		void LoadTapChiOnDGV()
		{
            //string query = "select * from baoTapChi";
            string query = "USP_LoadtapChi";
			TapchiList.DataSource = DataProvider.Instance.ExcuteQuery(query);
		}

        private void dgvTapChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTapChi.Rows[e.RowIndex];
                txtTC_ID.Text = row.Cells[0].Value.ToString();
                txtTC_Ten.Text = row.Cells[1].Value.ToString();
                txtTC_DiaChi.Text = row.Cells[2].Value.ToString();
                cbbTC_ThoiGian.Text = row.Cells[3].Value.ToString();
                txtTC_Email.Text = row.Cells[4].Value.ToString();
                txtTC_SDT.Text = row.Cells[5].Value.ToString();
            }
        }

        void LoadListPhatHanhInToCombobox(ComboBox cb)
		{
			cb.DataSource = PhatHanhDAO.Instance.GetListPhatHanh();
			cb.DisplayMember = "ThoiGianPH";
		}

		private void cbbTC_ThoiGian_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;

			ComboBox cb = sender as ComboBox;
		
			if (cb.SelectedItem == null)
				return;

			PhatHanh selected = cb.SelectedItem as PhatHanh;
			id = selected.IDPhatHanh;

		}

        private void btnTC_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();

                string query = string.Format("select ID_TAPCHI as[ID Tạp Chí], TENTAPCHI as[Tên Tạp Chí], DIACHITC as[Địa Chỉ],  ph.THOIGIANPH as[Thời Gian Phát Hành], EMAIL_TC as[Email], SDT_TC as [Số Điện Thoại] from BAOTAPCHI as btc, PHATHANH as ph where btc.ID_PHATHANH = ph.ID_PHATHANH " +
                    "and (dbo.FuncConvert(btc.TENTAPCHI) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or dbo.FuncConvert(ph.THOIGIANPH) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or dbo.FuncConvert(btc.DIACHITC) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or id_tapchi={0})", txtTC_Tim.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvTapChi.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        Regex reg = new Regex(match);

        private void btnTC_Them_Click(object sender, EventArgs e)
		{
			string tenTC = txtTC_Ten.Text;
			string diachiTC = txtTC_DiaChi.Text;
			string email = txtTC_Email.Text;
			string sdt = txtTC_SDT.Text;
			int id_PH = (cbbTC_ThoiGian.SelectedItem as PhatHanh).IDPhatHanh;
           
           
           
            try
            {
                if (reg.IsMatch(this.txtTC_Email.Text))
                {
                    if (TapChiDAO.Instance.ThemTC(tenTC, diachiTC, id_PH, email, sdt))
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo");
                        LoadTableTapChi();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại", "thông báo");
                    }
                }
                else MessageBox.Show("Sai email","Thông Báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

        private void btnTC_Xem_Click(object sender, EventArgs e)
        {
            LoadTableTapChi();
        }

        private void btnTC_Sua_Click(object sender, EventArgs e)
		{
			int id_TC = Int32.Parse(txtTC_ID.Text);
			string tenTC = txtTC_Ten.Text;
			string diachiTC = txtTC_DiaChi.Text;
			string email = txtTC_Email.Text;
			string sdt = txtTC_SDT.Text;
			int id_PH = (cbbTC_ThoiGian.SelectedItem as PhatHanh).IDPhatHanh;

            try
            {
                if (TapChiDAO.Instance.CapNhatTC(id_TC, tenTC, diachiTC, id_PH, email, sdt))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    LoadTableTapChi();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void btnTC_Xoa_Click(object sender, EventArgs e)
		{
			int id_TC = Int32.Parse(txtTC_ID.Text);
			string tenTC = txtTC_Ten.Text;
			string diachiTC = txtTC_DiaChi.Text;
			string email = txtTC_Email.Text;
			string sdt = txtTC_SDT.Text;
			int id_PH = (cbbTC_ThoiGian.SelectedItem as PhatHanh).IDPhatHanh;
            try
            {
                if (TapChiDAO.Instance.XoaTC(id_TC, tenTC, diachiTC, id_PH, email, sdt))
                {
                    MessageBox.Show("Xoá thành công", "Thông Báo");
                    LoadTableTapChi();
                }
                else
                {
                    MessageBox.Show("Xoá Thất Bại", "thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		#endregion

		#region Phát Hành

		public object PhatHanhList { get; private set; }
		BindingSource PhathanhList = new BindingSource();

		void LoadTablePhatHanh()
		{
			dgvPhatHanh.DataSource = PhathanhList;
			LoadPhatHanhOnDGV();
		}

		void LoadPhatHanhOnDGV()
		{
			string query = "USP_LoadPhatHanh";
			PhathanhList.DataSource = DataProvider.Instance.ExcuteQuery(query);
		}

        private void dgvPhatHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPhatHanh.Rows[e.RowIndex];
                txtPH_ID.Text = row.Cells[0].Value.ToString();
                txtPH_ThoiGian.Text = row.Cells[1].Value.ToString();
                txtPH_DienGiai.Text = row.Cells[2].Value.ToString();
              
            }
        }

        private void btnPH_Them_Click(object sender, EventArgs e)
		{
			int ID_PH = Int32.Parse(txtTL_ID.Text);
			string ThoiGian = txtPH_ThoiGian.Text;
			string DienGiai = txtPH_DienGiai.Text;

            try
            {
                if (PhatHanhDAO.Instance.ThemPhatHanh(ThoiGian, DienGiai))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadTablePhatHanh();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void btnPH_Sua_Click(object sender, EventArgs e)
		{
			int ID_PH = Int32.Parse(txtTL_ID.Text);
			string ThoiGian = txtPH_ThoiGian.Text;
			string DienGiai = txtPH_DienGiai.Text;

            try
            {
                if (PhatHanhDAO.Instance.CapNhatPhatHanh(ID_PH, ThoiGian, DienGiai))
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    LoadTablePhatHanh();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void btnPH_Xoa_Click(object sender, EventArgs e)
		{
			int ID_PH = Int32.Parse(txtTL_ID.Text);
			string ThoiGian = txtPH_ThoiGian.Text;
			string DienGiai = txtPH_DienGiai.Text;

            try
            {
                if (PhatHanhDAO.Instance.XoaPhatHanh(ID_PH, ThoiGian, DienGiai))
                {
                    MessageBox.Show("Xoá Thành Công", "Thông Báo");
                    LoadTablePhatHanh();
                }
                else
                {
                    MessageBox.Show("Xoá Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}


        private void btnPH_Xem_Click(object sender, EventArgs e)
        {
            LoadTablePhatHanh();
        }

        #endregion

        #region Nhà Báo
        public object NhaBaoList { get; private set; }
        BindingSource NhabaoList = new BindingSource();

        void LoadTableNhaBao()
        {
            dgvNhaBao.DataSource = NhabaoList;
            LoadNhaBaoOnDGV();
        }

        void LoadNhaBaoOnDGV()
        {
            txtTL_TenTL.Focus();
            string query = "USP_LoadNhaBao";
            NhabaoList.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void dgvNhaBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhaBao.Rows[e.RowIndex];
                txtNB_ID.Text = row.Cells[0].Value.ToString();
                txtNB_Ten.Text = row.Cells[1].Value.ToString();
                txtNB_ButHieu.Text = row.Cells[2].Value.ToString();
                txtNB_SDT.Text = row.Cells[3].Value.ToString();
                txtNB_Email.Text = row.Cells[4].Value.ToString();
                txtNB_DiaChi.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btbNB_Xem_Click(object sender, EventArgs e)
        {
            LoadTableNhaBao();
        }

        private void btnNB_Them_Click(object sender, EventArgs e)
        {
            string ten = txtNB_Ten.Text;
            string but = txtNB_ButHieu.Text;
            string sdt = txtNB_SDT.Text;
            string email = txtNB_Email.Text;
            string dc = txtNB_DiaChi.Text;

            try
            {
                if (reg.IsMatch(this.txtTC_Email.Text))
                {
                    if (NhaBaoDAO.Instance.ThemNhaBao(ten, but, sdt, email, dc))
                    {
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadTableNhaBao();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                    }
                }
                else MessageBox.Show("Sai Email", "Thông Báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNB_Sua_Click(object sender, EventArgs e)
        {
            string ten = txtNB_Ten.Text;
            string but = txtNB_ButHieu.Text;
            string sdt = txtNB_SDT.Text;
            string email = txtNB_Email.Text;
            string dc = txtNB_DiaChi.Text;
            try
            {
                if (NhaBaoDAO.Instance.SuaNhaBao(ten, but, sdt, email, dc))
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    LoadTableNhaBao();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông Báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNB_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtNB_ID.Text);
                if (NhaBaoDAO.Instance.XoaNhaBao(id))
                {
                    MessageBox.Show("Xoá Thành Công", "Thông Báo");
                    LoadTableNhaBao();
                }
                else
                {
                    MessageBox.Show("Xoá Thất Bại", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNB_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                // or(ID_NHABAO={0})
                string query = string.Format("select  ID_NHABAO as[ID Nhà Báo], TENNHABAO as[Tên Nhà Báo], BUTHIEU as[Bút Hiệu],   SDT_NB as[Số Điện Thoại], EMAIL_NB as[Email], DIACHI_NB as [Địa Chỉ] from NHABAO nb where (dbo.FuncConvert(nb.DIACHI_NB) like N'%'+ dbo.FuncConvert(N'{0}')+N'%') or (dbo.FuncConvert(BUTHIEU) like N'%'+ dbo.FuncConvert(N'{0}')+N'%') or (dbo.FuncConvert(TENNHABAO) like N'%'+ dbo.FuncConvert(N'{0}')+N'%') ", txtNB_Tim.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvNhaBao.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TaiKhoan
        public object TaiKhoanList { get; private set; }
        BindingSource taikhoanlist = new BindingSource();

        void LoadTableTaiKhoan()
        {
            dgvTK.DataSource = taikhoanlist;
            LoadTaiKhoanOnDGV();
        }

        void LoadTaiKhoanOnDGV()
        {
            txtTK_U.Focus();
            string query = "Select * from taiKhoan";
            taikhoanlist.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTK.Rows[e.RowIndex];
                txtTK_ID.Text = row.Cells[0].Value.ToString();
                txtTK_U.Text = row.Cells[1].Value.ToString();
                txtTK_P.Text = row.Cells[2].Value.ToString();
                txtTK_Dis.Text = row.Cells[3].Value.ToString();
                txtTK_Status.Text = row.Cells[4].Value.ToString();           
            }
        }

        private void btnTK_Them_Click(object sender, EventArgs e)
        {
            //int id = Int32.Parse(txtTK_ID.Text);
            string user = txtTK_U.Text;
            string pass = txtTK_P.Text;
            string dis = txtTK_Dis.Text;
            int status =  Convert.ToInt32(n_status.Value);
           try
            {
                if(TaiKhoanDAO.Instance.ThemTaiKhoan( user, pass, dis, status))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadTableTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTK_Sua_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtTK_ID.Text);
            string user = txtTK_U.Text;
            string pass = txtTK_P.Text;
            string dis = txtTK_Dis.Text;
            int status = Convert.ToInt32(n_status.Value);
            try
            {
                if (TaiKhoanDAO.Instance.CapNhatTaiKhoan(id, user, pass, dis, status))
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                    LoadTableTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTK_Xoa_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtTK_ID.Text);
            string user = txtTK_U.Text;
            string pass = txtTK_P.Text;
            string dis = txtTK_Dis.Text;
            int status = Convert.ToInt32(n_status.Value);
            try
            {
                if (TaiKhoanDAO.Instance.XoaTaiKhoan(id, user, pass, dis, status))
                {
                    MessageBox.Show("Xoá Thành Công", "Thông Báo");
                    LoadTableTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Xoá Thất Bại", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Events TEXTBOX
        public void txtTL_TenTL_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
            //Ctrl+ A textbox
        }

        private void txtTC_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //===========================THỂ LOẠI=======================================
        private void txtTL_TenTL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtTL_DienGiai.Focus();
            }
        }



        private void txtTL_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btnTL_Tim.PerformClick();
            }           
        }


        //==============================BÁO TẠP CHÍ===================================
        private void txtTC_Ten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtTC_DiaChi.Focus();
            }
        }

        private void txtTC_DiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtTC_Email.Focus();
            }
        }

        private void txtTC_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtTC_SDT.Focus();
            }
        }

        private void txtTC_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btnTC_Them.PerformClick();
            }
        }


        //============================== PHÁT HÀNH ======================================
        private void txtPH_ThoiGian_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtPH_DienGiai.Focus();
            }
        }

        private void txtPH_DienGiai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btnPH_Them.PerformClick();
            }
        }



        //============================== NHÀ BÁO ======================================
        private void txtNB_Ten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtNB_ButHieu.Focus();
            }
        }

        private void txtNB_ButHieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtNB_SDT.Focus();
            }
        }

        private void txtNB_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtNB_Email.Focus();
            }
        }

        private void txtNB_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                txtNB_DiaChi.Focus();
            }
        }


        private void cbbNB_Quyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btnNB_Them.PerformClick();
            }
        }




        //============================== QUYỀN ====================================== 


        private void txtTC_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTC_Tim.PerformClick();
            }
        }

        private void txtNB_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNB_Tim.PerformClick();
            }

        }



        #endregion

        private void txtTC_Email_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtTK_Status_TextChanged(object sender, EventArgs e)
        {
            int sta;
            if ( txtTK_Status.Text != null  )
            {
                Int32.TryParse("1", out sta);
                    txtTK_Status.Text = sta.ToString();           
            }            
        }
    }
}

