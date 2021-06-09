using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoChi.FORM
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBaoChi_DataSet_Report.USP_PR_PhatHanh' table. You can move, or remove it, as needed.
            this.uSP_PR_PhatHanhTableAdapter.Fill(this.quanLyBaoChi_DataSet_Report.USP_PR_PhatHanh);
            // TODO: This line of code loads data into the 'quanLyBaoChi_DataSet_Report.USP_RP_TheLoai' table. You can move, or remove it, as needed.
            this.uSP_RP_TheLoaiTableAdapter.Fill(this.quanLyBaoChi_DataSet_Report.USP_RP_TheLoai);
            // TODO: This line of code loads data into the 'quanLyBaoChi_DataSet_Report.UPS_RPNhaBao' table. You can move, or remove it, as needed.
            this.uPS_RPNhaBaoTableAdapter.Fill(this.quanLyBaoChi_DataSet_Report.UPS_RPNhaBao);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
