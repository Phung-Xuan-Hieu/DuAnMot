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
    public class BilllDetailResponsitory : IBillDetailResponsitory
    {
        ShopClothesContext _context;
        public BilllDetailResponsitory()
        {
            _context = new ShopClothesContext();
        }
        public bool Add(BillDetail x)
        {

            if (x == null) return false;
            x.Id = Guid.NewGuid();

            _context.billDetails.Add(x);
            _context.SaveChanges();
            return true;
        }

        public List<BillDetail> GetAll()
        {
            return _context.billDetails.ToList();
        }

        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = _context.billDetails.FirstOrDefault(c => c.Id == x);

            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool Update(BillDetail x)
        {
            if (x == null) return false;
            var tempobj = _context.billDetails.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Bill_Id = x.Bill_Id;
            tempobj.Pro_Id = x.Pro_Id;
            tempobj.Id = x.Id;

            tempobj.MaHDCT = x.MaHDCT;
            tempobj.Quantity = x.Quantity;
            tempobj.Price = x.Price;
            tempobj.Image = x.Image;



            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
        public bool Save()
        {
            _context.SaveChanges();
            return true;
        }
    }
}
