namespace QuanLyThuVien.From
{
    partial class frmInfoTPhieuMuon
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcDocGia = new DevExpress.XtraGrid.GridControl();
            this.gvDocGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPM = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuMuon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcCTPM = new DevExpress.XtraGrid.GridControl();
            this.gvCTPM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(952, 170);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.22F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.78F)});
            this.tablePanel1.Controls.Add(this.groupControl3);
            this.tablePanel1.Controls.Add(this.groupControl2);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(928, 146);
            this.tablePanel1.TabIndex = 4;
            // 
            // gcDocGia
            // 
            this.gcDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDocGia.Location = new System.Drawing.Point(2, 22);
            this.gcDocGia.MainView = this.gvDocGia;
            this.gcDocGia.Name = "gcDocGia";
            this.gcDocGia.Size = new System.Drawing.Size(482, 116);
            this.gcDocGia.TabIndex = 1;
            this.gcDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocGia});
            // 
            // gvDocGia
            // 
            this.gvDocGia.GridControl = this.gcDocGia;
            this.gvDocGia.Name = "gvDocGia";
            this.gvDocGia.OptionsBehavior.Editable = false;
            this.gvDocGia.OptionsBehavior.ReadOnly = true;
            this.gvDocGia.OptionsFind.AlwaysVisible = true;
            this.gvDocGia.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvDocGia.OptionsFind.ShowFindButton = false;
            this.gvDocGia.OptionsView.ShowGroupPanel = false;
            // 
            // gcPM
            // 
            this.gcPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPM.Location = new System.Drawing.Point(2, 22);
            this.gcPM.MainView = this.gvPhieuMuon;
            this.gcPM.Name = "gcPM";
            this.gcPM.Size = new System.Drawing.Size(426, 116);
            this.gcPM.TabIndex = 0;
            this.gcPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuMuon});
            // 
            // gvPhieuMuon
            // 
            this.gvPhieuMuon.GridControl = this.gcPM;
            this.gvPhieuMuon.Name = "gvPhieuMuon";
            this.gvPhieuMuon.OptionsBehavior.Editable = false;
            this.gvPhieuMuon.OptionsBehavior.ReadOnly = true;
            this.gvPhieuMuon.OptionsFind.AlwaysVisible = true;
            this.gvPhieuMuon.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvPhieuMuon.OptionsFind.ShowFindButton = false;
            this.gvPhieuMuon.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(952, 170);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tablePanel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(932, 150);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.groupControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 170);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(952, 283);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcCTPM);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(928, 259);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin phiếu mượn";
            // 
            // gcCTPM
            // 
            this.gcCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPM.Location = new System.Drawing.Point(2, 22);
            this.gcCTPM.MainView = this.gvCTPM;
            this.gcCTPM.Name = "gcCTPM";
            this.gcCTPM.Size = new System.Drawing.Size(924, 235);
            this.gcCTPM.TabIndex = 0;
            this.gcCTPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPM});
            // 
            // gvCTPM
            // 
            this.gvCTPM.GridControl = this.gcCTPM;
            this.gvCTPM.Name = "gvCTPM";
            this.gvCTPM.OptionsFind.AlwaysVisible = true;
            this.gvCTPM.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvCTPM.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvCTPM.OptionsFind.ShowFindButton = false;
            this.gvCTPM.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(952, 283);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(932, 263);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // groupControl2
            // 
            this.tablePanel1.SetColumn(this.groupControl2, 0);
            this.groupControl2.Controls.Add(this.gcPM);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.tablePanel1.SetRow(this.groupControl2, 0);
            this.groupControl2.Size = new System.Drawing.Size(430, 140);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Phiểu mượn";
            // 
            // groupControl3
            // 
            this.tablePanel1.SetColumn(this.groupControl3, 1);
            this.groupControl3.Controls.Add(this.gcDocGia);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(439, 3);
            this.groupControl3.Name = "groupControl3";
            this.tablePanel1.SetRow(this.groupControl3, 0);
            this.groupControl3.Size = new System.Drawing.Size(486, 140);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Độc giả";
            // 
            // frmInfoTPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 453);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmInfoTPhieuMuon";
            this.Text = "Thông Thin Phiếu Mượn";
            this.Load += new System.EventHandler(this.frmInfoTPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gcDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocGia;
        private DevExpress.XtraGrid.GridControl gcPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuMuon;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcCTPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPM;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}