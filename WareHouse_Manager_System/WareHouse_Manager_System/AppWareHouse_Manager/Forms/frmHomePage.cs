using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmHomePage : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        public frmHomePage(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userName = user;
            Account account = context.Accounts.Where(p => p.Account_ID == userName).SingleOrDefault();
            if (account.Account_Category_ID == "AC03") btnStaff.Visible = false;
            else btnStaff.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to logout ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLoginWindow loginWindow = new frmLoginWindow();
                loginWindow.ShowDialog();
            }    
        }

        private void btnSupply_Category_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply_Category supply_Category = new frmSupply_Category(userName);
            supply_Category.ShowDialog();
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupply supply = new frmSupply(userName);
            supply.ShowDialog();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPublisher publisher = new frmPublisher(userName);
            publisher.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccount account = new frmAccount(userName);
            account.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff_Manager staff_Manager = new frmStaff_Manager(userName);
            staff_Manager.ShowDialog();
        }

        private void btnImport_Coupon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImport_Coupon import_Coupon = new frmImport_Coupon(userName);
            import_Coupon.ShowDialog();
        }

        private void btnOutput_Coupon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOutput_Coupon output_Coupon = new frmOutput_Coupon(userName);
            output_Coupon.ShowDialog();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            frmStatistical frmStatistical = new frmStatistical();
            frmStatistical.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
            label4.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label5.Text = DateTime.Now.ToString("dddd");
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        string[] s = { "Chúc bạn một ngày tốt lành!", "Đừng làm việc quá sức nhé!", "Bạn đã ngủ đủ giấc chưa?", "Hôm nay của bạn thế nào?", "Luôn vui vẻ nhé!" ,
            "Hãy nhớ công việc của mình nhé!","Cố gắng lên nha!","Hãy đi kiếm người yêu nào!"};
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            label6.Text = s[r.Next(0, 8)];
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
