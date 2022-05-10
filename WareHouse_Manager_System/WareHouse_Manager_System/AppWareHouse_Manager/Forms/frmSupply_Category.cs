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
    public partial class frmSupply_Category : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        public frmSupply_Category(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lvSupply_Category.Columns.Add("STT");
            lvSupply_Category.Columns[0].Width = 50;
            lvSupply_Category.Columns.Add("Mã Loại Vật Tư");
            lvSupply_Category.Columns[1].Width = 200;
            lvSupply_Category.Columns.Add("Tên Loại Vật Tư");
            lvSupply_Category.Columns[2].Width = 200;
            lvSupply_Category.View = View.Details;
            lvSupply_Category.FullRowSelect = true;
            List<Supply_Category> listSupply_Category = context.Supply_Category.ToList();
            Insert_ListView(listSupply_Category);
            userName = user;
        }

        private void Insert_ListView (List<Supply_Category> listSupply_Category)
        {
            int number = 0;
            lvSupply_Category.Items.Clear();
            foreach (var item in listSupply_Category)
            {
                 number += 1;
                ListViewItem listView = new ListViewItem();
                listView.Text = number.ToString();
                listView.SubItems.Add(item.Supply_Category_ID);
                listView.SubItems.Add(item.Supply_Category_Name);
                lvSupply_Category.Items.Add(listView);            
            }    
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage homePage = new frmHomePage(userName);
            homePage.ShowDialog();
        }

        private void supplyWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply supply = new frmSupply(userName);
            supply.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty) Insert_ListView(context.Supply_Category.ToList());
            else
            {
                List<Supply_Category> supply_Categories = context.Supply_Category.Where(p => p.Supply_Category_ID.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())
                || p.Supply_Category_Name.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())).ToList();
                Insert_ListView(supply_Categories);
            }
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

        private void lvSupply_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSupply_Category.SelectedItems.Count > 0)
            {
                txtSupply_Category_ID.ForeColor = Color.Black;
                txtSupply_Category_Name.ForeColor = Color.Black;
                txtSupply_Category_ID.Text = lvSupply_Category.SelectedItems[0].SubItems[1].Text;
                txtSupply_Category_Name.Text = lvSupply_Category.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupply_Category_ID.Text != "" && txtSupply_Category_Name.Text != "")
                {
                    Supply_Category supply_Category = new Supply_Category();
                    supply_Category.Supply_Category_ID = txtSupply_Category_ID.Text.Trim();
                    supply_Category.Supply_Category_Name = txtSupply_Category_Name.Text.Trim();
                    context.Supply_Category.AddOrUpdate(supply_Category);
                    context.SaveChanges();
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    Insert_ListView(context.Supply_Category.ToList());
                    txtSupply_Category_ID.Text = "";
                    txtSupply_Category_Name.Text = "";
                }
                else { MessageBox.Show("Vui lòng nhập đầy đủ thông tin"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupply_Category_ID.Text != "")
                {
                    if (context.Supply_Category.Where(p => p.Supply_Category_ID == txtSupply_Category_ID.Text).Any() == true)
                    {
                        Supply_Category supply_Category = context.Supply_Category.Where(p => p.Supply_Category_ID == txtSupply_Category_ID.Text).SingleOrDefault();
                        context.Supply_Category.Remove(supply_Category);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        Insert_ListView(context.Supply_Category.ToList());
                        txtSupply_Category_ID.Text = "";
                        txtSupply_Category_Name.Text = "";
                    }
                    else { MessageBox.Show("Không tìm thấy loại vật tư cần xóa"); }
                }
                else { MessageBox.Show("Vui lòng nhập đầy đủ thông tin"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Bạn có chắc là muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLoginWindow loginWindow = new frmLoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
