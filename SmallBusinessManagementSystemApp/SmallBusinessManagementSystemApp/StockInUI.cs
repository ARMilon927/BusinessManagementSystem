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
    public partial class StockInUI : Form
    {
        public StockInUI()
        {
            InitializeComponent();
        }
        StockShowManager _stockShowManager = new StockShowManager();
        private void StockInUI_Load(object sender, EventArgs e)
        {
            stockInDataGridView.DataSource = _stockShowManager.ShowStock();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void SearchMethod()
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                DateTime startDate = Convert.ToDateTime(startDateTimePicker.Value);
                DateTime endDate = Convert.ToDateTime(endDateTimePicker.Value);
                if (_stockShowManager.SearchStock(searchTextBox.Text, startDate, endDate).Count <= 0)
                {
                    MessageBox.Show(@"No Data found");
                }

                stockInDataGridView.DataSource = _stockShowManager.SearchStock(searchTextBox.Text, startDate, endDate);
                return;
            }

            stockInDataGridView.DataSource = _stockShowManager.ShowStock();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void stockInDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            stockInDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }
    }
}
