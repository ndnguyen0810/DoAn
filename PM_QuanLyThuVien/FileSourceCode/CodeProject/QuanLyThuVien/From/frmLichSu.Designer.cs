namespace QuanLyThuVien.From
{
    partial class frmLichSu
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
            this.gcLS = new DevExpress.XtraGrid.GridControl();
            this.gvLS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLS)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLS
            // 
            this.gcLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLS.Location = new System.Drawing.Point(0, 0);
            this.gcLS.MainView = this.gvLS;
            this.gcLS.Name = "gcLS";
            this.gcLS.Size = new System.Drawing.Size(661, 358);
            this.gcLS.TabIndex = 0;
            this.gcLS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLS});
            // 
            // gvLS
            // 
            this.gvLS.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvLS.Appearance.FocusedCell.Options.UseFont = true;
            this.gvLS.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvLS.Appearance.FocusedRow.Options.UseFont = true;
            this.gvLS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvLS.GridControl = this.gcLS;
            this.gvLS.Name = "gvLS";
            this.gvLS.OptionsBehavior.Editable = false;
            this.gvLS.OptionsBehavior.ReadOnly = true;
            this.gvLS.OptionsFind.AlwaysVisible = true;
            this.gvLS.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 54;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã tài khoản";
            this.gridColumn2.FieldName = "MATK";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 127;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Họ và tên";
            this.gridColumn3.FieldName = "TENNV";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 140;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thời gian đăng nhập";
            this.gridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "THOIGIAN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 179;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chức vụ";
            this.gridColumn5.FieldName = "TENCV";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 181;
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 358);
            this.Controls.Add(this.gcLS);
            this.Name = "frmLichSu";
            this.Text = "Lịch sử đăng nhập";
            this.Load += new System.EventHandler(this.frmLichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}