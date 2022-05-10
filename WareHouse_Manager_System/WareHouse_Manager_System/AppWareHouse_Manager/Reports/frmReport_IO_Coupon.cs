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
    public partial class frmReport_IO_Coupon : Form
    {
        WareHouseManagerDBContext context = new WareHouseManagerDBContext();
        public frmReport_IO_Coupon()
        {
            InitializeComponent();
            FillImport_Coupon_ID();
            FillOutput_Coupon_ID();
        }

        private void frmReport_Import_Coupon_Load(object sender, EventArgs e)
        {
            this.reportViewerIO_Coupon.RefreshReport();
        }

        private void FillImport_Coupon_ID ()
        {
            cmbImport_Coupon_ID.DataSource = context.Import_Coupon.ToList();
            cmbImport_Coupon_ID.DisplayMember = "Import_Coupon_ID";
            cmbImport_Coupon_ID.ValueMember = "Import_Coupon_ID";
        }

        private void FillOutput_Coupon_ID()
        {
            cmbOutput_Coupon_ID.DataSource = context.Output_Coupon.ToList();
            cmbOutput_Coupon_ID.DisplayMember = "Output_Coupon_ID";
            cmbOutput_Coupon_ID.ValueMember = "Output_Coupon_ID";
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
           if (rbImport_Coupon.Checked == true)
            {    
                List<Import_Detail> import_Details = context.Import_Detail.ToList();
                List<Report_Import_Coupon> report_Import_Coupons = new List<Report_Import_Coupon>();
                ReportParameter[] reportParameters = new ReportParameter[2];
                foreach (Import_Detail import_Detail in import_Details)
                {
                    if (import_Detail.Import_Coupon_ID == cmbImport_Coupon_ID.Text)
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
                        reportParameters[0] = new ReportParameter("rpID", import_Detail.Import_Coupon_ID);
                        reportParameters[1] = new ReportParameter("rpDate", "Ngày " + import_Detail.Import_Coupon.Import_Coupon_Date.Value.Day.ToString() + " Tháng " + import_Detail.Import_Coupon.Import_Coupon_Date.Value.Month.ToString() + " Năm " + import_Detail.Import_Coupon.Import_Coupon_Date.Value.Year.ToString());
                    }
                }
                this.reportViewerIO_Coupon.LocalReport.ReportPath = "../../Reports/rptImport_Coupon.rdlc";
                this.reportViewerIO_Coupon.LocalReport.SetParameters(reportParameters);
                var reportDataSource = new ReportDataSource("Import_Coupon_DataSet", report_Import_Coupons);
                this.reportViewerIO_Coupon.LocalReport.DataSources.Clear();
                this.reportViewerIO_Coupon.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerIO_Coupon.RefreshReport();
            }    
           if (rbOutput_Coupon.Checked == true)
            {
                List<Output_Detail> output_Details = context.Output_Detail.ToList();
                List<Report_Output_Coupon> report_Output_Coupons = new List<Report_Output_Coupon>();
                ReportParameter[] reportParameters = new ReportParameter[2];
                foreach (Output_Detail output_Detail in output_Details)
                {
                    if (output_Detail.Output_Coupon_ID == cmbOutput_Coupon_ID.Text)
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
                        reportParameters[0] = new ReportParameter("rpID", output_Detail.Output_Coupon_ID);
                        reportParameters[1] = new ReportParameter("rpDate", "Ngày " + output_Detail.Output_Coupon.Output_Coupon_Date.Value.Day.ToString() + " Tháng " + output_Detail.Output_Coupon.Output_Coupon_Date.Value.Month.ToString() + " Năm " + output_Detail.Output_Coupon.Output_Coupon_Date.Value.Year.ToString());
                    }
                }
                this.reportViewerIO_Coupon.LocalReport.ReportPath = "../../Reports/rptOutput_Coupon.rdlc";
                this.reportViewerIO_Coupon.LocalReport.SetParameters(reportParameters);
                var reportDataSource = new ReportDataSource("Output_Coupon_DataSet", report_Output_Coupons);
                this.reportViewerIO_Coupon.LocalReport.DataSources.Clear();
                this.reportViewerIO_Coupon.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerIO_Coupon.RefreshReport();
            }    
        }

        private void rbImport_Coupon_CheckedChanged(object sender, EventArgs e)
        {
            cmbImport_Coupon_ID.Enabled = true;
            cmbOutput_Coupon_ID.Enabled = false;
        }

        private void rbOutput_Coupon_CheckedChanged(object sender, EventArgs e)
        {
            cmbImport_Coupon_ID.Enabled = false;
            cmbOutput_Coupon_ID.Enabled = true;
        }
    }
}
