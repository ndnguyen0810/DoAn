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
    public partial class frmLyDoVP : DevExpress.XtraEditors.XtraForm
    {
        public frmLyDoVP()
        {
            InitializeComponent();
        }

        private void frmLyDoVP_Load(object sender, EventArgs e)
        {
            string[] Lydo = {"Quá hạn","Mất sách","Hư hỏng tài liệu khổ 13x19", "Hư hỏng tài liệu khổ 17x24", "Hư hỏng tài liệu khổ 19x27" };
            foreach(string ld in Lydo)
            {
                cbbLydo.Properties.Items.Add(ld);
            }
        }

        public static string Lydo = "";

        private void btnChon_Click(object sender, EventArgs e)
        {
            if ((cbbLydo.EditValue == null) || (cbbLydo.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn lý do\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            Lydo =cbbLydo.SelectedItem.ToString();
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}