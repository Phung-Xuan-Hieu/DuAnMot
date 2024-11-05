using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Customer_Id { get; set; }
        public string MaHD { get; set; }

        public string Discount { get; set; }
        public DateTime Create_Date { get; set; }
        public int Status { get; set; }
        public virtual User User { get; set; }
        public virtual Customer customer { get; set; }
    }
}
