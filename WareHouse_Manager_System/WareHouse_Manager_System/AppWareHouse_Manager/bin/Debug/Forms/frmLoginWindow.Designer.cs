
namespace AppWareHouse_Manager
{
    partial class frmLoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginWindow));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWarningThree = new System.Windows.Forms.Label();
            this.pbWareHouse_Image = new System.Windows.Forms.PictureBox();
            this.pbPassword_Image = new System.Windows.Forms.PictureBox();
            this.pbAccount_Image = new System.Windows.Forms.PictureBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.panelTwo = new System.Windows.Forms.Panel();
            this.panelOne = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.lblWarningTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWareHouse_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(470, 223);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Location = new System.Drawing.Point(338, 223);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWarningThree
            // 
            this.lblWarningThree.AutoSize = true;
            this.lblWarningThree.ForeColor = System.Drawing.Color.Red;
            this.lblWarningThree.Location = new System.Drawing.Point(420, 25);
            this.lblWarningThree.Name = "lblWarningThree";
            this.lblWarningThree.Size = new System.Drawing.Size(0, 17);
            this.lblWarningThree.TabIndex = 24;
            // 
            // pbWareHouse_Image
            // 
            this.pbWareHouse_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbWareHouse_Image.Image = ((System.Drawing.Image)(resources.GetObject("pbWareHouse_Image.Image")));
            this.pbWareHouse_Image.Location = new System.Drawing.Point(12, 25);
            this.pbWareHouse_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbWareHouse_Image.Name = "pbWareHouse_Image";
            this.pbWareHouse_Image.Size = new System.Drawing.Size(251, 233);
            this.pbWareHouse_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWareHouse_Image.TabIndex = 33;
            this.pbWareHouse_Image.TabStop = false;
            // 
            // pbPassword_Image
            // 
            this.pbPassword_Image.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword_Image.Image")));
            this.pbPassword_Image.Location = new System.Drawing.Point(297, 142);
            this.pbPassword_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPassword_Image.Name = "pbPassword_Image";
            this.pbPassword_Image.Size = new System.Drawing.Size(44, 31);
            this.pbPassword_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword_Image.TabIndex = 56;
            this.pbPassword_Image.TabStop = false;
            // 
            // pbAccount_Image
            // 
            this.pbAccount_Image.Image = ((System.Drawing.Image)(resources.GetObject("pbAccount_Image.Image")));
            this.pbAccount_Image.Location = new System.Drawing.Point(297, 74);
            this.pbAccount_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAccount_Image.Name = "pbAccount_Image";
            this.pbAccount_Image.Size = new System.Drawing.Size(44, 31);
            this.pbAccount_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccount_Image.TabIndex = 55;
            this.pbAccount_Image.TabStop = false;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.ForeColor = System.Drawing.Color.Blue;
            this.lblShow.Location = new System.Drawing.Point(675, 157);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(37, 17);
            this.lblShow.TabIndex = 54;
            this.lblShow.Text = "Hiện";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.Color.White;
            this.lblChangePassword.ForeColor = System.Drawing.Color.Blue;
            this.lblChangePassword.Location = new System.Drawing.Point(340, 183);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(117, 17);
            this.lblChangePassword.TabIndex = 53;
            this.lblChangePassword.Text = "Quên mật khẩu ?";
            this.lblChangePassword.Click += new System.EventHandler(this.lblChangePassword_Click);
            // 
            // panelTwo
            // 
            this.panelTwo.BackColor = System.Drawing.Color.Black;
            this.panelTwo.Location = new System.Drawing.Point(428, 169);
            this.panelTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(231, 1);
            this.panelTwo.TabIndex = 51;
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.Black;
            this.panelOne.Location = new System.Drawing.Point(428, 105);
            this.panelOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(231, 1);
            this.panelOne.TabIndex = 52;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(347, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 17);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Mật khẩu :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(347, 86);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 17);
            this.lblUserName.TabIndex = 47;
            this.lblUserName.Text = "Tài khoản :";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Location = new System.Drawing.Point(428, 154);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(227, 15);
            this.txtUserPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(428, 88);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 16);
            this.txtUserName.TabIndex = 0;
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Red;
            this.lblWarningOne.Location = new System.Drawing.Point(425, 58);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(0, 17);
            this.lblWarningOne.TabIndex = 57;
            // 
            // lblWarningTwo
            // 
            this.lblWarningTwo.AutoSize = true;
            this.lblWarningTwo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTwo.Location = new System.Drawing.Point(425, 121);
            this.lblWarningTwo.Name = "lblWarningTwo";
            this.lblWarningTwo.Size = new System.Drawing.Size(0, 17);
            this.lblWarningTwo.TabIndex = 57;
            // 
            // frmLoginWindow
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 276);
            this.Controls.Add(this.lblWarningTwo);
            this.Controls.Add(this.lblWarningOne);
            this.Controls.Add(this.pbPassword_Image);
            this.Controls.Add(this.pbAccount_Image);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pbWareHouse_Image);
            this.Controls.Add(this.lblWarningThree);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoginWindow";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pbWareHouse_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWarningThree;
        private System.Windows.Forms.PictureBox pbWareHouse_Image;
        private System.Windows.Forms.PictureBox pbPassword_Image;
        private System.Windows.Forms.PictureBox pbAccount_Image;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Panel panelTwo;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.Label lblWarningTwo;
    }
}

