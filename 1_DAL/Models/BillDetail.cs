using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class BillDetail
    {
        public Guid Id { get; set; }

        public Guid Pro_Id { get; set; }

        public Guid Bill_Id { get; set; }
        public string MaHDCT { get; set; }

        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        //public string MaHDCT { get; set; }

        public virtual Product Product { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
