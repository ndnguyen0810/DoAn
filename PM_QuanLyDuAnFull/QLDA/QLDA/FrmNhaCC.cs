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
    public partial class FrmNhaCC : Form
    {
        public FrmNhaCC()
        {
            InitializeComponent();
        }
        string chuoi = "Server=MSI;Database=QLDA;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;
        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.NHACCAP' table. You can move, or remove it, as needed.
            this.nHACCAPTableAdapter.Fill(this.qLDADataSet.NHACCAP);
            DisplayData();
        }
        private void DisplayData()
        {
            con = new SqlConnection(chuoi);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from NHACCAP", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNCC.Text != "")
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO NHACCAP (MANCC,TENNCC,VON,THPHO,SDTNCC) " +
                        "VALUES (@MANCC,@TENNCC,@VON,@THPHO,@SDTNCC)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANCC", tbxNCC.Text);
                    cmd.Parameters.AddWithValue("@TENNCC", tbxTNCC.Text);
                    cmd.Parameters.AddWithValue("@VON", tbxVon.Text);
                    cmd.Parameters.AddWithValue("@THPHO", tbxTP.Text);
                    cmd.Parameters.AddWithValue("@SDTNCC", tbxSDTNCC.Text);
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
                if (tbxNCC.Text != "" )
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update NHACCAP Set TENNCC=@TENNCC,VON =@VON," +
                        "THPHO=@THPHO,SDTNCC=@SDTNCC Where MANCC = @MANCC";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANCC", tbxNCC.Text);
                    cmd.Parameters.AddWithValue("@TENNCC", tbxTNCC.Text);
                    cmd.Parameters.AddWithValue("@VON", tbxVon.Text);
                    cmd.Parameters.AddWithValue("@THPHO", tbxTP.Text);
                    cmd.Parameters.AddWithValue("@SDTNCC", tbxSDTNCC.Text);
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
            catch(Exception ex)
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
                    cmd.CommandText = "DELETE FROM NHACCAP Where MANCC = @MANCC";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANCC", cellValue);
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

        private void tbxSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

        }

        private void tbxVon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTKMNCC_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select * from NHACCAP where MANCC like '" + tbxTKMNCC.Text + "%'", con);
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
                tbxNCC.Text = row.Cells[0].Value.ToString();
                tbxTNCC.Text = row.Cells[1].Value.ToString();
                tbxVon.Text = row.Cells[2].Value.ToString();
                tbxTP.Text = row.Cells[3].Value.ToString();
                tbxSDTNCC.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
