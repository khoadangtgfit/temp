
namespace AppWareHouse_Manager.Reports
{
    partial class frmStatistical
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
            this.panelOne = new System.Windows.Forms.Panel();
            this.panelTwo = new System.Windows.Forms.Panel();
            this.reportViewerStatistical = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbSupply_QuantityLeft = new System.Windows.Forms.RadioButton();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.rbImport_Coupon = new System.Windows.Forms.RadioButton();
            this.dateTimePickerOne = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTwo = new System.Windows.Forms.DateTimePicker();
            this.rbOutput_Coupon = new System.Windows.Forms.RadioButton();
            this.panelOne.SuspendLayout();
            this.panelTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne
            // 
            this.panelOne.Controls.Add(this.rbOutput_Coupon);
            this.panelOne.Controls.Add(this.dateTimePickerTwo);
            this.panelOne.Controls.Add(this.dateTimePickerOne);
            this.panelOne.Controls.Add(this.rbImport_Coupon);
            this.panelOne.Controls.Add(this.btnStatistical);
            this.panelOne.Controls.Add(this.rbSupply_QuantityLeft);
            this.panelOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne.Location = new System.Drawing.Point(0, 0);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(1211, 170);
            this.panelOne.TabIndex = 0;
            // 
            // panelTwo
            // 
            this.panelTwo.Controls.Add(this.reportViewerStatistical);
            this.panelTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwo.Location = new System.Drawing.Point(0, 170);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(1211, 280);
            this.panelTwo.TabIndex = 1;
            // 
            // reportViewerStatistical
            // 
            this.reportViewerStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerStatistical.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStatistical.Name = "reportViewerStatistical";
            this.reportViewerStatistical.ServerReport.BearerToken = null;
            this.reportViewerStatistical.Size = new System.Drawing.Size(1211, 280);
            this.reportViewerStatistical.TabIndex = 0;
            // 
            // rbSupply_QuantityLeft
            // 
            this.rbSupply_QuantityLeft.AutoSize = true;
            this.rbSupply_QuantityLeft.Location = new System.Drawing.Point(27, 25);
            this.rbSupply_QuantityLeft.Name = "rbSupply_QuantityLeft";
            this.rbSupply_QuantityLeft.Size = new System.Drawing.Size(128, 24);
            this.rbSupply_QuantityLeft.TabIndex = 0;
            this.rbSupply_QuantityLeft.TabStop = true;
            this.rbSupply_QuantityLeft.Text = "Số Hàng Tồn";
            this.rbSupply_QuantityLeft.UseVisualStyleBackColor = true;
            // 
            // btnStatistical
            // 
            this.btnStatistical.AutoSize = true;
            this.btnStatistical.Location = new System.Drawing.Point(763, 74);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(85, 30);
            this.btnStatistical.TabIndex = 1;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // rbImport_Coupon
            // 
            this.rbImport_Coupon.AutoSize = true;
            this.rbImport_Coupon.Location = new System.Drawing.Point(27, 76);
            this.rbImport_Coupon.Name = "rbImport_Coupon";
            this.rbImport_Coupon.Size = new System.Drawing.Size(115, 24);
            this.rbImport_Coupon.TabIndex = 2;
            this.rbImport_Coupon.TabStop = true;
            this.rbImport_Coupon.Text = "Hàng Nhập";
            this.rbImport_Coupon.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerOne
            // 
            this.dateTimePickerOne.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOne.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOne.Location = new System.Drawing.Point(219, 74);
            this.dateTimePickerOne.Name = "dateTimePickerOne";
            this.dateTimePickerOne.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerOne.TabIndex = 3;
            // 
            // dateTimePickerTwo
            // 
            this.dateTimePickerTwo.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTwo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTwo.Location = new System.Drawing.Point(447, 74);
            this.dateTimePickerTwo.Name = "dateTimePickerTwo";
            this.dateTimePickerTwo.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTwo.TabIndex = 3;
            // 
            // rbOutput_Coupon
            // 
            this.rbOutput_Coupon.AutoSize = true;
            this.rbOutput_Coupon.Location = new System.Drawing.Point(27, 122);
            this.rbOutput_Coupon.Name = "rbOutput_Coupon";
            this.rbOutput_Coupon.Size = new System.Drawing.Size(111, 24);
            this.rbOutput_Coupon.TabIndex = 4;
            this.rbOutput_Coupon.TabStop = true;
            this.rbOutput_Coupon.Text = "Hàng Xuất";
            this.rbOutput_Coupon.UseVisualStyleBackColor = true;
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1211, 450);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Name = "frmStatistical";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmStatistical_Load);
            this.panelOne.ResumeLayout(false);
            this.panelOne.PerformLayout();
            this.panelTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Panel panelTwo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStatistical;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.RadioButton rbSupply_QuantityLeft;
        private System.Windows.Forms.DateTimePicker dateTimePickerTwo;
        private System.Windows.Forms.DateTimePicker dateTimePickerOne;
        private System.Windows.Forms.RadioButton rbImport_Coupon;
        private System.Windows.Forms.RadioButton rbOutput_Coupon;
    }
}