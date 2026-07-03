using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main()
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer"
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [create, read, update, delete]
            #region Managing DbContext Lifetime
            ///unmanaged code
            //CompanyDbContext db = new CompanyDbContext();
            //try
            //{
            //    //CRUD
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    db.Dispose(); // release connection to db
            //}

            ////managed code
            //using (CompanyDbContext db2 = new CompanyDbContext())
            //{
            //    //CRUD
            //}

            ////managed code with using declaration
            //using CompanyDbContext dbContext = new CompanyDbContext();
            ////CRUD
            ////code
            ////crud
            ////code 
            #endregion
            using CompanyDbContext db = new CompanyDbContext();

            Employee emp = new Employee()
            {
                //Id = 1,
                Name = "Ahmed",
                Salary = 5000,
                Age = 30
            };

            Department dept = new Department()
            {
                Name = "IT"
            };

            //Console.WriteLine(db.Entry(emp).State); 
            //Console.WriteLine(db.Entry(dept).State);

            ///detached
            ///unchanged
            ///deleted
            ///modified
            ///added

            #region Create
            //db.Employees.Add(emp);
            //db.Add(emp);
            //db.Set<Department>().Add(dept);
            //db.Entry(emp).State = EntityState.Added;
            //db.SaveChanges();

            //Console.WriteLine(db.Entry(emp).State);//detached
            //db.Employees.Add(emp); 
            //Console.WriteLine(db.Entry(emp).State);//added
            //db.SaveChanges();
            //Console.WriteLine(db.Entry(emp).State);//unchanged
            #endregion

            #region Read
            #region Multi elements
            //var result = (from e in db.Employees
            //              where e.Id == 1
            //              select e);//.ToList(); //linq query => select * from employees where id = 1

            ////linq query => select * from employees where id = 1
            //var result2 = db.Employees.Where(e => e.Id == 1).Select(e => e).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Salary: {item.Salary}, Age: {item.Age}");
            //}

            #endregion
            #region One elements
            //var result = (from e in db.Employees
            //              where e.Id == 1
            //              select e) //linq query => select * from employees where id = 1
            //.First();  //linq query => select top(1) * from employees where id = 1
            //.FirstOrDefault();  //linq query => select top(1) * from employees where id = 1 or null
            //.Single();  //linq query => select top(2) * from employees where id = 1
            //.SingleOrDefault();  //linq query => select top(2) * from employees where id = 1 or null
            //Console.WriteLine($"Id: {result.Id}, Name: {result.Name}, Salary: {result.Salary}, Age: {result.Age}");

            //var EMP = db.Employees.Find(1); //linq query => select * from employees where id = 1

            #endregion
            #region Tracking vs NoTracking
            //db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var EMP = (from e in db.Employees
            //           where e.Id == 1
            //           select e)
            //           .AsTracking()//.AsNoTracking()
            //           .FirstOrDefault();

            //Console.WriteLine(db.Entry(EMP).State);
            #endregion
            #endregion

            #region Update
            //var EMP = db.Employees.Where(e => e.Id == 1)
            //    //.AsNoTracking()
            //    .FirstOrDefault();
            //if(EMP is not null)
            //{
            //    Console.WriteLine(db.Entry(EMP).State);
            //    EMP.Name = "Test";
            //    Console.WriteLine(db.Entry(EMP).State);
            //    //db.Employees.Update(EMP);
            //    //Console.WriteLine(db.Entry(EMP).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(EMP).State);
            //}
            #endregion

            #region delete
            //var EMP = db.Employees.Where(e => e.Id == 1).AsNoTracking().FirstOrDefault();
            //if (EMP is not null)
            //{
            //    Console.WriteLine(db.Entry(EMP).State);
            //    db.Employees.Remove(EMP);
            //    Console.WriteLine(db.Entry(EMP).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(EMP).State);
            //}
            #endregion

            #endregion
        }
    }
}
