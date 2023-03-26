﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class connection
    {
      SqlConnection con = new SqlConnection(@"Data Source=MYACER\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
       //chọn lại server name và name database
        private void openConnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closeConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //ExecuteData: Them sua xoa du lieu
        public Boolean exeData(string cmd)
        {
            openConnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeConnect();
            return check;
        }

        public int ExSCL(string cmd)
        {
            openConnect();
            int data;
            SqlCommand sc = new SqlCommand(cmd, con);
            data = Int32.Parse(sc.ExecuteScalar().ToString());
            closeConnect();
            return data;
        }

        public string mysqli_ex_data(string str)
        {
            string data;

            con.Open();
            SqlCommand mysql_cmd = new SqlCommand(str, con);
            data = mysql_cmd.ExecuteScalar().ToString();
            con.Close();
            return data;
        }

        public void Ex_vp(string str)
        {
            openConnect();
            try
            {
                SqlCommand sc = new SqlCommand(str, con);
                sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            closeConnect();

        }

        //ReadData: Doc du lieu tu bang ra DataTable
        public DataTable readData(string cmd)
        {
            openConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            closeConnect();
            return dt;
        }

        //CreatID: tao ID moi theo tien to(preFix)
        public string creatId(string preFix, string sql)
        {
            string id = "";
            int countRow = -1;
            bool check = false; //Kiem tra ID khong dung thu tu: Flase
            DataTable dt = readData(sql);
            countRow = dt.Rows.Count; //Dem so luong ban ghi co trong bang         
            if (countRow > 0) //Co nhieu hơn 1 ban ghi thi moi kiem tra
            {
                int count = 1; //ID ao chay song song voi ID trong bang
                foreach (DataRow row in dt.Rows) //Duyet cac dong trong bang
                {
                    string idRow = row[0].ToString(); //Lay chuoi chua ID
                    int i = Int32.Parse(idRow.Substring(idRow.Length - 8, 8)); //Cat chuoi lay ID
                    if (i != count) //Sai thu tu
                    {
                        count = i - 1; //Gan ID ao bang ID that -1
                        check = true; //Check sai thu tu
                        break;
                    }
                    else
                    {
                        count++; //Khong sai thu tu
                    }
                }
                if (check) //Gan ID bị thieu cho ID duoc creat
                {
                    countRow = count;
                }
            }
            if (!check) //Neu khong co ID sai thu tu thi tang len 1 như binh thuong
            {
                countRow += 1;
            }
            if (countRow < 10)
            {
                id = preFix + "0000000" + countRow; //U00009
            }
            else if (countRow < 100)
            {
                id = preFix + "000000" + countRow; //U00999
            }
            else if (countRow < 10000)
            {
                id = preFix + "00000" + countRow; //U09999
            }
            else if (countRow < 100000)
            {
                id = preFix + "0000" + countRow; //U09999
            }
            else if (countRow < 1000000)
            {
                id = preFix + "000" + countRow; //U09999
            }
            else if (countRow < 10000000)
            {
                id = preFix + "00" + countRow; //U09999
            }
            else if (countRow < 100000000)
            {
                id = preFix + "0" + countRow; //U09999
            }
            else if (countRow < 1000000000)
            {
                id = preFix + countRow; //U99999
            }
            return id;
        }

        //check email
        public static bool CheckEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        //chek sdt
        public static bool checkSDT(string sdt)
        {
            int lenght;
            lenght = sdt.Length;
            if (lenght == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check cùng tên trong bảg
        public static bool checkName(string query, TextEdit textEdit, string column)
        {
            bool checkName = false;
            connection con = new connection();
            DataTable dt = new DataTable();
            dt = con.readData(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (textEdit.EditValue.ToString().Trim().Equals(dr[column].ToString()))
                    {
                        checkName = true;
                        // return true;
                        break;
                    }
                }
            }
            return checkName;
        }


        public static bool checkTK(string query, string textEdit, string column)
        {
            bool checkName = false;
            connection con = new connection();
            DataTable dt = new DataTable();
            dt = con.readData(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (textEdit.ToString().Trim().Equals(dr[column].ToString()))
                    {
                        checkName = true;
                        // return true;
                        break;
                    }
                }
            }
            return checkName;
        }

        public string CreateMD5(string str)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        //cột có tên

        public static string P_LoadDocGia = "select MADG as [Mã đọc giả],HOTEN as [Họ và tên], NAMSINH as [Năm sinh],GIOITINH as [Giới tính],DIACHI as [Địa chỉ],SDT as [Số điện thoại],Email from DOCGIA";
        public static string P_LoadSach = "select MASACH as [Mã sách],TENSACH as [Tên sách],TACGIA as [Tác giả],SoLuong as [Số lượng], GIATIEN as [Giá tiền], xb.TENNXB as [Nhà xuất bản], NAMXB as [Năm xuất bản], ls.TENLOAI as [Loại sách] from SACH  s, NXB xb, LOAISACH ls        where s.MANXB= xb.MANXB           and ls.MALOAI= s.MALOAI";
        public static string P_LoadNXB = "select MANXB as [Mã nhà xuất bản],TENNXB as [Tên nhà xuất bản],Diachi as [Địa chỉ],   sdt as [Số điện thoại],email as [Email], websize as [Websize] from NXB";
        public static string P_LoadLoaiSach = "select MALOAI as[Mã loại], TENLOAI as[Tên loại],vt.TENVITRI as[Tên vị trí] from LOAISACH ls, VITRI vt where ls.MAVT= vt.mavt";
        public static string P_LoadViTri = "select MAVT as[Mã vị trí], TENVITRI as[Tên vị trí]  from LOAISACH ls ";
        public static string P_LoadNhanVien = "select MANV as[Mã nhân viên], TENNV as [Họ và tên], NAMSINH as[Ngày sinh], GioiTinh as[Giới tính], Diachi as[Địa chỉ], SDT as [Số điện thoại], EMAIL as [Email], NgayVaoLam as [Ngày vào làm] from NHANVIEN";
        public static string P_LoadChucVu = "select MACV as [Mã chức vụ], TENCV as [Tên chức vụ] from CHUCVU";
        public static string P_TaiKhoan = "select MaTK as[Mã tài khoản], TENTK as [Tên tài khoản], MATKHAU as [Mật khẩu], n.TENNV as [Tên nhân viên], c.TENCV as [Chức vụ] from TAIKHOAN t, CHUCVU c, NHANVIEN n where t.MACV= c.MACV and t.MANV= n.MANV";

    }
}
