using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;

namespace SmallBusinessManagementSystemApp.Repository
{
    public class ProductRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
       // private SqlDataAdapter _sqlDataAdapter;
        private string query;
        private void Connect()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectionDatabase();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            Connect();
            query = "SELECT * from Categories";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Category aCategory = new Category
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]), Name = _sqlDataReader["Name"].ToString()
                };
                categories.Add(aCategory);
            }
            DatabaseConnection.sqlConnection.Close();
            return categories;
        }
        public int SaveProduct(Product aProduct)
        {
            Connect();
            query = "INSERT INTO Products(Name, Code, ReorderLevel, Description, CategoryId) VALUES (@Name, @Code, @ReorderLevel, @Description, @CategoryId) ";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aProduct.Name;
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aProduct.Code;
            _sqlCommand.Parameters.Add("ReorderLevel", SqlDbType.Int);
            _sqlCommand.Parameters["ReorderLevel"].Value = aProduct.ReorderLevel;
            _sqlCommand.Parameters.Add("Description", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Description"].Value = aProduct.Description;
            _sqlCommand.Parameters.Add("CategoryId", SqlDbType.Int);
            _sqlCommand.Parameters["CategoryId"].Value = aProduct.CategoryId;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public bool ExistProduct(Product aProduct, string unique)
        {
            Connect();
            if (unique == "name")
                query = "SELECT * FROM Products WHERE Name = '" + aProduct.Name + "' AND Id <> " + aProduct.Id + " ";
            if (unique == "code")
                query = "SELECT * FROM Products WHERE Code = '" + aProduct.Code + "' AND Id <> " + aProduct.Id + "";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            bool isExist = _sqlDataReader.HasRows;
            DatabaseConnection.sqlConnection.Close();
            return isExist;
        }
        public List<Product> ShowProduct()
        {
            List<Product> products = new List<Product>();
            Connect();
            query = "SELECT * FROM ProductsView ORDER BY Category";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Product aProduct = new Product
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Code = _sqlDataReader["Code"].ToString(),
                    Name = _sqlDataReader["Name"].ToString(),
                    ReorderLevel = Convert.ToInt32(_sqlDataReader["ReorderLevel"]),
                    Description = _sqlDataReader["Description"].ToString(),
                    CategoryName =  _sqlDataReader["Category"].ToString(),
                };
                products.Add(aProduct);
            }
            DatabaseConnection.sqlConnection.Close();
            return products;
        }
        public int UpdateProduct(Product aProduct)
        {
            Connect();
            query = "UPDATE Products SET Name = @Name, Code = @Code, ReorderLevel = @ReorderLevel, Description = @Description, CategoryId = @CategoryId WHERE Id = " + aProduct.Id + " ";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aProduct.Name;
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aProduct.Code;
            _sqlCommand.Parameters.Add("ReorderLevel", SqlDbType.Int);
            _sqlCommand.Parameters["ReorderLevel"].Value = aProduct.ReorderLevel;
            _sqlCommand.Parameters.Add("Description", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Description"].Value = aProduct.Description;
            _sqlCommand.Parameters.Add("CategoryId", SqlDbType.Int);
            _sqlCommand.Parameters["CategoryId"].Value = aProduct.CategoryId;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public List<Product> SearchProduct(string searchItem)
        {
            List<Product> products = new List<Product>();
            Connect();
            query = "SELECT * FROM ProductsView WHERE Category LIKE '%"+searchItem+ "%' OR Name LIKE '%" + searchItem + "%' OR Code LIKE '%" + searchItem + "%'";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Product aProduct = new Product
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Code = _sqlDataReader["Code"].ToString(),
                    Name = _sqlDataReader["Name"].ToString(),
                    ReorderLevel = Convert.ToInt32(_sqlDataReader["ReorderLevel"]),
                    Description = _sqlDataReader["Description"].ToString(),
                    CategoryName = _sqlDataReader["Category"].ToString()
                };
                products.Add(aProduct);
            }
            DatabaseConnection.sqlConnection.Close();
            return products;
        }
    }
}
