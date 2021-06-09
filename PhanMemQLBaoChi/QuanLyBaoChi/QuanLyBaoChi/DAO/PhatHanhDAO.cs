using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
	public class PhatHanhDAO
	{
		private static PhatHanhDAO instance;

		public static PhatHanhDAO Instance
		{
			get { if (instance == null) instance = new PhatHanhDAO(); return PhatHanhDAO.instance; }
			private set => instance = value;
		}

		private PhatHanhDAO() { }

		public List<PhatHanh> GetListPhatHanh()
		{
			List<PhatHanh> PhatHanhList = new List<PhatHanh>();
			string query = "Select * from PhatHanh";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				PhatHanh PhatHanh = new PhatHanh(item);
				PhatHanhList.Add(PhatHanh);
			}
			return PhatHanhList;
		}

		public List<PhatHanh> GetTCByIDPhatHanh(int id)
		{
			List<PhatHanh> list = new List<PhatHanh>();

			string query = "select* from phathanh where id_PhatHanh = " + id;

			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				PhatHanh ph = new PhatHanh(item);
				list.Add(ph);
			}
			return list;
		}


		public PhatHanh GetPhatHanhByID(int id)
		{
			PhatHanh phathanh = null;

			string query = "select* from phathanh where id_PhatHanh = " + id;

			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				phathanh = new PhatHanh(item);
				return phathanh;
			}

			return phathanh;
		}

		public bool ThemPhatHanh(string timePH, string diengiaiPH)
		{
			string query = string.Format("INSERT INTO PhatHanh( [THOIGIANPH], [DIENGIAI_PH]) VALUES (N'{0}', N'{1}')", timePH, diengiaiPH);
			int resual = DataProvider.Instance.ExcuteNonQuery(query);
			return resual > 0;
		}

		public bool CapNhatPhatHanh(int id_TP, string timePH, string diengiaiPH)
		{
			string query = string.Format("UPDATE PhatHanh SET ID_PHATHANH={0}, THOIGIANPH = N'{1}', DIENGIAI_PH=N'{2}' WHERE ID_PHATHANH={0}", id_TP, timePH, diengiaiPH);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool XoaPhatHanh(int id_TP, string timePH, string diengiaiPH)
		{
			string query = string.Format("DELETE PhatHanh where ID_PHATHANH={0}", id_TP, timePH, diengiaiPH);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

	}
}
