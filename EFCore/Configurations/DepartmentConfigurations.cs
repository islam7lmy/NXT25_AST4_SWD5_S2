using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("DepartmentInfo", "dbo")
                .HasKey(d => d.DeptId);

            builder.Property(d => d.DeptId)
            .UseIdentityColumn(10, 10);

            builder.Property(d => d.Name)
            .HasColumnName("DepartmentName")
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(d => d.CreationDate)
            .HasColumnType("date")
            .HasComputedColumnSql("CONVERT(date, GETDATE())");
        }
    }
}
