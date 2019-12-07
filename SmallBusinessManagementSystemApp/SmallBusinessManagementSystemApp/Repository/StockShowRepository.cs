using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;

namespace SmallBusinessManagementSystemApp.Repository
{
    class StockShowRepository
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

        public List<StockShow> ShowStock()
        {
            List<StockShow> stockShows = new List<StockShow>();
            Connect();
            query =
                @"SELECT Code, Name, Category, ReorderLevel, Opening = ((SELECT COALESCE(SUM(QtyIn), 0)  from StockIn where StockIn.Name = ProductsView.Name AND PurchaseDate < '" +
                DateTime.MinValue +
                "') -(SELECT COALESCE(SUM(QtyOut), 0)  from StockOut where StockOut.Name = ProductsView.Name AND SalesDate < '" +
                DateTime.MinValue +
                "')), QtyIn = (SELECT COALESCE(SUM(QtyIn), 0)  from StockIn where StockIn.Name = ProductsView.Name AND PurchaseDate BETWEEN '" +
                DateTime.MinValue + "' AND '" + DateTime.Today +
                "'), QtyOut = (SELECT COALESCE(SUM(QtyOut), 0) from StockOut where StockOut.Name = ProductsView.Name AND SalesDate BETWEEN '" +
                DateTime.MinValue + "' AND '" + DateTime.Today + "') FROM ProductsView";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                if (Convert.ToInt32(_sqlDataReader["Opening"]) == 0 &&
                    Convert.ToInt32(_sqlDataReader["QtyIn"]) == 0 &&
                    Convert.ToInt32(_sqlDataReader["QtyOut"]) == 0)
                    continue;
                else
                {
                    StockShow aStockShow = new StockShow
                    {
                        // ExpireDate = Convert.ToDateTime(_sqlDataReader["ExpiredDate"]),
                        Code = _sqlDataReader["Code"].ToString(),
                        Category = _sqlDataReader["Category"].ToString(),
                        Product = _sqlDataReader["Name"].ToString(),
                        Reorder = Convert.ToInt32(_sqlDataReader["ReorderLevel"]),
                        OpeningBalance = Convert.ToInt32(_sqlDataReader["Opening"]),
                        QuantityIn = Convert.ToInt32(_sqlDataReader["QtyIn"]),
                        QuantityOut = Convert.ToInt32(_sqlDataReader["QtyOut"])
                    };
                    aStockShow.ClosingBalance =
                        aStockShow.OpeningBalance + aStockShow.QuantityIn - aStockShow.QuantityOut;
                    stockShows.Add(aStockShow);
                }
            }

            DatabaseConnection.sqlConnection.Close();
            return stockShows;
        }

        public List<StockShow> SearchStock(string searchItem, DateTime startDate, DateTime endDate)
        {
            List<StockShow> stockShows = new List<StockShow>();
            Connect();
            query =
                @"SELECT Code, Name, Category, ReorderLevel, Opening = ((SELECT COALESCE(SUM(QtyIn), 0)  from StockIn where StockIn.Name = ProductsView.Name AND PurchaseDate < '" +
                startDate +
                "') -(SELECT COALESCE(SUM(QtyOut), 0)  from StockOut where StockOut.Name = ProductsView.Name AND SalesDate < '" +
                startDate +
                "')), QtyIn = (SELECT COALESCE(SUM(QtyIn), 0)  from StockIn where StockIn.Name = ProductsView.Name AND PurchaseDate BETWEEN '" +
                startDate + "' AND '" + endDate +
                "'), QtyOut = (SELECT COALESCE(SUM(QtyOut), 0) from StockOut where StockOut.Name = ProductsView.Name AND SalesDate BETWEEN '" +
                startDate + "' AND '" + endDate + "') FROM ProductsView WHERE ProductsView.Category LIKE '%"+ searchItem + "%' OR ProductsView.Name LIKE '%"+searchItem+"%'";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                if (Convert.ToInt32(_sqlDataReader["Opening"]) == 0 &&
                    Convert.ToInt32(_sqlDataReader["QtyIn"]) == 0 &&
                    Convert.ToInt32(_sqlDataReader["QtyOut"]) == 0)
                    continue;
                else
                {
                    StockShow aStockShow = new StockShow
                    {
                        // ExpireDate = Convert.ToDateTime(_sqlDataReader["ExpiredDate"]),
                        Code = _sqlDataReader["Code"].ToString(),
                        Category = _sqlDataReader["Category"].ToString(),
                        Product = _sqlDataReader["Name"].ToString(),
                        Reorder = Convert.ToInt32(_sqlDataReader["ReorderLevel"]),
                        OpeningBalance = Convert.ToInt32(_sqlDataReader["Opening"]),
                        QuantityIn = Convert.ToInt32(_sqlDataReader["QtyIn"]),
                        QuantityOut = Convert.ToInt32(_sqlDataReader["QtyOut"])
                    };
                    aStockShow.ClosingBalance =
                        aStockShow.OpeningBalance + aStockShow.QuantityIn - aStockShow.QuantityOut;
                    stockShows.Add(aStockShow);
                }
            }
            DatabaseConnection.sqlConnection.Close();
            return stockShows;
        }
    }
}
