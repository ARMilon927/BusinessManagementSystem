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
    public partial class PurchaseUI : Form
    {
        public PurchaseUI()
        {
            InitializeComponent();
        }
        PurchaseManager _purchaseManager = new PurchaseManager();
        List<Purchase> _purchases = new List<Purchase>();
        DataTable _table = new DataTable();
        private int _indexRow;
        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _purchaseManager.GetCategories();
            categoryComboBox.SelectedValue = 0;
            categoryComboBox.Text = @"--Select--";
            supplierComboBox.DataSource = _purchaseManager.GetSuppliers();
            supplierComboBox.SelectedValue = 0;
            supplierComboBox.Text = @"--Select--";
            productsComboBox.SelectedValue = 0;
            productsComboBox.Text = @"--Select--";
            purchaseDateTimePicker.Value = DateTime.Today;
            manufacturedDateTimePicker.Value = DateTime.Today;
            manufacturedDateTimePicker.Value = DateTime.Today;

            _table.Columns.Add("Sl", typeof(string));
            _table.Columns.Add("Products (Code)", typeof(string));
            _table.Columns.Add("Manufactured Date", typeof(string));
            _table.Columns.Add("Expired Date", typeof(string));
            _table.Columns.Add("Quantity", typeof(string));
            _table.Columns.Add("Unit Price(Tk)", typeof(string));
            _table.Columns.Add("Total Price(Tk)", typeof(string));
            _table.Columns.Add("MRP(Tk)", typeof(string));
            _table.Columns.Add("Remarks", typeof(string));
            purchaseDataGridView.DataSource = _table;
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
            purchaseDataGridView.Columns.Add(editColumn);
            purchaseDataGridView.Columns.Add(deleteColumn);
            purchaseDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            purchaseDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            purchaseDataGridView.EnableHeadersVisualStyles = false;
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.Text != @"--Select--")
            {
                productsComboBox.DataSource = _purchaseManager.GetProducts(Convert.ToInt32(categoryComboBox.SelectedValue));
                if (_purchaseManager.GetProducts(Convert.ToInt32(categoryComboBox.SelectedValue)).Count == 0)
                {
                    productsComboBox.SelectedValue = 0;
                    productsComboBox.Text = @"--Select--";
                }
            }
        }

        private void productsComboBox_TextChanged(object sender, EventArgs e)
        {
            availableQuantityTextBox.Text = _purchaseManager.GetAvailableQuantity(productsComboBox.Text).ToString();
            productCodeTextBox.Text = _purchaseManager.GetProductCode(productsComboBox.Text);
            List<double> prices = new List<double>();
            if (_purchaseManager.GetPurchaseUnitPriceMrpPrice(Convert.ToInt32(productsComboBox.SelectedValue)).Count > 0)
            {
                prices = _purchaseManager.GetPurchaseUnitPriceMrpPrice(Convert.ToInt32(productsComboBox.SelectedValue));
                previousUnitPriceTextBox.Text = prices[0].ToString();
                previousMrpTextBox.Text = prices[1].ToString();
                return;
            }
            previousUnitPriceTextBox.Text = @"";
            previousMrpTextBox.Text = @"";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidPurchase()) return;
                string code = _purchaseManager.GetPurchaseCode();
                Purchase aPurchase = new Purchase
                {
                    PurchaseDate = purchaseDateTimePicker.Value,
                    InvoiceNo = billTextBox.Text,
                    SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue),
                    CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue),
                    ProductId = Convert.ToInt32(productsComboBox.SelectedValue),
                    ManufacturedDate = manufacturedDateTimePicker.Value,
                    ExpiredDate = expireDateTimePicker.Value,
                    Quantity = Convert.ToInt32(quantityTextBox.Text),
                    UnitPrice = Convert.ToDouble(unitPriceTextBox.Text),
                    TotalPrice = Convert.ToDouble(totalPriceTextBox.Text),
                    MRP = Convert.ToDouble(mrpTextBox.Text),
                    Remarks = remarksTextBox.Text,
                    Code = code
                };
                string billNo = aPurchase.InvoiceNo;
                if (_purchaseManager.ExistBillNumber(billNo))
                {
                    billValidLabel.Text = @"This Bill no already exists";
                    return;
                }
                if (addButton.Text == @"Add")
                {

                    billValidLabel.Text = @"";
                    _purchases.Add(aPurchase);
                    _table.Rows.Add(null, productCodeTextBox.Text, manufacturedDateTimePicker.Text, expireDateTimePicker.Text,
                        quantityTextBox.Text, unitPriceTextBox.Text, totalPriceTextBox.Text, mrpTextBox.Text,
                        remarksTextBox.Text);
                    purchaseDataGridView.DataSource = _table;
                }
                if (addButton.Text == @"Update")
                {
                    addButton.Text = @"Add";
                    DataGridViewRow row = purchaseDataGridView.Rows[_indexRow];
                    row.Cells[1].Value = productCodeTextBox.Text;
                    row.Cells[2].Value = manufacturedDateTimePicker.Text;
                    row.Cells[3].Value = expireDateTimePicker.Text;
                    row.Cells[4].Value = quantityTextBox.Text;
                    row.Cells[5].Value = unitPriceTextBox.Text;
                    row.Cells[6].Value = totalPriceTextBox.Text;
                    row.Cells[7].Value = mrpTextBox.Text;
                    row.Cells[8].Value = remarksTextBox.Text;
                    _purchases[_indexRow] = aPurchase;
                }
            }
            catch (Exception exception)
            {
                return;
            }
            ClearInput();
        }
        private void ClearInput()
        {
            categoryComboBox.SelectedValue = 0;
            categoryComboBox.Text = @"--Select--";
            productsComboBox.SelectedValue = 0;
            productsComboBox.Text = @"--Select--";
            quantityTextBox.Clear();
            mrpTextBox.Clear();
            unitPriceTextBox.Clear();
        }
        private bool ValidPurchase()
        {
            if (String.IsNullOrEmpty(purchaseDateTimePicker.Text))
            {
                dateValidLabel.Text = @"Enter purchase date";
                return true;
            }
            dateValidLabel.Text = @"";
            if (String.IsNullOrEmpty(billTextBox.Text))
            {
                billValidLabel.Text = @"Enter bill no";
                return true;
            }
            billValidLabel.Text = @"";
            if (String.IsNullOrEmpty(supplierComboBox.Text)|| supplierComboBox.Text == @"--Select--")
            {
                supplierValidLabel.Text = @"Enter supplier name";
                return true;
            }
            supplierValidLabel.Text = @"";
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
                quantityValidLabel.Text = @"Enter quantity";
                return true;
            }
            quantityValidLabel.Text = @"";
            if (String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                unitPriceValidLabel.Text = @"Enter unit price";
                return true;
            }
            unitPriceValidLabel.Text = @"";
            if (String.IsNullOrEmpty(mrpTextBox.Text))
            {
                mrpValidLabel.Text = @"Enter unit price";
                return true;
            }
            mrpValidLabel.Text = @"";
            return false;
        }
        private void purchaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _indexRow = e.RowIndex;
                if (purchaseDataGridView.Columns[e.ColumnIndex].Name == @"Edit")
                {
                    addButton.Text = @"Update";
                    DataGridViewRow row = this.purchaseDataGridView.Rows[_indexRow];
                    idLabel.Text = row.Cells[0].Value.ToString();
                    productCodeTextBox.Text = row.Cells[1].Value.ToString();
                    manufacturedDateTimePicker.Text = row.Cells[2].Value.ToString();
                    expireDateTimePicker.Text = row.Cells[3].Value.ToString();
                    quantityTextBox.Text = row.Cells[4].Value.ToString();
                    unitPriceTextBox.Text = row.Cells[5].Value.ToString();
                    totalPriceTextBox.Text = row.Cells[6].Value.ToString();
                    mrpTextBox.Text = row.Cells[7].Value.ToString();
                    remarksTextBox.Text = row.Cells[8].Value.ToString();

                    billTextBox.Text = _purchases[_indexRow].InvoiceNo;
                    supplierComboBox.SelectedValue = _purchases[_indexRow].SupplierId;
                    categoryComboBox.SelectedValue = _purchases[_indexRow].CategoryId;
                    purchaseDateTimePicker.Value = _purchases[_indexRow].PurchaseDate;
                }
                if (purchaseDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show(@"Do you want to remove this product?", "ConfirmBox", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        purchaseDataGridView.Rows.RemoveAt(_indexRow);
                        _purchases.RemoveAt(_indexRow);
                    }
                }
            }
            catch (Exception exception)
            {
                return;
            }
        }
        private void purchaseDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == purchaseDataGridView.NewRowIndex)
                return;
            if (e.ColumnIndex == purchaseDataGridView.Columns["Sl"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var purchase in _purchases)
                {
                    int rowAffected = _purchaseManager.SavePurchase(purchase);
                    if (rowAffected < 0)
                    {
                        return;
                    }
                }
                MessageBox.Show(@"Purchase is done successfully");
            }
            catch (Exception exception)
            {
                return;
            }
            ClearInput();
            _table.Clear();
            purchaseDataGridView.Refresh();
            //string message = "";
            //message += purchase.Code + "\t" + purchase.CategoryId + "\t" + purchase.ProductId +
            //           "\t" + purchase.SupplierId + "\t" + purchase.ManufacturedDate + "\t" + purchase.PurchaseDate +
            //           "\t" + purchase.ExpiredDate + "\t" + purchase.Quantity + "\t" + purchase.UnitPrice +
            //           "\t" + purchase.TotalPrice + "\t" + purchase.MRP + "\t" + purchase.Remarks +
            //           "\n";
            //MessageBox.Show(message);
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back) || ch == '.'))
                e.Handled = true;
        }

        private void unitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '.' && unitPriceTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back) || ch == '.'))
                e.Handled = true;
        }

        private void mrpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '.' && mrpTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back) || ch == '.'))
                e.Handled = true;
        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantityTextBox.Text = @"0";
            }
            if (String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                unitPriceTextBox.Text = @"0";
            }
            totalPriceTextBox.Text = (Convert.ToDouble(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text))
                .ToString();
            mrpTextBox.Text = (Convert.ToDouble(unitPriceTextBox.Text) * 1.25)
                .ToString();
        }
    }
}
