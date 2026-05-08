using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Partiales
{
    ///scafollding
    internal partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        ///.net 8.0
        ///don't have accessmodifers
        ///don't have return type
        partial void sayhello();
    }
}
