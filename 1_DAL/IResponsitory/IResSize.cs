using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResSize
    {
        bool Add(Size x);

        bool Remove(Guid x);

        bool Update(Size x);

        Size GetByID(Guid id);
        List<Size> GetAll();
    }
}
