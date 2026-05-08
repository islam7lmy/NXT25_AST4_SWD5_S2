using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
		private int salary;

		/// getter & setter => methods
		public virtual int Salary
		{
			get { return salary; }
			set { salary = value - 1000; }
		}

		public virtual void Print()
		{
            Console.WriteLine("Hello Parent");
		}
	}

	class Child02 : Parent
	{
        /// salary - 1500 
		public override int Salary 
		{ 
			get => base.Salary; 
			set => base.Salary = value - 500; 
		}

        ///print => Hello Child
        public override void Print()
        {
            Console.WriteLine("Hello Child");
        }
	}

    class Child : Parent
    {
        /// salary - 1500 
		public sealed override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        ///print => Hello Child
        public sealed override void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    sealed class GrandChild : Child
    {
        public GrandChild()
        {
            Salary = 1545545;
            Print();
        }

        void test()
        {
            Salary = 1545545;
            Print();
        }

        //public new void Print()
        //{
        //    Console.WriteLine("hello GrandChild");
        //}

        //public override int Salary 
        //{ 
        //    get => base.Salary; 
        //    set => base.Salary = value; 
        //}

        //public override void Print()
        //{
        //    base.Print();
        //}
    }

    //class GrandGrandChild : GrandChild
    //{

    //}


}
