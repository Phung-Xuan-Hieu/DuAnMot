using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResSupplier
    {
        bool Add(Supplier x);

        bool Remove(Guid x);

        bool Update(Supplier x);

        Supplier GetByID(Guid id);
        List<Supplier> GetAll();
    }
}
