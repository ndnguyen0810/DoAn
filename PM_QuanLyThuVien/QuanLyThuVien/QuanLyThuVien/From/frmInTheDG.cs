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
    public partial class frmInTheDG : DevExpress.XtraEditors.XtraForm
    {
        public frmInTheDG()
        {
            InitializeComponent();
        }

        rpTheDocGia1 rpt = new rpTheDocGia1();
        private void frmInTheDG_Load(object sender, EventArgs e)
        {
            this.rpt = frmDocGia.rppm;
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}