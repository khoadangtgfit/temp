using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using AppWareHouse_Manager.Models;
using AppWareHouse_Manager.Forms;
using AppWareHouse_Manager.Reports;

namespace AppWareHouse_Manager
{
    public partial class frmUpdate_Publisher : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        string userName;
        string fileName;
        public frmUpdate_Publisher(string user)
        {
            InitializeComponent();
            this.AcceptButton = btnUpdate;
            txtPublisher_PhoneNumber.MaxLength = 10;
            this.StartPosition = FormStartPosition.CenterScreen;
            userName = user;
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
                if (txtPublisher_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã số nhà cung cấp*";
                if (txtPublisher_Name.Text == "") lblWarningTwo.Text = "*Vui lòng nhập tên nhà cung cấp*";
                if (txtPublisher_PhoneNumber.Text == "") lblWarningThree.Text = "*Vui lòng nhập số điện thoại nhà cung cấp*";
                if (txtPublisher_Address.Text == "") lblWarningFour.Text = "*Vui lòng nhập đại chỉ nhà cung cấp*";
                if (txtPublisher_ID.Text != "" && txtPublisher_Name.Text != "" && txtPublisher_PhoneNumber.Text != "" && txtPublisher_Address.Text != "")
                {
                    lblWarningOne.Text = "";
                    lblWarningTwo.Text = "";
                    lblWarningThree.Text = "";
                    lblWarningFour.Text = "";
                    if (long.TryParse(txtPublisher_PhoneNumber.Text, out long a))
                    {
                        if (txtPublisher_PhoneNumber.Text.Length == 10 && long.Parse(txtPublisher_PhoneNumber.Text) > 0)
                        {
                            Publisher publisher = new Publisher();
                            publisher.Publisher_ID = txtPublisher_ID.Text;
                            publisher.Publisher_Name = txtPublisher_Name.Text;
                            publisher.Publisher_PhoneNumber = txtPublisher_PhoneNumber.Text;
                            publisher.Publisher_Address = txtPublisher_Address.Text;
                            publisher.Publisher_Image = ConvertImageToBinary(pbAddImage.Image);
                            context.Publishers.AddOrUpdate(publisher);
                            context.SaveChanges();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                            Close();
                        }
                        else { MessageBox.Show("Số điện thoại phải đủ 10 số"); }
                    }  
                    else { MessageBox.Show("Số điện thoại phải là số nguyên"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPublisher_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã số nhà cung cấp*";
                   else if (context.Publishers.Where(p => p.Publisher_ID == txtPublisher_ID.Text).Any() == false) MessageBox.Show("Không tìm thấy nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                    else
                    {
                        Publisher publisher = context.Publishers.Where(p => p.Publisher_ID == txtPublisher_ID.Text).SingleOrDefault();
                        context.Publishers.Remove(publisher);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        Close();
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
