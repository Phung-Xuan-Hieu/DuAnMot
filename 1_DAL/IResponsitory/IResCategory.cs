using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResCategory
    {
        bool Add(Category x);

        bool Remove(Guid x);

        bool Update(Category x);

        Category GetByID(Guid id);
        List<Category> GetAll();
    }
}
