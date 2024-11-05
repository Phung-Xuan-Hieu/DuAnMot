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
    public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(c => c.CustomerId); // Khóa chính

            // Định nghĩa các thuộc tính
            builder.Property(c => c.CustomerId).HasColumnName("CustomerId");
            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
            builder.Property(c => c.Gender).HasMaxLength(10);
            builder.Property(c => c.Address).HasMaxLength(255);
            builder.Property(c => c.Phone).HasMaxLength(20);
            builder.Property(c => c.Email).HasMaxLength(255);
            builder.Property(c => c.Feedback).HasMaxLength(500);

            // Quan hệ một-một với bảng Vouchers
            // Xóa ràng buộc khi xóa voucher

            // Cấu hình các thứ khác (nếu cần)
        }
    }
}
