using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class PhatHanh
	{
		private int iDPhatHanh;
		private string thoiGianPH;
		private string dienGiaiPH;

		public int IDPhatHanh { get => iDPhatHanh; set => iDPhatHanh = value; }
		public string ThoiGianPH { get => thoiGianPH; set => thoiGianPH = value; }
		public string DienGiaiPH { get => dienGiaiPH; set => dienGiaiPH = value; }

		public PhatHanh(int iDPhatHanh, string thoiGianPH, string dienGiaiPH)
		{
			this.IDPhatHanh = iDPhatHanh;
			this.ThoiGianPH = thoiGianPH;
			this.DienGiaiPH = dienGiaiPH;
		}

		public PhatHanh(DataRow row)
		{
			this.IDPhatHanh = (int)row["ID_PhatHanh"];
			this.ThoiGianPH = row["thoiGianPH"].ToString();
			this.DienGiaiPH = row["DienGiai_PH"].ToString();
		}

	}
}
