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
    public partial class FrmCungUng : Form
    {
        public FrmCungUng()
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
            adapt = new SqlDataAdapter("select * from CUNGUNG", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void FrmCungUng_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.CUNGUNG' table. You can move, or remove it, as needed.
            this.cUNGUNGTableAdapter.Fill(this.qLDADataSet.CUNGUNG);
            // TODO: This line of code loads data into the 'qLDADataSet.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.qLDADataSet.HANGHOA);
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
                    cmd.CommandText = "DELETE FROM CUNGUNG Where STT = @STT";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@STT", cellValue);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(chuoi);
                if (tbxSTT.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update CUNGUNG Set MADUAN = @MADUAN,MAHANG = @MAHANG,SOLUONG = @SOLUONG" +
                        " Where STT=@STT ";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MAHANG", cbxMHH.Text);
                    cmd.Parameters.AddWithValue("@MADUAN", cbxMDA.Text);
                    cmd.Parameters.AddWithValue("@SOLUONG", tbxSoLuong.Text);
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
                if (tbxSTT.Text != "")
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO CUNGUNG (STT,MAHANG,MADUAN,SOLUONG) " +
                        "VALUES (@STT,@MAHANG,@MADUAN,@SOLUONG)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MAHANG", cbxMHH.Text);
                    cmd.Parameters.AddWithValue("@MADUAN", cbxMDA.Text);
                    cmd.Parameters.AddWithValue("@SOLUONG", tbxSoLuong.Text);
                    cmd.Parameters.AddWithValue("@STT", tbxSTT.Text);
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
        private void DataFilter(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select * from CUNGUNG where STT like '" + tbxTKSTT.Text + "%'", con);
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
                tbxSTT.Text = row.Cells[0].Value.ToString();
                cbxMHH.Text = row.Cells[1].Value.ToString();
                cbxMDA.Text = row.Cells[2].Value.ToString();
                tbxSoLuong.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
