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
    public partial class frmSupply : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
       
        public frmSupply(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lvSupply.Columns.Add("Hình ảnh");
            lvSupply.Columns.Add("STT");
            lvSupply.Columns[1].Width = 50;
            lvSupply.Columns.Add("Mã vật tư");
            lvSupply.Columns[2].Width = 100;
            lvSupply.Columns.Add("Tên vật tư");
            lvSupply.Columns[3].Width = 200;
            lvSupply.Columns.Add("Số lượng");
            lvSupply.Columns[4].Width = 100;
            lvSupply.Columns.Add("Đơn vị");
            lvSupply.Columns[5].Width = 100;
            lvSupply.Columns.Add("Tên loại vật tư");
            lvSupply.Columns[6].Width = 150;
            lvSupply.Columns.Add("Nhà cung cấp");
            lvSupply.Columns[7].Width = 100;
            lvSupply.View = View.Details;
            List<Supply> listSupply = context.Supplies.ToList();
            Insert_ListView(listSupply);
            lvSupply.FullRowSelect = true;
            userName = user;
            toolStripComboBoxOne.Items.Add("Theo loại vật tư");
            toolStripComboBoxOne.Items.Add("Theo nhà cung cấp");
            toolStripComboBoxOne.Items.Add("Theo số lượng");
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

        private void Insert_ListView (List<Supply> listSupply)
        {
            ImageList largeImage = new ImageList() { ImageSize = new Size(128, 192) };
            ImageList smallImage = new ImageList() { ImageSize = new Size(48, 48) };
            lvSupply.Items.Clear();
            int Number = 0;
            int index = 0;
            foreach (var item in listSupply)
            {
                ListViewItem listViewItem = new ListViewItem();
                Number += 1;
                listViewItem.SubItems.Add(Number.ToString());
                listViewItem.SubItems.Add(item.Supply_ID);
                listViewItem.SubItems.Add(item.Supply_Name);
                if (item.Supply_Quantity == 0) { listViewItem.SubItems.Add("Hết hàng"); }  
                else listViewItem.SubItems.Add(item.Supply_Quantity.ToString());
                listViewItem.SubItems.Add(item.Supply_Unit);
                listViewItem.SubItems.Add(item.Supply_Category_ID);
                listViewItem.SubItems.Add(item.Publisher_ID);
                largeImage.Images.Add(ConvertBinaryToImage(item.Supply_Image));
                smallImage.Images.Add(ConvertBinaryToImage(item.Supply_Image));
                lvSupply.SmallImageList = smallImage;
                lvSupply.LargeImageList = largeImage;
                listViewItem.ImageIndex = index;
                lvSupply.Items.Add(listViewItem);
                index++;
            }    
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage homePage = new frmHomePage(userName);
            homePage.ShowDialog();
        } 

        private void importCouponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImport_Coupon import_Coupon = new frmImport_Coupon(userName);
            import_Coupon.ShowDialog();
        }

        private void outportCouponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOutput_Coupon output_Coupon = new frmOutput_Coupon(userName);
            output_Coupon.ShowDialog();
        }

        private void supplyCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply_Category supply_Category = new frmSupply_Category(userName);
            supply_Category.ShowDialog();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPublisher publisher = new frmPublisher(userName);
            publisher.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty) Insert_ListView(context.Supplies.ToList());
            else
            {
                List<Supply> supplies = context.Supplies.Where(p => p.Supply_ID.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())
                || p.Supply_Name.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())).ToList();
                Insert_ListView(supplies);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Supply update_Supply = new frmUpdate_Supply(userName);
            update_Supply.ShowDialog();
            this.Hide();
            frmSupply supply = new frmSupply(userName);
            supply.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Supply update_Supply = new frmUpdate_Supply(userName);
            update_Supply.ShowDialog();
            Insert_ListView(context.Supplies.ToList());
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

        private void toolStripComboBoxOne_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (toolStripComboBoxOne.Text == "Theo loại vật tư")
            {
                List<Supply> supplies = context.Supplies.OrderBy(p => p.Supply_Category.Supply_Category_ID).ToList();
                Insert_ListView(supplies);
            }
            if (toolStripComboBoxOne.Text == "Theo nhà cung cấp")
            {
                List<Supply> supplies = context.Supplies.OrderBy(p => p.Publisher.Publisher_ID).ToList();
                Insert_ListView(supplies);
            }    
            if (toolStripComboBoxOne.Text == "Theo số lượng")
            {
                List<Supply> supplies = context.Supplies.OrderBy(p => p.Supply_Quantity).ToList();
                Insert_ListView(supplies);
            }
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e) { Insert_ListView(context.Supplies.ToList()); }
    }
}
