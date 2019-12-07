using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    class StockShowManager
    {
        StockShowRepository _stockShowRepository = new StockShowRepository();

        public List<StockShow> ShowStock()
        {
            return _stockShowRepository.ShowStock();
        }

        public List<StockShow> SearchStock(string searchItem, DateTime startDate, DateTime endDate)
        {
            return _stockShowRepository.SearchStock(searchItem, startDate, endDate);
        }

    }
}
