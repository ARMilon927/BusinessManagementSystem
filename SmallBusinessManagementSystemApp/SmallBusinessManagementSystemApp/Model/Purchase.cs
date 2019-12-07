using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public double MRP { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        //public int StockId { get; set; }
    }
}
