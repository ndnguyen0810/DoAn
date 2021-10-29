namespace QuanLyThuVien.From
{
    partial class frmSachDangMuon
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcSachDangMuon = new DevExpress.XtraGrid.GridControl();
            this.gvSachDangMuon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSachDangMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSachDangMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcSachDangMuon);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1154, 454);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sách đang được độc giả mượn";
            // 
            // gcSachDangMuon
            // 
            this.gcSachDangMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSachDangMuon.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcSachDangMuon.Location = new System.Drawing.Point(2, 23);
            this.gcSachDangMuon.MainView = this.gvSachDangMuon;
            this.gcSachDangMuon.Name = "gcSachDangMuon";
            this.gcSachDangMuon.Size = new System.Drawing.Size(1150, 429);
            this.gcSachDangMuon.TabIndex = 0;
            this.gcSachDangMuon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSachDangMuon});
            // 
            // gvSachDangMuon
            // 
            this.gvSachDangMuon.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvSachDangMuon.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvSachDangMuon.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvSachDangMuon.Appearance.DetailTip.Options.UseFont = true;
            this.gvSachDangMuon.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvSachDangMuon.Appearance.EvenRow.Options.UseFont = true;
            this.gvSachDangMuon.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvSachDangMuon.Appearance.Row.Options.UseFont = true;
            this.gvSachDangMuon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn6});
            this.gvSachDangMuon.GridControl = this.gcSachDangMuon;
            this.gvSachDangMuon.Name = "gvSachDangMuon";
            this.gvSachDangMuon.OptionsBehavior.ReadOnly = true;
            this.gvSachDangMuon.OptionsFind.AlwaysVisible = true;
            this.gvSachDangMuon.OptionsFind.FindNullPrompt = "Bạn cần tìm gì...";
            this.gvSachDangMuon.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvSachDangMuon.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.FieldName = "Mã sách";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.FieldName = "Tên sách";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.FieldName = "Tác giả";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Số lượng";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // frmSachDangMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 454);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSachDangMuon";
            this.Text = "Sách đang mượn";
            this.Load += new System.EventHandler(this.frmSachDangMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSachDangMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSachDangMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcSachDangMuon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSachDangMuon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}