using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IVoucherResponsitory
    {
        public bool CreateVoucher(Voucher voucher);
        public bool DeleteVoucher(Guid voucher);
        public bool UpdateVoucher(Voucher voucher);
        public List<Voucher> GetAllVoucher();
        public Voucher GetVoucherById(Guid id);
    }
}
