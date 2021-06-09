using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
    public class BaiBaoDAO
    {
       private static BaiBaoDAO instance;

		public static BaiBaoDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new BaiBaoDAO();
				return BaiBaoDAO.instance;
			}

			private set => instance = value;
		}

		private BaiBaoDAO() { }

		public List<BaiBao> GetListBaiBao()
		{
			List<BaiBao> BaiBaolist = new List<BaiBao>();
			string query = "select * from BaiBao";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			foreach(DataRow item in data.Rows)
			{
				BaiBao BaiBao = new BaiBao(item);
				BaiBaolist.Add(BaiBao);
			}

			return BaiBaolist;
		}



        public List<BaiBao> ThongKeBaiBao(string start, string end)
        {
            List<BaiBao> BaiBaolist = new List<BaiBao>();
            string query = string.Format("select * from BaiBao where NGAYDANG >= '{0}' and ngaydang<='{1}'", start, end);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BaiBao BaiBao = new BaiBao(item);

                BaiBaolist.Add(BaiBao);
            }

            return BaiBaolist;
        }



        public bool ThemBaiBao(string ten, string nd, string time, int idtc, int istl, int idnb, int idbv )
		{
			string query = string.Format("INSERT INTO BaiBao( [TenBaiBao],[NOIDUNGCHINH], [NGAYDANG], [ID_TAPCHI], [ID_THELOAI],[ID_NHABAO],[ID_BAIVIET]) VALUES ( N'{0}',N'{1}',N'{2}',{3},{4},{5},{6})", ten, nd, time,  idtc,  istl,  idnb,  idbv);
			int resual = DataProvider.Instance.ExcuteNonQuery(query);
			return resual > 0;
		}

		public bool SuaBaiBao(int idbb, string ten, string nd, string time, int idtc, int istl, int idnb, int idbv)
		{
			string query = string.Format("UPDATE BaiBao SET ID_BaiBao = {0}, TenBaiBao = N'{1}',NOIDUNGCHINH=N'{2}' , NGAYDANG=N'{3}', ID_TAPCHI={4}, ID_THELOAI={5},ID_NHABAO={6},ID_BAIVIET={7} where ID_BaiBao={0}", idbb, ten, nd, time, idtc, istl, idnb, idbv);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool XoaBaiBao(int idbb)
		{
			string query = string.Format("DELETE BaiBao where ID_BaiBao={0}",idbb);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}
    }
}
