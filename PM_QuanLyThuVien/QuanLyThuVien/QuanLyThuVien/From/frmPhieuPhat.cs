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
using QuanLyThuVien.Report;

namespace QuanLyThuVien.From
{
    public partial class frmPhieuPhat : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuPhat()
        {
            InitializeComponent();
        }
        rpPhieuPhat rpt = new rpPhieuPhat();
        private void frmPhieuPhat_Load(object sender, EventArgs e)
        {

            this.rpt = frmViPham.rppm;
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}