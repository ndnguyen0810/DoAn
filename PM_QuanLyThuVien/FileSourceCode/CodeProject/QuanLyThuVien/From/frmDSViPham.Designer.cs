namespace QuanLyThuVien.From
{
    partial class frmDSViPham
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
            this.components = new System.ComponentModel.Container();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcVP = new DevExpress.XtraGrid.GridControl();
            this.gvVP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDG = new DevExpress.XtraGrid.GridControl();
            this.gvDG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27.68F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.32F)});
            this.tablePanel1.Controls.Add(this.gcVP);
            this.tablePanel1.Controls.Add(this.gcDG);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(849, 446);
            this.tablePanel1.TabIndex = 0;
            // 
            // gcVP
            // 
            this.tablePanel1.SetColumn(this.gcVP, 1);
            this.gcVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVP.Location = new System.Drawing.Point(395, 3);
            this.gcVP.MainView = this.gvVP;
            this.gcVP.Name = "gcVP";
            this.tablePanel1.SetRow(this.gcVP, 0);
            this.gcVP.Size = new System.Drawing.Size(451, 440);
            this.gcVP.TabIndex = 0;
            this.gcVP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVP});
            // 
            // gvVP
            // 
            this.gvVP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvVP.GridControl = this.gcVP;
            this.gvVP.Name = "gvVP";
            this.gvVP.OptionsBehavior.Editable = false;
            this.gvVP.OptionsBehavior.ReadOnly = true;
            this.gvVP.OptionsFind.AlwaysVisible = true;
            this.gvVP.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gvVP.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvVP.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã sách";
            this.gridColumn5.FieldName = "MASACH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Lý do phạt";
            this.gridColumn6.FieldName = "LYDOPHAT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số lượng";
            this.gridColumn7.FieldName = "SOLUONG";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Đơn vị tính";
            this.gridColumn8.FieldName = "DONVITINH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tiền";
            this.gridColumn9.DisplayFormat.FormatString = "#,### VNĐ";
            this.gridColumn9.FieldName = "TIEN";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // gcDG
            // 
            this.tablePanel1.SetColumn(this.gcDG, 0);
            this.gcDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDG.Location = new System.Drawing.Point(3, 3);
            this.gcDG.MainView = this.gvDG;
            this.gcDG.Name = "gcDG";
            this.tablePanel1.SetRow(this.gcDG, 0);
            this.gcDG.Size = new System.Drawing.Size(386, 440);
            this.gcDG.TabIndex = 0;
            this.gcDG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDG});
            // 
            // gvDG
            // 
            this.gvDG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn11,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn10});
            this.gvDG.GridControl = this.gcDG;
            this.gvDG.Name = "gvDG";
            this.gvDG.OptionsBehavior.Editable = false;
            this.gvDG.OptionsBehavior.ReadOnly = true;
            this.gvDG.OptionsFind.AlwaysVisible = true;
            this.gvDG.OptionsView.ShowGroupPanel = false;
            this.gvDG.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDG_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã phiếu phạt";
            this.gridColumn1.FieldName = "MAPHAT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã phiếu mượn";
            this.gridColumn2.FieldName = "MAPM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày phạt";
            this.gridColumn3.FieldName = "NGAYPHAT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tiền phạt";
            this.gridColumn4.DisplayFormat.FormatString = "#,### VNĐ";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "TONGTIENPHAT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã độc giả";
            this.gridColumn10.FieldName = "MADG";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Họ tên";
            this.gridColumn11.FieldName = "HOTEN";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // frmDSViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 446);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmDSViPham";
            this.Text = "Danh sách vi phạm";
            this.Load += new System.EventHandler(this.frmDSViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gcVP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVP;
        private DevExpress.XtraGrid.GridControl gcDG;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}