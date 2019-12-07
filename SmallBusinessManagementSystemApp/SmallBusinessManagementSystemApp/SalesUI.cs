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
using SmallBusinessManagementSystemApp.Model;

namespace SmallBusinessManagementSystemApp
{
    public partial class SalesUI : Form
    {
        public SalesUI()
        {
            InitializeComponent();
        }
        SalesManager _salesManager = new SalesManager();
        List<Sales> _saleses = new List<Sales>();
        DataTable _table = new DataTable();
        private int _indexRow;
        private void SalesUI_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _salesManager.GetCategories();
            categoryComboBox.SelectedValue = 0;
            categoryComboBox.Text = @"--Select--";
            customerComboBox.DataSource = _salesManager.GetCustomers();
            customerComboBox.SelectedValue = 0;
            customerComboBox.Text = @"--Select--";
            productsComboBox.SelectedValue = 0;
            productsComboBox.Text = @"--Select--";

            _table.Columns.Add("Sl", typeof(int));
            _table.Columns.Add("Product", typeof(string));
            _table.Columns.Add("Quantity", typeof(int));
            _table.Columns.Add("MRP", typeof(float));
            _table.Columns.Add("TotalMRP", typeof(float));
            salesDataGridView.DataSource = _table;
            DataGridViewLinkColumn editColumn = new DataGridViewLinkColumn
            {
                HeaderText = @"Update",
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForLinkValue = true
            };
            DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn
            {
                HeaderText = @"Delete",
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true
            };
            salesDataGridView.Columns.Add(editColumn);
            salesDataGridView.Columns.Add(deleteColumn);
            salesDateTimePicker.Value = DateTime.Today;
            salesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            salesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            salesDataGridView.EnableHeadersVisualStyles = false;
        }
        private void productsComboBox_TextChanged(object sender, EventArgs e)
        {
            availableQuantityTextBox.Text = _salesManager.GetAvailableQuantity(productsComboBox.Text).ToString();
            double mrp = _salesManager.GetProductMRP(Convert.ToInt32(productsComboBox.SelectedValue));
            // productsComboBox.DataSource = _salesManager.GetProducts(Convert.ToInt32(categoryComboBox.SelectedValue));
            //productsComboBox.SelectedIndex = -1;
            //productsComboBox.SelectedText = "--Select--";
            mrpTextBox.Text = mrp.ToString();
        }
        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.Text != @"--Select--")
            {
                productsComboBox.DataSource = _salesManager.GetProducts(Convert.ToInt32(categoryComboBox.SelectedValue));
            }
        }
        private void customerComboBox_TextChanged(object sender, EventArgs e)
        {
            pointTextBox.Text = _salesManager.GetCustomerLoyaltyPoint(customerComboBox.Text).ToString();
            discountPercentageTextBox.Text = (Convert.ToInt32(pointTextBox.Text) / 10).ToString();
        }
        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (productsComboBox.Text != @"--Select--")
            {
                if (String.IsNullOrEmpty(quantityTextBox.Text))
                    quantityTextBox.Text = @"0";
                int reorder = _salesManager.GetReorderLevel(productsComboBox.Text);
                int salesAvailable = Convert.ToInt32(availableQuantityTextBox.Text) - reorder;
                if (salesAvailable - Convert.ToDouble(quantityTextBox.Text) <= 0)
                {
                    MessageBox.Show(@"Products available is below from reorder level");
                }
                if (String.IsNullOrEmpty(mrpTextBox.Text))
                    mrpTextBox.Text = @"0";
                totalMrpTextBox.Text = (Convert.ToDouble(quantityTextBox.Text) * Convert.ToDouble(mrpTextBox.Text)).ToString();
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidSales()) return;
                if (Convert.ToDouble(availableQuantityTextBox.Text) - Convert.ToDouble(quantityTextBox.Text) <= 0)
                {
                    MessageBox.Show(@"Sales quantity is more than available quantity");
                    return;
                }
                Sales aSales = new Sales
                {
                    Date = Convert.ToDateTime(salesDateTimePicker.Value),
                    CustomerId = Convert.ToInt32(customerComboBox.SelectedValue),
                    CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue),
                    ProductId = Convert.ToInt32(productsComboBox.SelectedValue),
                    Quantity = Convert.ToInt32(quantityTextBox.Text),
                    TotalMRP = Convert.ToDouble(totalMrpTextBox.Text),
                    Discount = Convert.ToDouble(discountPercentageTextBox.Text)
                };
                aSales.DiscountAmount = aSales.TotalMRP * aSales.Discount / 100;
                aSales.PayableAmount = aSales.TotalMRP - aSales.DiscountAmount;
                if (addButton.Text == @"Add")
                {
                    _saleses.Add(aSales);
                    _table.Rows.Add(null, productsComboBox.Text, quantityTextBox.Text, mrpTextBox.Text, totalMrpTextBox.Text);
                    salesDataGridView.DataSource = _table;
                }
                if (addButton.Text == @"Update")
                {
                    addButton.Text = @"Add";
                    DataGridViewRow row = salesDataGridView.Rows[_indexRow];
                    row.Cells[1].Value = productsComboBox.Text;
                    row.Cells[2].Value = quantityTextBox.Text;
                    row.Cells[3].Value = mrpTextBox.Text;
                    row.Cells[4].Value = totalMrpTextBox.Text;
                    _saleses[_indexRow] = aSales;
                }

            }
            catch (Exception exception)
            {
                return;
            }
            PaymentView();
            ClearProduct();
        }

        private bool ValidSales()
        {
            if (String.IsNullOrEmpty(customerComboBox.Text) || customerComboBox.Text == @"--Select--")
            {
                customerValidLabel.Text = @"Please select";
                return true;
            }
            customerValidLabel.Text = @"";
            if (String.IsNullOrEmpty(salesDateTimePicker.Text))
            {
                dateValidLabel.Text = @"Invalid";
                return true;
            }
            dateValidLabel.Text = @"";
            if (String.IsNullOrEmpty(categoryComboBox.Text) || categoryComboBox.Text == @"--Select--")
            {
                categoryValidLabel.Text = @"Invalid";
                return true;
            }
            categoryValidLabel.Text = @"";
            if (String.IsNullOrEmpty(productsComboBox.Text) || productsComboBox.Text == @"--Select--")
            {
                productValidLabel.Text = @"Invalid";
                return true;
            }
            productValidLabel.Text = @"";
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantityValidLabel.Text = @"Invalid";
                return true;
            }
            quantityValidLabel.Text = @"";
            return false;
        }
        private void PaymentView()
        {
            List<double> grandTotals = new List<double>();
            List<double> discountAmounts = new List<double>();
            List<double> payableAmounts = new List<double>();
            foreach (Sales data in _saleses)
            {
                grandTotals.Add(data.TotalMRP);
                discountAmounts.Add(data.DiscountAmount);
                payableAmounts.Add(data.PayableAmount);
            }
            grandTotalTextBox.Text = grandTotals.Sum().ToString();
            discountAmountTextBox.Text = discountAmounts.Sum().ToString();
            payableAmountTextBox.Text = payableAmounts.Sum().ToString();
        }

        private void salesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.salesDataGridView.NewRowIndex)
                return;
            if (e.ColumnIndex == this.salesDataGridView.Columns["Sl"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string code = _salesManager.GetSalesCode();
                foreach (Sales sales in _saleses)
                {
                    sales.Code = code;
                    int rowAffected = _salesManager.SaveSales(sales);
                    if (rowAffected < 0)
                    {
                        return;
                    }
                }
                MessageBox.Show(@"Sales is done successfully");
                int loyaltyPoint = (Convert.ToInt32(pointTextBox.Text) - Convert.ToInt32(_saleses[0].Discount)) + (Convert.ToInt32(grandTotalTextBox.Text) / 1000);
                _salesManager.SetCustomerLoyaltyPoint(loyaltyPoint, customerComboBox.Text);
                _table.Clear();
                salesDataGridView.Refresh();

            }
            catch (Exception exception)
            {
                return;
            }
            //for (int i = 0; i < salesDataGridView.RowCount; i++)
            //{
            //    Sales aSales = new Sales();
            //    DataGridViewRow row = this.salesDataGridView.Rows[i];
            //    aSales.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
            //    aSales.Date = salesDateTimePicker.Value;
            //    aSales.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            //    aSales.ProductId = Convert.ToInt32(productsComboBox.SelectedValue);
            //    aSales.Quantity = Convert.ToInt32(row.Cells[i+2].Value.ToString());
            //    aSales.TotalMRP = Convert.ToDouble(row.Cells[i+3].Value.ToString());
            //    aSales.Discount = Convert.ToDouble(discountPercentageTextBox.Text);
            //    aSales.DiscountAmount = aSales.TotalMRP + aSales.TotalMRP * aSales.Discount / 100;
            //    aSales.PayableAmount = aSales.TotalMRP - aSales.DiscountAmount;
            //    aSales.Code = code;
            //    _saleses.Add(aSales);
            //}
            //salesDataGridView.DataSource = null;
            ClearInput();
        }
        private void ClearInput()
        {
            ClearProduct();
            salesDateTimePicker.Value = DateTime.Today;
            customerComboBox.SelectedValue = 0;
            customerComboBox.Text = @"--Select--";
            grandTotalTextBox.Text = "";
            discountAmountTextBox.Text = "";
            payableAmountTextBox.Text = "";
        }

        private void ClearProduct()
        {
            categoryComboBox.SelectedValue = 0;
            categoryComboBox.Text = @"--Select--";
            productsComboBox.SelectedValue = 0;
            productsComboBox.Text = @"--Select--";
            quantityTextBox.Text = "";
            totalMrpTextBox.Text = "";
        }

        private void salesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _indexRow = e.RowIndex;
                if (salesDataGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    addButton.Text = @"Update";
                    DataGridViewRow row = this.salesDataGridView.Rows[_indexRow];
                    idLabel.Text = row.Cells[0].Value.ToString();
                    productsComboBox.Text = row.Cells[1].Value.ToString();
                    quantityTextBox.Text = row.Cells[2].Value.ToString();
                    mrpTextBox.Text = row.Cells[3].Value.ToString();
                    totalMrpTextBox.Text = row.Cells[4].Value.ToString();

                    customerComboBox.SelectedValue = _saleses[_indexRow].CustomerId;
                    categoryComboBox.SelectedValue = _saleses[_indexRow].CategoryId;
                    salesDateTimePicker.Value = _saleses[_indexRow].Date;
                }
                if (salesDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    //indexRow = e.RowIndex;
                    //addButton.Text = "Update";
                    //DataGridViewRow row = this.salesDataGridView.Rows[indexRow];
                    //idLabel.Text = row.Cells[0].Value.ToString();
                    //productsComboBox.Text = row.Cells[1].Value.ToString();
                    //quantityTextBox.Text = row.Cells[2].Value.ToString();
                    //mrpTextBox.Text = row.Cells[3].Value.ToString();
                    //totalMrpTextBox.Text = row.Cells[4].Value.ToString();
                    //MessageBoxButtons.OKCancel;
                    if (MessageBox.Show(@"Do you want to remove this product?", @"ConfirmBox", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        salesDataGridView.Rows.RemoveAt(_indexRow);
                        _saleses.RemoveAt(_indexRow);
                        PaymentView();
                    }
                }
            }
            catch (Exception exception)
            {
               return;
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back)))
                e.Handled = true;
        }
        private void mrpTextBox_TextChanged(object sender, EventArgs e)
        {
            if (productsComboBox.Text != @"--Select--")
            {
                if (String.IsNullOrEmpty(quantityTextBox.Text))
                    quantityTextBox.Text = @"0";
                if (String.IsNullOrEmpty(mrpTextBox.Text))
                    mrpTextBox.Text = @"0";
                totalMrpTextBox.Text = (Convert.ToDouble(quantityTextBox.Text) * Convert.ToDouble(mrpTextBox.Text)).ToString();
            }
        }
        private void mrpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '.' && quantityTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back) || ch == '.'))
                e.Handled = true;
        }
    }
}
