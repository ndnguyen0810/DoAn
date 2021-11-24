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
    public partial class frmSachDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmSachDangMuon()
        {
            InitializeComponent();
        }

        public static rpSachDangMuon rps = new rpSachDangMuon();
        private void frmSachDangMuon_Load(object sender, EventArgs e)
        {
           
            documentViewer1.PrintingSystem = rps.PrintingSystem;
            rps.CreateDocument();
        }
    }
}