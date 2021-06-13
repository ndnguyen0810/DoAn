using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoChi.DTO
{
	public class BaiDang
	{
		private int iDBaiBao;
		private int iDTapChi;
		private int viTriTrang;

		public int IDBaiBao { get => iDBaiBao; set => iDBaiBao = value; }
		public int IDTapChi { get => iDTapChi; set => iDTapChi = value; }
		public int ViTriTrang { get => viTriTrang; set => viTriTrang = value; }

		public BaiDang(int iDBaiBao, int iDTapChi, int viTriTrang)
		{
			this.IDBaiBao = iDBaiBao;
			this.IDTapChi = iDTapChi;
			this.ViTriTrang = viTriTrang;
		}

		public BaiDang(DataRow row)
		{
			this.IDBaiBao = (int)row["iD_BaiBao"];
			this.IDTapChi = (int)row["iD_TapChi"];
			this.ViTriTrang = (int)row["viTriTrang"];
		}
	}
}
