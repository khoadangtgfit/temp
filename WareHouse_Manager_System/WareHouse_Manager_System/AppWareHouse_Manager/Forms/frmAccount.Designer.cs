
namespace AppWareHouse_Manager
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.lblAccount_UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccount_DisplayName = new System.Windows.Forms.Label();
            this.txtAccount_UserName = new System.Windows.Forms.TextBox();
            this.txtAccount_Password = new System.Windows.Forms.TextBox();
            this.txtAccount_DisplayName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.panelOne = new System.Windows.Forms.Panel();
            this.panelTwo = new System.Windows.Forms.Panel();
            this.panelThree = new System.Windows.Forms.Panel();
            this.pbAddImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblWarrningOne = new System.Windows.Forms.Label();
            this.lblWarningTwo = new System.Windows.Forms.Label();
            this.lblWarningThree = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccount_UserName
            // 
            this.lblAccount_UserName.AutoSize = true;
            this.lblAccount_UserName.Location = new System.Drawing.Point(406, 88);
            this.lblAccount_UserName.Name = "lblAccount_UserName";
            this.lblAccount_UserName.Size = new System.Drawing.Size(86, 20);
            this.lblAccount_UserName.TabIndex = 0;
            this.lblAccount_UserName.Text = "Tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu :";
            // 
            // lblAccount_DisplayName
            // 
            this.lblAccount_DisplayName.AutoSize = true;
            this.lblAccount_DisplayName.Location = new System.Drawing.Point(406, 247);
            this.lblAccount_DisplayName.Name = "lblAccount_DisplayName";
            this.lblAccount_DisplayName.Size = new System.Drawing.Size(99, 20);
            this.lblAccount_DisplayName.TabIndex = 1;
            this.lblAccount_DisplayName.Text = "Tên hiển thị :";
            // 
            // txtAccount_UserName
            // 
            this.txtAccount_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount_UserName.Location = new System.Drawing.Point(548, 86);
            this.txtAccount_UserName.Name = "txtAccount_UserName";
            this.txtAccount_UserName.Size = new System.Drawing.Size(228, 19);
            this.txtAccount_UserName.TabIndex = 0;
            // 
            // txtAccount_Password
            // 
            this.txtAccount_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount_Password.Location = new System.Drawing.Point(547, 164);
            this.txtAccount_Password.Name = "txtAccount_Password";
            this.txtAccount_Password.Size = new System.Drawing.Size(228, 19);
            this.txtAccount_Password.TabIndex = 1;
            // 
            // txtAccount_DisplayName
            // 
            this.txtAccount_DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount_DisplayName.Location = new System.Drawing.Point(549, 245);
            this.txtAccount_DisplayName.Name = "txtAccount_DisplayName";
            this.txtAccount_DisplayName.Size = new System.Drawing.Size(228, 19);
            this.txtAccount_DisplayName.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnChange
            // 
            this.btnChange.AutoSize = true;
            this.btnChange.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.Location = new System.Drawing.Point(548, 321);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 30);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Thay đổi";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.AutoSize = true;
            this.btnSaveChange.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChange.Image")));
            this.btnSaveChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChange.Location = new System.Drawing.Point(683, 321);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(93, 30);
            this.btnSaveChange.TabIndex = 5;
            this.btnSaveChange.Text = "Lưu";
            this.btnSaveChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.Black;
            this.panelOne.Location = new System.Drawing.Point(549, 107);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(229, 1);
            this.panelOne.TabIndex = 5;
            // 
            // panelTwo
            // 
            this.panelTwo.BackColor = System.Drawing.Color.Black;
            this.panelTwo.Location = new System.Drawing.Point(547, 185);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(229, 1);
            this.panelTwo.TabIndex = 5;
            // 
            // panelThree
            // 
            this.panelThree.BackColor = System.Drawing.Color.Black;
            this.panelThree.Location = new System.Drawing.Point(549, 266);
            this.panelThree.Name = "panelThree";
            this.panelThree.Size = new System.Drawing.Size(229, 1);
            this.panelThree.TabIndex = 5;
            // 
            // pbAddImage
            // 
            this.pbAddImage.Location = new System.Drawing.Point(57, 88);
            this.pbAddImage.Name = "pbAddImage";
            this.pbAddImage.Size = new System.Drawing.Size(268, 208);
            this.pbAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddImage.TabIndex = 6;
            this.pbAddImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.AutoSize = true;
            this.btnAddImage.Location = new System.Drawing.Point(142, 321);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(88, 30);
            this.btnAddImage.TabIndex = 3;
            this.btnAddImage.Text = "Chọn ảnh";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImagre_Click);
            // 
            // lblWarrningOne
            // 
            this.lblWarrningOne.AutoSize = true;
            this.lblWarrningOne.ForeColor = System.Drawing.Color.Red;
            this.lblWarrningOne.Location = new System.Drawing.Point(547, 46);
            this.lblWarrningOne.Name = "lblWarrningOne";
            this.lblWarrningOne.Size = new System.Drawing.Size(0, 20);
            this.lblWarrningOne.TabIndex = 8;
            // 
            // lblWarningTwo
            // 
            this.lblWarningTwo.AutoSize = true;
            this.lblWarningTwo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTwo.Location = new System.Drawing.Point(547, 125);
            this.lblWarningTwo.Name = "lblWarningTwo";
            this.lblWarningTwo.Size = new System.Drawing.Size(0, 20);
            this.lblWarningTwo.TabIndex = 8;
            // 
            // lblWarningThree
            // 
            this.lblWarningThree.AutoSize = true;
            this.lblWarningThree.ForeColor = System.Drawing.Color.Red;
            this.lblWarningThree.Location = new System.Drawing.Point(545, 207);
            this.lblWarningThree.Name = "lblWarningThree";
            this.lblWarningThree.Size = new System.Drawing.Size(0, 20);
            this.lblWarningThree.TabIndex = 8;
            // 
            // frmAccount
            // 
            this.AcceptButton = this.btnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 387);
            this.Controls.Add(this.lblWarningThree);
            this.Controls.Add(this.lblWarningTwo);
            this.Controls.Add(this.lblWarrningOne);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.pbAddImage);
            this.Controls.Add(this.panelThree);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtAccount_DisplayName);
            this.Controls.Add(this.txtAccount_Password);
            this.Controls.Add(this.txtAccount_UserName);
            this.Controls.Add(this.lblAccount_DisplayName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccount_UserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccount";
            this.Text = "Thông tin cá nhân";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccount_DisplayName;
        private System.Windows.Forms.TextBox txtAccount_UserName;
        private System.Windows.Forms.TextBox txtAccount_Password;
        private System.Windows.Forms.TextBox txtAccount_DisplayName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Panel panelTwo;
        private System.Windows.Forms.Panel panelThree;
        private System.Windows.Forms.PictureBox pbAddImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lblWarrningOne;
        private System.Windows.Forms.Label lblWarningTwo;
        private System.Windows.Forms.Label lblWarningThree;
    }
}