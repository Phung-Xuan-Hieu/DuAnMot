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
    public class ProductRepo : IProductRepo
    {
        ShopClothesContext _shopClothesContext;
        public ProductRepo()
        {
            _shopClothesContext = new ShopClothesContext();
        }
        public bool Add(Product p)
        {
            if (p == null) return false;
            p.Id = Guid.NewGuid();

            _shopClothesContext.Products.Add(p);
            _shopClothesContext.SaveChanges();
            return true;
        }

        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = _shopClothesContext.Products.FirstOrDefault(c => c.Id == x);

            _shopClothesContext.Remove(tempobj);
            _shopClothesContext.SaveChanges();
            return true;
        }

        public List<Product> GetAll()
        {
            return _shopClothesContext.Products.ToList();
        }



        public bool Update(Product p)
        {
            if (p == null) return false;
            var tempobj = _shopClothesContext.Products.FirstOrDefault(c => c.Id == p.Id);

            tempobj.Cate_Id = p.Cate_Id;
            tempobj.Size_Id = p.Size_Id;
            tempobj.Color_Id = p.Color_Id;
            tempobj.Supplier_Id = p.Supplier_Id;
            tempobj.MaSp = p.MaSp;
            tempobj.Name = p.Name;
            tempobj.Quantity = p.Quantity;
            tempobj.Price = p.Price;
            tempobj.Description = p.Description;
            tempobj.Status = p.Status;



            _shopClothesContext.Update(tempobj);
            _shopClothesContext.SaveChanges();
            return true;
        }
    }
}
