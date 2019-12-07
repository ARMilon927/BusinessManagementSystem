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
    public partial class CategoryUI : Form
    {
        public CategoryUI()
        {
            InitializeComponent();
        }
        
        private CategoryManager _categoryManager = new CategoryManager();
        Category _category = new Category();
        private void CategoryUI_Load(object sender, EventArgs e)
        {
            categoryDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            categoryDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            categoryDataGridView.EnableHeadersVisualStyles = false;
            Display();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidCategory()) return;
                _category.Id = Convert.ToInt32(idLabel.Text);
                _category.Code = codeTextBox.Text;
                if (_categoryManager.ExistCategory(_category, "code"))
                {
                    codeValidLabel.Text = @"This Code already exists";
                    return;
                }
                codeValidLabel.Text = "";
                _category.Name = nameTextBox.Text;
                if (_categoryManager.ExistCategory(_category, "name"))
                {
                    nameValidLabel.Text = @"This Name already exists";
                    return;
                }
                nameValidLabel.Text = "";

                if (saveButton.Text == @"Save")
                {
                    MessageBox.Show(_categoryManager.SaveCategory(_category));
                }
                else
                {
                    MessageBox.Show(_categoryManager.UpdateCategory(_category));
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

        private bool ValidCategory()
        {
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeValidLabel.Text = @"Please insert code";
                return true;
            }
            if (codeTextBox.Text.Length != 4)
            {
                codeValidLabel.Text = @"Code should be in 4 characters";
                return true;
            }
            codeValidLabel.Text = "";
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                nameValidLabel.Text = @"Please insert Category name";
                return true;
            }
            nameValidLabel.Text = "";
            return false;
        }
        private void Display()
        {
            if (_categoryManager.ShowCategory().Count < 0)
            {
                MessageBox.Show(@"No Data found");
            }
            categoryDataGridView.DataSource = _categoryManager.ShowCategory();
        }
        
        private void categoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          try
          {
              if (categoryDataGridView != null && (e.RowIndex >= 0 && categoryDataGridView.Columns[e.ColumnIndex].Name == "Edit"))
              {
                  saveButton.Text = @"Update";
                  DataGridViewRow row = this.categoryDataGridView.Rows[e.RowIndex];
                  idLabel.Text = row.Cells[1].Value.ToString();
                  codeTextBox.Text = row.Cells[2].Value.ToString();
                  nameTextBox.Text = row.Cells[3].Value.ToString();
              }
          }
          catch (Exception exception)
          {
              return;
          }
            
        }
        private void categoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            categoryDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
               categoryDataGridView.DataSource = _categoryManager.SearchCategory(searchTextBox.Text);
            }
            else
            {
                categoryDataGridView.DataSource = _categoryManager.ShowCategory();
            }
            
        }
    }
}
