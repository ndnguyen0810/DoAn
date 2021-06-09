using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
    public  class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return TaiKhoanDAO.instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAO() { }


        public List<TaiKhoan> GetListTaiKhoan()
        {
            List<TaiKhoan> TaiKhoanList = new List<TaiKhoan>();
            string query = "Select * from TaiKhoan";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TaiKhoan TaiKhoan = new TaiKhoan(item);
                TaiKhoanList.Add(TaiKhoan);
            }
            return TaiKhoanList;
        }

        public bool ThemTaiKhoan(string user, string pass, string disp, int status)
        {
            string query = string.Format("INSERT INTO TaiKhoan( [username],[password],[display],[status]) VALUES ('{0}', '{1}',N'{2}',{3})", user, pass, disp, status);
            int resual = DataProvider.Instance.ExcuteNonQuery(query);
            return resual > 0;
        }

        public bool CapNhatTaiKhoan(int id, string user, string pass, string disp, int status)
        {
            string query = string.Format("UPDATE TaiKhoan SET ID_TK={0}, username = N'{1}', password=N'{2}',display=N'{3}', status={4} WHERE ID_TaiKhoan={0}", id, user, pass, disp, status);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool XoaTaiKhoan(int id, string user, string pass, string disp, int status)
        {
            string query = string.Format("DELETE TaiKhoan where ID_TK={0}", id, user, pass, disp, status);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
