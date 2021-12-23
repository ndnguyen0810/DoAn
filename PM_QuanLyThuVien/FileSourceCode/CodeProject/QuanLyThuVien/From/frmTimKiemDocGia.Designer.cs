namespace QuanLyThuVien.From
{
    partial class frmTimKiemDocGia
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
            this.gcDG = new DevExpress.XtraGrid.GridControl();
            this.gvDG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.36F)});
            this.tablePanel1.Controls.Add(this.gcDG);
            this.tablePanel1.Controls.Add(this.gcSach);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1126, 429);
            this.tablePanel1.TabIndex = 1;
            // 
            // gcDG
            // 
            this.tablePanel1.SetColumn(this.gcDG, 0);
            this.gcDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDG.Location = new System.Drawing.Point(3, 3);
            this.gcDG.MainView = this.gvDG;
            this.gcDG.Name = "gcDG";
            this.tablePanel1.SetRow(this.gcDG, 0);
            this.gcDG.Size = new System.Drawing.Size(531, 423);
            this.gcDG.TabIndex = 1;
            this.gcDG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDG});
            // 
            // gvDG
            // 
            this.gvDG.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvDG.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvDG.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDG.Appearance.Row.Options.UseFont = true;
            this.gvDG.GridControl = this.gcDG;
            this.gvDG.Name = "gvDG";
            this.gvDG.OptionsBehavior.Editable = false;
            this.gvDG.OptionsBehavior.ReadOnly = true;
            this.gvDG.OptionsFind.AlwaysVisible = true;
            this.gvDG.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvDG.OptionsView.ShowGroupPanel = false;
            this.gvDG.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDG_RowClick);
            // 
            // gcSach
            // 
            this.tablePanel1.SetColumn(this.gcSach, 1);
            this.gcSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSach.Location = new System.Drawing.Point(540, 3);
            this.gcSach.MainView = this.gvSach;
            this.gcSach.Name = "gcSach";
            this.tablePanel1.SetRow(this.gcSach, 0);
            this.gcSach.Size = new System.Drawing.Size(583, 423);
            this.gcSach.TabIndex = 0;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach});
            // 
            // gvSach
            // 
            this.gvSach.GridControl = this.gcSach;
            this.gvSach.Name = "gvSach";
            this.gvSach.OptionsBehavior.ReadOnly = true;
            this.gvSach.OptionsFind.AlwaysVisible = true;
            this.gvSach.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvSach.OptionsView.ShowGroupPanel = false;
            this.gvSach.DoubleClick += new System.EventHandler(this.gvSach_DoubleClick);
            // 
            // frmTimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 429);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmTimKiemDocGia";
            this.Text = "Tìm kiếm độc giả";
            this.Load += new System.EventHandler(this.frmTimKiemDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gcDG;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDG;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach;
    }
}