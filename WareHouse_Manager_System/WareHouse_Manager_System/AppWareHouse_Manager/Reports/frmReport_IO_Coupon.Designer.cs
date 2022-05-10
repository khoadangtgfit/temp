
namespace AppWareHouse_Manager.Reports
{
    partial class frmReport_IO_Coupon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Report_Import_CouponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTwo = new System.Windows.Forms.Panel();
            this.reportViewerIO_Coupon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbImport_Coupon_ID = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbOutput_Coupon_ID = new System.Windows.Forms.ComboBox();
            this.rbImport_Coupon = new System.Windows.Forms.RadioButton();
            this.rbOutput_Coupon = new System.Windows.Forms.RadioButton();
            this.panelOne = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Import_CouponBindingSource)).BeginInit();
            this.panelTwo.SuspendLayout();
            this.panelOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // Report_Import_CouponBindingSource
            // 
            this.Report_Import_CouponBindingSource.DataSource = typeof(AppWareHouse_Manager.Reports.Report_Import_Coupon);
            // 
            // panelTwo
            // 
            this.panelTwo.Controls.Add(this.reportViewerIO_Coupon);
            this.panelTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwo.Location = new System.Drawing.Point(0, 149);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(1279, 901);
            this.panelTwo.TabIndex = 0;
            // 
            // reportViewerIO_Coupon
            // 
            this.reportViewerIO_Coupon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Import_Coupon_DataSet";
            reportDataSource1.Value = this.Report_Import_CouponBindingSource;
            this.reportViewerIO_Coupon.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerIO_Coupon.LocalReport.ReportEmbeddedResource = "AppWareHouse_Manager.Reports.rptImport_Coupon.rdlc";
            this.reportViewerIO_Coupon.Location = new System.Drawing.Point(0, 0);
            this.reportViewerIO_Coupon.Name = "reportViewerIO_Coupon";
            this.reportViewerIO_Coupon.ServerReport.BearerToken = null;
            this.reportViewerIO_Coupon.Size = new System.Drawing.Size(1279, 901);
            this.reportViewerIO_Coupon.TabIndex = 0;
            // 
            // cmbImport_Coupon_ID
            // 
            this.cmbImport_Coupon_ID.FormattingEnabled = true;
            this.cmbImport_Coupon_ID.Location = new System.Drawing.Point(410, 23);
            this.cmbImport_Coupon_ID.Name = "cmbImport_Coupon_ID";
            this.cmbImport_Coupon_ID.Size = new System.Drawing.Size(180, 28);
            this.cmbImport_Coupon_ID.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Location = new System.Drawing.Point(700, 53);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(76, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbOutput_Coupon_ID
            // 
            this.cmbOutput_Coupon_ID.FormattingEnabled = true;
            this.cmbOutput_Coupon_ID.Location = new System.Drawing.Point(410, 82);
            this.cmbOutput_Coupon_ID.Name = "cmbOutput_Coupon_ID";
            this.cmbOutput_Coupon_ID.Size = new System.Drawing.Size(180, 28);
            this.cmbOutput_Coupon_ID.TabIndex = 4;
            // 
            // rbImport_Coupon
            // 
            this.rbImport_Coupon.AutoSize = true;
            this.rbImport_Coupon.Location = new System.Drawing.Point(244, 27);
            this.rbImport_Coupon.Name = "rbImport_Coupon";
            this.rbImport_Coupon.Size = new System.Drawing.Size(116, 24);
            this.rbImport_Coupon.TabIndex = 5;
            this.rbImport_Coupon.TabStop = true;
            this.rbImport_Coupon.Text = "Phiếu Nhập";
            this.rbImport_Coupon.UseVisualStyleBackColor = true;
            this.rbImport_Coupon.CheckedChanged += new System.EventHandler(this.rbImport_Coupon_CheckedChanged);
            // 
            // rbOutput_Coupon
            // 
            this.rbOutput_Coupon.AutoSize = true;
            this.rbOutput_Coupon.Location = new System.Drawing.Point(244, 83);
            this.rbOutput_Coupon.Name = "rbOutput_Coupon";
            this.rbOutput_Coupon.Size = new System.Drawing.Size(112, 24);
            this.rbOutput_Coupon.TabIndex = 5;
            this.rbOutput_Coupon.TabStop = true;
            this.rbOutput_Coupon.Text = "Phiếu Xuất";
            this.rbOutput_Coupon.UseVisualStyleBackColor = true;
            this.rbOutput_Coupon.CheckedChanged += new System.EventHandler(this.rbOutput_Coupon_CheckedChanged);
            // 
            // panelOne
            // 
            this.panelOne.Controls.Add(this.rbOutput_Coupon);
            this.panelOne.Controls.Add(this.rbImport_Coupon);
            this.panelOne.Controls.Add(this.cmbOutput_Coupon_ID);
            this.panelOne.Controls.Add(this.btnPrint);
            this.panelOne.Controls.Add(this.cmbImport_Coupon_ID);
            this.panelOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne.Location = new System.Drawing.Point(0, 0);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(1279, 149);
            this.panelOne.TabIndex = 0;
            // 
            // frmReport_IO_Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 1050);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Name = "frmReport_IO_Coupon";
            this.Text = "In Phiếu Nhập";
            this.Load += new System.EventHandler(this.frmReport_Import_Coupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report_Import_CouponBindingSource)).EndInit();
            this.panelTwo.ResumeLayout(false);
            this.panelOne.ResumeLayout(false);
            this.panelOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTwo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerIO_Coupon;
        private System.Windows.Forms.BindingSource Report_Import_CouponBindingSource;
        private System.Windows.Forms.ComboBox cmbImport_Coupon_ID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbOutput_Coupon_ID;
        private System.Windows.Forms.RadioButton rbImport_Coupon;
        private System.Windows.Forms.RadioButton rbOutput_Coupon;
        private System.Windows.Forms.Panel panelOne;
    }
}