using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWareHouse_Manager.Models;
using AppWareHouse_Manager.Forms;
using AppWareHouse_Manager.Reports;

namespace AppWareHouse_Manager
{
    public partial class frmChangePassword : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        public frmChangePassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnChangePassword;
            txtStaff_PhoneNumber.MaxLength = 10;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirm.UseSystemPasswordChar = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaff_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã số nhân viên*";
                if (txtStaff_PhoneNumber.Text == "") lblWarningTwo.Text = "*Vui lòng nhập số điện thoại*";
                if (txtNewPassword.Text == "") lblWarningThree.Text = "*Vui lòng nhập mật khẩu mới*";
                if (txtConfirm.Text == "") lblWarningFour.Text = "*Vui lòng xác nhận lại mật khẩu mới*";
                if (txtStaff_PhoneNumber.Text != "" && txtStaff_ID.Text != "" && txtNewPassword.Text != "" && txtConfirm.Text != "")
                {
                    lblWarningOne.Text = "";
                    lblWarningTwo.Text = "";
                    lblWarningThree.Text = "";
                    lblWarningFour.Text = "";
                    if (long.TryParse(txtStaff_PhoneNumber.Text, out long a)) 
                    {
                        if (txtStaff_PhoneNumber.Text.Length == 10 && long.Parse(txtStaff_PhoneNumber.Text) > 0)
                        {
                                if (context.Accounts.Where(p => p.Staff.Staff_ID == txtStaff_ID.Text && p.Staff.Staff_PhoneNumber == txtStaff_PhoneNumber.Text).Any() == true)
                                {
                                    Account account = context.Accounts.Where(p => p.Staff.Staff_ID == txtStaff_ID.Text && p.Staff.Staff_PhoneNumber == txtStaff_PhoneNumber.Text).SingleOrDefault();
                                    Account account1 = new Account();
                                    account1.Account_ID = account.Account_ID;
                                    account1.Account_UserName = account.Account_UserName;
                                    account1.Account_Password = txtConfirm.Text;
                                    account1.Account_DisplayName = account.Account_DisplayName;
                                    account1.Account_Category_ID = account.Account_Category_ID;
                                    account1.Staff_ID = txtStaff_ID.Text;
                                    context.Accounts.AddOrUpdate(account1);
                                    context.SaveChanges();
                                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                                    Close();
                                }
                                else { MessageBox.Show("Không tìm thấy nhân viên sở hữu số điện thoại này"); }
                        }
                        else { MessageBox.Show("Số điện thoại phải đủ 10 số"); }
                    }
                    else MessageBox.Show("Số điện thoại phải là số nguyên");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);  }
        }
        private void lblShow_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == true && txtConfirm.UseSystemPasswordChar == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
