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
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> buider)
        {
            buider.ToTable("Bill");

            buider.HasKey(x => x.Id);
            buider.Property(p => p.User_Id).IsRequired();
            buider.Property(p => p.Customer_Id).IsRequired();
            buider.Property(p => p.MaHD).HasColumnName("MaHD").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.User_Id).IsRequired();
            buider.Property(p => p.Customer_Id).IsRequired();

            buider.Property(p => p.Discount).HasColumnName("Discount").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.Create_Date).HasColumnName("Create_Date").HasColumnType("datetime").IsRequired();
            buider.Property(p => p.Status).HasColumnName("Status").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.User).WithMany().HasForeignKey(p => p.User_Id);
            buider.HasOne(p => p.customer).WithMany().HasForeignKey(p => p.Customer_Id);
        }
    }
}
