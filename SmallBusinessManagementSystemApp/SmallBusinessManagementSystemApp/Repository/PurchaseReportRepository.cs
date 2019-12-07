using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;

namespace SmallBusinessManagementSystemApp.Repository
{
    public class PurchaseReportRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
        
        private string query;
        private void Connect()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectionDatabase();
        }
        public List<PurchaseReport> GetPurchaseReport(DateTime startDate, DateTime endDate)
        {
            Connect();
            query = "SELECT distinct( Product), P.Code, P.Category, (COALESCE((SELECT SUM(QtyIn) FROM StockIn WHERE PurchaseDate BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND Name = PurchaseView.Product), 0) - COALESCE((SELECT SUM(QtyOut) FROM StockOut WHERE SalesDate BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND Name = PurchaseView.Product),0) ) as Unsold, CostPrice = (COALESCE((SELECT AVG(UnitPrice) FROM PurchaseView AS P WHERE Date BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND P.Product = PurchaseView.Product Group by Product), 0)), MRP = (COALESCE((SELECT AVG(MRP) FROM PurchaseView AS P WHERE Date BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND P.Product = PurchaseView.Product Group by Product), 0)), (COALESCE((SELECT AVG(MRP) FROM PurchaseView AS P WHERE Date BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND P.Product = PurchaseView.Product Group by Product), 0) - (COALESCE((SELECT AVG(UnitPrice) FROM PurchaseView AS P WHERE Date BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND P.Product = PurchaseView.Product Group by Product), 0)) ) *(SELECT (COALESCE((SELECT SUM(QtyIn) FROM StockIn WHERE PurchaseDate BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND Name = PurchaseView.Product), 0) - COALESCE((SELECT SUM(QtyOut) FROM StockOut WHERE SalesDate BETWEEN ' "+ startDate +"' AND ' "+ endDate+"' AND Name = PurchaseView.Product), 0)) as Unsold) AS Profit   FROM PurchaseView, ProductsView AS P WHERE P.Name = PurchaseView.Product group by Product, P.Code, P.Category";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            List<PurchaseReport> purchaseReports = new List<PurchaseReport>();
            while (_sqlDataReader.Read())
            {
                if (Convert.ToInt32(_sqlDataReader["Unsold"]) == 0)
                {
                    continue;
                }
                else
                {
                    PurchaseReport aPurchaseReport = new PurchaseReport
                    {
                        Category = _sqlDataReader["Category"].ToString(),
                        ProductCode = _sqlDataReader["Code"].ToString(),
                        ProductName = _sqlDataReader["Product"].ToString(),
                        AvailableQuantity = Convert.ToInt32(_sqlDataReader["Unsold"]),
                        CostPrice = Convert.ToDouble(_sqlDataReader["CostPrice"]),
                        MRP = Convert.ToDouble(_sqlDataReader["MRP"]),
                        Profit = Convert.ToDouble(_sqlDataReader["Profit"])
                    };
                    purchaseReports.Add(aPurchaseReport);
                }
                
            }
            DatabaseConnection.sqlConnection.Close();
            return purchaseReports;
        }
        //public List<PurchaseReport> ShowPurchaseReport()
        //{
        //    Connect();
        //    query = "select * from PurchaseReportView ";
        //    _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
        //    _sqlDataReader = _sqlCommand.ExecuteReader();
        //    List<PurchaseReport> purchaseReports = new List<PurchaseReport>();
        //    while (_sqlDataReader.Read())
        //    {
        //        PurchaseReport aPurchaseReport = new PurchaseReport
        //        {
        //            Category = _sqlDataReader["Category"].ToString(),
        //            ProductCode = _sqlDataReader["Code"].ToString(),
        //            ProductName = _sqlDataReader["Product"].ToString(),
        //            AvailableQuantity = Convert.ToInt32(_sqlDataReader["AvailableQuantity"]),
        //            CostPrice = Convert.ToDouble(_sqlDataReader["UnitPrice"]),
        //            MRP = Convert.ToDouble(_sqlDataReader["MRP"]),
        //            Profit = Convert.ToDouble(_sqlDataReader["Profit"])
        //        };
        //        purchaseReports.Add(aPurchaseReport);
        //    }
        //    DatabaseConnection.sqlConnection.Close();
        //    return purchaseReports;
        //}
    }
}
