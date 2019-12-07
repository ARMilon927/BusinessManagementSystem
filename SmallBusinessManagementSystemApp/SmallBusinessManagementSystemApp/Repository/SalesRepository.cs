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
    public class SalesRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
      //  private SqlDataAdapter _sqlDataAdapter;
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
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Category aCategory = new Category
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Name = _sqlDataReader["Name"].ToString()
                };
                categories.Add(aCategory);
            }
            DatabaseConnection.sqlConnection.Close();
            return categories;
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Connect();
            query = "SELECT * from Customers";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Customer aCustomer = new Customer
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Name = _sqlDataReader["Name"].ToString()
                };
                customers.Add(aCustomer);
            }
            DatabaseConnection.sqlConnection.Close();
            return customers;
        }
        public List<Product> GetProducts(int categoryId)
        {
            List<Product> products = new List<Product>();
            Connect();
            query = "SELECT * FROM Products WHERE CategoryId = " + categoryId + " ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Product aProduct = new Product
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Name = _sqlDataReader["Name"].ToString(),
                };
                products.Add(aProduct);
            }
            DatabaseConnection.sqlConnection.Close();
            return products;
        }
        public int GetCustomerLoyaltyPoint(string customerName)
        {
            Connect();
            query = "SELECT LoyaltyPoint FROM Customers WHERE Name = '" + customerName + "'";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            int loyaltyPoint = 0;
            while (_sqlDataReader.Read())
            {
                loyaltyPoint = Convert.ToInt32(_sqlDataReader["LoyaltyPoint"]);
            }
            DatabaseConnection.sqlConnection.Close();
            return loyaltyPoint;
        }
        public double GetProductMRP(int productId)
        {
            Connect();
            query = "SELECT MRP FROM Purchases WHERE ProductId = " + productId + " ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            double mrp = 0;
            while (_sqlDataReader.Read())
            {
                mrp = Convert.ToInt32(_sqlDataReader["MRP"]);
            }
            DatabaseConnection.sqlConnection.Close();
            return mrp;
        }
        public string GetSalesCode()
        {
            string code;
            Connect();
            query = "SELECT Id FROM Saleses ORDER BY Id DESC";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            if (_sqlDataReader.Read())
            {
                int id = int.Parse(_sqlDataReader["Id"].ToString()) + 1;
                code = "SC2019-" + id.ToString("0000");
            }
            else if (Convert.IsDBNull(_sqlDataReader))
            {
                code = ("SC2019-" + "0001");
            }
            else
            {
                code = ("SC2019-" + "0001");
            }
            DatabaseConnection.sqlConnection.Close();
            return code;
        }
        public int SaveSales(Sales aSales)
        {
            Connect();
            query = "INSERT INTO Saleses (Date, Code, Quantity, TotalMRP, Discount, DiscountAmount, PayableAmount, CategoryId, CustomerId, ProductId) VALUES (@Date, @Code, @Quantity, @TotalMRP, @Discount, @DiscountAmount, @PayableAmount, @CategoryId, @CustomerId, @ProductId)";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Date", SqlDbType.Date);
            _sqlCommand.Parameters["Date"].Value = aSales.Date.Date;
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aSales.Code;
            _sqlCommand.Parameters.Add("Quantity", SqlDbType.Int);
            _sqlCommand.Parameters["Quantity"].Value = aSales.Quantity;
            _sqlCommand.Parameters.Add("TotalMRP", SqlDbType.Float);
            _sqlCommand.Parameters["TotalMRP"].Value = aSales.TotalMRP;
            _sqlCommand.Parameters.Add("Discount", SqlDbType.Float);
            _sqlCommand.Parameters["Discount"].Value = aSales.Discount;
            _sqlCommand.Parameters.Add("DiscountAmount", SqlDbType.Float);
            _sqlCommand.Parameters["DiscountAmount"].Value = aSales.DiscountAmount;
            _sqlCommand.Parameters.Add("PayableAmount", SqlDbType.Float);
            _sqlCommand.Parameters["PayableAmount"].Value = aSales.PayableAmount;
            _sqlCommand.Parameters.Add("CategoryId", SqlDbType.Int);
            _sqlCommand.Parameters["CategoryId"].Value = aSales.CategoryId;
            _sqlCommand.Parameters.Add("CustomerId", SqlDbType.Int);
            _sqlCommand.Parameters["CustomerId"].Value = aSales.CustomerId;
            _sqlCommand.Parameters.Add("ProductId", SqlDbType.Int);
            _sqlCommand.Parameters["ProductId"].Value = aSales.ProductId;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public int SetCustomerLoyaltyPoint(int point, string customerName)
        {
            Connect();
            query = "UPDATE Customers SET LoyaltyPoint = @LoyaltyPoint WHERE Name = '" + customerName + "'";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("LoyaltyPoint", SqlDbType.Int);
            _sqlCommand.Parameters["LoyaltyPoint"].Value = point;

            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;

            //int loyaltyPoint = 0;
            //while (_sqlDataReader.Read())
            //{
            //    loyaltyPoint = Convert.ToInt32(_sqlDataReader["LoyaltyPoint"]);
            //}
            //DatabaseConnection.sqlConnection.Close();
            //return loyaltyPoint;
        }
        public double GetAvailableQuantity(string productName)
        {
            Connect();
            query = "SELECT AvailableQuantity, Product FROM  AvailableProduct WHERE Product = '" + productName + "' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            double quantity = 0;
            while (_sqlDataReader.Read())
            {
                quantity = (Convert.ToDouble(_sqlDataReader["AvailableQuantity"]));
            }
            DatabaseConnection.sqlConnection.Close();
            return quantity;
        }
        public int GetReorderLevel(string productName)
        {
            Connect();
            query = "select ReorderLevel from Products where Name = '" + productName + "' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            int reorderLevel = 0;
            while (_sqlDataReader.Read())
            {
                reorderLevel = (Convert.ToInt32(_sqlDataReader["ReorderLevel"]));
            }
            DatabaseConnection.sqlConnection.Close();
            return reorderLevel;
        }
        public List<SalesShow> ShowSales()
        {
            List<SalesShow> salesShows = new List<SalesShow>();
            Connect();
            query = "SELECT distinct (SalesCode), SalesDate, Customer FROM SalesView";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                SalesShow aSalesShow = new SalesShow
                {
                    Date = Convert.ToDateTime(_sqlDataReader["SalesDate"]),
                    SalesCode = _sqlDataReader["SalesCode"].ToString(),
                    Customer = _sqlDataReader["Customer"].ToString()
                };
                salesShows.Add(aSalesShow);
            }
            DatabaseConnection.sqlConnection.Close();
            return salesShows;
        }
        public List<SalesShow> ShowSalesProduct(string salesCode)
        {
            List<SalesShow> salesProductShows = new List<SalesShow>();
            Connect();
            query = "SELECT Code, Product, Category, Quantity, TotalMRP, DiscountAmount, PayableAmount FROM SalesView WHERE SalesCode = '" + salesCode + "'";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                SalesShow aSalesShow = new SalesShow
                {
                    ProductCode = _sqlDataReader["Code"].ToString(),
                    Product = _sqlDataReader["Product"].ToString(),
                    Category = _sqlDataReader["Category"].ToString(),
                    Quantity = Convert.ToInt32(_sqlDataReader["Quantity"]),
                    TotalMRP = Convert.ToDouble(_sqlDataReader["TotalMRP"]),
                    DiscountAmount = Convert.ToDouble(_sqlDataReader["DiscountAmount"]),
                    PayableAmount = Convert.ToDouble(_sqlDataReader["PayableAmount"])
                };
                salesProductShows.Add(aSalesShow);
            }
            DatabaseConnection.sqlConnection.Close();
            return salesProductShows;
        }
        public List<SalesShow> SearchSales(string searchItem)
        {
            List<SalesShow> salesShows = new List<SalesShow>();
            Connect();
            query = "select distinct (SalesCode), SalesDate, Customer FROM SalesView WHERE SalesCode LIKE '%" + searchItem+ "%' OR SalesDate LIKE '%" + searchItem + "%' OR Customer LIKE '%" + searchItem + "%' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                SalesShow aSalesShow = new SalesShow
                {
                    Date = Convert.ToDateTime(_sqlDataReader["SalesDate"]),
                    SalesCode = _sqlDataReader["SalesCode"].ToString(),
                    Customer = _sqlDataReader["Customer"].ToString()
                };
                salesShows.Add(aSalesShow);
            }
            DatabaseConnection.sqlConnection.Close();
            return salesShows;
        }


    }
}
