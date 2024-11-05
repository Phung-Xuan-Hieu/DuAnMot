using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IBillDetailResponsitory
    {
        bool Add(BillDetail x);

        bool Remove(Guid x);
        bool Save();

        bool Update(BillDetail x);

        List<BillDetail> GetAll();
    }
}
