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
    public partial class frmSachTrongThuVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSachTrongThuVien()
        {
            InitializeComponent();
        }
       

        private void frmSachTrongThuVien_Load(object sender, EventArgs e)
        {
           
            
        }

        private void gvSach_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {

        }
    }
}