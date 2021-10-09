namespace QuanLyThuVien.From
{
    partial class frmDatePitker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatePitker));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHUy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.txtHanTra = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn ngày hẹn trả sách";
            // 
            // btnHUy
            // 
            this.btnHUy.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUy.Appearance.Options.UseFont = true;
            this.btnHUy.Location = new System.Drawing.Point(37, 55);
            this.btnHUy.Name = "btnHUy";
            this.btnHUy.Size = new System.Drawing.Size(75, 23);
            this.btnHUy.TabIndex = 2;
            this.btnHUy.Text = "Huỷ";
            this.btnHUy.Click += new System.EventHandler(this.btnHUy_Click);
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.Location = new System.Drawing.Point(155, 55);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtHanTra
            // 
            this.txtHanTra.EditValue = null;
            this.txtHanTra.Location = new System.Drawing.Point(37, 26);
            this.txtHanTra.Name = "txtHanTra";
            this.txtHanTra.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanTra.Properties.Appearance.Options.UseFont = true;
            this.txtHanTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHanTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHanTra.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtHanTra.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtHanTra.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtHanTra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtHanTra.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtHanTra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtHanTra.Size = new System.Drawing.Size(193, 22);
            this.txtHanTra.TabIndex = 3;
            // 
            // frmDatePitker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 105);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHUy);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtHanTra);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmDatePitker.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatePitker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hạn trả";
            this.Load += new System.EventHandler(this.frmDatePitker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHUy;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.DateEdit txtHanTra;
    }
}