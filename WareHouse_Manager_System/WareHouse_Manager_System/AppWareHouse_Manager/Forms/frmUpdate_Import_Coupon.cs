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

namespace AppWareHouse_Manager.Forms
{
    public partial class frmUpdate_Import_Coupon : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        public frmUpdate_Import_Coupon()
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
                if (txtImport_Coupon_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã phiếu nhập*";
                if (txtImport_Detail_Qunatity.Text == "") lblWarningTwo.Text = "*Vui lòng nhập số lượng*";
                if (txtImport_Detail_Price.Text == "") lblWarningThree.Text = "*Vui lòng nhập giá tiền*";
                if (txtImport_Detail_Note.Text == "") lblWarningFour.Text = "*Vui lòng nhập ghi chú*";
                if (txtImport_Coupon_ID.Text != "" && txtImport_Detail_Qunatity.Text != "" && txtImport_Detail_Price.Text != "" && txtImport_Detail_Note.Text != "")
                {
                    if (int.TryParse(txtImport_Detail_Qunatity.Text, out int a))
                    {
                        if (int.Parse(txtImport_Detail_Qunatity.Text) > 0)
                        {
                            if (long.TryParse(txtImport_Detail_Price.Text, out long b))
                            {
                                if (long.Parse(txtImport_Detail_Price.Text) > 0)
                                {
                                    Import_Coupon import_Coupon = new Import_Coupon();
                                    import_Coupon.Import_Coupon_ID = txtImport_Coupon_ID.Text;
                                    import_Coupon.Import_Coupon_Date = dtpImport_Coupon_Date.Value;
                                    Staff staff = context.Staffs.Where(p => p.Staff_Name == cmbStaff_Name.Text).SingleOrDefault();
                                    import_Coupon.Staff_ID = staff.Staff_ID;
                                    context.Import_Coupon.AddOrUpdate(import_Coupon);
                                    context.SaveChanges();
                                    Import_Detail import_Detail = new Import_Detail();
                                    import_Detail.Import_Coupon_ID = txtImport_Coupon_ID.Text;
                                    Supply supply = context.Supplies.Where(p => p.Supply_Name == cmbSupply_Name.Text).SingleOrDefault();
                                    import_Detail.Supply_ID = supply.Supply_ID;
                                    import_Detail.Import_Detail_Quantity = a;
                                    import_Detail.Import_Detail_Price = b;
                                    import_Detail.Import_Detail_Note = txtImport_Detail_Note.Text;
                                    Supply supply1 = new Supply();
                                    supply1.Supply_ID = supply.Supply_ID;
                                    supply1.Supply_Name = supply.Supply_Name;
                                    if (context.Import_Detail.Where(p => p.Import_Coupon_ID == txtImport_Coupon_ID.Text && p.Supply_ID == supply.Supply_ID).Any() == false)
                                    {
                                        supply1.Supply_Quantity = supply.Supply_Quantity + int.Parse(txtImport_Detail_Qunatity.Text);
                                    }
                                    else
                                    {
                                        Import_Detail import_Detail1  = context.Import_Detail.Where(p => p.Import_Coupon_ID == txtImport_Coupon_ID.Text && p.Supply_ID == supply.Supply_ID).SingleOrDefault();
                                        int c = int.Parse(import_Detail1.Import_Detail_Quantity.ToString())  - int.Parse(txtImport_Detail_Qunatity.Text);
                                        if (c < 0)
                                        {
                                            supply1.Supply_Quantity = supply.Supply_Quantity - c;
                                        }
                                        if (c > 0)
                                        {
                                            supply1.Supply_Quantity = supply.Supply_Quantity - c;
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
                                    context.Import_Detail.AddOrUpdate(import_Detail);
                                    context.SaveChanges();
                                    MessageBox.Show("Cập nhật thành công");
                                    Close();
                                }
                                else MessageBox.Show("Giá tiền phải là số nguyên");
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
            if (txtImport_Coupon_ID.Text == "") lblWarningOne.Text = "*Vui lòng nhập mã phiếu nhập*";
            else
            {
                if (context.Import_Coupon.Where(p => p.Import_Coupon_ID == txtImport_Coupon_ID.Text).Any() == true)
                {
                    Import_Coupon import_Coupon = context.Import_Coupon.Where(p => p.Import_Coupon_ID == txtImport_Coupon_ID.Text).SingleOrDefault();
                    if (context.Import_Detail.Where(p => p.Import_Coupon.Import_Coupon_ID == import_Coupon.Import_Coupon_ID).Any() == true)
                    {
                        Import_Detail import_Detail = context.Import_Detail.Where(p => p.Import_Coupon.Import_Coupon_ID == import_Coupon.Import_Coupon_ID).SingleOrDefault();
                        Supply supply = context.Supplies.Where(p => p.Supply_ID == import_Detail.Supply.Supply_ID).SingleOrDefault();
                        Supply supply1 = new Supply();
                        supply1.Supply_ID = supply.Supply_ID;
                        supply1.Supply_Name = supply.Supply_Name;
                        supply1.Supply_Category_ID = supply.Supply_Category_ID;
                        supply1.Supply_Quantity = supply.Supply_Quantity - import_Detail.Import_Detail_Quantity;
                        supply1.Supply_Unit = supply.Supply_Unit;
                        supply1.Supply_Image = supply.Supply_Image;
                        supply1.Publisher_ID = supply.Publisher.Publisher_ID;
                        context.Supplies.AddOrUpdate(supply1);
                        context.SaveChanges();
                        context.Import_Detail.Remove(import_Detail);
                        context.Import_Coupon.Remove(import_Coupon);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        Close();
                    }
                    else
                    {
                        context.Import_Coupon.Remove(import_Coupon);
                    } 
                }
                else MessageBox.Show("Không tìm thấy phiếu nhập hàng này");
            }    
        }
    }
}
