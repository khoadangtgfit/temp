using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWareHouse_Manager.Models;
using AppWareHouse_Manager.Forms;
using AppWareHouse_Manager.Reports;

namespace AppWareHouse_Manager
{
    public partial class frmAccount : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        string fileName;
        public frmAccount(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Account account = context.Accounts.Where(p => p.Account_ID == user).SingleOrDefault();
            this.AcceptButton = btnChange;
            txtAccount_UserName.Text = account.Account_UserName;
            txtAccount_Password.Text = account.Account_Password;
            txtAccount_DisplayName.Text = account.Account_DisplayName;
            pbAddImage.Image = ConvertBinaryToImage(account.Staff.Staff_Image);
            userName = account.Account_ID;
            Disable_Text();
        }

        private void Disable_Text()
        {
            txtAccount_UserName.Enabled = false;
            txtAccount_Password.Enabled = false;
            txtAccount_DisplayName.Enabled = false;
            btnSaveChange.Enabled = false;
            btnAddImage.Enabled = false;
            btnChange.Enabled = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage homePage = new frmHomePage(userName);
            homePage.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtAccount_UserName.Enabled = true;
            txtAccount_Password.Enabled = true;
            txtAccount_DisplayName.Enabled = true;
            btnSaveChange.Enabled = true;
            btnAddImage.Enabled = true;
            btnChange.Enabled = false;
        }

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Dispose();
                return memoryStream.ToArray();
            }
        }

        private Image ConvertBinaryToImage(byte[] data) { using (MemoryStream memoryStream = new MemoryStream(data)) return Image.FromStream(memoryStream); }

        private void btnAddImagre_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg", ValidateNames = true, Multiselect = false };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    pbAddImage.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccount_UserName.Text == "") lblWarrningOne.Text = "*Vui lòng nhập tên tài khoản*";
                if (txtAccount_Password.Text == "") lblWarningTwo.Text = "*Vui lòng nhập mật khẩu*";
                if (txtAccount_DisplayName.Text == "") lblWarningThree.Text = "*Vui lòng nhập têm hiển thị*";
                if (txtAccount_UserName.Text != "" && txtAccount_Password.Text != "" && txtAccount_DisplayName.Text != "")
                 {
                    Account acc = context.Accounts.Where(p => p.Account_ID == userName).SingleOrDefault();
                    Staff staff = context.Staffs.Where(p => p.Staff_ID == acc.Staff_ID).SingleOrDefault();
                    Staff staff1 = new Staff();
                    staff1.Staff_ID = staff.Staff_ID;
                    staff1.Staff_Name = staff.Staff_Name;
                    staff1.Staff_PhoneNumber = staff.Staff_PhoneNumber;
                    staff1.Staff_Salary = staff.Staff_Salary;
                    staff1.Staff_Address = staff.Staff_Address;
                    staff1.Staff_Category_ID = staff.Staff_Category_ID;
                    staff1.Staff_Image = ConvertImageToBinary(pbAddImage.Image);
                    context.Staffs.AddOrUpdate(staff1);
                    context.SaveChanges();       
                    Account account = new Account();
                    account.Account_ID = acc.Account_ID;
                    account.Account_UserName = txtAccount_UserName.Text;
                    account.Account_Password = txtAccount_Password.Text;
                    account.Account_DisplayName = txtAccount_DisplayName.Text;
                    account.Staff_ID = acc.Staff_ID;
                    account.Account_Category_ID = acc.Account_Category_ID;
                    context.Accounts.AddOrUpdate(account);
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                    lblWarrningOne.Text = "";
                    lblWarningTwo.Text = "";
                    lblWarningThree.Text = "";
                    Disable_Text();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) { if (MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); } }
    }
}
