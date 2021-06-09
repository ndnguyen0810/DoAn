using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class TheLoai
	{
		private int iDTheLoai;
		private string tenTheLoai;
		private string dienGiaiTL;

		public int IDTheLoai { get => iDTheLoai; set => iDTheLoai = value; }
		public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
		public string DienGiaiTL { get => dienGiaiTL; set => dienGiaiTL = value; }

		public TheLoai(int iDTheLoai, string tenTheLoai, string dienGiaiTL)
		{
			this.IDTheLoai = iDTheLoai;
			this.TenTheLoai = tenTheLoai;
			this.DienGiaiTL = dienGiaiTL;
		}

		public TheLoai(DataRow row)
		{
			this.IDTheLoai = (int)row["ID_TheLoai"];
			this.TenTheLoai = row["TenTheLoai"].ToString();
			this.DienGiaiTL = row["DienGiai_TL"].ToString();
		}

	}
}
