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
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> buider)
        {
            buider.ToTable("Voucher");
            buider.HasKey(x => x.Id);
            buider.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar(100)").IsRequired();

            buider.Property(p => p.Voucher_Percent).HasColumnName("Voucher_Percent").HasColumnType("decimal").IsRequired();
            buider.Property(p => p.minPrice).HasColumnName("MinPrice").HasColumnType("decimal").IsRequired();
            buider.Property(p => p.Status).HasColumnName("Status").HasColumnType("decimal").IsRequired();
            buider.Property(p => p.Create_Date).HasColumnName("Create_Date").HasColumnType("datetime").IsRequired();
            buider.Property(p => p.End_Date).HasColumnName("End_Date").HasColumnType("datetime").IsRequired();


        }
    }
}
