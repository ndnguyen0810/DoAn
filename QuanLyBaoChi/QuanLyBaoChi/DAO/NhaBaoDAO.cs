using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
     public class NhaBaoDAO
     {
        private static NhaBaoDAO instance;

        public static NhaBaoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaBaoDAO();
                return NhaBaoDAO.instance;
            }

            private set => instance = value;
        }

        private NhaBaoDAO() { }

        public List<NhaBao> GetListNhaBao()
        {
            List<NhaBao> NhaBaolist = new List<NhaBao>();
            string query = "select * from NhaBao";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaBao NhaBao = new NhaBao(item);
                NhaBaolist.Add(NhaBao);
            }

            return NhaBaolist;
        }



        public bool ThemNhaBao(string ten, string hieu, string email, string sdt, string dc)
        {
            string query = string.Format("INSERT INTO NhaBao( [TenNhaBao],[ButHieu], [sdt_NB],[email_NB],[diachi_NB]) VALUES ( N'{0}',N'{1}','{2}','{3}',N'{4}')", ten,hieu, email,sdt,dc);
            int resual = DataProvider.Instance.ExcuteNonQuery(query);
            return resual > 0;
        }

        public bool XoaNhaBao(int id)
        {
            string query = string.Format("delete nhabao where id_nhabao={0}",id);
            int resual = DataProvider.Instance.ExcuteNonQuery(query);
            return resual > 0;
        }

        public bool SuaNhaBao(string ten, string hieu, string email, string sdt, string dc)
        {
            string query = string.Format("UPDATE NhaBao SET( [TenNhaBao],[ButHieu], [sdt_NB],[email_NB],[diachi_NB]) VALUES ( N'{0}',N'{1}')", ten, hieu, email, sdt, dc);
            int resual = DataProvider.Instance.ExcuteNonQuery(query);
            return resual > 0;
        }

        public List<NhaBao> DemNB()
        {
            List<NhaBao> NhaBaolist = new List<NhaBao>();
            string query = "select COUNT(*) from NHABAO";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaBao NhaBao = new NhaBao(item);

                NhaBaolist.Add(NhaBao);
            }

            return NhaBaolist;
        }
    }
}
