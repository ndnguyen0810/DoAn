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
using DevExpress.XtraCharts;

namespace QuanLyThuVien.From
{
    public partial class frmBieuDo1 : DevExpress.XtraEditors.XtraForm
    {
        public frmBieuDo1()
        {
            InitializeComponent();
        }

        private void frmBieuDo1_Load(object sender, EventArgs e)
        {

            
        }

        connection con = new connection();

        void BieuDoLine(DateTime dt_start, DateTime dt_finelly) // 12 - 11
        {
           // chartControl1 chartControl1 = new chartControl1();

            // Create a line series.
            Series DocGia = new Series("Đọc giả", ViewType.Line);
            Series ViPham = new Series("Vi Phạm", ViewType.Line);
            Series SachMuon = new Series("Sách đang mượn", ViewType.Line);

            int result_time = dt_finelly.Month - dt_start.Month;
            for (int i = dt_start.Month; i <= dt_finelly.Month; i++)
            {
                 
                int cmd1 = con.ExSCL(string.Format("select count(p.soluong) from CTPM c, PHIEUMUON p where c.MAPM= p.MAPM and MONTH(NGAYMUON)= {0} and c.TRANGTHAI=N'Đang mượn'", i)); //số lương sách mượn/ nagyf
                int cmd2 = con.ExSCL(string.Format("select COUNT(*) from PHIEUMUON where TRANGTHAI =N'Đang mượn' and MONTH(ngaymuon)={0}", i));
                int cmd3 = con.ExSCL(string.Format("select COUNT(*) from PHIEUPHAT where  MONTH(NGAYPHAT)={0}", i));
                DocGia.Points.Add(new SeriesPoint(i, cmd1)); 
                SachMuon.Points.Add(new SeriesPoint(i, cmd2)); 
                ViPham.Points.Add(new SeriesPoint(i, cmd3));

            }
            chartControl1.Series.Clear();
            chartControl1.Series.Add(DocGia);
            chartControl1.Series.Add(ViPham);
            chartControl1.Series.Add(SachMuon);

            DocGia.ArgumentScaleType = ScaleType.Numerical;
            // Access the view-type-specific options of the series.
            ((LineSeriesView)DocGia.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)DocGia.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)DocGia.View).LineStyle.DashStyle = DashStyle.Dash;
            ((LineSeriesView)ViPham.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)ViPham.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)ViPham.View).LineStyle.DashStyle = DashStyle.Dash;

            ((LineSeriesView)SachMuon.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)SachMuon.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)SachMuon.View).LineStyle.DashStyle = DashStyle.Dash;

            // Access the type-specific options of the diagram.
            ((XYDiagram)chartControl1.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary).
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add a title to the chart (if necessary).
            chartControl1.Titles.Add(new ChartTitle());
            chartControl1.Titles[0].Text = "GIÁ TRỊ GIA TĂNG THEO THÁNG";

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(chartControl1);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Parse(dtpS.DateTime.ToString("dd/MM/yyyy")),
              d2 = DateTime.Parse(dtpE.DateTime.ToString("dd/MM/yyyy"));
            BieuDoLine(d1, d2);


        }
    }
}