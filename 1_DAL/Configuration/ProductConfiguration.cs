using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configuration
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> buider)
        {
            buider.ToTable("Product");

            buider.HasKey(x => x.Id);

            buider.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.Supplier_Id).IsRequired();
            buider.Property(p => p.Color_Id).IsRequired();
            buider.Property(p => p.Cate_Id).IsRequired();
            buider.Property(p => p.Size_Id).IsRequired();
            buider.Property(p => p.MaSp).HasColumnName("Masp").HasColumnType("nvarchar(100)").IsRequired();

            buider.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("int").IsRequired();
            buider.Property(p => p.Description).HasColumnName("Description").HasColumnType("nvarchar(400)").IsRequired();
            buider.Property(p => p.Status).HasColumnName("Status").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.Price).HasColumnName("Price").HasColumnType("decimal").IsRequired();

            buider.HasOne(p => p.Supplier).WithMany().HasForeignKey(p => p.Supplier_Id);
            buider.HasOne(p => p.Size).WithMany().HasForeignKey(p => p.Size_Id);
            buider.HasOne(p => p.Color).WithMany().HasForeignKey(p => p.Color_Id);
            buider.HasOne(p => p.Category).WithMany().HasForeignKey(p => p.Cate_Id);
        }
    }
}
