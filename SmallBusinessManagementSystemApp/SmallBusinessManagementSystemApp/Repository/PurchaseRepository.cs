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
    public class PurchaseRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
    //    private SqlDataAdapter _sqlDataAdapter;
        private string query;
        private void Connect()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectionDatabase();
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Connect();
            query = "SELECT * from Suppliers";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Supplier aSupplier = new Supplier
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]), Name = _sqlDataReader["Name"].ToString()
                };
                suppliers.Add(aSupplier);
            }
            DatabaseConnection.sqlConnection.Close();
            return suppliers;
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
                    Name = _sqlDataReader["Name"].ToString()
                };
                products.Add(aProduct);
            }
            DatabaseConnection.sqlConnection.Close();
            return products;
        }
        public string GetProductCode(string productName)
        {
            
            Connect();
            query = "SELECT Code FROM Products WHERE Name = '" + productName + "' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            string code = "";
            while (_sqlDataReader.Read())
            {
                code = (_sqlDataReader["Code"]).ToString();
            }
            DatabaseConnection.sqlConnection.Close();
            return code;
        }
        public List<double> GetPurchaseUnitPriceMrpPrice(int productId)
        {
            Connect();
            query = "SELECT UnitPrice, MRP FROM Purchases WHERE ProductId = " + productId + " ORDER BY Id DESC ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            List<double> prices = new List<double>();
            while (_sqlDataReader.Read())
            {
                prices.Add( Convert.ToDouble(_sqlDataReader["UnitPrice"]));
                prices.Add( Convert.ToDouble(_sqlDataReader["MRP"]));
            }
            DatabaseConnection.sqlConnection.Close();
            return prices;
        }
        public string GetPurchaseCode()
        {
            string code;
            Connect();
            query = "SELECT Id FROM Purchases ORDER BY Id DESC";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            if (_sqlDataReader.Read())
            {
                int id = int.Parse(_sqlDataReader["Id"].ToString()) + 1;
                code = "PC2019-" + id.ToString("0000");
            }
            else if (Convert.IsDBNull(_sqlDataReader))
            {
                code = ("PC2019-" + "0001");
            }
            else
            {
                code = ("PC2019-" + "0001");
            }
            DatabaseConnection.sqlConnection.Close();
            return code;
        }
        public bool ExistBillNumber(string billNo)
        {
            Connect();
            query = "SELECT * FROM Purchases WHERE BillNo = '" + billNo + "' ";
            
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            bool isExist = _sqlDataReader.HasRows;
            DatabaseConnection.sqlConnection.Close();
            return isExist;
        }
        public int SavePurchase(Purchase aPurchase)
        {
            Connect();
            query = "INSERT INTO Purchases(Date, BillNo, Code, ManufacturedDate, ExpiredDate, Remarks, Quantity, UnitPrice, TotalPrice, MRP, CategoryId, SupplierId, ProductId) VALUES (@Date, @BillNo, @Code, @ManufacturedDate, @ExpiredDate, @Remarks, @Quantity, @UnitPrice, @TotalPrice, @MRP, @CategoryId, @SupplierId, @ProductId)";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Date", SqlDbType.Date);
            _sqlCommand.Parameters["Date"].Value = aPurchase.PurchaseDate.Date;
            _sqlCommand.Parameters.Add("ManufacturedDate", SqlDbType.Date);
            _sqlCommand.Parameters["ManufacturedDate"].Value = aPurchase.ManufacturedDate.Date;
            _sqlCommand.Parameters.Add("ExpiredDate", SqlDbType.Date);
            _sqlCommand.Parameters["ExpiredDate"].Value = aPurchase.ExpiredDate.Date;
            _sqlCommand.Parameters.Add("BillNo", SqlDbType.NVarChar);
            _sqlCommand.Parameters["BillNo"].Value = aPurchase.InvoiceNo;
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aPurchase.Code;
            _sqlCommand.Parameters.Add("Quantity", SqlDbType.Int);
            _sqlCommand.Parameters["Quantity"].Value = aPurchase.Quantity;
            _sqlCommand.Parameters.Add("Remarks", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Remarks"].Value = aPurchase.Remarks;
            _sqlCommand.Parameters.Add("UnitPrice", SqlDbType.Float);
            _sqlCommand.Parameters["UnitPrice"].Value = aPurchase.UnitPrice;
            _sqlCommand.Parameters.Add("TotalPrice", SqlDbType.Float);
            _sqlCommand.Parameters["TotalPrice"].Value = aPurchase.TotalPrice;
            _sqlCommand.Parameters.Add("MRP", SqlDbType.Float);
            _sqlCommand.Parameters["MRP"].Value = aPurchase.MRP;
            _sqlCommand.Parameters.Add("CategoryId", SqlDbType.Int);
            _sqlCommand.Parameters["CategoryId"].Value = aPurchase.CategoryId;
            _sqlCommand.Parameters.Add("ProductId", SqlDbType.Int);
            _sqlCommand.Parameters["ProductId"].Value = aPurchase.ProductId;
            _sqlCommand.Parameters.Add("SupplierId", SqlDbType.Int);
            _sqlCommand.Parameters["SupplierId"].Value = aPurchase.SupplierId;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
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
        public List<PurchaseShow> ShowPurchase()
        {
            List<PurchaseShow> purchaseShows = new List<PurchaseShow>();
            Connect();
            query = "SELECT Distinct(Code), Date, Supplier, BillNo FROM PurchaseView ORDER BY Date";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                PurchaseShow aPurchaseShow = new PurchaseShow
                {
                    Date = Convert.ToDateTime(_sqlDataReader["Date"]),
                    PurchaseCode = _sqlDataReader["Code"].ToString(),
                    Supplier = _sqlDataReader["Supplier"].ToString(),
                    Invoice = _sqlDataReader["BillNo"].ToString(),
                };
                purchaseShows.Add(aPurchaseShow);
            }
            DatabaseConnection.sqlConnection.Close();
            return purchaseShows;
        }
        public List<PurchaseShow> ShowPurchaseProduct(string purchaseCode)
        {
            List<PurchaseShow> purchaseProductShows = new List<PurchaseShow>();
            Connect();
            query = "SELECT ProductsView.Code, Product, Quantity, UnitPrice, MRP, TotalPrice FROM PurchaseView, ProductsView WHERE PurchaseView.Product = ProductsView.Name AND PurchaseView.Code = '" + purchaseCode + "'";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                PurchaseShow aPurchaseShow = new PurchaseShow
                {
                    ProductCode = _sqlDataReader["Code"].ToString(),
                    Product = _sqlDataReader["Product"].ToString(),
                    Quantity = Convert.ToInt32(_sqlDataReader["Quantity"]),
                    UnitPrice = Convert.ToDouble(_sqlDataReader["UnitPrice"]),
                    MRP = Convert.ToDouble(_sqlDataReader["MRP"]),
                    TotalPrice = Convert.ToDouble(_sqlDataReader["TotalPrice"])
                };
                purchaseProductShows.Add(aPurchaseShow);
            }
            DatabaseConnection.sqlConnection.Close();
            return purchaseProductShows;
        }
        public List<PurchaseShow> SearchPurchase(string searchItem)
        {
            List<PurchaseShow> purchaseShows = new List<PurchaseShow>();
            Connect();
            query = "SELECT Distinct(Code), Date, Supplier, BillNo  FROM PurchaseView WHERE Code LIKE '%" + searchItem+ "%' OR Date LIKE '%"+searchItem+"%' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                PurchaseShow aPurchaseShow = new PurchaseShow
                {
                    Date = Convert.ToDateTime(_sqlDataReader["Date"]),
                    PurchaseCode = _sqlDataReader["Code"].ToString(),
                    Supplier = _sqlDataReader["Supplier"].ToString(),
                    Invoice = _sqlDataReader["BillNo"].ToString(),
                };
                purchaseShows.Add(aPurchaseShow);
            }
            DatabaseConnection.sqlConnection.Close();
            return purchaseShows;
        }


    }
}
