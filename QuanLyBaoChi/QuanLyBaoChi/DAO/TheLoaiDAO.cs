using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
	public class TheLoaiDAO
	{
		private static TheLoaiDAO instance;

		public static TheLoaiDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new TheLoaiDAO();
				return TheLoaiDAO.instance;
			}

			private set => instance = value;
		}

		private TheLoaiDAO() { }

		public List<TheLoai> GetListTheLoai()
		{
			List<TheLoai> TheLoailist = new List<TheLoai>();
			string query = "select * from THELOAI";
           
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			foreach(DataRow item in data.Rows)
			{
				TheLoai theloai = new TheLoai(item);
				TheLoailist.Add(theloai);
			}

			return TheLoailist;
		}

        public List<TheLoai> SeachTheLoaiByName(string name)
        {
            List<TheLoai> TheLoailist = new List<TheLoai>();
            //dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name)
            string query =string.Format("select * from THELOAI where dbo.FuncConvert(TenTheLoai) like N'%' + dbo.FuncConvert(N'{0}') +'%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TheLoai theloai = new TheLoai(item);                 
                TheLoailist.Add(theloai);
            }

            return TheLoailist;
        }

        public bool ThemTheLoai( string tenTL, string dienGiai)
		{
			string query = string.Format("INSERT INTO TheLoai( [TenTheLoai],[DienGiai_TL]) VALUES ( N'{0}',N'{1}')", tenTL, dienGiai);
			int resual = DataProvider.Instance.ExcuteNonQuery(query);
			return resual > 0;
		}

		public bool SuaTheLoai(int id_TL, string tenTL, string dienGiai)
		{
			string query = string.Format("UPDATE TheLoai SET ID_TheLoai = {0}, TenTheLoai = N'{1}', DienGiai_TL=N'{2}' where ID_TheLoai={0}", id_TL, tenTL, dienGiai);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool XoaTheLoai(int id_TL, string tenTL, string dienGiai)
		{
			string query = string.Format("DELETE TheLoai where ID_TheLoai={0}", id_TL, tenTL, dienGiai);
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}
	}
}
