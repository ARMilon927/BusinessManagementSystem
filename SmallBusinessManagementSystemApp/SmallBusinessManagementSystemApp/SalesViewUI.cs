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
    public partial class SalesViewUI : Form
    {
        public SalesViewUI()
        {
            InitializeComponent();
        }
        SalesManager _salesManager = new SalesManager();
        private void SalesViewUI_Load(object sender, EventArgs e)
        {
            customerInfoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            customerInfoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            customerInfoDataGridView.EnableHeadersVisualStyles = false;
            customerInfoDataGridView.DataSource = _salesManager.ShowSales();
            salesProductInfoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            salesProductInfoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            salesProductInfoDataGridView.EnableHeadersVisualStyles = false;

        }

        private void customerInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (customerInfoDataGridView != null &&
                    (e.RowIndex >= 0 && customerInfoDataGridView.Columns[e.ColumnIndex].Name == "Details"))
                {
                    DataGridViewRow row = this.customerInfoDataGridView.Rows[e.RowIndex];
                    string salesCode = row.Cells[2].Value.ToString();
                    salesProductInfoDataGridView.DataSource = _salesManager.ShowSalesProduct(salesCode);
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void customerInfoDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            customerInfoDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void salesProductInfoDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            salesProductInfoDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(searchTextBox.Text))
                {
                    string searchItem = searchTextBox.Text;
                    customerInfoDataGridView.DataSource = _salesManager.SearchSales(searchItem);
                    return;
                }
                customerInfoDataGridView.DataSource = _salesManager.ShowSales();

            }
            catch (Exception exception)
            {
                return;
            }
        }
    }
}
