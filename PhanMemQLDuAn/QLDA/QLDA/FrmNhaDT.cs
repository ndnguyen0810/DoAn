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
    public partial class FrmNhaDT : Form
    {
        public FrmNhaDT()
        {
            InitializeComponent();
        }
        string chuoi = "Server=MSI;Database=QLDA;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;
        private void FrmNhaDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.NHADAUTU' table. You can move, or remove it, as needed.
            this.nHADAUTUTableAdapter.Fill(this.qLDADataSet.NHADAUTU);
            DisplayData();
        }
        private void DisplayData()
        {
            con = new SqlConnection(chuoi);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from NHADAUTU", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNDT.Text != "" )
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO NHADAUTU (MANDT,TENNDT,SOTIEN) " +
                        "VALUES (@MANDT,@TNDT,@ST)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANDT", tbxNDT.Text);
                    cmd.Parameters.AddWithValue("@TNDT", tbxTNDT.Text);
                    cmd.Parameters.AddWithValue("@ST", tbxSOTIEN.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Vui lòng Nhập Hết Thông tin");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                if (tbxNDT.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update NHADAUTU Set TENNDT=@TNDT,SOTIEN =@ST " +
                        "Where MANDT = @MANDT";              
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANDT", tbxNDT.Text);
                    cmd.Parameters.AddWithValue("@TNDT", tbxTNDT.Text);
                    cmd.Parameters.AddWithValue("@ST", tbxSOTIEN.Text);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataQLDA.SelectedRows)
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM NHADAUTU Where MANDT = @MANDT";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANDT", cellValue);
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    DataQLDA.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbxTKMNDT_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select * from NHADAUTU where MANDT like '" + tbxTKMNDT.Text + "%'", con);
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
                tbxNDT.Text = row.Cells[0].Value.ToString();
                tbxTNDT.Text = row.Cells[1].Value.ToString();
                tbxSOTIEN.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
