using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public double TotalMRP { get; set; }
        public double Discount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayableAmount { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
    }
}