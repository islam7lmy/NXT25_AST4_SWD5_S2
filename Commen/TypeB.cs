using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    internal class TypeB
    {
        void test()
        {
            rank r = rank.first;
            TypeA a = new TypeA();
            //a.x = 10; //invalid because it's private
            a.y = 1; //valid because it's internal
            a.z = 2; //valid because it's public

            TypeC C = new TypeC();
            //C.x = 10; //invalid because it's private
            C.y = 1; //valid because it's internal
            C.z = 2; //valid because it's public
        }
    }
}

namespace test2
{
    internal class test1
    {
        void test()
        {
            rank r = rank.first;
            TypeA a = new TypeA();
            //a.x = 10; //invalid because it's private
            a.y = 1; //valid because it's internal
            a.z = 2; //valid because it's public
        }
    }
}
