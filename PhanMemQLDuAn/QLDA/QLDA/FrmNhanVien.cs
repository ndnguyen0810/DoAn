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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
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
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from NHANVIEN", con);
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
                    cmd.CommandText = "DELETE FROM NHANVIEN Where MANV = @MANV";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANV", cellValue);
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
                if (tbxMNV.Text != "" && cbxMDA.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update DUAN Set MADUAN = @MADUAN,TENNV=@TENNV,NAMSINH =@NAMSINH,SDTNV=@SDTNV," +
                        "DIACHINV=@DIACHINV  Where MANV = @MANV";
                    DateTime ns = DateTNamSinh.Value;
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANV", tbxMNV.Text);
                    cmd.Parameters.AddWithValue("@MADUAN", cbxMDA.Text);
                    cmd.Parameters.AddWithValue("@TENNV", tbxTNV.Text);
                    cmd.Parameters.AddWithValue("@NAMSINH", ns);
                    cmd.Parameters.AddWithValue("@SDTNV", tbxSDTNV.Text);
                    cmd.Parameters.AddWithValue("@DIACHINV", tbxDiaChi.Text);
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
                if (tbxMNV.Text != "" && cbxMDA.Text != "")
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO NHANVIEN (MANV,MADUAN,TENNV,NAMSINH,SDTNV,DIACHINV) " +
                        "VALUES (@MANV,@MADUAN,@TENNV, @NAMSINH,@SDTNV,@DIACHINV)";
                    DateTime ns = DateTNamSinh.Value;
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANV", tbxMNV.Text);
                    cmd.Parameters.AddWithValue("@MADUAN", cbxMDA.Text);
                    cmd.Parameters.AddWithValue("@TENNV", tbxTNV.Text);
                    cmd.Parameters.AddWithValue("@NAMSINH", ns);
                    cmd.Parameters.AddWithValue("@SDTNV", tbxSDTNV.Text);
                    cmd.Parameters.AddWithValue("@DIACHINV", tbxDiaChi.Text);
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

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.qLDADataSet.DUAN);
            // TODO: This line of code loads data into the 'qLDADataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLDADataSet.NHANVIEN);
            DisplayData();
        }

        private void DataQLDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DataQLDA.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                tbxMNV.Text = row.Cells[0].Value.ToString();
                cbxMDA.Text = row.Cells[1].Value.ToString();
                tbxTNV.Text = row.Cells[2].Value.ToString();
                tbxSDTNV.Text = row.Cells[4].Value.ToString();
                DateTime ns = DateTime.Parse(row.Cells[3].Value.ToString());
                tbxDiaChi.Text = row.Cells[5].Value.ToString();
                DateTNamSinh.Value = ns;
            }
        }

        private void tbxTKMNV_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoi);
            con.Open();
            adapt = new SqlDataAdapter("select * from NHANVIEN where MANV like '" + tbxTKMNV.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
    }
}
