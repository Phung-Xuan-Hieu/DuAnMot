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
    public class BillResponsitory : IBillResponsitory
    {
        ShopClothesContext _context;
        public BillResponsitory()
        {
            _context = new ShopClothesContext();
        }
        public bool Add(Bill x)
        {
            if (x == null) return false;
            x.Id = Guid.NewGuid();
            _context.Bills.Add(x);
            _context.SaveChanges();
            return true;
        }

        public List<Bill> GetAll()
        {
            return _context.Bills.ToList();
        }
        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = _context.Bills.FirstOrDefault(c => c.Id == x);
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Bill x)
        {
            if (x == null) return false;
            var tempobj = _context.Bills.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Id = x.Id;
            tempobj.User_Id = x.User_Id;
            tempobj.Customer_Id = x.Customer_Id;
            tempobj.MaHD = x.MaHD;
            tempobj.Create_Date = x.Create_Date;
            tempobj.Discount = x.Discount;
            tempobj.Status = x.Status;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
