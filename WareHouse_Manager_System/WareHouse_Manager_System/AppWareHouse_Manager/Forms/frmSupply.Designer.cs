
namespace AppWareHouse_Manager
{
    partial class frmSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupply));
            this.lvSupply = new System.Windows.Forms.ListView();
            this.menuStripOne = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCouponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outportCouponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supplyCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxOne = new System.Windows.Forms.ToolStripComboBox();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSupply
            // 
            this.lvSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSupply.HideSelection = false;
            this.lvSupply.Location = new System.Drawing.Point(0, 37);
            this.lvSupply.Name = "lvSupply";
            this.lvSupply.Size = new System.Drawing.Size(1306, 507);
            this.lvSupply.TabIndex = 4;
            this.lvSupply.UseCompatibleStateImageBehavior = false;
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
            this.txtSearch,
            this.settingToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.toolStripComboBoxOne,
            this.logoutToolStripMenuItem});
            this.menuStripOne.Location = new System.Drawing.Point(0, 0);
            this.menuStripOne.Name = "menuStripOne";
            this.menuStripOne.Size = new System.Drawing.Size(1306, 37);
            this.menuStripOne.TabIndex = 5;
            this.menuStripOne.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(131, 33);
            this.homeToolStripMenuItem.Text = "Trang Chủ";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCouponToolStripMenuItem,
            this.outportCouponToolStripMenuItem,
            this.toolStripSeparator1,
            this.supplyCategoryToolStripMenuItem,
            this.publisherToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 33);
            this.openToolStripMenuItem.Text = "Tùy chọn";
            // 
            // importCouponToolStripMenuItem
            // 
            this.importCouponToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.importCouponToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.importCouponToolStripMenuItem.Name = "importCouponToolStripMenuItem";
            this.importCouponToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.importCouponToolStripMenuItem.Text = "Phiếu nhập";
            this.importCouponToolStripMenuItem.Click += new System.EventHandler(this.importCouponToolStripMenuItem_Click);
            // 
            // outportCouponToolStripMenuItem
            // 
            this.outportCouponToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.outportCouponToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outportCouponToolStripMenuItem.Name = "outportCouponToolStripMenuItem";
            this.outportCouponToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.outportCouponToolStripMenuItem.Text = "Phiếu xuất";
            this.outportCouponToolStripMenuItem.Click += new System.EventHandler(this.outportCouponToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(298, 6);
            // 
            // supplyCategoryToolStripMenuItem
            // 
            this.supplyCategoryToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.supplyCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplyCategoryToolStripMenuItem.Name = "supplyCategoryToolStripMenuItem";
            this.supplyCategoryToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.supplyCategoryToolStripMenuItem.Text = "Quản lý loại vật tư";
            this.supplyCategoryToolStripMenuItem.Click += new System.EventHandler(this.supplyCategoryToolStripMenuItem_Click);
            // 
            // publisherToolStripMenuItem
            // 
            this.publisherToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.publisherToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.publisherToolStripMenuItem.Name = "publisherToolStripMenuItem";
            this.publisherToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.publisherToolStripMenuItem.Text = "Thông tin nhà cung cấp";
            this.publisherToolStripMenuItem.Click += new System.EventHandler(this.publisherToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(125, 33);
            this.searchToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 33);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.làmMớiToolStripMenuItem});
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(130, 33);
            this.settingToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.updateToolStripMenuItem.Text = "Cập nhật";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.làmMớiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.làmMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("làmMớiToolStripMenuItem.Image")));
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(91, 33);
            this.sortToolStripMenuItem.Text = "Sắp xếp";
            // 
            // toolStripComboBoxOne
            // 
            this.toolStripComboBoxOne.Name = "toolStripComboBoxOne";
            this.toolStripComboBoxOne.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBoxOne.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxOne_SelectedIndexChanged);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(40, 33);
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 544);
            this.Controls.Add(this.lvSupply);
            this.Controls.Add(this.menuStripOne);
            this.Name = "frmSupply";
            this.Text = "Quản lý vật tư";
            this.menuStripOne.ResumeLayout(false);
            this.menuStripOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvSupply;
        private System.Windows.Forms.MenuStrip menuStripOne;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCouponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outportCouponToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supplyCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxOne;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
    }
}