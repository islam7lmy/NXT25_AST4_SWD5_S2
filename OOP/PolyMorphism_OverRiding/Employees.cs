using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    /// base class
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void MyFun01()
        {
            Console.WriteLine("I am Employeee");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee : Id = {Id} , Name = {Name} , Age = {Age}");
        }
    }

    /// drived class
    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        
        //hidding => static binded
        public new void MyFun01()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }

        //dynamic => override
        public override void MyFun02()
        {
            Console.WriteLine($"FullTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }

        public void MyFunc03()
        {
            Console.WriteLine("I am drived method");
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }

        //dynamic
        public override void MyFun01()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }

        //static
        public new void MyFun02()
        {
            Console.WriteLine($"PartTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , HourRate = {HourRate} , CountOfHours = {CountOfHours}");
        }
    }

    class FreeLanceEmployee : Employee
    {
        public decimal ProjectPrice { get; set; }
    }
}
