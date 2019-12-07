using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        public List<Category> GetCategories()
        {
            return _productRepository.GetCategories();
        }

        public bool ExistProduct(Product aProduct, string unique)
        {
            return _productRepository.ExistProduct(aProduct, unique);
        }

        public string SaveProduct(Product aProduct)
        {
            string message = _productRepository.SaveProduct(aProduct) > 0
                ? "Product is saved"
                : "Product can not saved";
            return message;
        }

        public string UpdateProduct(Product aProduct)
        {
            string message = _productRepository.UpdateProduct(aProduct) > 0
                ? "Product is updated"
                : "Product can not updated";
            return message;
        }

        public List<Product> ShowProduct()
        {
            return _productRepository.ShowProduct();
        }

        public List<Product> SearchProduct(string searchItem)
        {
            return _productRepository.SearchProduct(searchItem);
        }
    }
}
