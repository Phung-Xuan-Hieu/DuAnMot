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
    public class ResSupplier : IResSupplier
    {
        ShopClothesContext contextsup;
        public ResSupplier()
        {
            contextsup = new ShopClothesContext();
        }

        public bool Add(Supplier x)
        {
            if (x == null) return false;
            x.Id = Guid.NewGuid();
            contextsup.Suppliers.Add(x);
            contextsup.SaveChanges();
            return true;
        }

        public List<Supplier> GetAll()
        {
            return contextsup.Suppliers.ToList();
        }

        public Supplier GetByID(Guid id)
        {
            return contextsup.Suppliers.Find(id);
        }

        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = contextsup.Suppliers.FirstOrDefault(c => c.Id == x);
            contextsup.Remove(tempobj);
            contextsup.SaveChanges();
            return true;
        }

        public bool Update(Supplier x)
        {
            if (x == null) return false;
            var tempobj = contextsup.Suppliers.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Id = x.Id;
            tempobj.Name = x.Name;
            contextsup.Update(tempobj);
            contextsup.SaveChanges();
            return true;
        }
    }
}
