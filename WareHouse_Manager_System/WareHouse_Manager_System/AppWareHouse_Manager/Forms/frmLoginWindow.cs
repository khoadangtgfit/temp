using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWareHouse_Manager.Models;
using AppWareHouse_Manager.Forms;
using AppWareHouse_Manager.Reports;

namespace AppWareHouse_Manager
{
    public partial class frmLoginWindow : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        public frmLoginWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnLogin;
            txtUserPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "") lblWarningOne.Text = "*Vui lòng nhập tên tài khoản*";
                if (txtUserPassword.Text == "") lblWarningTwo.Text = "*Vui lòng nhập mật khẩu*";
                if (txtUserName.Text != "" && txtUserPassword.Text != "")
                {
                    lblWarningOne.Text = "";
                    lblWarningTwo.Text = "";
                    lblWarningThree.Text = "";
                    if (context.Accounts.Where(p => p.Account_UserName == txtUserName.Text && p.Account_Password == txtUserPassword.Text).Any() == true)
                    {
                        this.Hide();
                        Account account = context.Accounts.Where(p => p.Account_UserName == txtUserName.Text).SingleOrDefault();
                        frmHomePage homePage = new frmHomePage(account.Account_ID);
                        homePage.ShowDialog();
                    }
                    else lblWarningThree.Text = "*Tài khoản hoặc mật khẩu bạn nhập đã sai!*";
                }                 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        { 
            frmChangePassword changePassword = new frmChangePassword();
            changePassword.ShowDialog();
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.UseSystemPasswordChar) txtUserPassword.UseSystemPasswordChar = false;
            else txtUserPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e) {  Application.Exit(); }
    }
}
