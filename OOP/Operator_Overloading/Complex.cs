using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public Complex()
        {

        }
        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }
    }
}
