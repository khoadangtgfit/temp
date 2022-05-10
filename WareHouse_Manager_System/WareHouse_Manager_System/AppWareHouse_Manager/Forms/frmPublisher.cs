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
    public partial class frmPublisher : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        public frmPublisher(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lvPublisher.Columns.Add("Hình Ảnh");
            lvPublisher.Columns.Add("STT");
            lvPublisher.Columns[1].Width = 50;
            lvPublisher.Columns.Add("Mã số nhà cung cấp");
            lvPublisher.Columns[2].Width = 120;
            lvPublisher.Columns.Add("Tên nhà cung cấp");
            lvPublisher.Columns[3].Width = 150;
            lvPublisher.Columns.Add("Số điện thoại");
            lvPublisher.Columns[4].Width = 150;
            lvPublisher.Columns.Add("Địa chỉ");
            lvPublisher.Columns[5].Width = 150;         
            lvPublisher.View = View.Details;
            lvPublisher.FullRowSelect = true;
            List<Publisher> publishers = context.Publishers.ToList();
            Insert_ListView(publishers);
            userName = user;
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

        private void Insert_ListView (List<Publisher> publishers)
        {
            lvPublisher.Items.Clear();
            ImageList largeImage = new ImageList() { ImageSize = new Size(128, 192) };
            ImageList smallImage = new ImageList() { ImageSize = new Size(48, 48) };
            int number = 0;
            int index = 0;
            foreach (var item in publishers)
            {
                number += 1;
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "";
                listViewItem.SubItems.Add(number.ToString());
                listViewItem.SubItems.Add(item.Publisher_ID);
                listViewItem.SubItems.Add(item.Publisher_Name);
                listViewItem.SubItems.Add(item.Publisher_PhoneNumber);
                listViewItem.SubItems.Add(item.Publisher_Address);
                largeImage.Images.Add(ConvertBinaryToImage(item.Publisher_Image));
                smallImage.Images.Add(ConvertBinaryToImage(item.Publisher_Image));
                listViewItem.ImageIndex = index;
                lvPublisher.SmallImageList = smallImage;
                lvPublisher.LargeImageList = largeImage;
                lvPublisher.Items.Add(listViewItem);
                index++;
            }    
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Publisher update_Publisher = new frmUpdate_Publisher(userName);
            update_Publisher.ShowDialog();
            this.Hide();
            frmPublisher publisher = new frmPublisher(userName);
            publisher.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Publisher update_Publisher = new frmUpdate_Publisher(userName);
            update_Publisher.ShowDialog();
            Insert_ListView(context.Publishers.ToList());
        }
        private void xắpSếpAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Publisher> publishers = context.Publishers.OrderBy(p => p.Publisher_Name).ToList();
            Insert_ListView(publishers);
        }

        private void sắpXếpZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Publisher> publishers = context.Publishers.OrderByDescending(p => p.Publisher_Name).ToList();
            Insert_ListView(publishers);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty) Insert_ListView(context.Publishers.ToList());
            else
            {
                List<Publisher> publishers = context.Publishers.Where(p => p.Publisher_ID.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())
                || p.Publisher_Name.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())).ToList();
                Insert_ListView(publishers);
            }
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
