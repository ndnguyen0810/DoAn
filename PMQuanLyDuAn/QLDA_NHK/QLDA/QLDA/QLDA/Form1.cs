using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace QLDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoi = "Server=MSI;Database=QLDA;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;
        private void DisplayData()
        {
            con = new SqlConnection(chuoi);
            con.Open();
            dt = new DataTable();
            adapt = new SqlDataAdapter("select da.MADUAN,da.TENDUAN,da.THANHPHO_DUAN,ct.TENCTTC,da.TGBD,da.DUKIENHT,da.TGHT,nv.TENNV,ndt.TENNDT from DUAN da, CTYTHICONG ct, NHANVIEN nv, NHADAUTU ndt, DAUTU dt where da.MACTTC = ct.MACTTC and nv.MADUAN = da.MADUAN and dt.MADUAN = da.MADUAN and ndt.MANDT = dt.MANDT", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void tbxTKMDA_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select da.MADUAN,da.TENDUAN,da.THANHPHO_DUAN,ct.TENCTTC,da.TGBD,da.DUKIENHT,da.TGHT,nv.TENNV,ndt.TENNDT from DUAN da, CTYTHICONG ct, NHANVIEN nv, NHADAUTU ndt, DAUTU dt where da.MACTTC = ct.MACTTC and nv.MADUAN = da.MADUAN and dt.MADUAN = da.MADUAN and ndt.MANDT = dt.MANDT and da.MADUAN like '" + tbxTKMDA.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }

        private void TolDA_Click(object sender, EventArgs e)
        {
            FrmDuAn frm = new FrmDuAn();
            frm.Show();
        }

        private void TolNCC_Click(object sender, EventArgs e)
        {
            FrmNhaCC frm = new FrmNhaCC();
            frm.Show();
        }

        private void TolCTTC_Click(object sender, EventArgs e)
        {
            FrmCTTC frm = new FrmCTTC();
            frm.Show();
        }

        private void TolNDT_Click(object sender, EventArgs e)
        {
            FrmNhaDT frm = new FrmNhaDT();
            frm.Show();
        }

        private void TolHH_Click(object sender, EventArgs e)
        {
            FrmHangHoa frm = new FrmHangHoa();
            frm.Show();
        }

        private void TolNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
        }

        private void TolCC_Click(object sender, EventArgs e)
        {
            FrmCungCap frm = new FrmCungCap();
            frm.Show();
        }

        private void TolDT_Click(object sender, EventArgs e)
        {
            FrmDauTu frm = new FrmDauTu();
            frm.Show();
        }

        private void TolCU_Click(object sender, EventArgs e)
        {
            FrmCungUng frm = new FrmCungUng();
            frm.Show();
        }
        private void copyAlltoClipboard()
        {
            DataQLDA.SelectAll();
            DataObject dataObj = DataQLDA.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void TolBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 0; i < DataQLDA.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = DataQLDA.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < DataQLDA.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataQLDA.Columns.Count; j++)
                        {
                            if (DataQLDA.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = DataQLDA.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
