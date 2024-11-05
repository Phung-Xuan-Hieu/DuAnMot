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
    public class ColorConfiguration: IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> buider)
        {
            buider.ToTable("Color");

            buider.HasKey(x => x.Id);

            buider.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar(100)").IsRequired();


        }
    }
}
