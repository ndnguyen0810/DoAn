using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class BaoTapChi
	{
		private int iDTapChi;
		private string tenTapChi;
		private string diaChiTC;
		private int iDPhatHanh;
		private string emailTC;
		private string sdtTC;

		public BaoTapChi()
		{
			this.IDTapChi = iDTapChi;
			this.TenTapChi = tenTapChi;
			this.DiaChiTC = diaChiTC;
			this.IDPhatHanh = iDPhatHanh;
			this.EmailTC = emailTC;
			this.SdtTC = sdtTC;
		}
		public BaoTapChi(DataRow row)
		{
			this.IDTapChi = (int)row["iD_TapChi"];
			this.TenTapChi = row["tenTapChi"].ToString();
			this.DiaChiTC = row["diaChiTC"].ToString();
			this.IDPhatHanh = (int)row["iD_PhatHanh"];
			this.EmailTC = row["email_TC"].ToString();
			this.SdtTC = row["sdt_TC"].ToString();
		}

		public int IDTapChi { get => iDTapChi; set => iDTapChi = value; }
		public string TenTapChi { get => tenTapChi; set => tenTapChi = value; }
		public string DiaChiTC { get => diaChiTC; set => diaChiTC = value; }
		public int IDPhatHanh { get => iDPhatHanh; set => iDPhatHanh = value; }
		public string EmailTC { get => emailTC; set => emailTC = value; }
		public string SdtTC { get => sdtTC; set => sdtTC = value; }
	}
}
