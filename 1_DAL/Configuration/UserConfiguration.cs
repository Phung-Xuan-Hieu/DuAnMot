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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> buider)
        {
            buider.ToTable("User");
            buider.HasKey(x => x.Id);
            buider.Property(p => p.role_Id).IsRequired();

            buider.Property(p => p.UserName).HasColumnName("UserName").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.PassWord).HasColumnName("PassWord").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.Email).HasColumnName("Email").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.Role).WithMany().HasForeignKey(p => p.role_Id);
        }
    }
}
