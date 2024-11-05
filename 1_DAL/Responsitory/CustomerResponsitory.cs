using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Responsitory
{
    public class CustomerResponsitory : ICustomerResponsitory
    {
        ShopClothesContext _context;

        List<Customer> customers;
        public CustomerResponsitory()
        {
            _context = new ShopClothesContext();
            customers = new List<Customer>();
        }
        public bool CreateCustomer(Customer customer)
        {
            if (customer == null) return false;
            customer.CustomerId = Guid.NewGuid();
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCustomer(Guid customer)
        {
            if (customer == null) return false;
            var cus = _context.Customers.FirstOrDefault(c => c.CustomerId == customer);

            _context.Remove(cus);
            _context.SaveChanges();
            return true;
        }

        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(Guid id)
        {
            return _context.Customers.Find(id);
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (customer == null) return false;
            var cus = _context.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            cus.Name = customer.Name;
            cus.Gender = customer.Gender;
            cus.Address = customer.Address;
            cus.Phone = customer.Phone;
            cus.Email = customer.Email;
            cus.Feedback = customer.Feedback;
            _context.Update(cus);
            _context.SaveChanges();
            return true;
        }
    }
}
