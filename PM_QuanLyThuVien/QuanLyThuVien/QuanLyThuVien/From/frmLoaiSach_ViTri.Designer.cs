namespace QuanLyThuVien.From
{
    partial class frmLoaiSach_ViTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSach_ViTri));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gwVT = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gwLoaiSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gctLoaisach = new DevExpress.XtraEditors.GroupControl();
            this.btnLamMoiLS = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaLS = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLS = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLS = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnLamMoiNXB = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoaNXB = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.btnSuaNXB = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenVT = new DevExpress.XtraEditors.TextEdit();
            this.btnThemNXB = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwLoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctLoaisach)).BeginInit();
            this.gctLoaisach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Controls.Add(this.groupControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(467, 244, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1259, 698);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.26F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.74F)});
            this.tablePanel1.Controls.Add(this.gwVT);
            this.tablePanel1.Controls.Add(this.gwLoaiSach);
            this.tablePanel1.Controls.Add(this.gctLoaisach);
            this.tablePanel1.Controls.Add(this.groupControl3);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 239F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1235, 674);
            this.tablePanel1.TabIndex = 4;
            // 
            // gwVT
            // 
            this.tablePanel1.SetColumn(this.gwVT, 1);
            this.gwVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gwVT.Location = new System.Drawing.Point(626, 153);
            this.gwVT.MainView = this.gridView2;
            this.gwVT.Name = "gwVT";
            this.tablePanel1.SetRow(this.gwVT, 1);
            this.gwVT.Size = new System.Drawing.Size(606, 518);
            this.gwVT.TabIndex = 3;
            this.gwVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gwVT;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindNullPrompt = "Bạn cần tìm gì ở đây...";
            this.gridView2.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gwLoaiSach
            // 
            this.tablePanel1.SetColumn(this.gwLoaiSach, 0);
            this.gwLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gwLoaiSach.Location = new System.Drawing.Point(3, 153);
            this.gwLoaiSach.MainView = this.gridView1;
            this.gwLoaiSach.Name = "gwLoaiSach";
            this.tablePanel1.SetRow(this.gwLoaiSach, 1);
            this.gwLoaiSach.Size = new System.Drawing.Size(617, 518);
            this.gwLoaiSach.TabIndex = 2;
            this.gwLoaiSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gwLoaiSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Bạn cần tìm gì ở đây...";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gctLoaisach
            // 
            this.tablePanel1.SetColumn(this.gctLoaisach, 0);
            this.gctLoaisach.Controls.Add(this.btnLamMoiLS);
            this.gctLoaisach.Controls.Add(this.btnXoaLS);
            this.gctLoaisach.Controls.Add(this.btnSuaLS);
            this.gctLoaisach.Controls.Add(this.btnThemLS);
            this.gctLoaisach.Controls.Add(this.labelControl2);
            this.gctLoaisach.Controls.Add(this.txtTenLoaiSach);
            this.gctLoaisach.Controls.Add(this.labelControl1);
            this.gctLoaisach.Controls.Add(this.txtMaLoaiSach);
            this.gctLoaisach.Location = new System.Drawing.Point(3, 3);
            this.gctLoaisach.Name = "gctLoaisach";
            this.tablePanel1.SetRow(this.gctLoaisach, 0);
            this.gctLoaisach.Size = new System.Drawing.Size(617, 144);
            this.gctLoaisach.TabIndex = 0;
            this.gctLoaisach.Text = "Loại Sách";
            // 
            // btnLamMoiLS
            // 
            this.btnLamMoiLS.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLamMoiLS.Appearance.Options.UseFont = true;
            this.btnLamMoiLS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiLS.ImageOptions.SvgImage")));
            this.btnLamMoiLS.Location = new System.Drawing.Point(403, 97);
            this.btnLamMoiLS.Name = "btnLamMoiLS";
            this.btnLamMoiLS.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoiLS.TabIndex = 2;
            this.btnLamMoiLS.Text = "Làm mới";
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoaLS.Appearance.Options.UseFont = true;
            this.btnXoaLS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaLS.ImageOptions.SvgImage")));
            this.btnXoaLS.Location = new System.Drawing.Point(281, 97);
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.Size = new System.Drawing.Size(100, 30);
            this.btnXoaLS.TabIndex = 2;
            this.btnXoaLS.Text = "Xoá";
            // 
            // btnSuaLS
            // 
            this.btnSuaLS.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSuaLS.Appearance.Options.UseFont = true;
            this.btnSuaLS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaLS.ImageOptions.SvgImage")));
            this.btnSuaLS.Location = new System.Drawing.Point(161, 97);
            this.btnSuaLS.Name = "btnSuaLS";
            this.btnSuaLS.Size = new System.Drawing.Size(100, 30);
            this.btnSuaLS.TabIndex = 2;
            this.btnSuaLS.Text = "Sửa";
            // 
            // btnThemLS
            // 
            this.btnThemLS.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThemLS.Appearance.Options.UseFont = true;
            this.btnThemLS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemLS.ImageOptions.SvgImage")));
            this.btnThemLS.Location = new System.Drawing.Point(39, 97);
            this.btnThemLS.Name = "btnThemLS";
            this.btnThemLS.Size = new System.Drawing.Size(100, 30);
            this.btnThemLS.TabIndex = 2;
            this.btnThemLS.Text = "Thêm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(39, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên loại";
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(106, 66);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenLoaiSach.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiSach.Size = new System.Drawing.Size(231, 22);
            this.txtTenLoaiSach.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã loại";
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(106, 35);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaLoaiSach.Properties.Appearance.Options.UseFont = true;
            this.txtMaLoaiSach.Properties.ReadOnly = true;
            this.txtMaLoaiSach.Size = new System.Drawing.Size(231, 22);
            this.txtMaLoaiSach.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.tablePanel1.SetColumn(this.groupControl3, 1);
            this.groupControl3.Controls.Add(this.btnLamMoiNXB);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.btnXoaNXB);
            this.groupControl3.Controls.Add(this.txtMaVT);
            this.groupControl3.Controls.Add(this.btnSuaNXB);
            this.groupControl3.Controls.Add(this.txtTenVT);
            this.groupControl3.Controls.Add(this.btnThemNXB);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Location = new System.Drawing.Point(626, 3);
            this.groupControl3.Name = "groupControl3";
            this.tablePanel1.SetRow(this.groupControl3, 0);
            this.groupControl3.Size = new System.Drawing.Size(606, 144);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Vị Trí";
            // 
            // btnLamMoiNXB
            // 
            this.btnLamMoiNXB.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLamMoiNXB.Appearance.Options.UseFont = true;
            this.btnLamMoiNXB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiNXB.ImageOptions.SvgImage")));
            this.btnLamMoiNXB.Location = new System.Drawing.Point(415, 97);
            this.btnLamMoiNXB.Name = "btnLamMoiNXB";
            this.btnLamMoiNXB.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoiNXB.TabIndex = 2;
            this.btnLamMoiNXB.Text = "Làm mới";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(66, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mã vị trí";
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoaNXB.Appearance.Options.UseFont = true;
            this.btnXoaNXB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaNXB.ImageOptions.SvgImage")));
            this.btnXoaNXB.Location = new System.Drawing.Point(299, 97);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(100, 30);
            this.btnXoaNXB.TabIndex = 2;
            this.btnXoaNXB.Text = "Xoá";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(140, 33);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaVT.Properties.Appearance.Options.UseFont = true;
            this.txtMaVT.Properties.ReadOnly = true;
            this.txtMaVT.Size = new System.Drawing.Size(225, 22);
            this.txtMaVT.TabIndex = 0;
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSuaNXB.Appearance.Options.UseFont = true;
            this.btnSuaNXB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaNXB.ImageOptions.SvgImage")));
            this.btnSuaNXB.Location = new System.Drawing.Point(182, 97);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(100, 30);
            this.btnSuaNXB.TabIndex = 2;
            this.btnSuaNXB.Text = "Sửa";
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(140, 64);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenVT.Properties.Appearance.Options.UseFont = true;
            this.txtTenVT.Size = new System.Drawing.Size(225, 22);
            this.txtTenVT.TabIndex = 0;
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThemNXB.Appearance.Options.UseFont = true;
            this.btnThemNXB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemNXB.ImageOptions.SvgImage")));
            this.btnThemNXB.Location = new System.Drawing.Point(66, 97);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(100, 30);
            this.btnThemNXB.TabIndex = 2;
            this.btnThemNXB.Text = "Thêm";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(66, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tên vị trí";
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1021, 1);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1259, 698);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1239, 678);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmLoaiSach_ViTri
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 698);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoaiSach_ViTri";
            this.Text = "Loại sách";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwLoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctLoaisach)).EndInit();
            this.gctLoaisach.ResumeLayout(false);
            this.gctLoaisach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gwVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gwLoaiSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl gctLoaisach;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiLS;
        private DevExpress.XtraEditors.SimpleButton btnXoaLS;
        private DevExpress.XtraEditors.SimpleButton btnSuaLS;
        private DevExpress.XtraEditors.SimpleButton btnThemLS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiSach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiSach;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiNXB;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnXoaNXB;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraEditors.SimpleButton btnSuaNXB;
        private DevExpress.XtraEditors.TextEdit txtTenVT;
        private DevExpress.XtraEditors.SimpleButton btnThemNXB;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}