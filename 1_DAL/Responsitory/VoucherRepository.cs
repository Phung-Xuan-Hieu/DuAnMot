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
    public class VoucherRepository : IVoucherResponsitory
    {
        ShopClothesContext _context;
        public VoucherRepository()
        {
            _context = new ShopClothesContext();

        }
        public bool CreateVoucher(Voucher voucher)
        {

            if (voucher == null) return false;
            voucher.Id = Guid.NewGuid();
            _context.Vouchers.Add(voucher);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteVoucher(Guid voucher)
        {
            if (voucher == null) return false;
            var voucher1 = _context.Vouchers.FirstOrDefault(c => c.Id == voucher);

            _context.Remove(voucher1);
            _context.SaveChanges();
            return true;
        }

        public List<Voucher> GetAllVoucher()
        {
            return _context.Vouchers.ToList();
        }

        public Voucher GetVoucherById(Guid id)
        {
            return _context.Vouchers.Find(id);
        }

        public bool UpdateVoucher(Voucher voucher)
        {
            if (voucher == null) return false;
            var vou = _context.Vouchers.FirstOrDefault(c => c.Id == voucher.Id);
            vou.Id = voucher.Id;
            vou.Name = voucher.Name;
            vou.Create_Date = voucher.Create_Date;
            vou.End_Date = voucher.End_Date;
            vou.Status = voucher.Status;
            vou.Voucher_Percent = voucher.Voucher_Percent;
            vou.minPrice = voucher.minPrice;
            _context.Update(vou);
            _context.SaveChanges();
            return true;
        }
    }
}
