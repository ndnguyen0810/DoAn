using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
    public class TaiKhoan
    {
        private int iD_TK;
        private string username;
        private string password;
        private string display;
        private int status;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Display { get => display; set => display = value; }
        public int Status { get => status; set => status = value; }
        public int ID_TK { get => iD_TK; set => iD_TK = value; }

        public TaiKhoan(int id, string username, string password, string display, int status)
        {
            this.ID_TK = iD_TK;
            this.Username = username;
            this.Password = password;
            this.Display = display;
            this.Status = status;
        }

        public TaiKhoan(DataRow row)
        {
            this.ID_TK = (int)row["ID_TK"];
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Display = row["display"].ToString();
            this.Status = (int)row["status"];
        }
    }
}
