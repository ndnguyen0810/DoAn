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
    public partial class FrmCungCap : Form
    {
        public FrmCungCap()
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
            adapt = new SqlDataAdapter("select * from CUNGCAP", con);
            adapt.Fill(dt);
            DataQLDA.DataSource = dt;
            con.Close();
        }
        private void FrmCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDADataSet.CUNGCAP' table. You can move, or remove it, as needed.            // TODO: This line of code loads data into the 'qLDADataSet.NHACCAP' table. You can move, or remove it, as needed.
            this.nHACCAPTableAdapter.Fill(this.qLDADataSet.NHACCAP);
            // TODO: This line of code loads data into the 'qLDADataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.qLDADataSet.DUAN);
            // TODO: This line of code loads data into the 'qLDADataSet.CUNGCAP' table. You can move, or remove it, as needed.
            this.cUNGCAPTableAdapter.Fill(this.qLDADataSet.CUNGCAP);
            DisplayData();
        }
    
        private void DataQLDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DataQLDA.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                cbxMNCC.Text = row.Cells[0].Value.ToString();
                cbxMDA.Text = row.Cells[1].Value.ToString();
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
                    cmd.CommandText = "DELETE FROM CUNGCAP Where MAHANG = @MAHANG and MADUAN = @MADUAN";
                    string cellValue = Convert.ToString(row.Cells[0].Value);
                    string cellValue1 = Convert.ToString(row.Cells[1].Value);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MAHANG", cellValue);
                    cmd.Parameters.AddWithValue("@MADUAN", cellValue);
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
                if (cbxMNCC.Text != "" & cbxMDA.Text !="")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update CUNGCAP Set MADUAN = @MADUAN" +
                        " Where MANCC=@MANCC ";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANCC", cbxMNCC.Text);
                    cmd.Parameters.AddWithValue("@MADUAN", cbxMDA.Text);
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
                if (cbxMNCC.Text != "" &cbxMDA.Text != "")
                {
                    con = new SqlConnection(chuoi);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO CUNGCAP (MANCC,MADUAN) " +
                        "VALUES (@MANCC,@MADUAN)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@MANCC", cbxMNCC.Text);
                    cmd.Parameters.AddWithValue("@MADUAN", cbxMDA.Text);
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
            BindingSource bs = new BindingSource();
            bs.DataSource = DataQLDA.DataSource;
            bs.Filter = "MANCC like '" + tbxTKMNCC.Text + "%' AND  MADUAN like '" + tbxTKMDA.Text + "%'";
            DataQLDA.DataSource = bs;
        }
    }
}
