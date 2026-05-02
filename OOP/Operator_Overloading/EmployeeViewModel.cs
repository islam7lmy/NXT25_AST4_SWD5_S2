using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_Overloading
{
    //table [model]
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Detuctions { get { return Salary * .2m; } }

        //public EmployeeViewModel ToEmployeeViewModel()
        //{
        //    //this keyword => refer to object that call method
        //    //return new EmployeeViewModel()
        //    //{
        //    //    FullName = $"{this.FirstName} {this.LastName}",
        //    //    Age = DateTime.Now.Year - this.BirthDate.Year,
        //    //    Address = $"{this.Address}, {this.City}, {this.Country}",
        //    //    NetSalary = this.Salary - this.Detuctions

        //    //};

        //    return new EmployeeViewModel(this);
        //}
    }

    static class employeeExtintions
    {
        public static EmployeeViewModel ToEmployeeViewModel(this Employee emp)
        {
            //this keyword => refer to object that call method
            //return new EmployeeViewModel()
            //{
            //    FullName = $"{this.FirstName} {this.LastName}",
            //    Age = DateTime.Now.Year - this.BirthDate.Year,
            //    Address = $"{this.Address}, {this.City}, {this.Country}",
            //    NetSalary = this.Salary - this.Detuctions

            //};

            return new EmployeeViewModel(emp);
        }
    }

    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal NetSalary { get; set; }

        public EmployeeViewModel()
        {
            
        }
        public EmployeeViewModel(Employee emp)
        {
            FullName = $"{emp.FirstName} {emp.LastName}";
            Age = DateTime.Now.Year - emp.BirthDate.Year;
            Address = $"{emp.Address}, {emp.City}, {emp.Country}";
            NetSalary = emp.Salary - emp.Detuctions;

        }
        public override string ToString()
        {
            return $"Name : {FullName}\nAge : {Age}\nAddress : {Address}\nNetSalary : {NetSalary}";
        }

        public static explicit /*EmployeeViewModel*/ operator EmployeeViewModel(Employee emp)
        {
            //return new EmployeeViewModel()
            //{
            //    FullName = $"{emp.FirstName} {emp.LastName}",
            //    Age = DateTime.Now.Year - emp.BirthDate.Year,
            //    Address = $"{emp.Address}, {emp.City}, {emp.Country}",
            //    NetSalary = emp.Salary - emp.Detuctions

            //};

            return new EmployeeViewModel(emp);
        }

        //public static implicit /*EmployeeViewModel*/ operator EmployeeViewModel(Employee emp)
        //{
        //    return new EmployeeViewModel()
        //    {
        //        FullName = $"{emp.FirstName} {emp.LastName}",
        //        Age = DateTime.Now.Year - emp.BirthDate.Year,
        //        Address = $"{emp.Address}, {emp.City}, {emp.Country}",
        //        NetSalary = emp.Salary - emp.Detuctions

        //    };
        //}
    }
}
