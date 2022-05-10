using AppWareHouse_Manager.Models;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using AppWareHouse_Manager.Forms;
using AppWareHouse_Manager.Reports;

namespace AppWareHouse_Manager.Forms
{
    public partial class frmUpdate_Output_Coupon : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        public frmUpdate_Output_Coupon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnUpdate;
            FillStaff_Name();
            FillSupply_Name();
        }

        private void FillStaff_Name()
        {
            cmbStaff_Name.DataSource = context.Staffs.ToList();
            cmbStaff_Name.DisplayMember = "Staff_Name";
            cmbStaff_Name.ValueMember = "Staff_ID";
        }

        private void FillSupply_Name()
        {
            cmbSupply_Name.DataSource = context.Supplies.ToList();
            cmbSupply_Name.DisplayMember = "Supply_Name";
            cmbSupply_Name.ValueMember = "Supply_ID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOutput_Coupon_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã phiếu xuất*";
                if (txtOutput_Detail_Qunatity.Text == "") lblWarningTwo.Text = "*Vui lòng nhập số lượng*";
                if (txtOutput_Detail_Price.Text == "") lblWarningThree.Text = "*Vui lòng nhập giá tiền*";
                if (txtOutput_Detail_Note.Text == "") lblWarningFour.Text = "*Vui lòng nhập ghi chú*";
                if (txtOutput_Coupon_Address.Text == "") lblWarningFive.Text = "*Vui lòng nhập địa chỉ*";
                if (txtOutput_Coupon_ID.Text != "" && txtOutput_Detail_Qunatity.Text != "" && txtOutput_Detail_Price.Text != "" && txtOutput_Detail_Note.Text != "" && txtOutput_Coupon_Address.Text != "")
                {
                    if (int.TryParse(txtOutput_Detail_Qunatity.Text, out int a))
                    {
                        if (int.Parse(txtOutput_Detail_Qunatity.Text) > 0)
                        {
                            if (long.TryParse(txtOutput_Detail_Price.Text, out long b))
                            {
                                if (long.Parse(txtOutput_Detail_Price.Text) > 0)
                                {
                                    Output_Coupon output_Coupon = new Output_Coupon();
                                    output_Coupon.Output_Coupon_ID = txtOutput_Coupon_ID.Text;
                                    output_Coupon.Output_Coupon_Date = dtpOutput_Coupon_Date.Value;
                                    Staff staff = context.Staffs.Where(p => p.Staff_Name == cmbStaff_Name.Text).SingleOrDefault();
                                    output_Coupon.Staff_ID = staff.Staff_ID;
                                    output_Coupon.Output_Coupon_Address = txtOutput_Coupon_Address.Text;
                                    context.Output_Coupon.AddOrUpdate(output_Coupon);
                                    context.SaveChanges();
                                    Output_Detail output_Detail = new Output_Detail();
                                    output_Detail.Output_Coupon_ID = txtOutput_Coupon_ID.Text;
                                    Supply supply = context.Supplies.Where(p => p.Supply_Name == cmbSupply_Name.Text).SingleOrDefault();
                                    output_Detail.Supply_ID = supply.Supply_ID;
                                    output_Detail.Output_Detail_Quantity = a;
                                    output_Detail.Output_Detail_Price = b;
                                    output_Detail.Output_Detail_Note = txtOutput_Detail_Note.Text;
                                    Supply supply1 = new Supply();
                                    supply1.Supply_ID = supply.Supply_ID;
                                    supply1.Supply_Name = supply.Supply_Name;
                                    if (decimal.Parse(txtOutput_Detail_Qunatity.Text) <= supply.Supply_Quantity)
                                    {
                                        if (context.Output_Detail.Where(p => p.Output_Coupon_ID == txtOutput_Coupon_ID.Text && p.Supply_ID == supply.Supply_ID).Any() == false)
                                        {
                                            supply1.Supply_Quantity = supply.Supply_Quantity - int.Parse(txtOutput_Detail_Qunatity.Text);
                                        }
                                        else
                                        {
                                            Output_Detail output_Detail1 = context.Output_Detail.Where(p => p.Output_Coupon_ID == txtOutput_Coupon_ID.Text && p.Supply_ID == supply.Supply_ID).SingleOrDefault();
                                            int c = int.Parse(output_Detail1.Output_Detail_Quantity.ToString()) - int.Parse(txtOutput_Detail_Qunatity.Text);
                                            if (c > 0)
                                            {
                                                supply1.Supply_Quantity = supply.Supply_Quantity + c;
                                            }
                                            if (c < 0)
                                            {
                                                supply1.Supply_Quantity = supply.Supply_Quantity + c;
                                            }
                                            if (c == 0)
                                            {
                                                supply1.Supply_Quantity = supply.Supply_Quantity + 0;
                                            }
                                        }
                                        supply1.Supply_Unit = supply.Supply_Unit;
                                        supply1.Supply_Category_ID = supply.Supply_Category_ID;
                                        supply1.Publisher_ID = supply.Publisher_ID;
                                        supply1.Supply_Image = supply.Supply_Image;
                                        context.Supplies.AddOrUpdate(supply1);
                                        context.SaveChanges();
                                        context.Output_Detail.AddOrUpdate(output_Detail);
                                        context.SaveChanges();
                                        MessageBox.Show("Cập nhật thành công");
                                        Close();
                                    }
                                    else MessageBox.Show("Không đủ hàng");
                                }
                                else MessageBox.Show("Giá tiền phải lớn hơn không");
                            }
                            else MessageBox.Show("Giá tiền phải là số nguyên");
                        }
                        else MessageBox.Show("Số lượng nhập phải lớn hơn không");
                    }
                    else MessageBox.Show("Số lượng phải là số nguyên");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOutput_Coupon_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã phiếu xuất*";
            else
            {
                if (context.Output_Coupon.Where(p => p.Output_Coupon_ID == txtOutput_Coupon_ID.Text).Any() == true)
                {
                    Output_Coupon output_Coupon = context.Output_Coupon.Where(p => p.Output_Coupon_ID == txtOutput_Coupon_ID.Text).SingleOrDefault();
                    if (context.Output_Detail.Where(p => p.Output_Coupon.Output_Coupon_ID == output_Coupon.Output_Coupon_ID).Any() == true)
                    {
                        Output_Detail output_Detail = context.Output_Detail.Where(p => p.Output_Coupon.Output_Coupon_ID == output_Coupon.Output_Coupon_ID).SingleOrDefault();
                        Supply supply = context.Supplies.Where(p => p.Supply_ID == output_Detail.Supply.Supply_ID).SingleOrDefault();
                        Supply supply1 = new Supply();
                        supply1.Supply_ID = supply.Supply_ID;
                        supply1.Supply_Name = supply.Supply_Name;
                        supply1.Supply_Quantity = supply.Supply_Quantity + output_Detail.Output_Detail_Quantity;
                        supply1.Supply_Unit = supply.Supply_Unit;
                        supply1.Publisher_ID = supply.Publisher.Publisher_ID;
                        supply1.Supply_Image = supply.Supply_Image;
                        supply1.Supply_Category_ID = supply.Supply_Category.Supply_Category_ID;
                        context.Supplies.AddOrUpdate(supply1);
                        context.SaveChanges();
                        context.Output_Detail.Remove(output_Detail);
                        context.Output_Coupon.Remove(output_Coupon);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        Close();
                    }
                    else
                    {
                        context.Output_Coupon.Remove(output_Coupon);
                    }
                }
                else MessageBox.Show("Không tìm thấy phiếu xuất hàng này");
            }
        }
    }
}
