using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class SalesReport
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int SoldQuantity { get; set; }
        public double CostPrice { get; set; }
        public double SalesPrice { get; set; }
        public double Profit { get; set; }
    }
}
