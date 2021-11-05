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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcPM = new DevExpress.XtraGrid.GridControl();
            this.gvPM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcDocGiaa = new DevExpress.XtraGrid.GridControl();
            this.gvDocGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcCTPM = new DevExpress.XtraGrid.GridControl();
            this.gvCTPM = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGiaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.47F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 218F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1134, 474);
            this.tablePanel1.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25.37F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 34.63F)});
            this.tablePanel2.Controls.Add(this.groupControl2);
            this.tablePanel2.Controls.Add(this.groupControl3);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 4);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1128, 210);
            this.tablePanel2.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.tablePanel2.SetColumn(this.groupControl2, 0);
            this.groupControl2.Controls.Add(this.gcPM);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 4);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.tablePanel2.SetRow(this.groupControl2, 0);
            this.groupControl2.Size = new System.Drawing.Size(471, 202);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin phiếu mượn";
            // 
            // gcPM
            // 
            this.gcPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPM.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcPM.Location = new System.Drawing.Point(2, 22);
            this.gcPM.MainView = this.gvPM;
            this.gcPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPM.Name = "gcPM";
            this.gcPM.Size = new System.Drawing.Size(467, 178);
            this.gcPM.TabIndex = 0;
            this.gcPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPM});
            this.gcPM.DoubleClick += new System.EventHandler(this.gcPM_DoubleClick);
            // 
            // gvPM
            // 
            this.gvPM.DetailHeight = 431;
            this.gvPM.GridControl = this.gcPM;
            this.gvPM.Name = "gvPM";
            this.gvPM.OptionsBehavior.Editable = false;
            this.gvPM.OptionsBehavior.ReadOnly = true;
            this.gvPM.OptionsFind.AlwaysVisible = true;
            this.gvPM.OptionsFind.FindNullPrompt = "Bạn cần tìm gì...";
            this.gvPM.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvPM.OptionsFind.ShowFindButton = false;
            this.gvPM.OptionsView.ShowGroupPanel = false;
            this.gvPM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPM_RowClick);
            this.gvPM.DoubleClick += new System.EventHandler(this.gvPM_DoubleClick);
            // 
            // groupControl3
            // 
            this.tablePanel2.SetColumn(this.groupControl3, 1);
            this.groupControl3.Controls.Add(this.gcDocGiaa);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(480, 4);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.tablePanel2.SetRow(this.groupControl3, 0);
            this.groupControl3.Size = new System.Drawing.Size(645, 202);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thông tin độc giả";
            // 
            // gcDocGiaa
            // 
            this.gcDocGiaa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDocGiaa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDocGiaa.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcDocGiaa.Location = new System.Drawing.Point(2, 22);
            this.gcDocGiaa.MainView = this.gvDocGia;
            this.gcDocGiaa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDocGiaa.Name = "gcDocGiaa";
            this.gcDocGiaa.Size = new System.Drawing.Size(641, 178);
            this.gcDocGiaa.TabIndex = 0;
            this.gcDocGiaa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocGia});
            // 
            // gvDocGia
            // 
            this.gvDocGia.DetailHeight = 431;
            this.gvDocGia.GridControl = this.gcDocGiaa;
            this.gvDocGia.Name = "gvDocGia";
            this.gvDocGia.OptionsBehavior.Editable = false;
            this.gvDocGia.OptionsBehavior.ReadOnly = true;
            this.gvDocGia.OptionsFind.AlwaysVisible = true;
            this.gvDocGia.OptionsFind.FindNullPrompt = "Bạn cần tìm gì...";
            this.gvDocGia.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvDocGia.OptionsFind.ShowFindButton = false;
            this.gvDocGia.OptionsView.ShowGroupPanel = false;
            this.gvDocGia.DoubleClick += new System.EventHandler(this.gvDocGia_DoubleClick);
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.gcCTPM);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 222);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 1);
            this.groupControl1.Size = new System.Drawing.Size(1128, 248);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chi tiết phiếu mượn";
            // 
            // gcCTPM
            // 
            this.gcCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTPM.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcCTPM.Location = new System.Drawing.Point(2, 22);
            this.gcCTPM.MainView = this.gvCTPM;
            this.gcCTPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTPM.Name = "gcCTPM";
            this.gcCTPM.Size = new System.Drawing.Size(1124, 224);
            this.gcCTPM.TabIndex = 0;
            this.gcCTPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPM});
            // 
            // gvCTPM
            // 
            this.gvCTPM.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCTPM.Appearance.FocusedRow.Options.UseFont = true;
            this.gvCTPM.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCTPM.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gvCTPM.DetailHeight = 431;
            this.gvCTPM.GridControl = this.gcCTPM;
            this.gvCTPM.Name = "gvCTPM";
            this.gvCTPM.OptionsBehavior.Editable = false;
            this.gvCTPM.OptionsBehavior.ReadOnly = true;
            this.gvCTPM.OptionsFind.AlwaysVisible = true;
            this.gvCTPM.OptionsFind.FindNullPrompt = "Bạn cần tìm gì...";
            this.gvCTPM.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvCTPM.OptionsFind.ShowFindButton = false;
            this.gvCTPM.OptionsView.ShowGroupPanel = false;
            // 
            // frmInfoTPhieuMuon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 474);
            this.Controls.Add(this.tablePanel1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInfoTPhieuMuon";
            this.Text = "frmInfoTPhieuMuon";
            this.Load += new System.EventHandler(this.frmInfoTPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGiaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPM;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcDocGiaa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocGia;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcCTPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPM;
    }
}