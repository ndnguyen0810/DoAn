using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
    public class BaiVietDAO
    {
        private static BaiVietDAO instance;

        public static BaiVietDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaiVietDAO();
                return BaiVietDAO.instance;
            }

            private set => instance = value;
        }

        private BaiVietDAO() { }

        public List<BaiViet> GetListBaiViet()
        {
            List<BaiViet> BaiVietlist = new List<BaiViet>();
            string query = "select * from BaiViet";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BaiViet BaiViet = new BaiViet(item);
                BaiVietlist.Add(BaiViet);
            }

            return BaiVietlist;
        }

 

        public bool ThemBaiViet(string ten, string nd, string day, int idtg)
        {
            string query = string.Format("INSERT INTO BaiViet( [TenBaiViet],[NoiDung_BV],[NgayViet],[ID_NhaBao]) VALUES ( N'{0}',N'{1}',N'{2}',{3})", ten, nd,day,idtg);
            int resual = DataProvider.Instance.ExcuteNonQuery(query);
            return resual > 0;
        }

        public bool SuaBaiViet(int id, string ten, string nd, string day, int idtg)
        {
            string query = string.Format("UPDATE BaiViet SET ID_BaiViet = {0}, TenBaiViet = N'{1}', NoiDung_BV=N'{2}',NgayViet='{3}', ID_NhaBao={4} where ID_BaiViet={0}",id, ten, nd, day, idtg);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool XoaBaiViet(int id, string ten, string nd, string day, int idtg)
        {
            string query = string.Format("DELETE BaiViet where ID_BaiViet={0}", id, ten, nd, day, idtg);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<BaiViet> ThongKeBaiViet(string start, string end)
        {
            List<BaiViet> BaiVietlist = new List<BaiViet>();
            string query = string.Format("select * from BaiViet where NGAYVIET >= '{0}' and NGAYVIET<='{1}' ", start, end);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BaiViet BaiViet = new BaiViet(item);

                BaiVietlist.Add(BaiViet);
            }

            return BaiVietlist;
        }
    }
}
