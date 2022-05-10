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
    public partial class frmImport_Coupon : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        public frmImport_Coupon(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userName = user;
            dgvImport_Coupon.Columns.Add("dgvNumber", "STT");
            dgvImport_Coupon.Columns[0].Width = 70;
            dgvImport_Coupon.Columns.Add("dgvStaff_Name", "Người lập phiếu");  
            dgvImport_Coupon.Columns[1].Width = 125;
            dgvImport_Coupon.Columns.Add("dgvImport_Coupon_ID", "Mã phiếu nhập");
            dgvImport_Coupon.Columns[2].Width = 140;
            dgvImport_Coupon.Columns.Add("dgvImport_Coupon_Date", "Ngày nhập hàng");
            dgvImport_Coupon.Columns[3].Width = 175;
            dgvImport_Coupon.Columns.Add("dgvSupply_Name", "Tên vật tư");
            dgvImport_Coupon.Columns[4].Width = 175;
            dgvImport_Coupon.Columns.Add("dgvImport_Detail_Quantity", "Số lượng");
            dgvImport_Coupon.Columns[5].Width = 175;
            dgvImport_Coupon.Columns.Add("dgvImport_Detail_Price", "Gía");
            dgvImport_Coupon.Columns[6].Width = 175;
            dgvImport_Coupon.Columns.Add("dgvImport_Detail_Note", "Ghi chú");
            dgvImport_Coupon.Columns[7].Width = 175;
            dgvImport_Coupon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Insert_DataGridView(context.Import_Detail.ToList());
        }

        private void Insert_DataGridView (List<Import_Detail> import_Details)
        {
            int number = 0;
            dgvImport_Coupon.Rows.Clear();
            foreach (var item in import_Details)
            {
                int index = dgvImport_Coupon.Rows.Add();
                number += 1;
                dgvImport_Coupon.Rows[index].Cells[0].Value = number.ToString();
                Staff staff = context.Staffs.Where(p => p.Staff_ID == item.Import_Coupon.Staff_ID).SingleOrDefault();
                dgvImport_Coupon.Rows[index].Cells[1].Value = staff.Staff_Name; 
                dgvImport_Coupon.Rows[index].Cells[2].Value = item.Import_Coupon_ID;              
                dgvImport_Coupon.Rows[index].Cells[3].Value = string.Format(item.Import_Coupon.Import_Coupon_Date.Value.Day + "/" + item.Import_Coupon.Import_Coupon_Date.Value.Month + "/" + item.Import_Coupon.Import_Coupon_Date.Value.Year);
                dgvImport_Coupon.Rows[index].Cells[4].Value = item.Supply.Supply_Name;
                dgvImport_Coupon.Rows[index].Cells[5].Value = item.Import_Detail_Quantity;
                dgvImport_Coupon.Rows[index].Cells[6].Value = item.Import_Detail_Price;
                dgvImport_Coupon.Rows[index].Cells[7].Value = item.Import_Detail_Note;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage homePage = new frmHomePage(userName);
            homePage.ShowDialog();
        }

        private void outputCouponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOutput_Coupon output_Coupon = new frmOutput_Coupon(userName);
            output_Coupon.ShowDialog();
        }

        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply supply = new frmSupply(userName);
            supply.ShowDialog();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Import_Coupon updateImport_Coupon = new frmUpdate_Import_Coupon();
            updateImport_Coupon.ShowDialog();
            this.Hide();
            frmImport_Coupon import_Coupon = new frmImport_Coupon(userName);
            import_Coupon.ShowDialog();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Import_Coupon updateImport_Coupon = new frmUpdate_Import_Coupon();
            updateImport_Coupon.ShowDialog();
            Insert_DataGridView(context.Import_Detail.ToList());
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert_DataGridView(context.Import_Detail.ToList());
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == "") Insert_DataGridView(context.Import_Detail.ToList());
            else
            {
                List<Import_Detail> import_Coupons = context.Import_Detail.Where(p => p.Import_Coupon.Import_Coupon_ID.Trim().ToLower().Contains(toolStripTextBoxSearch.Text.Trim().ToLower())
                ||  p.Import_Coupon.Staff.Staff_Name.Trim().ToLower().Contains(toolStripTextBoxSearch.Text.Trim().ToLower())
                || p.Supply.Supply_Name.Trim().ToLower().Contains(toolStripTextBoxSearch.Text.Trim().ToLower())).ToList();
                Insert_DataGridView(import_Coupons);
            }
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Import_Detail> import_Details = context.Import_Detail.OrderBy(p => p.Import_Coupon.Import_Coupon_Date.Value.Day).ToList();
            Insert_DataGridView(import_Details);
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Import_Detail> import_Details = context.Import_Detail.OrderBy(p => p.Import_Coupon.Import_Coupon_Date.Value.Month).ToList();
            Insert_DataGridView(import_Details);
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Import_Detail> import_Details = context.Import_Detail.OrderBy(p => p.Import_Coupon.Import_Coupon_Date.Value.Year).ToList();
            Insert_DataGridView(import_Details);
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

        private void inPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmReport_IO_Coupon report_Import_Coupon = new frmReport_IO_Coupon();
           report_Import_Coupon.ShowDialog();
        }
    }
}
