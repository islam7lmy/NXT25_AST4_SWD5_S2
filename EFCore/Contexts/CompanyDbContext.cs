using EFCore.Configurations;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Your_Connection_String_Here");
            //optionsBuilder.UseSqlServer("Data source = ISLAM7LMYLAPVM\\ISLAM7LMY;Intial Catalog = NXT25.EFMyCompany; Integrated Security = True");
            //optionsBuilder.UseSqlServer("Data source = ISLAM7LMYLAPVM\\ISLAM7LMY;Intial Catalog = NXT25.EFMyCompany; User Id = sa; Password = 1234567");
            optionsBuilder.UseSqlServer("Data Source=ISLAM7LMYLAPVM\\ISLAM7LMY;Initial Catalog=NXT25.EFMyCompany;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent API
            #region ways to access property
            //modelBuilder.Entity<Employee>()
            //    .Property("Name")
            //    .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //    .Property(nameof(Employee.Name))
            //    .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Name)
            //    .HasDefaultValue("No Name");
            #endregion

            #region Shadow Property
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(200);
            #endregion

            #region Mapping To Class
            //modelBuilder.Entity<Department>()
            //    .ToTable("DepartmentInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(50)
            //    .IsRequired();

            //modelBuilder.Entity<Department>()
            //    .Property(d=>d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("CONVERT(date, GETDATE())");


            ///efcore3.1 new feature
            //modelBuilder.Entity<Department>(builder =>
            //{
            //    builder.ToTable("DepartmentInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //    builder.Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //    builder.Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(50)
            //    .IsRequired();

            //    builder.Property(d => d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("CONVERT(date, GETDATE())");
            //});
            #endregion
            #endregion

            #region 4. ConfigurationClass
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
