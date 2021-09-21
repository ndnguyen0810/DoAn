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
    public partial class frmDatePitker : DevExpress.XtraEditors.XtraForm
    {
        public frmDatePitker()
        {
            InitializeComponent();
        }

        public static string date = "";
        private void frmDatePitker_Load(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if ((txtHanTra.EditValue == null) || (txtHanTra.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày hẹn trả sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDateTime(txtHanTra.EditValue.ToString()).CompareTo(DateTime.Now.Date) < 0)
            {
                XtraMessageBox.Show("Ngày hẹn trả sách không được nhỏ hơn ngày hiện tại\r\nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            date = txtHanTra.EditValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHUy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}