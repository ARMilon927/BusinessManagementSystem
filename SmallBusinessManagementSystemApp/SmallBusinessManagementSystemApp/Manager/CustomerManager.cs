using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;
using SmallBusinessManagementSystemApp.Repository;

namespace SmallBusinessManagementSystemApp.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public string SaveCustomer(Customer aCustomer)
        {
            string message = _customerRepository.SaveCustomer(aCustomer) > 0
                ? "Customer is saved"
                : "Customer can not saved";
            return message;
        }

        public bool ExistCustomer(Customer aCustomer, string unique)
        {
            return _customerRepository.ExistCustomer(aCustomer, unique);
        }

        public List<Customer> ShowCustomer()
        {
            return _customerRepository.ShowCustomer();
        }

        public string UpdateCustomer(Customer aCustomer)
        {
            string message = _customerRepository.UpdateCustomer(aCustomer) > 0
                ? "Customer is updated"
                : "Customer can not updated";
            return message;
        }

        public List<Customer> SearchCustomer(string searchItem)
        {
            return _customerRepository.SearchCustomer(searchItem);
        }
    }
}
