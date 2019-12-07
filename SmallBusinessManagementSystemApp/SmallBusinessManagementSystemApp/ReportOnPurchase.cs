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
    public partial class ReportOnPurchase : Form
    {
        public ReportOnPurchase()
        {
            InitializeComponent();
        }
        PurchaseReportManager _purchaseReportManager = new PurchaseReportManager();
        private void ReportOnPurchase_Load(object sender, EventArgs e)
        {
            startDateTimePicker.Value = DateTime.Today;
            endDateTimePicker.Value = DateTime.Today;
            purchaseReportDataGridView.DataSource = _purchaseReportManager.GetPurchaseReport(DateTime.MinValue, DateTime.MaxValue);

            // CalculateReport();
            purchaseReportDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            purchaseReportDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            purchaseReportDataGridView.EnableHeadersVisualStyles = false;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(startDateTimePicker.Value);
            DateTime endDate = Convert.ToDateTime(endDateTimePicker.Value);
            if (_purchaseReportManager.GetPurchaseReport(startDate, endDate).Count <= 0)
            {
                MessageBox.Show(@"No Data found");
            }
            purchaseReportDataGridView.DataSource = _purchaseReportManager.GetPurchaseReport(startDate, endDate);

        }
        private void purchaseReportDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            purchaseReportDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        
    }
}
