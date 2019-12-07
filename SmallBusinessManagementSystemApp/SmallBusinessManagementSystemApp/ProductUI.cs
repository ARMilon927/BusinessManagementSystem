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
    public partial class ProductUI : Form
    {
        public ProductUI()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager();
        Product _product = new Product();
        private void ProductUI_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _productManager.GetCategories();
            categoryComboBox.SelectedIndex = -1;
            categoryComboBox.Text = @"--Select--";
            Display();
            productDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            productDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            productDataGridView.EnableHeadersVisualStyles = false;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidProduct()) return;
                _product.Id = Convert.ToInt32(idLabel.Text);
                _product.Code = codeTextBox.Text;
                if (_productManager.ExistProduct(_product, "code"))
                {
                    codeValidLabel.Text = @"This Code already exists";
                    return;
                }
                codeValidLabel.Text = "";
                _product.Name = nameTextBox.Text;
                if (_productManager.ExistProduct(_product, "name"))
                {
                    nameValidLabel.Text = @"This Name already exists";
                    return;
                }
                nameValidLabel.Text = "";
                _product.ReorderLevel = Convert.ToInt32(reorderTextBox.Text);
                _product.Description = descriptionRichTextBox.Text;
                _product.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                if (saveButton.Text == @"Save")
                {
                    MessageBox.Show(_productManager.SaveProduct(_product));
                }
                else
                {
                    MessageBox.Show(_productManager.UpdateProduct(_product));
                    saveButton.Text = @"Save";
                }
            }
            catch (Exception exception)
            {
                return;
            }
            
            Display();
            ClearInput();
        }
        private void ClearInput()
        {
            nameTextBox.Clear();
            codeTextBox.Clear();
            idLabel.Text = @"-1";
        }
        private void Display()
        {
            if (_productManager.ShowProduct().Count <= 0)
            {
                MessageBox.Show(@"No Data found");
            }
            productDataGridView.DataSource = _productManager.ShowProduct();
        }
        private bool ValidProduct()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameValidLabel.Text = @"Please enter a product name";
                return true;
            }
            nameValidLabel.Text = "";
            if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                codeValidLabel.Text = @"Please enter product code";
                return true;
            }
            if (codeTextBox.Text.Length != 4)
            {
                codeValidLabel.Text = @"Code length must be in 4 characters";
                return true;
            }
            codeValidLabel.Text = "";
            if (Convert.ToInt32(reorderTextBox.Text) < 10)
            {
                reorderValidLabel.Text = @"Reorder level should be at least 10";
                return true;
            }
            reorderValidLabel.Text = "";
            if (categoryComboBox.SelectedIndex == -1)
            {
                categoryValidLabel.Text = @"Please select a category";
                return true;
            }
            categoryValidLabel.Text = "";
            return false;
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.RowIndex == productDataGridView.Columns["Action"].Index)
            try
            {
                if (productDataGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    saveButton.Text = @"Update";
                    DataGridViewRow row = this.productDataGridView.Rows[e.RowIndex];
                    idLabel.Text = row.Cells[1].Value.ToString();
                    codeTextBox.Text = row.Cells[2].Value.ToString();
                    nameTextBox.Text = row.Cells[3].Value.ToString();
                    categoryComboBox.Text = row.Cells[4].Value.ToString();
                    reorderTextBox.Text = row.Cells[5].Value.ToString();
                    descriptionRichTextBox.Text = row.Cells[6].Value.ToString();
                }
            }
            catch (Exception exception)
            {
               return;
            }
            
        }
        private void productDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            productDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
                productDataGridView.DataSource = _productManager.SearchProduct(searchTextBox.Text);
            else
            {
                Display();
            }
            
        }

        private void reorderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
