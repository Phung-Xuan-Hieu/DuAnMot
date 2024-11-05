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
    public class ResColor : IResColor
    {
        ShopClothesContext contextcor;
        public ResColor()
        {
            contextcor = new ShopClothesContext();
        }

        public bool Add(Color x)
        {
            if (x == null) return false;
            x.Id = Guid.NewGuid();
            contextcor.Colors.Add(x);
            contextcor.SaveChanges();
            return true;
        }

        public List<Color> GetAll()
        {
            return contextcor.Colors.ToList();
        }

        public Color GetByID(Guid id)
        {
            return contextcor.Colors.Find(id);
        }

        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = contextcor.Colors.FirstOrDefault(c => c.Id == x);
            contextcor.Remove(tempobj);
            contextcor.SaveChanges();
            return true;
        }

        public bool Update(Color x)
        {
            if (x == null) return false;
            var tempobj = contextcor.Colors.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Id = x.Id;
            tempobj.Name = x.Name;
            contextcor.Update(tempobj);
            contextcor.SaveChanges();
            return true;
        }
    }
}
