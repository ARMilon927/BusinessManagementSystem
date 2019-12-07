using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBusinessManagementSystemApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashboardUI());
            //Application.Run(new PurchaseUI());
            //Application.Run(new CategoryUI());
            //Application.Run(new ProductUI());
            //Application.Run(new CustomerUI());
            //Application.Run(new SupplierUI());
            //Application.Run(new SalesUI());
            //Application.Run(new ReportOnSales());
            //Application.Run(new ReportOnPurchase());

        }
    }
}
