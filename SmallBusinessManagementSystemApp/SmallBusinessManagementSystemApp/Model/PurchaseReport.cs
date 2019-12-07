using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class PurchaseReport
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int AvailableQuantity { get; set; }
        public double CostPrice { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }
    }
}
