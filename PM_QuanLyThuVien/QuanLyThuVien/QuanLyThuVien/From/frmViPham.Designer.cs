namespace QuanLyThuVien.From
{
    partial class frmViPham
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
            this.gcPhat = new DevExpress.XtraGrid.GridControl();
            this.gvPhat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbLydoPhat = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblMaPM = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLydoPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcPhat
            // 
            this.tablePanel1.SetColumn(this.gcPhat, 0);
            this.gcPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhat.Location = new System.Drawing.Point(3, 86);
            this.gcPhat.MainView = this.gvPhat;
            this.gcPhat.Name = "gcPhat";
            this.gcPhat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbbLydoPhat});
            this.tablePanel1.SetRow(this.gcPhat, 1);
            this.gcPhat.Size = new System.Drawing.Size(777, 365);
            this.gcPhat.TabIndex = 0;
            this.gcPhat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhat,
            this.gridView1});
            // 
            // gvPhat
            // 
            this.gvPhat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.gvPhat.GridControl = this.gcPhat;
            this.gvPhat.Name = "gvPhat";
            this.gvPhat.OptionsView.ShowGroupPanel = false;
            // 
            // col1
            // 
            this.col1.Caption = "Số thứ tự";
            this.col1.Name = "col1";
            this.col1.Visible = true;
            this.col1.VisibleIndex = 0;
            // 
            // col2
            // 
            this.col2.Caption = "Mã sách";
            this.col2.Name = "col2";
            this.col2.Visible = true;
            this.col2.VisibleIndex = 1;
            // 
            // col3
            // 
            this.col3.Caption = "Lý do phạt";
            this.col3.ColumnEdit = this.cbbLydoPhat;
            this.col3.Name = "col3";
            this.col3.Visible = true;
            this.col3.VisibleIndex = 2;
            // 
            // cbbLydoPhat
            // 
            this.cbbLydoPhat.AutoHeight = false;
            this.cbbLydoPhat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLydoPhat.Items.AddRange(new object[] {
            "Quá hạn",
            "Mất sách",
            "Rách sách khổ 13x19",
            "Rách sách khổ 17x24",
            "Rách sách khổ 19x27"});
            this.cbbLydoPhat.Name = "cbbLydoPhat";
            // 
            // col4
            // 
            this.col4.Caption = "Ghi chú";
            this.col4.Name = "col4";
            this.col4.Visible = true;
            this.col4.VisibleIndex = 3;
            // 
            // col5
            // 
            this.col5.Caption = "Tiền";
            this.col5.Name = "col5";
            this.col5.Visible = true;
            this.col5.VisibleIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcPhat;
            this.gridView1.Name = "gridView1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.12F)});
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Controls.Add(this.gcPhat);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 83F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(783, 454);
            this.tablePanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.lblMaPM);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 0);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(777, 77);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // lblMaPM
            // 
            this.lblMaPM.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMaPM.Appearance.Options.UseFont = true;
            this.lblMaPM.Location = new System.Drawing.Point(75, 23);
            this.lblMaPM.Name = "lblMaPM";
            this.lblMaPM.Size = new System.Drawing.Size(75, 16);
            this.lblMaPM.TabIndex = 0;
            this.lblMaPM.Text = "labelControl1";
            // 
            // frmViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 454);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý vi phạm";
            this.Load += new System.EventHandler(this.frmViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLydoPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPhat;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblMaPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhat;
        private DevExpress.XtraGrid.Columns.GridColumn col1;
        private DevExpress.XtraGrid.Columns.GridColumn col2;
        private DevExpress.XtraGrid.Columns.GridColumn col3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbbLydoPhat;
        private DevExpress.XtraGrid.Columns.GridColumn col4;
        private DevExpress.XtraGrid.Columns.GridColumn col5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}