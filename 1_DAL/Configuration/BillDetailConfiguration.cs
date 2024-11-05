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
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> buider)
        {
            buider.ToTable("BillDetail");

            buider.HasKey(x => x.Id);
            buider.Property(p => p.Bill_Id).IsRequired();
            buider.Property(p => p.Pro_Id).IsRequired();
            buider.Property(p => p.MaHDCT).HasColumnName("Mahdct").HasColumnType("nvarchar(100)").IsRequired();

            buider.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("decimal").IsRequired();
            buider.Property(p => p.Price).HasColumnName("Price").HasColumnType("decimal").IsRequired();
            buider.Property(p => p.Image).HasColumnName("Image").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.Bill).WithMany().HasForeignKey(p => p.Bill_Id);
            buider.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.Pro_Id);
        }
    }
}
