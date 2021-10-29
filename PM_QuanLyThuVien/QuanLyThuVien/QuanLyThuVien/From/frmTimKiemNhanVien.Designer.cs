namespace QuanLyThuVien.From
{
    partial class frmTimKiemNhanVien
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
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gvNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcNV);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(686, 346);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm nhân viên";
            // 
            // gcNV
            // 
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNV.Location = new System.Drawing.Point(2, 23);
            this.gcNV.MainView = this.gvNV;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(682, 321);
            this.gcNV.TabIndex = 0;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNV});
            // 
            // gvNV
            // 
            this.gvNV.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNV.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvNV.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNV.Appearance.Row.Options.UseFont = true;
            this.gvNV.GridControl = this.gcNV;
            this.gvNV.Name = "gvNV";
            this.gvNV.OptionsBehavior.Editable = false;
            this.gvNV.OptionsBehavior.ReadOnly = true;
            this.gvNV.OptionsFind.AlwaysVisible = true;
            this.gvNV.OptionsFind.FindNullPrompt = "Bạn muốn tìm gì...";
            this.gvNV.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvNV.OptionsView.ShowGroupPanel = false;
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 346);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTimKiemNhanVien";
            this.Text = "Tìm kiếm nhân viên";
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNV;
    }
}