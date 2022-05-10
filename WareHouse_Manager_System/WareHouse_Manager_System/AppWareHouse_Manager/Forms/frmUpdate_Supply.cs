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
    public partial class frmUpdate_Supply : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        string fileName;
        public frmUpdate_Supply(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnUpdate;
            FillSupply_Category_Name();
            FillPublisher_Name();
            userName = user;
        }

        private void FillSupply_Category_Name ()
        {
            cmbSupply_Category_Name.DataSource = context.Supply_Category.ToList();
            cmbSupply_Category_Name.DisplayMember = "Supply_Category_Name";
            cmbSupply_Category_Name.ValueMember = "Supply_Category_ID";
        }

        private void FillPublisher_Name ()
        {
            cmbPublisher_Name.DataSource = context.Publishers.ToList();
            cmbPublisher_Name.DisplayMember = "Publisher_Name";
            cmbPublisher_Name.ValueMember = "Publisher_ID";
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
                if (txtSupply_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã vật tư*";
                if (txtSupply_Name.Text == "") lblWarningTwo.Text = "*Vui lòng nhập tên vật tư*";
                if (txtSupply_Quantity.Text == "") lblWarningThree.Text = "Vui lòng nhập số lượng";
                if (txtSupply_Unit.Text == "") lblWarningFour.Text = "Vui lòng nhập giá";
                if (txtSupply_ID.Text != "" && txtSupply_Name.Text != "" && txtSupply_Quantity.Text != "" && txtSupply_Unit.Text != "")
                {
                    if (int.TryParse(txtSupply_Quantity.Text, out int a))
                    {
                        if (int.Parse(txtSupply_Quantity.Text) >= 0)
                        {
                            Supply supply = new Supply();
                            supply.Supply_ID = txtSupply_ID.Text;
                            supply.Supply_Name = txtSupply_Name.Text;
                            supply.Supply_Quantity = a;
                            supply.Supply_Unit = txtSupply_Unit.Text;
                            Supply_Category supply_Category = context.Supply_Category.Where(p => p.Supply_Category_Name == cmbSupply_Category_Name.Text).SingleOrDefault();
                            supply.Supply_Category_ID = supply_Category.Supply_Category_ID;
                            Publisher publisher = context.Publishers.Where(p => p.Publisher_Name == cmbPublisher_Name.Text).SingleOrDefault();
                            supply.Publisher_ID = publisher.Publisher_ID;
                            supply.Supply_Image = ConvertImageToBinary(pbAddImage.Image);
                            context.Supplies.AddOrUpdate(supply);
                            context.SaveChanges();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                            Close();
                        }
                        else MessageBox.Show("Số lượng không được nhỏ hơn 0");
                    }
                    else MessageBox.Show("Số lượng phải là số nguyên");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupply_ID.Text != "")
                {
                    
                    if (context.Supplies.Where(p => p.Supply_ID == txtSupply_ID.Text).Any() == false) MessageBox.Show("Không tìm thấy vật tư này");
                    else
                    {
                        Supply supply = context.Supplies.Where(p => p.Supply_ID == txtSupply_ID.Text).SingleOrDefault();
                        context.Supplies.Remove(supply);
                         context.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                         Close();
                    }
                }
                else if (txtSupply_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã vật tư*";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNewSupply_Category_Click(object sender, EventArgs e)
        {
            frmSupply_Category Supply_Category = new frmSupply_Category(userName);
            Supply_Category.ShowDialog();
            FillSupply_Category_Name();
        }

        private void btnNewPublisher_Click(object sender, EventArgs e)
        {
            frmUpdate_Publisher update_Publisher = new frmUpdate_Publisher(userName);
            update_Publisher.ShowDialog();
            FillPublisher_Name();
        }
    }
}
