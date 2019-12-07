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
    public partial class SupplierUI : Form
    {
        public SupplierUI()
        {
            InitializeComponent();
        }
        Supplier _supplier = new Supplier();
        SupplierManager _supplierManager = new SupplierManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidSupplier()) return;
                _supplier.Id = Convert.ToInt32(idLabel.Text);
                _supplier.Code = codeTextBox.Text;
                if (_supplierManager.ExistSupplier(_supplier, "code"))
                {
                    codeValidLabel.Text = @"This code already exists";
                    return;
                }
                codeValidLabel.Text = "";
                _supplier.Name = nameTextBox.Text;
                if (_supplierManager.ExistSupplier(_supplier, "name"))
                {
                    nameValidLabel.Text = @"This name already exists";
                    return;
                }
                nameValidLabel.Text = "";
                _supplier.Email = emailTextBox.Text;
                if (_supplierManager.ExistSupplier(_supplier, "email"))
                {
                    emailValidLabel.Text = @"This email already exists";
                    return;
                }
                emailValidLabel.Text = "";
                _supplier.Address = addressTextBox.Text;
                _supplier.Contact = contactTextBox.Text;
                _supplier.ContactPerson = contactPersonTextBox.Text;
                if (saveButton.Text == @"Save")
                {
                    MessageBox.Show(_supplierManager.SaveSupplier(_supplier));
                }
                else
                {
                    MessageBox.Show(_supplierManager.UpdateSupplier(_supplier));
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
            codeTextBox.Clear();
            nameTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            contactPersonTextBox.Clear();
        }

        private bool ValidSupplier()
        {
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeValidLabel.Text = @"Please enter supplier code";
                return true;
            }
            if (codeTextBox.Text.Length != 4)
            {
                codeValidLabel.Text = @"Supplier code should be in 4 characters";
                return true;
            }
            codeValidLabel.Text = "";
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                nameValidLabel.Text = @"Please enter supplier name";
                return true;
            }
            nameValidLabel.Text = "";
            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                addressValidLabel.Text = @"Please enter supplier address";
                return true;
            }
            addressValidLabel.Text = "";
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                emailValidLabel.Text = @"Please enter supplier email";
                return true;
            }

            emailValidLabel.Text = "";
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                contactValidLabel.Text = @"Please enter supplier contact number";
                return true;
            }
            contactValidLabel.Text = "";
            if (String.IsNullOrEmpty(contactPersonTextBox.Text))
            {
                contactPersonValidLabel.Text = @"Please enter supplier contact person";
                return true;
            }
            contactPersonValidLabel.Text = "";
            return false;
        }
        private void Display()
        {
            if (_supplierManager.ShowSupplier().Count < 0)
                MessageBox.Show(@"No data found");
            supplierDataGridView.DataSource = _supplierManager.ShowSupplier();
        }

        private void SupplierUI_Load(object sender, EventArgs e)
        {
            Display();
            supplierDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            supplierDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            supplierDataGridView.EnableHeadersVisualStyles = false;

        }

        private void supplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (supplierDataGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    saveButton.Text = @"Update";
                    DataGridViewRow row = this.supplierDataGridView.Rows[e.RowIndex];
                    idLabel.Text = row.Cells[1].Value.ToString();
                    codeTextBox.Text = row.Cells[2].Value.ToString();
                    nameTextBox.Text = row.Cells[3].Value.ToString();
                    addressTextBox.Text = row.Cells[4].Value.ToString();
                    emailTextBox.Text = row.Cells[5].Value.ToString();
                    contactTextBox.Text = row.Cells[6].Value.ToString();
                    contactPersonTextBox.Text = row.Cells[7].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                return;
            }
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
                supplierDataGridView.DataSource = _supplierManager.SearchSupplier(searchTextBox.Text);
            else
            {
                supplierDataGridView.DataSource = _supplierManager.ShowSupplier();
            }
        }

        private void supplierDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            supplierDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
