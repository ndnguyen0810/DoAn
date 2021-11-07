namespace QuanLyThuVien.From
{
    partial class frmTimKiemSach
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
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.L = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcSach);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 416);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tổng hợp sách trong thư viện";
            // 
            // gcSach
            // 
            this.gcSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSach.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcSach.Location = new System.Drawing.Point(2, 23);
            this.gcSach.MainView = this.gvSach;
            this.gcSach.Name = "gcSach";
            this.gcSach.Size = new System.Drawing.Size(1004, 391);
            this.gcSach.TabIndex = 1;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach});
            // 
            // gvSach
            // 
            this.gvSach.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvSach.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSach.Appearance.Row.Options.UseFont = true;
            this.gvSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.L,
            this.gridColumn7,
            this.gridColumn8});
            this.gvSach.GridControl = this.gcSach;
            this.gvSach.Name = "gvSach";
            this.gvSach.OptionsBehavior.Editable = false;
            this.gvSach.OptionsBehavior.ReadOnly = true;
            this.gvSach.OptionsFind.AlwaysVisible = true;
            this.gvSach.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvSach.OptionsFind.FindNullPrompt = "Bạn muốn tìm gì...";
            this.gvSach.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvSach.OptionsFind.ShowSearchNavButtons = false;
            this.gvSach.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.FieldName = "Mã sách";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.FieldName = "Tên sách";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 247;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.FieldName = "Tác giả";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 217;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.FieldName = "Nhà xuất bản";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 256;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.FieldName = "Vị trí";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 123;
            // 
            // L
            // 
            this.L.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.L.AppearanceHeader.Options.UseFont = true;
            this.L.FieldName = "Loại sách";
            this.L.Name = "L";
            this.L.Visible = true;
            this.L.VisibleIndex = 5;
            this.L.Width = 74;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.FieldName = "Năm xuất bản";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 110;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.FieldName = "Số lượng";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 72;
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 416);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTimKiemSach";
            this.Text = "Tìm kiếm sách";
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn L;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}