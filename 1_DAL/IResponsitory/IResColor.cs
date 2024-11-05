using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResColor
    {
        bool Add(Color x);

        bool Remove(Guid x);

        bool Update(Color x);

        Color GetByID(Guid id);
        List<Color> GetAll();
    }
}
