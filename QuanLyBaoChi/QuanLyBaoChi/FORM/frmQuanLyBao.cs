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
	public partial class frmQuanLyBao : Form
	{
		public frmQuanLyBao()
		{
			InitializeComponent();
            LoadTableBaiBao();
            LoadTableBaiViet();
            LoadTableBaiDang();
        }

        string chuoi = @"Data Source=admin\dinhnguyen;Initial Catalog=QuanLyBaoChi_New;Integrated Security=True";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;

        #region BaiBao
        public object BaiBaoList { get; private set; }
        BindingSource BaibaoList = new BindingSource();

        void LoadTableBaiBao()
        {
            dgvBaiBao.DataSource = BaibaoList;
            LoadBaiBaoOnDGV();
            LoadListTapChiInToComboBox(cbbBB_TapChi);
            LoadListTheLoaiInToCombobox(cbbBB_TL);
            LoadListBaiVietInToCombobox(cbbBB_IDBaiViet);
            LoadListNhaBaoInToCombobox(cbbBB_NguoiViet);
        }

        void LoadBaiBaoOnDGV()
        {
            string query = "USP_LoadBaiBao";
            BaibaoList.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }


        private void dgvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBaiBao.Rows[e.RowIndex];
                txtBB_ID.Text = row.Cells[0].Value.ToString();
                txtBB_TenBB.Text= row.Cells[1].Value.ToString();
                txtBB_NoiDung.Text = row.Cells[2].Value.ToString();
                dtpBB_NgayDang.Text = row.Cells[3].Value.ToString();
                cbbBB_TapChi.Text= row.Cells[4].Value.ToString();
                cbbBB_TL.Text = row.Cells[5].Value.ToString();
                cbbBB_NguoiViet.Text = row.Cells[6].Value.ToString();
                cbbBB_IDBaiViet.Text = row.Cells[7].Value.ToString();

            }
        }

        void LoadListTapChiInToComboBox(ComboBox cb)
        {
            cb.DataSource = TapChiDAO.Instance.GetListBaoTapChi();
            cb.DisplayMember = "TenTapChi";
        }

        void LoadListTheLoaiInToCombobox(ComboBox cb)
        {
            cb.DataSource = TheLoaiDAO.Instance.GetListTheLoai();
            cb.DisplayMember = "TenTheLoai";
        }

        void LoadListNhaBaoInToCombobox(ComboBox cb)
        {
            cb.DataSource = NhaBaoDAO.Instance.GetListNhaBao();
            cb.DisplayMember = "ButHieu";
        }

        void LoadListBaiVietInToCombobox(ComboBox cb)
        {
            cb.DataSource = BaiVietDAO.Instance.GetListBaiViet();
            cb.DisplayMember = "TenBaiViet";
        }

        private void cbbBB_TapChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            BaoTapChi selected = cb.SelectedItem as BaoTapChi;
            id = selected.IDTapChi;
        }

        private void cbbBB_TL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            TheLoai selected = cb.SelectedItem as TheLoai;
            id = selected.IDTheLoai;
        }

        private void cbbBB_NguoiViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            NhaBao selected = cb.SelectedItem as NhaBao;
            id = selected.IDNhaBao;
        }

        private void cbbBB_IDBaiViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            BaiViet selected = cb.SelectedItem as BaiViet;
            id = selected.IDBaiViet;
        }

        private void dtpBB_NgayDang_ValueChanged(object sender, EventArgs e)
        {
            DateTime dati = dtpBB_NgayDang.Value;
        }

        private void btnBB_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtBB_TenBB.Text;
                string nd = txtBB_NoiDung.Text;
                string time = dtpBB_NgayDang.Text;
                int tc = (cbbBB_TapChi.SelectedItem as BaoTapChi).IDTapChi;
                int tl = (cbbBB_TL.SelectedItem as TheLoai).IDTheLoai;
                int nv = (cbbBB_NguoiViet.SelectedItem as NhaBao).IDNhaBao;
                int bv = (cbbBB_IDBaiViet.SelectedItem as BaiViet).IDBaiViet;

                if (BaiBaoDAO.Instance.ThemBaiBao(name, nd, time, tc, tl, nv, bv))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadTableBaiBao();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBB_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                int idbb = Int32.Parse(txtBB_ID.Text);
                string name = txtBB_NoiDung.Text;
                string nd = txtBB_NoiDung.Text;
                string time = dtpBB_NgayDang.Text;
                int tc = (cbbBB_TapChi.SelectedItem as BaoTapChi).IDTapChi;
                int tl = (cbbBB_TL.SelectedItem as TheLoai).IDTheLoai;
                int nv = (cbbBB_NguoiViet.SelectedItem as NhaBao).IDNhaBao;
                int bv = (cbbBB_IDBaiViet.SelectedItem as BaiViet).IDBaiViet;

                if (BaiBaoDAO.Instance.SuaBaiBao(idbb, name, nd, time, tc, tl, nv, bv))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    LoadTableBaiBao();
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

        private void btnBB_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idbb = Int32.Parse(txtBB_ID.Text);
                if (BaiBaoDAO.Instance.XoaBaiBao(idbb))
                {
                    MessageBox.Show("Xoá thành công", "Thông Báo");
                    LoadTableBaiBao();
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

        private void btnBB_Xem_Click(object sender, EventArgs e)
        {
            LoadTableBaiBao();
        }

        private void btnBB_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = string.Format("select ID_BAIBAO as [ID Bài Báo], TENBAIBAO as [Tên Bài Báo], NOIDUNGCHINH as [Nội Dung Chính], NGAYDANG as [Ngày Đăng Bài], btc.TENTAPCHI as [Báo Tạp Chí], tl.TENTHELOAI as [Thể Loại], nb.BUTHIEU as [Bút Hiệu], bv.ID_BAIVIET as [ID Bài Viết] " +
                    "from BAOTAPCHI as btc, THELOAI as tl, NHABAO as nb, BAIVIET as bv, BAIBAO as bb " +
                    "where btc.ID_TAPCHI= bb.ID_TAPCHI and tl.ID_THELOAI = bb.ID_THELOAI and nb.ID_NHABAO = bb.ID_NHABAO and bv.ID_BAIVIET = bb.ID_BAIVIET " +
                    "and (dbo.FuncConvert(bb.TenBaiBao) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' " +
                    "or dbo.FuncConvert(bb.NOIDUNGCHINH) like N'%'+ dbo.FuncConvert(N'{0}')+N'%'" +
                    "or dbo.FuncConvert(btc.TENTAPCHI) like N'%'+ dbo.FuncConvert(N'{0}')+N'%'" +
                    "or dbo.FuncConvert(tl.TENTHELOAI) like N'%'+ dbo.FuncConvert(N'{0}')+N'%'" +
                    "or dbo.FuncConvert(nb.BUTHIEU) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' " +
                    "or bb.id_BaiBao={0} or bv.id_baiViet={0})", txtBB_Tim.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvBaiBao.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region BaiViet
        public object BaiVietList { get; private set; }
        BindingSource BaivietList = new BindingSource();

        void LoadTableBaiViet()
        {
            dgvBaiViet.DataSource = BaivietList;
            LoadBaiVietOnDGV();
         
            LoadListNhaBaoInToCombobox(cbbBV_TacGia);
        }

        void LoadBaiVietOnDGV()
        {
            //txtBB_TenBB.Focus();
            string query = "USP_LoadBaiViet";
            BaivietList.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void dgvBaiViet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBaiViet.Rows[e.RowIndex];
                txtBV_ID.Text = row.Cells[0].Value.ToString();
                txtBV_TenBV.Text = row.Cells[1].Value.ToString();
                txtBV_NDC.Text = row.Cells[2].Value.ToString();
                dtpBV_NgayViet.Text = row.Cells[3].Value.ToString();
                cbbBV_TacGia.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dtpBV_NgayViet_ValueChanged(object sender, EventArgs e)
        {
            DateTime dati = dtpBV_NgayViet.Value;
        }

        private void btnBV_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtBV_NDC.Text;
                string nd = txtBV_NDC.Text;
                string time = dtpBV_NgayViet.Text;
                int tg = (cbbBV_TacGia.SelectedItem as NhaBao).IDNhaBao;

                if (BaiVietDAO.Instance.ThemBaiViet(name, nd, time, tg))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadTableBaiViet();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBV_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtBV_ID.Text);
                string name = txtBV_NDC.Text;
                string nd = txtBV_NDC.Text;
                string time = dtpBV_NgayViet.Text;
                int tg = (cbbBV_TacGia.SelectedItem as NhaBao).IDNhaBao;

                if (BaiVietDAO.Instance.SuaBaiViet(id, name, nd, time, tg))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    LoadTableBaiViet();
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

        private void btnBV_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtBV_ID.Text);
                string name = txtBV_NDC.Text;
                string nd = txtBV_NDC.Text;
                string time = dtpBV_NgayViet.Text;
                int tg = (cbbBV_TacGia.SelectedItem as NhaBao).IDNhaBao;
                if (BaiVietDAO.Instance.XoaBaiViet(id, name, nd, time, tg))
                {
                    MessageBox.Show("Xoá thành công", "Thông Báo");
                    LoadTableBaiViet();
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

        private void btnBV_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = string.Format("select ID_BAIVIET as[ID Bài Viết], TENBAIVIET as[Tên Bài Viết], NOIDUNG_BV as[Nội Dung Chính],  NGAYVIET as[Ngày Viết Bài], nb.BUTHIEU as[Tác Giả] from BAIVIET as bv, NHABAO as nb " +
                    "where bv.ID_BAIVIET= nb.ID_NHABAO and ( dbo.FuncConvert(bv.TenBaiViet) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or dbo.FuncConvert(nb.tennhabao) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or dbo.FuncConvert( bv.NOIDUNG_BV) like N'%'+ dbo.FuncConvert(N'{0}')+N'%')", txtBV_Tim.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvBaiViet.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bai Dang
        public object BaiDangList { get; private set; }
        BindingSource BaidangList = new BindingSource();

        void LoadTableBaiDang()
        {
            dgvBaiDang.DataSource = BaidangList;
            LoadBaiDangOnDGV();
            LoadListTapChiInToComboBox(cbbBD_TC);
            LoadListTenBaiBaoInToComboBox(cbbBD_Name);
        }

        void LoadBaiDangOnDGV()
        {
            string query = "USP_LoadBaiDang";
            BaidangList.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        void LoadListTenBaiBaoInToComboBox(ComboBox cb)
        {
            cb.DataSource = BaiBaoDAO.Instance.GetListBaiBao();
            cb.DisplayMember = "TenBaiBao";
        }
        
        private void cbbBD_TC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            BaoTapChi selected = cb.SelectedItem as BaoTapChi;
            id = selected.IDTapChi;
        }

        private void cbbBD_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            BaiBao selected = cb.SelectedItem as BaiBao;
            id = selected.IDBaiBao;
        }

        private void btnBD_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (cbbBD_Name.SelectedItem as BaiBao).IDBaiBao;
                int trang = Int32.Parse(txtBD_Trang.Text);
                int idtc = (cbbBD_TC.SelectedItem as BaoTapChi).IDTapChi;

                if (BaiDangDAO.Instance.ThemBaiDang(id, idtc, trang))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadTableBaiDang();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBD_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (cbbBD_Name.SelectedItem as BaiBao).IDBaiBao;
                int trang = Int32.Parse(txtBD_Trang.Text);
                int idtc = (cbbBD_TC.SelectedItem as BaoTapChi).IDTapChi;

                if (BaiDangDAO.Instance.SuaBaiDang(id, idtc, trang))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    LoadTableBaiDang();
                }
                else
                {
                    MessageBox.Show("sửa Thất Bại", "thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBD_Xoa_Click(object sender, EventArgs e)
        {
            try {
                int id = (cbbBD_Name.SelectedItem as BaiBao).IDBaiBao;
                int trang = Int32.Parse(txtBD_Trang.Text);
                int idtc = (cbbBD_TC.SelectedItem as BaoTapChi).IDTapChi;
                if (BaiDangDAO.Instance.XoaBaiDang(id, idtc, trang))
                {
                    MessageBox.Show("Xoá thành công", "Thông Báo");
                    LoadTableBaiDang();
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

        private void btnBD_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                con.Open();
                string query = string.Format("select  bb.TENBAIBAO as [Tên Bài Báo],btc.TENTAPCHI as[Tên Tạp Chí],bd.VITRITRANG as[Vị Trí Trang] from BAOTAPCHI as btc, BAIBAO as bb, BAIDANG as bd where bb.ID_BAIBAO = bd.ID_BAIBAO  and btc.ID_TAPCHI = bd.ID_TAPCHI and (dbo.FuncConvert(bb.TENBAIBAO) like N'%'+ dbo.FuncConvert(N'{0}')+N'%' or  dbo.FuncConvert(btc.TENTAPCHI) like N'%'+ dbo.FuncConvert(N'{0}')+N'%')", txtBD_Tim.Text);
                adapt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dgvBaiDang.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #endregion


        private void btnBD_Xem_Click(object sender, EventArgs e)
        {
            LoadTableBaiDang();
        }

        private void btnBV_Xem_Click(object sender, EventArgs e)
        {
            LoadTableBaiViet();
        }

        private void frmQuanLyBao_Load(object sender, EventArgs e)
        {
            dtpBB_NgayDang.Format = DateTimePickerFormat.Short;
        }

        private void dgvBaiDang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBaiDang.Rows[e.RowIndex];
                cbbBD_Name.Text = row.Cells[0].Value.ToString();
                cbbBD_TC.Text = row.Cells[1].Value.ToString();
                txtBD_Trang.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtBB_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBB_Tim.PerformClick();
            }
        }

        private void txtBV_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBV_Tim.PerformClick();
            }
        }

        private void txtBD_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBD_Tim.PerformClick();
            }
        }
    }
}
