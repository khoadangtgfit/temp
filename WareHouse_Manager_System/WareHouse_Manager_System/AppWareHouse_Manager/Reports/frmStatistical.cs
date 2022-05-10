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
using Microsoft.Reporting.WinForms;

namespace AppWareHouse_Manager.Reports
{
    public partial class frmStatistical : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        public frmStatistical()
        {
            InitializeComponent();
            dateTimePickerOne.Value = DateTime.Now;
            dateTimePickerTwo.Value = DateTime.Now;
        }

        private void frmStatistical_Load(object sender, EventArgs e)
        {

            this.reportViewerStatistical.RefreshReport();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            if (rbSupply_QuantityLeft.Checked == true)
            {
                List<Supply> supplies = context.Supplies.ToList();
                List<Report_Supply_QuantityLeft> report_Supply_QuantityLefts = new List<Report_Supply_QuantityLeft>();
                foreach (Supply supply in supplies)
                {
                    Report_Supply_QuantityLeft report_Supply_QuantityLeft = new Report_Supply_QuantityLeft();
                    report_Supply_QuantityLeft.Supply_Name = supply.Supply_Name;
                    if (supply.Supply_Quantity > 0)
                    {
                        report_Supply_QuantityLeft.Supply_Quantity = supply.Supply_Quantity.ToString();
                    }
                    else
                    {
                        report_Supply_QuantityLeft.Supply_Quantity = "Hết hàng";
                    }
                    report_Supply_QuantityLeft.Supply_Unit = supply.Supply_Unit;
                    report_Supply_QuantityLefts.Add(report_Supply_QuantityLeft);
                }
                this.reportViewerStatistical.LocalReport.ReportPath = "../../Reports/rptSupply_QuantityLeft.rdlc";
                var reportDataSource = new ReportDataSource("Supply_QuantityLeft", report_Supply_QuantityLefts);
                this.reportViewerStatistical.LocalReport.DataSources.Clear();
                this.reportViewerStatistical.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerStatistical.RefreshReport();
            }
            else
            {
                if (rbImport_Coupon.Checked == true)
                {
                    if (dateTimePickerOne.Value <= dateTimePickerTwo.Value )
                    {
                        if (context.Import_Detail.Where(p => p.Import_Coupon.Import_Coupon_Date.Value >= dateTimePickerOne.Value && p.Import_Coupon.Import_Coupon_Date.Value <= dateTimePickerTwo.Value).Any() == true)
                        {
                            List<Import_Detail> import_Details = context.Import_Detail.ToList();
                            List<Report_Import_Coupon> report_Import_Coupons = new List<Report_Import_Coupon>();
                            ReportParameter[] reportParameters = new ReportParameter[2];
                            reportParameters[0] = new ReportParameter("rpID", "Nhiều");
                            reportParameters[1] = new ReportParameter("rpDate","Từ "+dateTimePickerOne.Value.ToString("dd/MM/yyyy")+" đến "+dateTimePickerTwo.Value.ToString("dd/MM/yyyy"));
                            foreach (Import_Detail import_Detail in import_Details)
                            {
                                if (import_Detail.Import_Coupon.Import_Coupon_Date.Value >= dateTimePickerOne.Value && import_Detail.Import_Coupon.Import_Coupon_Date.Value <= dateTimePickerTwo.Value)
                                {
                                    Report_Import_Coupon report_Import_Coupon = new Report_Import_Coupon();
                                    report_Import_Coupon.Import_Coupon_ID = import_Detail.Import_Coupon_ID;
                                    report_Import_Coupon.Staff_Name = import_Detail.Import_Coupon.Staff_ID;
                                    report_Import_Coupon.Supply_Name = import_Detail.Supply.Supply_Name;
                                    report_Import_Coupon.Import_Coupon_Quantity = import_Detail.Import_Detail_Quantity.ToString();
                                    report_Import_Coupon.Import_Coupon_Price = import_Detail.Import_Detail_Price.ToString();
                                    report_Import_Coupon.Import_Coupon_Date = import_Detail.Import_Coupon.Import_Coupon_Date.Value.Day.ToString() + "/" + import_Detail.Import_Coupon.Import_Coupon_Date.Value.Month.ToString() + "/" + import_Detail.Import_Coupon.Import_Coupon_Date.Value.Year.ToString();
                                    report_Import_Coupon.Import_Coupon_Note = import_Detail.Import_Detail_Note;
                                    report_Import_Coupons.Add(report_Import_Coupon);
                                   
                                }
                            }

                            this.reportViewerStatistical.LocalReport.ReportPath = "../../Reports/rptImport_Coupon.rdlc";
                            this.reportViewerStatistical.LocalReport.SetParameters(reportParameters);
                            var reportDataSource = new ReportDataSource("Import_Coupon_DataSet", report_Import_Coupons);
                            this.reportViewerStatistical.LocalReport.DataSources.Clear();
                            this.reportViewerStatistical.LocalReport.DataSources.Add(reportDataSource);
                            this.reportViewerStatistical.RefreshReport();
                        }
                        else MessageBox.Show("Không có hàng nào được nhập vào khoảng thời gian này");
                    }
                    else MessageBox.Show("Ngày chọn sau phải lớn hơn ngày chọn trước");
                }
                else
                {
                    if (rbOutput_Coupon.Checked == true)
                    {
                        if (dateTimePickerOne.Value <= dateTimePickerTwo.Value)
                        {
                            if (context.Output_Detail.Where(p => p.Output_Coupon.Output_Coupon_Date.Value >= dateTimePickerOne.Value && p.Output_Coupon.Output_Coupon_Date.Value <= dateTimePickerTwo.Value).Any() == true)
                            {
                                List<Output_Detail> output_Details = context.Output_Detail.ToList();
                                List<Report_Output_Coupon> report_Output_Coupons = new List<Report_Output_Coupon>();
                                ReportParameter[] reportParameters = new ReportParameter[2];
                                reportParameters[0] = new ReportParameter("rpID", "Nhiều");
                                reportParameters[1] = new ReportParameter("rpDate", "Từ " + dateTimePickerOne.Value.ToString("dd/MM/yyyy") + " đến " + dateTimePickerTwo.Value.ToString("dd/MM/yyyy"));
                                foreach (Output_Detail output_Detail in output_Details)
                                {
                                    if (output_Detail.Output_Coupon.Output_Coupon_Date.Value >= dateTimePickerOne.Value && output_Detail.Output_Coupon.Output_Coupon_Date.Value <= dateTimePickerTwo.Value)
                                    {
                                        Report_Output_Coupon report_Output_Coupon = new Report_Output_Coupon();
                                        report_Output_Coupon.Output_Coupon_ID = output_Detail.Output_Coupon_ID;
                                        report_Output_Coupon.Staff_Name = output_Detail.Output_Coupon.Staff_ID;
                                        report_Output_Coupon.Supply_Name = output_Detail.Supply.Supply_Name;
                                        report_Output_Coupon.Output_Coupon_Quantity = output_Detail.Output_Detail_Quantity.ToString();
                                        report_Output_Coupon.Ouput_Coupon_Price = output_Detail.Output_Detail_Price.ToString();
                                        report_Output_Coupon.Output_Coupon_Date = output_Detail.Output_Coupon.Output_Coupon_Date.Value.Day.ToString() + "/" + output_Detail.Output_Coupon.Output_Coupon_Date.Value.Month.ToString() + "/" + output_Detail.Output_Coupon.Output_Coupon_Date.Value.Year.ToString();
                                        report_Output_Coupon.Output_Coupon_Address = output_Detail.Output_Coupon.Output_Coupon_Address;
                                        report_Output_Coupon.Output_Coupon_Note = output_Detail.Output_Detail_Note;
                                        report_Output_Coupons.Add(report_Output_Coupon);
                                        
                                    }
                                }
                                this.reportViewerStatistical.LocalReport.ReportPath = "../../Reports/rptOutput_Coupon.rdlc";
                                this.reportViewerStatistical.LocalReport.SetParameters(reportParameters);
                                var reportDataSource = new ReportDataSource("Output_Coupon_DataSet", report_Output_Coupons);
                                this.reportViewerStatistical.LocalReport.DataSources.Clear();
                                this.reportViewerStatistical.LocalReport.DataSources.Add(reportDataSource);
                                this.reportViewerStatistical.RefreshReport();
                            }
                            else MessageBox.Show("Không tìm thấy hàng xuất trong khoảng thời gian này");
                        }
                        else MessageBox.Show("Ngày chọn sau phải lớn hơn ngày chọn trước");
                    }    
                }    
            }    
        }
    }
}
