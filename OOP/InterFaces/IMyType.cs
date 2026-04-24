using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    // Interface: is a contract that defines a set of
    // methods, properties, events, or indexers that a class or struct must implement.
    internal interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// 1. Method Signature
        /// 2. property Signature
        /// 3. event Signature
        /// 4. indexer signature
        /// 5. Default Implementation (C# 8.0 +)

        /// Default Access Modifier inside the interface is public
        /// private is not allowed inside the interface

        ///property Signature
        int Salary { get; set; }

        ///Method Signature
        void MyFun();


        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }
    }

    class MyType : IMyType  // => Implmentation
    {
        ///clr will generate backing filed
        //public int Salary { get; set; }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void MyFun()
        {
            Console.WriteLine("Hello");
        }
    }

    class MyTypev2 : IMyType  // => Implmentation
    {
        ///clr will generate backing filed
        //public int Salary { get; set; }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

        public void MyFun()
        {
            Console.WriteLine("Hello print");
        }
    }

}
