using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class PurchaseReportManager
    {
        PurchaseReportRepository _purchaseReportRepository = new PurchaseReportRepository();
        //public List<PurchaseReport> ShowPurchaseReport()
        //{
        //    return _purchaseReportRepository.ShowPurchaseReport();
        //}

        public List<PurchaseReport> GetPurchaseReport(DateTime startDate, DateTime endDate)
        {
            return _purchaseReportRepository.GetPurchaseReport(startDate, endDate);
        }
    }
}
