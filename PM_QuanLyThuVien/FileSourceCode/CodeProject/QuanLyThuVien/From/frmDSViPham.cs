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
    public partial class frmDSViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmDSViPham()
        {
            InitializeComponent();
        }

        connection con = new connection();
        
        
        private void loadDGVP()
        {
            DataTable dt = con.readData("select MAPHAT, p.MAPM, pm.MADG, HOTEN,NGAYPHAT, p.TONGTIENPHAT from PHIEUPHAT p , DOCGIA d, " +
                "PHIEUMUON pm where p.MAPM = pm.MAPM and pm.MADG = d.MADG");
            if(dt!= null)
            {
                gcDG.DataSource = dt;
            }
        }
        private void loadCTVP()
        {
            DataTable dt = con.readData("select c.MASACH, LYDOPHAT, c.SOLUONG, DONVITINH, TIEN from ctpp c, SACH s where c.MASACH=s.MASACH");
            if (dt != null)
            {
                gcVP.DataSource = dt;
            }
        }

        private void frmDSViPham_Load(object sender, EventArgs e)
        {
            loadDGVP();
            loadCTVP();
        }

        private void gvDG_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int inde = gvDG.FocusedRowHandle;
            string madg = gvDG.GetRowCellValue(inde, gvDG.Columns[5]).ToString();
           
            if (madg != null)
            {
                loadPPClickDG(madg);
            }
            else
            {
                loadCTVP();
            }
        }

        private void loadPPClickDG(string madg)
        {
            DataTable dt = con.readData(string.Format("select c.MASACH, LYDOPHAT, c.SOLUONG, DONVITINH, TIEN from ctpp c, SACH s, PHIEUMUON p,PHIEUPHAT pp where c.MASACH=s.MASACH and p.MAPM=pp.MAPM and c.MAPHAT= pp.MAPHAT and p.MADG ='{0}'", madg));
            if (dt != null)
            {
                gcVP.DataSource = dt;
            }
        }
    }
}