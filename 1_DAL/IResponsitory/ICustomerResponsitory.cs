using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface ICustomerResponsitory
    {
        public bool CreateCustomer(Customer customer);
        public bool UpdateCustomer(Customer customer);
        public bool DeleteCustomer(Guid customer);
        public List<Customer> GetAllCustomer();
        public Customer GetCustomerById(Guid id);
    }
}
