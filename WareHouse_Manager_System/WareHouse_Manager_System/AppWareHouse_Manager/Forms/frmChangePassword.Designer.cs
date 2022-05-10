
namespace AppWareHouse_Manager
{
    partial class frmChangePassword
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
            this.lblStaff_ID = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtStaff_ID = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblStaff_NumberPhone = new System.Windows.Forms.Label();
            this.txtStaff_PhoneNumber = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.panelOne = new System.Windows.Forms.Panel();
            this.panelTwo = new System.Windows.Forms.Panel();
            this.panelThree = new System.Windows.Forms.Panel();
            this.panelFour = new System.Windows.Forms.Panel();
            this.lblWarningTwo = new System.Windows.Forms.Label();
            this.lblWarningThree = new System.Windows.Forms.Label();
            this.lblWarningFour = new System.Windows.Forms.Label();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaff_ID
            // 
            this.lblStaff_ID.AutoSize = true;
            this.lblStaff_ID.Location = new System.Drawing.Point(76, 41);
            this.lblStaff_ID.Name = "lblStaff_ID";
            this.lblStaff_ID.Size = new System.Drawing.Size(132, 20);
            this.lblStaff_ID.TabIndex = 0;
            this.lblStaff_ID.Text = "Mã số nhân viên :";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(98, 212);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(112, 20);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Mật khẩu mới :";
            // 
            // txtStaff_ID
            // 
            this.txtStaff_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaff_ID.Location = new System.Drawing.Point(216, 40);
            this.txtStaff_ID.Name = "txtStaff_ID";
            this.txtStaff_ID.Size = new System.Drawing.Size(263, 19);
            this.txtStaff_ID.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Location = new System.Drawing.Point(216, 215);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(263, 19);
            this.txtNewPassword.TabIndex = 2;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(37, 305);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(173, 20);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Nhập lại mật khẩu mới :";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Location = new System.Drawing.Point(216, 303);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(263, 19);
            this.txtConfirm.TabIndex = 3;
            // 
            // lblStaff_NumberPhone
            // 
            this.lblStaff_NumberPhone.AutoSize = true;
            this.lblStaff_NumberPhone.Location = new System.Drawing.Point(98, 129);
            this.lblStaff_NumberPhone.Name = "lblStaff_NumberPhone";
            this.lblStaff_NumberPhone.Size = new System.Drawing.Size(110, 20);
            this.lblStaff_NumberPhone.TabIndex = 0;
            this.lblStaff_NumberPhone.Text = "Số điện thoại :";
            // 
            // txtStaff_PhoneNumber
            // 
            this.txtStaff_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaff_PhoneNumber.Location = new System.Drawing.Point(214, 130);
            this.txtStaff_PhoneNumber.Name = "txtStaff_PhoneNumber";
            this.txtStaff_PhoneNumber.Size = new System.Drawing.Size(263, 19);
            this.txtStaff_PhoneNumber.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(214, 376);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(85, 30);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Hoàn Tất";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.ForeColor = System.Drawing.Color.Blue;
            this.lblShow.Location = new System.Drawing.Point(514, 268);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(42, 20);
            this.lblShow.TabIndex = 6;
            this.lblShow.Text = "Hiện";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.Black;
            this.panelOne.Location = new System.Drawing.Point(204, 65);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(287, 1);
            this.panelOne.TabIndex = 7;
            // 
            // panelTwo
            // 
            this.panelTwo.BackColor = System.Drawing.Color.Black;
            this.panelTwo.Location = new System.Drawing.Point(206, 152);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(284, 1);
            this.panelTwo.TabIndex = 7;
            // 
            // panelThree
            // 
            this.panelThree.BackColor = System.Drawing.Color.Black;
            this.panelThree.Location = new System.Drawing.Point(206, 240);
            this.panelThree.Name = "panelThree";
            this.panelThree.Size = new System.Drawing.Size(285, 1);
            this.panelThree.TabIndex = 7;
            // 
            // panelFour
            // 
            this.panelFour.BackColor = System.Drawing.Color.Black;
            this.panelFour.Location = new System.Drawing.Point(207, 328);
            this.panelFour.Name = "panelFour";
            this.panelFour.Size = new System.Drawing.Size(284, 1);
            this.panelFour.TabIndex = 7;
            // 
            // lblWarningTwo
            // 
            this.lblWarningTwo.AutoSize = true;
            this.lblWarningTwo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTwo.Location = new System.Drawing.Point(200, 82);
            this.lblWarningTwo.Name = "lblWarningTwo";
            this.lblWarningTwo.Size = new System.Drawing.Size(0, 20);
            this.lblWarningTwo.TabIndex = 8;
            // 
            // lblWarningThree
            // 
            this.lblWarningThree.AutoSize = true;
            this.lblWarningThree.ForeColor = System.Drawing.Color.Red;
            this.lblWarningThree.Location = new System.Drawing.Point(203, 172);
            this.lblWarningThree.Name = "lblWarningThree";
            this.lblWarningThree.Size = new System.Drawing.Size(0, 20);
            this.lblWarningThree.TabIndex = 8;
            // 
            // lblWarningFour
            // 
            this.lblWarningFour.AutoSize = true;
            this.lblWarningFour.ForeColor = System.Drawing.Color.Red;
            this.lblWarningFour.Location = new System.Drawing.Point(203, 259);
            this.lblWarningFour.Name = "lblWarningFour";
            this.lblWarningFour.Size = new System.Drawing.Size(0, 20);
            this.lblWarningFour.TabIndex = 8;
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Red;
            this.lblWarningOne.Location = new System.Drawing.Point(200, -2);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(0, 20);
            this.lblWarningOne.TabIndex = 8;
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 434);
            this.Controls.Add(this.lblWarningFour);
            this.Controls.Add(this.lblWarningThree);
            this.Controls.Add(this.lblWarningOne);
            this.Controls.Add(this.lblWarningTwo);
            this.Controls.Add(this.panelFour);
            this.Controls.Add(this.panelThree);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtStaff_PhoneNumber);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblStaff_NumberPhone);
            this.Controls.Add(this.txtStaff_ID);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblStaff_ID);
            this.Name = "frmChangePassword";
            this.Text = "Thay Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaff_ID;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtStaff_ID;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblStaff_NumberPhone;
        private System.Windows.Forms.TextBox txtStaff_PhoneNumber;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Panel panelTwo;
        private System.Windows.Forms.Panel panelThree;
        private System.Windows.Forms.Panel panelFour;
        private System.Windows.Forms.Label lblWarningTwo;
        private System.Windows.Forms.Label lblWarningThree;
        private System.Windows.Forms.Label lblWarningFour;
        private System.Windows.Forms.Label lblWarningOne;
    }
}