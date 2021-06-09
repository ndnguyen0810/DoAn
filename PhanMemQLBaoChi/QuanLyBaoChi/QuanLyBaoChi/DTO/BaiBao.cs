using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class BaiBao
	{
		public BaiBao( int iDBaiBao, string tenBaiBao, string noiDungChinh, DateTime ngayDang, int iDTapChi, int iDTheLoai, int iDNhaBao, int iDBaiViet)
		{
			this.IDBaiBao = idBaiBao;
			this.TenBaiBao = tenBaiBao;
			this.NoiDungChinh = noiDungChinh;
			this.NgayDang = ngayDang;
			this.IDTapChi = iDTapChi;
			this.IDTheLoai = iDTheLoai;
			this.IDNhaBao = iDNhaBao;
			this.IDBaiViet = iDBaiViet;
		}

		public BaiBao(DataRow row)
		{
            this.IDBaiBao = (int)row["ID_BaiBao"];
            this.TenBaiBao = row["TenBaiBao"].ToString();
            this.NoiDungChinh = row["NoiDungChinh"].ToString();
            this.NgayDang = DateTime.Parse( row["NgayDang"].ToString());
            this.IDTapChi = (int)row["ID_TapChi"];
            this.IDTheLoai = (int)row["ID_TheLoai"];
            this.IDNhaBao = (int)row["ID_NhaBao"];
            this.IDBaiViet = (int)row["ID_BaiViet"];
        }
        private int idBaiBao;
		private string tenBaiBao;
		private string noiDungChinh;
		private DateTime ngayDang;
		private int iDTapChi;
		private int iDTheLoai;
		private int iDNhaBao;
		private int iDBaiViet;

		public int IDBaiBao { get => idBaiBao; set => idBaiBao = value; }
		public string TenBaiBao { get => tenBaiBao; set => tenBaiBao = value; }
		public string NoiDungChinh { get => noiDungChinh; set => noiDungChinh = value; }
		public DateTime NgayDang { get => ngayDang; set => ngayDang = value; }
		public int IDTapChi { get => iDTapChi; set => iDTapChi = value; }
		public int IDTheLoai { get => iDTheLoai; set => iDTheLoai = value; }
		public int IDNhaBao { get => iDNhaBao; set => iDNhaBao = value; }
		public int IDBaiViet { get => iDBaiViet; set => iDBaiViet = value; }
	}
}
