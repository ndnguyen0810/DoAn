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
    public partial class FrmHangHoa : Form
    {
        public FrmHangHoa()
        {
            InitializeComponent();
        }
        string chuoi = "Server=MSI;Database=QLDA;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection con;
        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.NHACCAP' table. You can move, or remove it, as needed.
            this.nHACCAPTableAdapter.Fill(this.qLDADataSet.NHACCAP);
            // TODO: This line of code loads data into the 'qLDADataSet.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.qLDADataSet.HANGHOA);
            DisplayData();
        }
        private void DisplayData()
        {
            con = new SqlConnection(chuoi);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from HANGHOA", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataQLDA.SelectedRows)
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM HANGHOA Where MAHANG = @MAHANG";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MAHANG", cellValue);
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
                if (tbxMHH.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update CTYTHICONG Set MANCC=@MANCC,TENHANG = @TENHANG,MAU=@MAU," +
                        "TRONGLUONG=@TRONGLUONG Where MAHANG = @MAHANG";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANCC", cbxMNCC.Text);
                    cmd.Parameters.AddWithValue("@TENHANG", tbxTHH.Text);
                    cmd.Parameters.AddWithValue("@MAU", tbxMau.Text);
                    cmd.Parameters.AddWithValue("@TRONGLUONG", tbxTrongLuong.Text);
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
                if (tbxMHH.Text != "")
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO CTYTHICONG (MAHANG,MANCC,TENHANG,MAU,TRONGLUONG) " +
                        "VALUES (@MAHANG,@MANCC,@TENHANG,@MAU,@TRONGLUONG)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MAHANG", tbxMHH.Text);
                    cmd.Parameters.AddWithValue("@MANCC", cbxMNCC.Text);
                    cmd.Parameters.AddWithValue("@TENHANG", tbxTHH.Text);
                    cmd.Parameters.AddWithValue("@MAU", tbxMau.Text);
                    cmd.Parameters.AddWithValue("@TRONGLUONG", tbxTrongLuong.Text);
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

        private void tbxTKMHH_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select * from HANGHOA where MAHANG like '" + tbxTKMHH.Text + "%'", con);
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
                tbxMHH.Text = row.Cells[0].Value.ToString();
                cbxMNCC.Text = row.Cells[1].Value.ToString();
                tbxTHH.Text = row.Cells[2].Value.ToString();
                tbxMau.Text = row.Cells[3].Value.ToString();
                tbxTrongLuong.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
