using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class StockOut
    {
        public int Id { get; set; }
        public DateTime StockOutDate { get; set; }
        public string StockOutType { get; set; }
        public int StockOutQuantity { get; set; }
        public double TotalPrice { get; set; }
        public string Remarks { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int PurchaseId { get; set; }
        //public int StockId { get; set; }
    }
}
