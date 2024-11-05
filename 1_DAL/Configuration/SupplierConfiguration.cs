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
    public class SupplierConfiguration: IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> buider)
        {
            buider.ToTable("Supplier");

            buider.HasKey(x => x.Id);

            buider.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
