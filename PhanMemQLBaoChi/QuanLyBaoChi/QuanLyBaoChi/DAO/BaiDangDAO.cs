using QuanLyBaoChi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DAO
{
    public class BaiDangDAO
    {
        private static BaiDangDAO instance;

        public static BaiDangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaiDangDAO();
                return BaiDangDAO.instance;
            }

            private set => instance = value;
        }

        private BaiDangDAO() { }

        public List<BaiDang> GetListBaiDang()
        {
            List<BaiDang> BaiDanglist = new List<BaiDang>();
            string query = "select * from BaiDang";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BaiDang BaiDang = new BaiDang(item);
                BaiDanglist.Add(BaiDang);
            }

            return BaiDanglist;
        }



        public bool ThemBaiDang(int id ,int idtc, int trang)
        {
            string query = string.Format("INSERT INTO BaiDang([ID_BaiBao], [ID_TapChi],[ViTRITRANG]) VALUES ( {0},{1},{2})", id,idtc, trang);
            int resual = DataProvider.Instance.ExcuteNonQuery(query);
            return resual > 0;
        }

        public bool SuaBaiDang(int id, int idtc, int trang)
        {
            string query = string.Format("UPDATE BaiDang SET ID_BaiBao = {0}, ID_TapChi = {1}, ViTRITRANG={2} where ID_BaiBao={0}", id, idtc, trang);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool XoaBaiDang(int id, int idtc, int trang)
        {
            string query = string.Format("DELETE BaiDang where ID_BaiBao={0} and ID_TapChi={1}", id, idtc, trang);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
