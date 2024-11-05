using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IBillResponsitory
    {
        bool Add(Bill x);

        bool Remove(Guid x);

        bool Update(Bill x);

        List<Bill> GetAll();
    }
}
