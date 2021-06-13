using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    public partial class FrmDuAn : Form
    {
        public FrmDuAn()
        {
            InitializeComponent();
        }
        string chuoi = "Server=MSI;Database=QLDA;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;
        private void FrmDuAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.CTYTHICONG' table. You can move, or remove it, as needed.
            this.cTYTHICONGTableAdapter.Fill(this.qLDADataSet.CTYTHICONG);
            // TODO: This line of code loads data into the 'qLDADataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.qLDADataSet.DUAN);
            DisplayData();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataQLDA.SelectedRows)
                {                   
                                con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM DUAN Where MADUAN = @MADUAN";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MADUAN", cellValue);
                    int n= cmd.ExecuteNonQuery();
                    con.Close();
                    DataQLDA.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                } 

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        private void DisplayData()
        {
            con = new SqlConnection(chuoi);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from DUAN", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            try {
                 con = new SqlConnection(chuoi);       
            if(tbxMDA.Text !="" && cbxCTTC.Text != "")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Update DUAN Set MACTTC = @CTTC,TENDUAN=@TDA,THANHPHO_DUAN =@TP,TGBD=@TBD,DUKIENHT=@DHT," +
                    "TGHT=@THT  Where MADUAN = @MA";
                DateTime tgbd = DateTTGBD.Value;
                DateTime dkht = DateTDKHT.Value;
                DateTime tgkt = DateTTGHT.Value;
                con.Open();
                cmd.Parameters.AddWithValue("@CTTC", cbxCTTC.Text);
                cmd.Parameters.AddWithValue("@MA",tbxMDA.Text );
                cmd.Parameters.AddWithValue("@TDA", tbxTDA.Text);
                cmd.Parameters.AddWithValue("@TP", tbxTP.Text);
                cmd.Parameters.AddWithValue("@TBD", tgbd);
                cmd.Parameters.AddWithValue("@DHT", dkht);
                cmd.Parameters.AddWithValue("@THT", tgkt);
                int n = cmd.ExecuteNonQuery(); 
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxMDA.Text != "" && cbxCTTC.Text != "")
                    {
                        con = new SqlConnection(chuoi);
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO DUAN (MADUAN,MACTTC,TENDUAN,THANHPHO_DUAN,TGBD,DUKIENHT,TGHT) " +
                            "VALUES (@MDA,@MCTTC,@TDA, @TP,@TGBD,@DKHT,@TGHT)";
                        DateTime tgbd = DateTTGBD.Value;
                        DateTime dkht = DateTDKHT.Value;
                        DateTime tgkt = DateTTGHT.Value;
                        con.Open();
                        cmd.Parameters.AddWithValue("@MCTTC", cbxCTTC.Text);
                        cmd.Parameters.AddWithValue("@MDA", tbxMDA.Text);
                        cmd.Parameters.AddWithValue("@TDA", tbxTDA.Text);
                        cmd.Parameters.AddWithValue("@TP", tbxTP.Text);
                        cmd.Parameters.AddWithValue("@TGBD", tgbd);
                        cmd.Parameters.AddWithValue("@DKHT", dkht);
                        cmd.Parameters.AddWithValue("@TGHT", tgkt);   
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Inserted Successfully");
                        DisplayData();
                    }
                    else
                    {
                    MessageBox.Show("Vui lòng Nhập Hết Thông tin");

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
            

        }

        private void tbxTKMDA_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select * from DUAN where MADUAN like '" + tbxTKMDA.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }

        private void DataQLDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DataQLDA.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                tbxMDA.Text = row.Cells[0].Value.ToString();
                cbxCTTC.Text = row.Cells[1].Value.ToString();
                tbxTDA.Text = row.Cells[2].Value.ToString();
                tbxTP.Text = row.Cells[3].Value.ToString();
                DateTime tgbd = DateTime.Parse(row.Cells[4].Value.ToString());
                DateTime dkht = DateTime.Parse(row.Cells[5].Value.ToString());
                DateTime tgkt = DateTime.Parse(row.Cells[6].Value.ToString());
                DateTDKHT.Value = dkht;
                DateTTGBD.Value = tgbd;
                DateTTGHT.Value = tgkt;
            }
        }
    }
}
