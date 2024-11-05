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
    public class ResSize : IResSize
    {
        ShopClothesContext contextsize;
        public ResSize()
        {
            contextsize = new ShopClothesContext();
        }

        public bool Add(Size x)
        {
            if (x == null) return false;
            x.Id = Guid.NewGuid();
            contextsize.Sizes.Add(x);
            contextsize.SaveChanges();
            return true;
        }

        public List<Size> GetAll()
        {
            return contextsize.Sizes.ToList();
        }

        public Size GetByID(Guid id)
        {
            return contextsize.Sizes.Find(id);
        }

        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = contextsize.Sizes.FirstOrDefault(c => c.Id == x);
            contextsize.Remove(tempobj);
            contextsize.SaveChanges();
            return true;
        }

        public bool Update(Size x)
        {
            if (x == null) return false;
            var tempobj = contextsize.Sizes.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Id = x.Id;
            tempobj.Name = x.Name;
            contextsize.Update(tempobj);
            contextsize.SaveChanges();
            return true;
        }
    }
}
