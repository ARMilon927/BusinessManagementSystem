using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystemApp.Manager;

namespace SmallBusinessManagementSystemApp
{
    public partial class ReportOnSales : Form
    {
        public ReportOnSales()
        {
            InitializeComponent();
        }
        SalesReportManager _salesReportManager = new SalesReportManager();
        private void ReportOnSales_Load(object sender, EventArgs e)
        {
            salesReportDataGridView.DataSource = _salesReportManager.GetSalesReport(DateTime.MinValue, DateTime.MaxValue);

            // CalculateReport();
            salesReportDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            salesReportDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            salesReportDataGridView.EnableHeadersVisualStyles = false;

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(startDateTimePicker.Value);
            DateTime endDate = Convert.ToDateTime(endDateTimePicker.Value);
            if (_salesReportManager.GetSalesReport(startDate, endDate).Count <= 0)
            {
                MessageBox.Show(@"No Data found");
            }
            salesReportDataGridView.DataSource = _salesReportManager.GetSalesReport(startDate, endDate);
            //CalculateReport();
        }

        private void salesReportDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            salesReportDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        

        private void salesReportDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //private void CalculateReport()
        //{
        //    salesReportDataGridView[4, salesReportDataGridView.Rows.Count -1].Value = "Total";
        //    salesReportDataGridView.Rows[salesReportDataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Blue;
        //    salesReportDataGridView.Rows[salesReportDataGridView.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.NavajoWhite;

        //    double totalCost = 0;
        //    double totalSales = 0;
        //    double totalProfit = 0;
        //    for (int i = 0; i < salesReportDataGridView.Rows.Count - 1; i++)
        //    {
        //        var cost = salesReportDataGridView.Rows[i].Cells[5].Value;
        //        var sales = salesReportDataGridView.Rows[i].Cells[6].Value;
        //        var profit = salesReportDataGridView.Rows[i].Cells[7].Value;
        //        if (cost != DBNull.Value && sales != DBNull.Value && profit != DBNull.Value)
        //        {
        //            totalCost += Convert.ToDouble(cost);
        //            totalSales += Convert.ToDouble(sales);
        //            totalProfit += Convert.ToDouble(profit);
        //        }

        //        salesReportDataGridView.Rows[salesReportDataGridView.Rows.Count -1].Cells[5].Value =
        //            totalCost.ToString();
        //        salesReportDataGridView.Rows[salesReportDataGridView.Rows.Count - 1].Cells[6].Value =
        //            totalSales.ToString();
        //        salesReportDataGridView.Rows[salesReportDataGridView.Rows.Count - 1].Cells[7].Value =
        //            totalProfit.ToString();
        //    }
        //}
    }
}
