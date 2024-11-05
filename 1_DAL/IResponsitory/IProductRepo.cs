using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IProductRepo
    {
        public bool Add(Product p);
        public bool Update(Product p);
        public bool Remove(Guid p);
        List<Product> GetAll();
    }
}
