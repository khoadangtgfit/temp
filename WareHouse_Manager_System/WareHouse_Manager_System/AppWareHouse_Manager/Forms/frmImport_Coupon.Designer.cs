
namespace AppWareHouse_Manager
{
    partial class frmImport_Coupon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport_Coupon));
            this.menuStripOne = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputCouponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvImport_Coupon = new System.Windows.Forms.DataGridView();
            this.menuStripOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport_Coupon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripOne
            // 
            this.menuStripOne.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStripOne.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripOne.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.openToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripTextBoxSearch,
            this.chỉnhSửaToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStripOne.Location = new System.Drawing.Point(0, 0);
            this.menuStripOne.Name = "menuStripOne";
            this.menuStripOne.Size = new System.Drawing.Size(1139, 35);
            this.menuStripOne.TabIndex = 0;
            this.menuStripOne.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(131, 31);
            this.homeToolStripMenuItem.Text = "Trang Chủ";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCouponToolStripMenuItem,
            this.supplyToolStripMenuItem,
            this.toolStripSeparator1,
            this.inPhiếuNhậpToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 31);
            this.openToolStripMenuItem.Text = "Tùy chọn";
            // 
            // outputCouponToolStripMenuItem
            // 
            this.outputCouponToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.outputCouponToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outputCouponToolStripMenuItem.Name = "outputCouponToolStripMenuItem";
            this.outputCouponToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.outputCouponToolStripMenuItem.Text = "Phiếu xuất";
            this.outputCouponToolStripMenuItem.Click += new System.EventHandler(this.outputCouponToolStripMenuItem_Click);
            // 
            // supplyToolStripMenuItem
            // 
            this.supplyToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.supplyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            this.supplyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.supplyToolStripMenuItem.Text = "Vật tư";
            this.supplyToolStripMenuItem.Click += new System.EventHandler(this.supplyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // inPhiếuNhậpToolStripMenuItem
            // 
            this.inPhiếuNhậpToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.inPhiếuNhậpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inPhiếuNhậpToolStripMenuItem.Name = "inPhiếuNhậpToolStripMenuItem";
            this.inPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inPhiếuNhậpToolStripMenuItem.Text = "In Phiếu ";
            this.inPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.inPhiếuNhậpToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(124, 31);
            this.searchToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(250, 31);
            this.toolStripTextBoxSearch.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_TextChanged);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cậpNhậtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cậpNhậtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cậpNhậtToolStripMenuItem.Image")));
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.xóaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xóaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaToolStripMenuItem.Image")));
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.yearToolStripMenuItem});
            this.sortToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(91, 31);
            this.sortToolStripMenuItem.Text = "Sắp xếp";
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.dayToolStripMenuItem.Text = "Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.monthToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.monthToolStripMenuItem.Text = "Month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.yearToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.yearToolStripMenuItem.Text = "Year";
            this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(40, 31);
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dgvImport_Coupon
            // 
            this.dgvImport_Coupon.AllowUserToAddRows = false;
            this.dgvImport_Coupon.AllowUserToDeleteRows = false;
            this.dgvImport_Coupon.BackgroundColor = System.Drawing.Color.White;
            this.dgvImport_Coupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport_Coupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport_Coupon.Location = new System.Drawing.Point(0, 35);
            this.dgvImport_Coupon.Name = "dgvImport_Coupon";
            this.dgvImport_Coupon.ReadOnly = true;
            this.dgvImport_Coupon.RowHeadersWidth = 62;
            this.dgvImport_Coupon.RowTemplate.Height = 28;
            this.dgvImport_Coupon.Size = new System.Drawing.Size(1139, 496);
            this.dgvImport_Coupon.TabIndex = 1;
            // 
            // frmImport_Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 531);
            this.Controls.Add(this.dgvImport_Coupon);
            this.Controls.Add(this.menuStripOne);
            this.MainMenuStrip = this.menuStripOne;
            this.Name = "frmImport_Coupon";
            this.Text = "Quản Lý Phiếu Nhập";
            this.menuStripOne.ResumeLayout(false);
            this.menuStripOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport_Coupon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOne;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCouponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvImport_Coupon;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inPhiếuNhậpToolStripMenuItem;
    }
}