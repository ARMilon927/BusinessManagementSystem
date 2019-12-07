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
    public partial class PurchaseShowUI : Form
    {
        public PurchaseShowUI()
        {
            InitializeComponent();
        }
        PurchaseManager _purchaseManager = new PurchaseManager();
        private void PurchaseShowUI_Load(object sender, EventArgs e)
        {
            supplierInfoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            supplierInfoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            supplierInfoDataGridView.EnableHeadersVisualStyles = false;
            supplierInfoDataGridView.DataSource = _purchaseManager.ShowPurchase();
            purchaseProductInfoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            purchaseProductInfoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            purchaseProductInfoDataGridView.EnableHeadersVisualStyles = false;
        }

        private void supplierInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (supplierInfoDataGridView != null && (e.RowIndex >= 0 && supplierInfoDataGridView.Columns[e.ColumnIndex].Name == "Details"))
                {
                    DataGridViewRow row = this.supplierInfoDataGridView.Rows[e.RowIndex];
                    string purchaseCode = row.Cells[2].Value.ToString();
                    purchaseProductInfoDataGridView.DataSource = _purchaseManager.ShowPurchaseProduct(purchaseCode);
                }
            }
            catch (Exception exception)
            {
                return;
            }
        }

        private void supplierInfoDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            supplierInfoDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void purchaseProductInfoDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            purchaseProductInfoDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(searchTextBox.Text))
                {
                    if (_purchaseManager.SearchPurchase(searchTextBox.Text).Count < 1)
                    {
                        MessageBox.Show(@"No data found");
                        supplierInfoDataGridView.DataSource = _purchaseManager.SearchPurchase(searchTextBox.Text);
                        return;
                    }
                    supplierInfoDataGridView.DataSource = _purchaseManager.SearchPurchase(searchTextBox.Text);
                }
                else
                {
                    supplierInfoDataGridView.DataSource = _purchaseManager.ShowPurchase();
                }
                
            }
            catch (Exception exception)
            {
                return;
            }
            
        }
    }
}
