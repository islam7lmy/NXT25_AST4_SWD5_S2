using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<Employee> Employees { get; set; }
    }
}
