using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using QRCoder;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
using System.Data.SQLite;

namespace CreateQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //connect sqlite
        string str_conn = string.Format(@"Data Source ={0}\QLGPLX.db", System.Windows.Forms.Application.StartupPath);
        SQLiteDataAdapter da_sqlite;
        DataTable dt;
        void load_data()
        {
            using(SQLiteConnection conn = new SQLiteConnection(str_conn))
            {
                conn.Open();
                da_sqlite = new SQLiteDataAdapter("select maso as 'Mã Số' , hoten as 'Họ Tên', ngaysinh as 'Ngày sinh', quequan as 'Quê quán', loaibang as 'Loại bằng', ngaycap as 'Ngày cấp',thoihan as'Thời hạn', hethan as 'Hết hạn'  from Infomation ",conn);
                dt = new DataTable();
                da_sqlite.Fill(dt);
                dgvList.DataSource = dt;
            }
        }


        #region Tạo mã Qr

        private void txtMaSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CreateQR()
        {
            string maso = txtMaSo.Text;
            string hoten = txtHoTen.Text;
            string namsinh = dtpSinh.Text;
            string diachi = txtQueQuan.Text;
            string LoaiBang = cbbLoaiBang.SelectedItem.ToString();
            string NgayCap = dtpNgayCap.Text;
            string ThoiHan = cbbThoiHan.SelectedItem.ToString();
            string HetHan = dtpHetHan.Text;

            if(cbbLoaiBang.SelectedItem.ToString()=="Bằng A1")
            {               
                string full = "Mã số: " + maso + "\nHọ tên: " + hoten + "\nNăm sinh: " + namsinh + "\nĐịa chỉ: " + diachi + "\nLoại bằng: "
                + LoaiBang + "\nNgày cấp: " + NgayCap + "\nThời hạn: Vô thời hạn" +"\nNgày hết hạn: Không";
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(full, QRCodeGenerator.ECCLevel.Q));
                pictureBoxQR.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
             
                qrGenerator.Dispose();
                qrCode.Dispose();
            }
            else
            {
                string full = "Mã số: " + maso + "\nHọ tên: " + hoten + "\nNăm sinh: " + namsinh + "\nĐịa chỉ: " + diachi + "\nLoại bằng: "
               + LoaiBang + "\nNgày cấp: " + NgayCap + "\nThời hạn: Có thời hạn"+ "\nNgày hết hạn: "+HetHan;
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(full, QRCodeGenerator.ECCLevel.Q));
                pictureBoxQR.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
                qrGenerator.Dispose();
                qrCode.Dispose();
            }                    
        }


        private int checkso(ulong maso)
        {
            maso = ulong.Parse(txtMaSo.Text);
            int dem = 0;
            while (maso >= 10)
            {
                maso /= 10; // hay n = n /10;
                dem++;
            }
            return dem+1;
        }

        private void dtpSinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime dati = dtpSinh.Value;
        }

        private void dtpNgayCap_ValueChanged(object sender, EventArgs e)
        {
            DateTime dati = dtpNgayCap.Value;
        }

        private void dtpHetHan_ValueChanged(object sender, EventArgs e)
        {
            DateTime dati = dtpHetHan.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG file (*.png)|*.png|JPEG file (*.jpg)|*.jpg|GIF file (*.gif)|*.gif|Bitmap file (*.bmp)|*.bmp";
            save.Title = "Bạn có muốn lưu?";
            save.FileName = txtHoTen.Text;


            if (this.pictureBoxQR.Image != null)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat imageFormat;

                    switch (save.FilterIndex)
                    {
                        case 1:
                            imageFormat = ImageFormat.Jpeg;

                            break;
                        case 2:
                            imageFormat = ImageFormat.Gif;

                            break;
                        case 3:
                            imageFormat = ImageFormat.Bmp;

                            break;
                        default:
                            imageFormat = ImageFormat.Png;

                            break;
                    }

                    this.pictureBoxQR.Image.Save(save.FileName, imageFormat);
                }
            }
            else
            {
                MessageBox.Show("Create image before you save it.", "Error");
            }
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng điển họ tên");
            }

            if (txtQueQuan.Text == "")
            {
                errorProvider1.SetError(txtQueQuan, "vui lòng điển quên quán");
            }

            if (txtMaSo.Text == ""|| checkso(ulong.Parse(txtMaSo.Text)) < 12)
            {
                errorProvider1.SetError(txtMaSo, "Vui lòng điển mã số");
            }

            else
            {
                if (cbDieuKhoan.Checked == false)
                {
                    MessageBox.Show("Bạn chưa đồng ý với điều kiện ở trên", "Thông báo");
                }
                else
                {
                    this.CreateQR();
                    btnSave.Visible = true;
                }
            }
        }


        #endregion 


        #region Đọc mã QR


 

        private void OpenCamera()
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cbbhinhthuc.Items.Add(filterInfo.Name);
            cbbhinhthuc.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OpenCamera();
            btnSave.Visible = false;
            load_data();

           
        }

       
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
                CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cbbhinhthuc.SelectedIndex].MonikerString);
                CaptureDevice.NewFrame += CaptureDevice_NewFrame;
                CaptureDevice.Start();
                timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        public Result result;
        string chuoi_rl;
        private int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                 result = barcodeReader.Decode((Bitmap)ptbCamera.Image);

                if (result != null && i == 0)// && i==0
                {
                    i++; timer1.Stop();
                    chuoi_rl = result.ToString();
                    MessageBox.Show(result.ToString(), "Thông Báo");
                   
                    if (CaptureDevice.IsRunning &&i!=0)//&&i!=0
                    {
                        CaptureDevice.Stop();
                        i = 0;
                    }
                }
               
                
            }
        }
        
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (CaptureDevice.IsRunning)
            {
                CaptureDevice.Stop();
            }
        }
        //add csdl
        SQLiteCommand cmd_sqlite;
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string chuoi = chuoi_rl;//result.ToString();
            Regex regex = new Regex("\n");
            string[] ketqua = regex.Split(chuoi);
            string[] Luu = new string[8];
            for (int j = 0; j <= 7; j++)
            {
                string[] DaCut = ketqua[j].Split(':');
                Luu[j] = DaCut[1];
            }
           
            using (SQLiteConnection conn = new SQLiteConnection(str_conn))
            {
                conn.Open();
                string str = string.Format("insert into Infomation values ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Luu[0].Trim(), Luu[1].Trim(), Luu[2].Trim(), Luu[3].Trim(), Luu[4].Trim(), Luu[5].Trim(), Luu[6].Trim(), Luu[7].Trim());
                SQLiteCommand cmd = new SQLiteCommand(str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                string kt = String.Format("select * from Infomation where maso='{0}'", Luu[0].Trim());
                SQLiteDataAdapter da_kt = new SQLiteDataAdapter(kt, conn);
                DataTable dt_kt = new DataTable();
                da_kt.Fill(dt_kt);
                if (dt_kt.Rows.Count >1)
                {
                    MessageBox.Show("Đã tồn tại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    DataTable dt = new DataTable();
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                    dgvList.Refresh();
                }
            }
            dgvList.DataSource = null;
            load_data();

        }





        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}