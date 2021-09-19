namespace QuanLyThuVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.btnMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrasach = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachTrongTV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachDangMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocGiaDangMuon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.barHeaderItem1);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMuon,
            this.btnTrasach,
            this.btnDocGia,
            this.btnTimSach,
            this.btnTimDocGia,
            this.btnSachTrongTV,
            this.btnSachDangMuon,
            this.btnDocGiaDangMuon,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnDangXuat,
            this.skinDropDownButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 34;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1136, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 32;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // btnMuon
            // 
            this.btnMuon.Caption = "Mượn sách";
            this.btnMuon.Id = 1;
            this.btnMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMuon.ImageOptions.Image")));
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnTrasach
            // 
            this.btnTrasach.Caption = "Trả sách";
            this.btnTrasach.Id = 2;
            this.btnTrasach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrasach.ImageOptions.Image")));
            this.btnTrasach.Name = "btnTrasach";
            this.btnTrasach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnDocGia
            // 
            this.btnDocGia.Caption = "Độc giả";
            this.btnDocGia.Id = 3;
            this.btnDocGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDocGia.ImageOptions.Image")));
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnTimSach
            // 
            this.btnTimSach.Caption = "Tìm kiếm sách";
            this.btnTimSach.Id = 4;
            this.btnTimSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSach.ImageOptions.Image")));
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.Caption = "Tìm kiếm độc giả";
            this.btnTimDocGia.Id = 5;
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnSachTrongTV
            // 
            this.btnSachTrongTV.Caption = "Sách trong thư viện";
            this.btnSachTrongTV.Id = 6;
            this.btnSachTrongTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachTrongTV.ImageOptions.Image")));
            this.btnSachTrongTV.Name = "btnSachTrongTV";
            this.btnSachTrongTV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnSachDangMuon
            // 
            this.btnSachDangMuon.Caption = "Sách đang mượn";
            this.btnSachDangMuon.Id = 7;
            this.btnSachDangMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachDangMuon.ImageOptions.Image")));
            this.btnSachDangMuon.Name = "btnSachDangMuon";
            this.btnSachDangMuon.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnDocGiaDangMuon
            // 
            this.btnDocGiaDangMuon.Caption = "Độc giả đang mượn";
            this.btnDocGiaDangMuon.Id = 8;
            this.btnDocGiaDangMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDocGiaDangMuon.ImageOptions.Image")));
            this.btnDocGiaDangMuon.Name = "btnDocGiaDangMuon";
            this.btnDocGiaDangMuon.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm tài khoản";
            this.barButtonItem1.Id = 26;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đổi mật khẩu";
            this.barButtonItem2.Id = 27;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thay đổi thông tin";
            this.barButtonItem3.Id = 28;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 30;
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgSach,
            this.ribbonPageGroup8,
            this.rbgTimKiem});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // rbgSach
            // 
            this.rbgSach.ItemLinks.Add(this.btnMuon);
            this.rbgSach.ItemLinks.Add(this.btnDocGia);
            this.rbgSach.ItemLinks.Add(this.btnTrasach);
            this.rbgSach.Name = "rbgSach";
            this.rbgSach.Text = "Sách";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnSachTrongTV);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnSachDangMuon);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnDocGiaDangMuon);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Thống kê";
            // 
            // rbgTimKiem
            // 
            this.rbgTimKiem.ItemLinks.Add(this.btnTimSach);
            this.rbgTimKiem.ItemLinks.Add(this.btnTimDocGia);
            this.rbgTimKiem.ItemLinks.Add(this.barButtonItem10);
            this.rbgTimKiem.Name = "rbgTimKiem";
            this.rbgTimKiem.Text = "Tìm kiếm";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Giao diện";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tài khoản";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Hỗ trợ";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 500);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1136, 24);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 33;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 524);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Thư Viện";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgSach;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnMuon;
        private DevExpress.XtraBars.BarButtonItem btnTrasach;
        private DevExpress.XtraBars.BarButtonItem btnDocGia;
        private DevExpress.XtraBars.BarButtonItem btnTimSach;
        private DevExpress.XtraBars.BarButtonItem btnTimDocGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgTimKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnSachTrongTV;
        private DevExpress.XtraBars.BarButtonItem btnSachDangMuon;
        private DevExpress.XtraBars.BarButtonItem btnDocGiaDangMuon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
    }
}