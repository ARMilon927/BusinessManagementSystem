using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    public class StockShow
    {
        public string Code { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int Reorder { get; set; }
        public DateTime ExpireDate { get; set; }
        public int OpeningBalance { get; set; }
        public int QuantityIn { get; set; }
        public int QuantityOut { get; set; }
        public int ClosingBalance { get; set; }
    }
}
