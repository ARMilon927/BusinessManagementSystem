using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class SalesManager
    {
        SalesRepository _salesRepository = new SalesRepository();
        public List<Category> GetCategories()
        {
            return _salesRepository.GetCategories();
        }
        public List<Customer> GetCustomers()
        {
            return _salesRepository.GetCustomers();
        }
        public int GetCustomerLoyaltyPoint(string customerName)
        {
            return _salesRepository.GetCustomerLoyaltyPoint(customerName);
        }
        public int SetCustomerLoyaltyPoint(int point, string customerName)
        {
            return _salesRepository.SetCustomerLoyaltyPoint(point, customerName);
        }
        public List<Product> GetProducts(int categoryId)
        {
            return _salesRepository.GetProducts(categoryId);
        }
        public string GetSalesCode()
        {
            return _salesRepository.GetSalesCode();
        }
        public double GetProductMRP(int productId)
        {
            return _salesRepository.GetProductMRP(productId);
        }
        public int SaveSales(Sales aSales)
        {
            return _salesRepository.SaveSales(aSales);
        }
        public double GetAvailableQuantity(string productName)
        {
            return _salesRepository.GetAvailableQuantity(productName);
        }

        public int GetReorderLevel(string productName)
        {
            return _salesRepository.GetReorderLevel(productName);
        }

        public List<SalesShow> ShowSales()
        {
            return _salesRepository.ShowSales();
        }

        public List<SalesShow> ShowSalesProduct(string salesCode)
        {
            return _salesRepository.ShowSalesProduct(salesCode);
        }

        public List<SalesShow> SearchSales(string searchItem)
        {
            return _salesRepository.SearchSales(searchItem);
        }
    }
}