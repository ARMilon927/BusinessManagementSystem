using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class PurchaseShow
    {
        public DateTime Date { get; set; }
        public string PurchaseCode { get; set; }
        public string Supplier { get; set; }
        public string Invoice { get; set; }
        public string ProductCode { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        public double TotalPrice { get; set; }
    }
}
