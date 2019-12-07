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
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }
        Customer _customer = new Customer();
        CustomerManager _customerManager = new CustomerManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidCustomer()) return;
                _customer.Id = Convert.ToInt32(idLabel.Text);
                _customer.Code = codeTextBox.Text;
                if (_customerManager.ExistCustomer(_customer, "code"))
                {
                    codeValidLabel.Text = @"This code already exists";
                    return;
                }
                codeValidLabel.Text = "";
                _customer.Name = nameTextBox.Text;
                if (_customerManager.ExistCustomer(_customer, "name"))
                {
                    nameValidLabel.Text = @"This name already exists";
                    return;
                }
                nameValidLabel.Text = "";
                _customer.Email = emailTextBox.Text;
                if (_customerManager.ExistCustomer(_customer, "email"))
                {
                    emailValidLabel.Text = @"This email already exists";
                    return;
                }
                emailValidLabel.Text = "";
                _customer.Address = addressTextBox.Text;
                _customer.Contact = contactTextBox.Text;
                _customer.LoyaltyPoint = Convert.ToInt32(pointTextBox.Text);
                if (saveButton.Text == @"Save")
                {
                    MessageBox.Show(_customerManager.SaveCustomer(_customer));
                }
                else
                {
                    MessageBox.Show(_customerManager.UpdateCustomer(_customer));
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
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            pointTextBox.Text = @"0";
        }

        private bool ValidCustomer()
        {
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeValidLabel.Text = @"Please enter customer code";
                return true;
            }
            if (codeTextBox.Text.Length != 4)
            {
                codeValidLabel.Text = @"Customer code should be in 4 characters";
                return true;
            }
            codeValidLabel.Text = "";
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                nameValidLabel.Text = @"Please enter customer name";
                return true;
            }
            nameValidLabel.Text = "";
            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                addressValidLabel.Text = @"Please enter customer address";
                return true;
            }
            addressValidLabel.Text = "";
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                emailValidLabel.Text = @"Please enter customer email";
                return true;
            }

            emailValidLabel.Text = "";
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                contactValidLabel.Text = @"Please enter customer contact number";
                return true;
            }

            if (contactTextBox.Text.Length != 11)
            {
                contactValidLabel.Text = @"Contact number should be in 11 digits";
                return true;
            }
            contactValidLabel.Text = "";
            if (String.IsNullOrEmpty(pointTextBox.Text))
            {
                loyalityValidLabel.Text = @"Please enter customer loyalty point";
                return true;
            }
            loyalityValidLabel.Text = "";
            return false;
        }
        private void Display()
        {
            if (_customerManager.ShowCustomer().Count < 0)
                MessageBox.Show(@"No data found");
            customerDataGridView.DataSource = _customerManager.ShowCustomer();
        }
        private void CustomerUI_Load(object sender, EventArgs e)
        {
            customerDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            customerDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            customerDataGridView.EnableHeadersVisualStyles = false;
            Display();
            //DataGridViewLinkColumn editColumn = new DataGridViewLinkColumn
            //{
            //    HeaderText = @"Action", Name = "Edit", Text = "Edit", UseColumnTextForLinkValue = true
            //};
            //customerDataGridView.Columns.Add(editColumn);
            pointTextBox.Text = @"0";
        }
        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (customerDataGridView != null && (e.RowIndex >= 0 && customerDataGridView.Columns[e.ColumnIndex].Name == "Edit"))
                {
                    saveButton.Text = @"Update";
                    DataGridViewRow row = this.customerDataGridView.Rows[e.RowIndex];
                    idLabel.Text = row.Cells[1].Value.ToString();
                    codeTextBox.Text = row.Cells[2].Value.ToString();
                    nameTextBox.Text = row.Cells[3].Value.ToString();
                    addressTextBox.Text = row.Cells[4].Value.ToString();
                    emailTextBox.Text = row.Cells[5].Value.ToString();
                    contactTextBox.Text = row.Cells[6].Value.ToString();
                    pointTextBox.Text = row.Cells[7].Value.ToString();
                }
            }
            catch (Exception exception)
            {
               return;
            }
          
        }

        

        private void customerDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            customerDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
                customerDataGridView.DataSource = _customerManager.SearchCustomer(searchTextBox.Text);
            else
            {
                customerDataGridView.DataSource = _customerManager.ShowCustomer();
            }
            
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back)))
                e.Handled = true;
        }

        private void pointTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsDigit(ch) || (ch == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
