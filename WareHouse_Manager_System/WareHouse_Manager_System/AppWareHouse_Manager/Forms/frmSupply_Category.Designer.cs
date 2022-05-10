
namespace AppWareHouse_Manager
{
    partial class frmSupply_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupply_Category));
            this.lvSupply_Category = new System.Windows.Forms.ListView();
            this.menuStripOne = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vậtTưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSupply_Category_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupply_Category_ID = new System.Windows.Forms.TextBox();
            this.txtSupply_Category_Name = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelOne = new System.Windows.Forms.Panel();
            this.panelTwo = new System.Windows.Forms.Panel();
            this.menuStripOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSupply_Category
            // 
            this.lvSupply_Category.HideSelection = false;
            this.lvSupply_Category.Location = new System.Drawing.Point(0, 154);
            this.lvSupply_Category.Name = "lvSupply_Category";
            this.lvSupply_Category.Size = new System.Drawing.Size(687, 353);
            this.lvSupply_Category.TabIndex = 3;
            this.lvSupply_Category.UseCompatibleStateImageBehavior = false;
            this.lvSupply_Category.SelectedIndexChanged += new System.EventHandler(this.lvSupply_Category_SelectedIndexChanged);
            // 
            // menuStripOne
            // 
            this.menuStripOne.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStripOne.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripOne.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.supplyWindowToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.txtSearch,
            this.toolStripMenuItemLogout});
            this.menuStripOne.Location = new System.Drawing.Point(0, 0);
            this.menuStripOne.Name = "menuStripOne";
            this.menuStripOne.Size = new System.Drawing.Size(687, 35);
            this.menuStripOne.TabIndex = 11;
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
            // supplyWindowToolStripMenuItem
            // 
            this.supplyWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vậtTưToolStripMenuItem,
            this.phiếuNhậpToolStripMenuItem,
            this.phiếuXuấtToolStripMenuItem});
            this.supplyWindowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplyWindowToolStripMenuItem.Name = "supplyWindowToolStripMenuItem";
            this.supplyWindowToolStripMenuItem.Size = new System.Drawing.Size(103, 31);
            this.supplyWindowToolStripMenuItem.Text = "Tùy Chọn";
            // 
            // vậtTưToolStripMenuItem
            // 
            this.vậtTưToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.vậtTưToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vậtTưToolStripMenuItem.Name = "vậtTưToolStripMenuItem";
            this.vậtTưToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.vậtTưToolStripMenuItem.Text = "Vật Tư";
            this.vậtTưToolStripMenuItem.Click += new System.EventHandler(this.vậtTưToolStripMenuItem_Click);
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.phiếuNhậpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu Nhập";
            this.phiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpToolStripMenuItem_Click);
            // 
            // phiếuXuấtToolStripMenuItem
            // 
            this.phiếuXuấtToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.phiếuXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phiếuXuấtToolStripMenuItem.Name = "phiếuXuấtToolStripMenuItem";
            this.phiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.phiếuXuấtToolStripMenuItem.Text = "Phiếu Xuất";
            this.phiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(125, 31);
            this.searchToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 31);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolStripMenuItemLogout
            // 
            this.toolStripMenuItemLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemLogout.Image")));
            this.toolStripMenuItemLogout.Name = "toolStripMenuItemLogout";
            this.toolStripMenuItemLogout.Size = new System.Drawing.Size(40, 31);
            this.toolStripMenuItemLogout.Click += new System.EventHandler(this.toolStripMenuItemLogout_Click);
            // 
            // lblSupply_Category_ID
            // 
            this.lblSupply_Category_ID.AutoSize = true;
            this.lblSupply_Category_ID.Location = new System.Drawing.Point(22, 61);
            this.lblSupply_Category_ID.Name = "lblSupply_Category_ID";
            this.lblSupply_Category_ID.Size = new System.Drawing.Size(124, 20);
            this.lblSupply_Category_ID.TabIndex = 12;
            this.lblSupply_Category_ID.Text = "Mã Loại Vật Tư :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Loại Vật Tư :";
            // 
            // txtSupply_Category_ID
            // 
            this.txtSupply_Category_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupply_Category_ID.Location = new System.Drawing.Point(181, 59);
            this.txtSupply_Category_ID.Name = "txtSupply_Category_ID";
            this.txtSupply_Category_ID.Size = new System.Drawing.Size(203, 19);
            this.txtSupply_Category_ID.TabIndex = 0;
            // 
            // txtSupply_Category_Name
            // 
            this.txtSupply_Category_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupply_Category_Name.Location = new System.Drawing.Point(181, 104);
            this.txtSupply_Category_Name.Name = "txtSupply_Category_Name";
            this.txtSupply_Category_Name.Size = new System.Drawing.Size(203, 19);
            this.txtSupply_Category_Name.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(466, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(466, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.Black;
            this.panelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOne.Location = new System.Drawing.Point(181, 80);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(200, 1);
            this.panelOne.TabIndex = 14;
            // 
            // panelTwo
            // 
            this.panelTwo.BackColor = System.Drawing.Color.Black;
            this.panelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTwo.Location = new System.Drawing.Point(181, 129);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(200, 1);
            this.panelTwo.TabIndex = 14;
            // 
            // frmSupply_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 507);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSupply_Category_Name);
            this.Controls.Add(this.txtSupply_Category_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSupply_Category_ID);
            this.Controls.Add(this.lvSupply_Category);
            this.Controls.Add(this.menuStripOne);
            this.MainMenuStrip = this.menuStripOne;
            this.Name = "frmSupply_Category";
            this.Text = "Loại vật tư";
            this.menuStripOne.ResumeLayout(false);
            this.menuStripOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvSupply_Category;
        private System.Windows.Forms.MenuStrip menuStripOne;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.Label lblSupply_Category_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupply_Category_ID;
        private System.Windows.Forms.TextBox txtSupply_Category_Name;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem vậtTưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Panel panelTwo;
    }
}