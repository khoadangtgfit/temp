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
    public partial class frmUpdate_Staff : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string fileName;
        public frmUpdate_Staff()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnUpdate;
            FillStaff_Category_Name();
            cmbStaff_Category_Name.Text = "";
            txtStaff_NumberPhone.MaxLength = 10;
        }

        private void FillStaff_Category_Name ()
        {
            cmbStaff_Category_Name.DataSource = context.Staff_Category.ToList();
            cmbStaff_Category_Name.DisplayMember = "Staff_Catefory_Name";
            cmbStaff_Category_Name.ValueMember = "Staff_Category_ID";
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

        private void btnAddImage_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaff_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã số nhân viên*";
                if (txtStaff_Name.Text == "") lblWarningTwo.Text = "*Vui lòng nhập họ và tên nhân viên*";
                if (txtStaff_Address.Text == "") lblWarningThree.Text = "*Vui lòng nhập địa chỉ nhân viên*";
                if (txtStaff_NumberPhone.Text == "") lblWarningFour.Text = "*Vui lòng nhập số điện thoại*";
                if (txtStaff_Salary.Text == "") lblWarningFive.Text = "*Vui lòng nhập lương cho nhân viên*";
                if (txtAccount_ID.Text == "") lblWarningSix.Text = "*Vui lòng nhập mã tài khoản*";
                if (txtAccount_Name.Text == "") lblWarningSeven.Text = "*Vui lòng nhập tài khoản*";
                if (txtAccount_Password.Text == "") lblWarningEight.Text = "*Vui lòng nhập tài khoản*";
                if (txtAccount_DisplayName.Text == "") lblWarningNine.Text = "*Vui lòng nhập tài khoản*";
                if (txtStaff_ID.Text != "" && txtStaff_Name.Text != "" && txtStaff_Address.Text != ""
                    && txtStaff_NumberPhone.Text != "" && txtStaff_Salary.Text != "" && cmbStaff_Category_Name.Text != "" 
                    && txtAccount_ID.Text != "" && txtAccount_Name.Text != "" && txtAccount_Password.Text != "" && txtAccount_DisplayName.Text != "")
                {
                    if (long.TryParse(txtStaff_NumberPhone.Text, out long a))
                    {
                        if (txtStaff_NumberPhone.Text.Length == 10)
                        {
                            if (long.Parse(txtStaff_NumberPhone.Text) > 0)
                            {
                                if (decimal.TryParse(txtStaff_Salary.Text, out decimal b))
                                {
                                    if (decimal.Parse(txtStaff_Salary.Text) > 0)
                                    {
                                            Staff staff = new Staff();
                                            staff.Staff_ID = txtStaff_ID.Text;
                                            staff.Staff_Name = txtStaff_Name.Text;
                                            staff.Staff_Address = txtStaff_Address.Text;
                                            staff.Staff_PhoneNumber = txtStaff_NumberPhone.Text;
                                            staff.Staff_Salary = b;
                                            Staff_Category staff_Category = context.Staff_Category.Where(p => p.Staff_Catefory_Name == cmbStaff_Category_Name.Text).SingleOrDefault();
                                            staff.Staff_Category_ID = staff_Category.Staff_Category_ID;
                                            staff.Staff_Image = ConvertImageToBinary(pbAddImage.Image);
                                            context.Staffs.AddOrUpdate(staff);
                                            context.SaveChanges();
                                            Account account = new Account();
                                            account.Account_ID = txtAccount_ID.Text;
                                            account.Account_UserName = txtAccount_Name.Text;
                                            account.Account_Password = txtAccount_Password.Text;
                                            account.Account_DisplayName = txtAccount_DisplayName.Text;
                                            Account_Category account_Category = context.Account_Category.Where(p => p.Account_Category_Name == cmbStaff_Category_Name.Text).SingleOrDefault();
                                            account.Account_Category_ID = account_Category.Account_Category_ID;
                                            account.Staff_ID = txtStaff_ID.Text;
                                            context.Accounts.AddOrUpdate(account);
                                            context.SaveChanges();
                                            MessageBox.Show("Cập nhật thành công");
                                            Close();
                                    }
                                    else MessageBox.Show("Lương phải lớn hơn không");
                                }
                                else MessageBox.Show("Lương phải là số nguyên");
                            }
                            else MessageBox.Show("Số điện thoại không thể nhỏ hơn không");
                        }
                        else MessageBox.Show("Số điện thoại phải đủ 10 số");
                    }
                    else MessageBox.Show("Số điện thoại phải là số nguyên");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaff_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã số nhân viên*";
                if (txtStaff_ID.Text != "")
                {
                    if (context.Staffs.Where(p => p.Staff_ID == txtStaff_ID.Text).Any() == true)
                    {
                        if (context.Accounts.Where(p => p.Staff.Staff_ID == txtStaff_ID.Text).Any() == true)
                        {
                            Account account = context.Accounts.Where(p => p.Staff.Staff_ID == txtStaff_ID.Text).SingleOrDefault();
                            context.Accounts.Remove(account);
                            Staff staff = context.Staffs.Where(p => p.Staff_ID == txtStaff_ID.Text).SingleOrDefault();
                            context.Staffs.Remove(staff);
                            context.SaveChanges();
                            MessageBox.Show("Xóa thành công");
                            Close();
                        }
                        else
                        {
                            Staff staff = context.Staffs.Where(p => p.Staff_ID == txtStaff_ID.Text).SingleOrDefault();
                            context.Staffs.Remove(staff);
                            context.SaveChanges();
                            MessageBox.Show("Xóa thành công");
                            Close();
                        }
                    }
                    else MessageBox.Show("không tìm thấy nhân viên này");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
