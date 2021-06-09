using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class BaiViet
	{
		private int iDBaiViet;
		private string tenBaiViet;
		private string noiDungBV;
		private DateTime ngayViet;
		private int iDNhaBao;

		public int IDBaiViet { get => iDBaiViet; set => iDBaiViet = value; }
		public string TenBaiViet { get => tenBaiViet; set => tenBaiViet = value; }
		public string NoiDungBV { get => noiDungBV; set => noiDungBV = value; }
		public DateTime NgayViet { get => ngayViet; set => ngayViet = value; }
		public int IDNhaBao { get => iDNhaBao; set => iDNhaBao = value; }

		public BaiViet(int iDBaiViet, string tenBaiViet, string noiDungBV, DateTime ngayViet, int iDNhaBao)
		{
			this.IDBaiViet = iDBaiViet;
			this.TenBaiViet = tenBaiViet;
			this.NoiDungBV = noiDungBV;
			this.NgayViet = ngayViet;
			this.IDNhaBao = iDNhaBao;
		}

		public BaiViet(DataRow row)
		{
			this.IDBaiViet = (int)row["ID_BaiViet"];
			this.TenBaiViet = row["TenBaiViet"].ToString();
			this.NoiDungBV = row["NoiDung_BV"].ToString();
			this.NgayViet =  DateTime.Parse(row["NgayViet"].ToString());
			this.IDNhaBao = (int)row["ID_NhaBao"];
		}
	}
}
