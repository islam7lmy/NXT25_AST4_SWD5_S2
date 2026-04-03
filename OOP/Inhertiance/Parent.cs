using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    internal class Parent
    {
        public int A { get; set; }

        ///clr will create a default constructor for parent class that will initialize the attributes of parent class with their default values
        //public Parent()
        //{

        //}

        /// user defined constructor
        public Parent(int a)
        {
            A = a;
        }



        public void MyFun01()
        {
            Console.WriteLine("Hi I am Parent");
        }

        public void MyFun02()
        {
            Console.WriteLine($"A = {A}");
        }
    }

    class Child : Parent
    {
        //public int A { get; set; }

        public int B { get; set; }

        /// clr will create a default constructor for child class that will call the default constructor of parent class
        //public Child() : base()
        //{

        //}

        /// user defined constructor
        public Child(int _a, int _b) : base(_a)
        {
            B = _b;
        }

        //public void MyFun01()
        //{
        //    Console.WriteLine("Hi I am Child");
        //}

        //public void MyFun02()
        //{
        //    Console.WriteLine($"A = {A} , B = {B}");
        //}
    }
}
