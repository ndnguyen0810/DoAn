using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
    public class DangNhapDAO
    {
        private static object instance;

        private DangNhapDAO() { }

        public static object Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return instance; }
            private set => instance = value;
        }

        public bool DangNhap(string userName, string passWord)
        {
            string query = "USP_DangNhap @username , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
