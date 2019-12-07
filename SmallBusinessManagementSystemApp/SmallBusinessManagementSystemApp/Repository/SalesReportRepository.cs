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
    public class SalesReportRepository
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
        public List<SalesReport> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            Connect();
            query = @"SELECT DISTINCT( Code), Product, Category, Quantity,(Quantity * (COALESCE((SELECT AVG(UnitPrice) FROM PurchaseView AS P WHERE Date BETWEEN ' "+ startDate+"' AND '"+ endDate+"' AND P.Product = SalesView.Product GROUP BY Product), 0)))AS CostPrice, PayableAmount FROM SalesView WHERE SalesDate BETWEEN ' "+ startDate+"' AND ' "+ endDate+"' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            List<SalesReport> salesReports = new List<SalesReport>();
            while (_sqlDataReader.Read())
            {
                SalesReport aSalesReport = new SalesReport
                {
                    Category = _sqlDataReader["Category"].ToString(),
                    ProductCode = _sqlDataReader["Code"].ToString(),
                    ProductName = _sqlDataReader["Product"].ToString(),
                    SoldQuantity = Convert.ToInt32(_sqlDataReader["Quantity"]),
                    CostPrice = Convert.ToDouble(_sqlDataReader["CostPrice"]),
                    SalesPrice = Convert.ToDouble(_sqlDataReader["PayableAmount"]),
                    Profit = Convert.ToDouble(_sqlDataReader["PayableAmount"]) - Convert.ToDouble(_sqlDataReader["CostPrice"])
                };
                int sameProduct = 0;
                foreach (SalesReport aReport in salesReports)
                {
                    if (aReport.ProductName == aSalesReport.ProductName)
                    {
                        aReport.SoldQuantity += aSalesReport.SoldQuantity;
                        aReport.CostPrice += aSalesReport.CostPrice;
                        aReport.SalesPrice += aSalesReport.SalesPrice;
                        aReport.Profit += aSalesReport.Profit;
                        sameProduct++;
                    }
                }
                if (sameProduct <= 0)
                {
                    salesReports.Add(aSalesReport);
                }
                else
                {
                    continue;
                }
                
            }
            DatabaseConnection.sqlConnection.Close();
            return salesReports;
        }
        //public List<SalesReport> ShowSalesReport()
        //{
        //    Connect();
        //    query = "select * from SalesReportView ";
        //    _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
        //    _sqlDataReader = _sqlCommand.ExecuteReader();
        //    List<SalesReport> salesReports = new List<SalesReport>();
        //    while (_sqlDataReader.Read())
        //    {
        //        SalesReport aSalesReport = new SalesReport
        //        {
        //            Category = _sqlDataReader["Category"].ToString(),
        //            ProductCode = _sqlDataReader["Code"].ToString(),
        //            ProductName = _sqlDataReader["Product"].ToString(),
        //            SoldQuantity = Convert.ToInt32(_sqlDataReader["SoldQty"]),
        //            CostPrice = Convert.ToDouble(_sqlDataReader["CostPrice"]),
        //            SalesPrice = Convert.ToDouble(_sqlDataReader["SalesPrice"]),
        //            Profit = Convert.ToDouble(_sqlDataReader["Profit"])
        //        };
        //        salesReports.Add(aSalesReport);
        //    }
        //    DatabaseConnection.sqlConnection.Close();
        //    return salesReports;
        //}
    }
}
