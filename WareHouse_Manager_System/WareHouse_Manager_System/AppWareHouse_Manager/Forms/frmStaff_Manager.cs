using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmStaff_Manager : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        public frmStaff_Manager(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lvStaff.Columns.Add("Hình Ảnh");
            lvStaff.Columns.Add("STT");
            lvStaff.Columns[1].Width = 50;
            lvStaff.Columns.Add("MSNV");
            lvStaff.Columns[2].Width = 75;
            lvStaff.Columns.Add("Họ và tên");
            lvStaff.Columns[3].Width = 100;
            lvStaff.Columns.Add("Địa chỉ");
            lvStaff.Columns[4].Width = 150;
            lvStaff.Columns.Add("Số điện thoại");
            lvStaff.Columns[5].Width = 125;
            lvStaff.Columns.Add("Lương");
            lvStaff.Columns[6].Width = 100;
            lvStaff.Columns.Add("Chức vụ");
            lvStaff.Columns[7].Width = 100;
            lvStaff.Columns.Add("Tài khoản");
            lvStaff.Columns[8].Width = 100;
            lvStaff.Columns.Add("Mật khẩu");
            lvStaff.Columns[9].Width = 100;
            lvStaff.View = View.Details;
            lvStaff.FullRowSelect = true;
            List<Staff> listStaff = context.Staffs.ToList();
            Insert_ListView(listStaff);
            userName = user;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage homePage = new frmHomePage(userName);
            homePage.ShowDialog();
        }

        private void vậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply supply = new frmSupply(userName);
            supply.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImport_Coupon import_Coupon = new frmImport_Coupon(userName);
            import_Coupon.ShowDialog();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOutput_Coupon output_Coupon = new frmOutput_Coupon(userName);
            output_Coupon.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                List<Staff> staffs = context.Staffs.Where(p => p.Staff_ID.Contains(txtSearch.Text.Trim().ToLower()) || p.Staff_Name.Contains(txtSearch.Text.Trim().ToLower())
                || p.Staff_Address.Contains(txtSearch.Text.Trim().ToLower()) || p.Staff_PhoneNumber.Contains(txtSearch.Text.Trim().ToLower())).ToList();
                Insert_ListView(staffs);
            }
            else Insert_ListView(context.Staffs.ToList());
        }

        private Image ConvertBinaryToImage(byte[] data) { using (MemoryStream ms = new MemoryStream(data)) { return Image.FromStream(ms); } }

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void Insert_ListView (List<Staff> listStaff)
        {
            lvStaff.Items.Clear();
            ImageList largeImage = new ImageList() { ImageSize = new Size(128, 192) };
            ImageList smallImage = new ImageList() { ImageSize = new Size(48, 48) };
            int Number = 0;
            int index = 0;
            foreach (Staff  item in listStaff)
            {
               foreach(Account account in context.Accounts.ToList())
                {
                    if (account.Staff_ID == item.Staff_ID)
                    {
                        Number += 1;
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems.Add(Number.ToString());
                        listViewItem.SubItems.Add(item.Staff_ID);
                        listViewItem.SubItems.Add(item.Staff_Name);
                        listViewItem.SubItems.Add(item.Staff_Address);
                        listViewItem.SubItems.Add(item.Staff_PhoneNumber);
                        listViewItem.SubItems.Add(item.Staff_Salary.ToString());
                        listViewItem.SubItems.Add(item.Staff_Category.Staff_Catefory_Name);
                        listViewItem.SubItems.Add(account.Account_UserName);
                        listViewItem.SubItems.Add(account.Account_Password);
                        largeImage.Images.Add(ConvertBinaryToImage(item.Staff_Image));
                        smallImage.Images.Add(ConvertBinaryToImage(item.Staff_Image));
                        listViewItem.ImageIndex = index;
                        lvStaff.SmallImageList = smallImage;
                        lvStaff.LargeImageList = largeImage;
                        lvStaff.Items.Add(listViewItem);
                        index++;
                    }    
                }    
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Staff update_Staff = new frmUpdate_Staff();
            update_Staff.ShowDialog();
            this.Hide();
            frmStaff_Manager staff_Manager = new frmStaff_Manager(userName);
            staff_Manager.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Staff update_Staff = new frmUpdate_Staff();
            update_Staff.ShowDialog();
            Insert_ListView(context.Staffs.ToList());
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            List<Staff> staffs = context.Staffs.ToList();
            Insert_ListView(staffs);
            lvStaff.Refresh();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLoginWindow loginWindow = new frmLoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
