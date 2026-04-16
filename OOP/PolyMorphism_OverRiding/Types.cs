using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }

        public void MyFun01() 
        {
            Console.WriteLine("I am Base [Parent]");
        }


        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A  , int _B) : base(_A)
        {
            B = _B;
        }

        /// static binded method
        /// apply overriding => new keyword  [hidding]
        /// compliation time
        public new void MyFun01()
        {
            Console.WriteLine("I am Base [Child]");
        }

        /// dynamic binded method
        /// apply overriding => override keyword
        /// to apply override => method of parent must be [not private , virtual]
        /// Runtime 
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }
    }
}
