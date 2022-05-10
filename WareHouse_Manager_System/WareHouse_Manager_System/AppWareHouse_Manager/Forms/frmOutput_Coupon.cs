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
    public partial class frmOutput_Coupon : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        public frmOutput_Coupon(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userName = user;
            dgvOutput_Coupon.Columns.Add("dgvNumber", "STT");
            dgvOutput_Coupon.Columns[0].Width = 70;
            dgvOutput_Coupon.Columns.Add("dgvStaff_Name", "Người lập phiếu");
            dgvOutput_Coupon.Columns[1].Width = 125;
            dgvOutput_Coupon.Columns.Add("dgvOutput_Coupon_ID", "Mã phiếu xuất");
            dgvOutput_Coupon.Columns[2].Width = 140;
            dgvOutput_Coupon.Columns.Add("dgvOutput_Coupon_Date", "Ngày xuất hàng");
            dgvOutput_Coupon.Columns[3].Width = 175;
            dgvOutput_Coupon.Columns.Add("dgvOutput_Detail_Address", "Địa chỉ");
            dgvOutput_Coupon.Columns[4].Width = 175;
            dgvOutput_Coupon.Columns.Add("dgvSupply_Name", "Tên vật tư");
            dgvOutput_Coupon.Columns[5].Width = 175;
            dgvOutput_Coupon.Columns.Add("dgvOutput_Detail_Quantity", "Số lượng");
            dgvOutput_Coupon.Columns[6].Width = 175;
            dgvOutput_Coupon.Columns.Add("dgvOutput_Detail_Price", "Gía");
            dgvOutput_Coupon.Columns[7].Width = 175;
            dgvOutput_Coupon.Columns.Add("dgvOutput_Detail_Note", "Ghi chú");
            dgvOutput_Coupon.Columns[8].Width = 175;
            dgvOutput_Coupon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Insert_DataGridView(context.Output_Detail.ToList());
        }

        private void Insert_DataGridView(List<Output_Detail> output_Details)
        {
            int number = 0;
            dgvOutput_Coupon.Rows.Clear();
            foreach (var item in output_Details)
            {
                int index = dgvOutput_Coupon.Rows.Add();
                number += 1;
                dgvOutput_Coupon.Rows[index].Cells[0].Value = number.ToString();
                Staff staff = context.Staffs.Where(p => p.Staff_ID == item.Output_Coupon.Staff_ID).SingleOrDefault();
                dgvOutput_Coupon.Rows[index].Cells[1].Value = staff.Staff_Name;
                dgvOutput_Coupon.Rows[index].Cells[2].Value = item.Output_Coupon_ID;
                dgvOutput_Coupon.Rows[index].Cells[3].Value = string.Format(item.Output_Coupon.Output_Coupon_Date.Value.Day + "/" + item.Output_Coupon.Output_Coupon_Date.Value.Month + "/" + item.Output_Coupon.Output_Coupon_Date.Value.Year);
                dgvOutput_Coupon.Rows[index].Cells[4].Value = item.Output_Coupon.Output_Coupon_Address;
                dgvOutput_Coupon.Rows[index].Cells[5].Value = item.Supply.Supply_Name;
                dgvOutput_Coupon.Rows[index].Cells[6].Value = item.Output_Detail_Quantity;
                dgvOutput_Coupon.Rows[index].Cells[7].Value = item.Output_Detail_Price;
                dgvOutput_Coupon.Rows[index].Cells[8].Value = item.Output_Detail_Note;
            }
        }



        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage homePage = new frmHomePage(userName);
            homePage.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImport_Coupon import_Coupon = new frmImport_Coupon(userName);
            import_Coupon.ShowDialog();
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == "") Insert_DataGridView(context.Output_Detail.ToList());
            else
            {
                List<Output_Detail> output_Coupons = context.Output_Detail.Where(p => p.Output_Coupon_ID.Trim().ToLower().Contains(toolStripTextBoxSearch.Text.Trim().ToLower())
                | p.Output_Coupon.Staff.Staff_Name.Trim().ToLower().Contains(toolStripTextBoxSearch.Text.Trim().ToLower())
                || p.Output_Coupon.Output_Coupon_Address.Trim().ToLower().Contains(toolStripTextBoxSearch.Text.Trim().ToLower())).ToList();
                Insert_DataGridView(output_Coupons);
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

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Output_Coupon update_Output_Coupon = new frmUpdate_Output_Coupon();
            update_Output_Coupon.ShowDialog();
            this.Hide();
            frmOutput_Coupon output_Coupon = new frmOutput_Coupon(userName);
            output_Coupon.ShowDialog();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Output_Coupon update_Output_Coupon = new frmUpdate_Output_Coupon();
            update_Output_Coupon.ShowDialog();
            Insert_DataGridView(context.Output_Detail.ToList());
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert_DataGridView(context.Output_Detail.ToList());
        }

        private void vậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply frmSupply = new frmSupply(userName);
            frmSupply.ShowDialog();
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Output_Detail> output_Details = context.Output_Detail.OrderBy(p => p.Output_Coupon.Output_Coupon_Date.Value.Day).ToList();
            Insert_DataGridView(output_Details);
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Output_Detail> output_Details = context.Output_Detail.OrderBy(p => p.Output_Coupon.Output_Coupon_Date.Value.Month).ToList();
            Insert_DataGridView(output_Details);
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Output_Detail> output_Details = context.Output_Detail.OrderBy(p => p.Output_Coupon.Output_Coupon_Date.Value.Year).ToList();
            Insert_DataGridView(output_Details);
        }

        private void inPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport_IO_Coupon report_IO_Coupon = new frmReport_IO_Coupon();
            report_IO_Coupon.ShowDialog();
        }
    }
}
