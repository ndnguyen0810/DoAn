using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
	public class TapChiDAO
	{
		private static TapChiDAO instance;

		public static TapChiDAO Instance
		{
			get { if (instance == null) instance = new TapChiDAO(); return TapChiDAO.instance; }
			private set => instance = value;
		}

		private TapChiDAO() { }

		public List<BaoTapChi> GetListBaoTapChi()
		{
			List<BaoTapChi> BaoTapChiList = new List<BaoTapChi>();
			string query = "Select *from BaoTapChi";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				BaoTapChi BaoTapChi = new BaoTapChi(item);
				BaoTapChiList.Add(BaoTapChi);
			}
			return BaoTapChiList;
		}

        public List<BaiBao> GetListTapChiByNameInCombobox()
        {
            List<BaiBao> BaiBaoList = new List<BaiBao>();
            string query = "Select * from BaoTapChi";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BaiBao BaiBao = new BaiBao(item);
                BaiBaoList.Add(BaiBao);
            }
            return BaiBaoList;
        }

        public List<BaoTapChi> SeachTapChiByName(string name)
        {
            List<BaoTapChi> BaoTapChiList = new List<BaoTapChi>();

            string query = string.Format("select * from BaoTapChi where dbo.FuncConvert(TenTapChi) like N'%' + dbo.FuncConvert(N'{0}') +'%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BaoTapChi BaoTapChi = new BaoTapChi(item);
                BaoTapChiList.Add(BaoTapChi);
            }
            return BaoTapChiList;
        }


        public bool ThemTC(string tenTC, string dichiTC, int id_phathanh,string email_tc, string teL)
		{
			string query = string.Format("INSERT INTO BaoTApChi( [TENTAPCHI], [DIACHITC], [ID_PHATHANH], [EMAIL_TC], [SDT_TC]) VALUES (N'{0}', N'{1}',{2},N'{3}','{4}')", tenTC, dichiTC,id_phathanh,email_tc, teL);
			int resual = DataProvider.Instance.ExcuteNonQuery(query);
			return resual > 0;
		}

		public bool CapNhatTC(int id_TC, string tenTC, string dichiTC, int id_phathanh, string email_tc, string teL)
		{
			string query = string.Format("UPDATE BAOTAPCHI SET ID_TAPCHI={0}, TENTAPCHI = N'{1}', DIACHITC=N'{2}',ID_PHATHANH={3}, EMAIL_TC='{4}', SDT_TC= '{5}' WHERE ID_TAPCHI={0}", id_TC,tenTC, dichiTC, id_phathanh, email_tc, teL);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool XoaTC(int id_TC, string tenTC, string dichiTC, int id_phathanh, string email_tc, string teL)
		{
			string query = string.Format("DELETE BAOTAPCHI where ID_TAPCHI={0}", id_TC, tenTC, dichiTC, id_phathanh, email_tc, teL);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

	}
}
