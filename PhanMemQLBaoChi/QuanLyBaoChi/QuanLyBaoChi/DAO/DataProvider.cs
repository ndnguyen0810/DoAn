using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
	public class DataProvider
	{
		private static DataProvider instance;

		private string chuoikn = @"Data Source=admin\dinhnguyen;Initial Catalog=QuanLyBaoChi_New;Integrated Security=True";

		public static DataProvider Instance
		{
			get
			{
				if (instance == null)
					instance = new DataProvider();
				return DataProvider.instance;
			}
			private set { DataProvider.instance = value; }
		}
		private DataProvider() { }
		public DataTable ExcuteQuery(string query, object[] parameter = null)
		{
			DataTable data = new DataTable();

			using (SqlConnection conn = new SqlConnection(chuoikn))
			{
				conn.Open();

				SqlCommand cmd = new SqlCommand(query, conn);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							cmd.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				adapter.Fill(data);

				conn.Close();
			}
			return data;
		}


		public int ExcuteNonQuery(string query, object[] parameter = null) // trả về số dòng insert thành công
		{
			int data = 0;

			using (SqlConnection conn = new SqlConnection(chuoikn))
			{
				conn.Open();

				SqlCommand cmd = new SqlCommand(query, conn);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							cmd.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				data = cmd.ExecuteNonQuery();
				conn.Close();
			}

			return data;
		}


		public object ExcuteScalar(string query, object[] parameter = null) 
		{
			object data = 0;

			using (SqlConnection conn = new SqlConnection(chuoikn))
			{
				conn.Open();

				SqlCommand cmd = new SqlCommand(query, conn);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							cmd.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				data = cmd.ExecuteScalar();
				conn.Close();
			}

			return data;
		}
	}
}
