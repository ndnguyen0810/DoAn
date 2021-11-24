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
    public partial class frmDocGiaDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGiaDangMuon()
        {
            InitializeComponent();
        }

        public static rpDocGiaDangMuon rps = new rpDocGiaDangMuon();

        private void frmDocGiaDangMuon_Load(object sender, EventArgs e)
        {
          
            documentViewer1.PrintingSystem = rps.PrintingSystem;
            rps.CreateDocument();
            
        }

        
    }
}