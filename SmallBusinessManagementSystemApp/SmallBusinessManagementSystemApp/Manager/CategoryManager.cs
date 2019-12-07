using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class CategoryManager
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        public string SaveCategory(Category aCategory)
        {
            string message = _categoryRepository.SaveCategory(aCategory) > 0 ? "Category saved successfully" : "Category can not saved";
            return message;
        }

        public List<Category> ShowCategory()
        {
            return _categoryRepository.ShowCategory();
        }

        public bool ExistCategory(Category aCategory, string unique)
        {
            return _categoryRepository.ExistCategory(aCategory, unique);
        }

        public string UpdateCategory(Category aCategory)
        {
            string message = _categoryRepository.UpdateCategory(aCategory) > 0 ? "Category updated successfully" : "Category can not updated";
            return message;
        }

        public List<Category> SearchCategory(string searchItem)
        {
            return _categoryRepository.SearchCategory(searchItem);
        }
    }
}
