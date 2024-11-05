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
    public class ResCategory : IResCategory
    {
        ShopClothesContext contextcate;
        public ResCategory()
        {
            contextcate = new ShopClothesContext();
        }

        public bool Add(Category x)
        {
            if (x == null) return false;
            x.Id = Guid.NewGuid();

            contextcate.Categories.Add(x);
            contextcate.SaveChanges();
            return true;
        }

        public List<Category> GetAll()
        {
            return contextcate.Categories.ToList();
        }

        public Category GetByID(Guid id)
        {
            return contextcate.Categories.Find(id);
        }

        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = contextcate.Categories.FirstOrDefault(c => c.Id == x);

            contextcate.Remove(tempobj);
            contextcate.SaveChanges();
            return true;
        }

        public bool Update(Category x)
        {
            if (x == null) return false;
            var tempobj = contextcate.Categories.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Id = x.Id;
            tempobj.Name = x.Name;
            contextcate.Update(tempobj);
            contextcate.SaveChanges();
            return true;
        }
    }
}
