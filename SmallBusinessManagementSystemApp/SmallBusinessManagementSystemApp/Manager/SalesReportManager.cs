using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class SalesReportManager
    {
        SalesReportRepository _salesReportRepository = new SalesReportRepository();
        //public List<SalesReport> ShowSalesReport()
        //{
        //    return _salesReportRepository.ShowSalesReport();
        //}

        public List<SalesReport> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            return _salesReportRepository.GetSalesReport(startDate, endDate);
        }
    }
}
