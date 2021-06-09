using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class NhaBao
	{
		private int iDNhaBao;
		private string tenNhaBao;
		private string butHieu;
		private string sdtNB;
		private string emailNB;
		private string diaChiNB;


		public NhaBao(int iDNhaBao, string tenNhaBao, string butHieu, string sdtNB, string emailNB, string diaChiNB)
		{
			this.IDNhaBao = iDNhaBao;
			this.TenNhaBao = tenNhaBao;
			this.ButHieu = butHieu;
			this.SdtNB = sdtNB;
			this.EmailNB = emailNB;
			this.DiaChiNB = diaChiNB;

		}

		public NhaBao(DataRow row)
		{
			this.IDNhaBao = (int)row["ID_NhaBao"];
			this.TenNhaBao = row["TenNhaBao"].ToString();
			this.ButHieu = row["ButHieu"].ToString();
			this.SdtNB = row["SDT_NB"].ToString();
			this.EmailNB = row["Email_NB"].ToString();
			this.DiaChiNB = row["DiaChi_NB"].ToString();
		
		}

		public int IDNhaBao { get => iDNhaBao; set => iDNhaBao = value; }
		public string TenNhaBao { get => tenNhaBao; set => tenNhaBao = value; }
		public string ButHieu { get => butHieu; set => butHieu = value; }
		public string SdtNB { get => sdtNB; set => sdtNB = value; }
		public string EmailNB { get => emailNB; set => emailNB = value; }
		public string DiaChiNB { get => diaChiNB; set => diaChiNB = value; }
	
	}
}
