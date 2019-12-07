using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();

        public string SaveSupplier(Supplier aSupplier)
        {
            string message = _supplierRepository.SaveSupplier(aSupplier) > 0
                ? "Supplier is saved"
                : "Supplier can not saved";
            return message;
        }

        public bool ExistSupplier(Supplier aSupplier, string unique)
        {
            return _supplierRepository.ExistSupplier(aSupplier, unique);
        }

        public List<Supplier> ShowSupplier()
        {
            return _supplierRepository.ShowSupplier();
        }

        public string UpdateSupplier(Supplier aSupplier)
        {
            string message = _supplierRepository.UpdateSupplier(aSupplier) > 0
                ? "Supplier is updated"
                : "Supplier can not updated";
            return message;
        }

        public List<Supplier> SearchSupplier(string searchItem)
        {
            return _supplierRepository.SearchSupplier(searchItem);
        }
    }
}
