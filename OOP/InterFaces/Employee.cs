using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Address} :: {Salary}";
        }

        /// default constructor => empty parameterless constructor
        public Employee()
        {
            
        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        public Employee(Employee emp)
        {
            Id = emp.Id ;
            Name = emp.Name ;
            Salary = emp.Salary ;
            Address = emp.Address ;
        }

        public static Employee DeepCopy(Employee emp)
        {
            //return new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    Address = emp.Address
            //};

            return new Employee(emp);
        }

        /// object memeber method
        public object Clone()
        {
            ///this keyword => refere to object that call method
            return new Employee(this);
        }
    }
}
