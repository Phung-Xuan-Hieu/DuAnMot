using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid Cate_Id { get; set; }

        public Guid Size_Id { get; set; }

        public Guid Color_Id { get; set; }

        public Guid Supplier_Id { get; set; }
        public string MaSp { get; set; }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual Size Size { get; set; }
        public virtual Color Color { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
