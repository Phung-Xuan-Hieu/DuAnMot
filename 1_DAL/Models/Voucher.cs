using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class Voucher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Status { get; set; }
        public float Voucher_Percent { get; set; }
        public float minPrice { get; set; }
    }
}
