using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class PurchaseManager
    {
        private PurchaseRepository _purchaseRepository = new PurchaseRepository();

        public List<Supplier> GetSuppliers()
        {
            return _purchaseRepository.GetSuppliers();
        }

        public List<Category> GetCategories()
        {
            return _purchaseRepository.GetCategories();
        }
        public List<Product> GetProducts(int categoryId)
        {
            return _purchaseRepository.GetProducts(categoryId);
        }

        public string GetProductCode(string productName)
        {
            return _purchaseRepository.GetProductCode(productName);
        }

        public string GetPurchaseCode()
        {
            return _purchaseRepository.GetPurchaseCode();
        }

        public int SavePurchase(Purchase aPurchase)
        {
            return _purchaseRepository.SavePurchase(aPurchase);
        }

        public bool ExistBillNumber(string billNo)
        {
            return _purchaseRepository.ExistBillNumber(billNo);
        }
        public List<double> GetPurchaseUnitPriceMrpPrice(int productId)
        {
            return _purchaseRepository.GetPurchaseUnitPriceMrpPrice(productId);
        }

        public double GetAvailableQuantity(string productName)
        {
            return _purchaseRepository.GetAvailableQuantity(productName);
        }

        public List<PurchaseShow> ShowPurchase()
        {
            return _purchaseRepository.ShowPurchase();
        }

        public List<PurchaseShow> ShowPurchaseProduct(string purchaseCode)
        {
            return _purchaseRepository.ShowPurchaseProduct(purchaseCode);
        }

        public List<PurchaseShow> SearchPurchase(string searchItem)
        {
            return _purchaseRepository.SearchPurchase(searchItem);
        }
    }
}
