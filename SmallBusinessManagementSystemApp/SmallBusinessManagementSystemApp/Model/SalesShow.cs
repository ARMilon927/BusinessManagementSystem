using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class SalesShow
    {
        public DateTime Date { get; set; }
        public string SalesCode { get; set; }
        public string Customer { get; set; }
        public string ProductCode { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double DiscountAmount { get; set; }
        public double TotalMRP { get; set; }
        public double PayableAmount { get; set; }
    }
}
