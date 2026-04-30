using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    #region old implment
    //not fully implmented class => so you can't create object from it
    internal abstract class Shape
    {
        ///property implementation => property with implementation
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        //not implmented property just signture
        public abstract double Perimeter { get; }

        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.
        public abstract double CalcArea();

        public void test()
        {
            Console.WriteLine("Hello i am  default implment method");
        }
    }

    class Squere : Shape
    {
        //public double Dim01 { get; set; }
        public override double Perimeter { get { return Dim01 * 4; } }
        public override double CalcArea()
        {
            return Dim01 * Dim01;
        }
    }

    class Rectangle : Shape
    {
        //public double Dim01 { get; set; }
        //public double Dim02 { get; set; }

        public override double Perimeter { get { return 2 * (Dim01 + Dim02); } }

        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    class Circle : Shape
    {
        //public double Dim01 { get; set; }

        public override double Perimeter { get { return 2 * 3.14 * Dim01; } }

        public override double CalcArea()
        {
            return 3.14 * Dim01 * Dim01;
        }
    } 
    #endregion
}

namespace OOP.Abstraction02
{
    public interface IShape
    {
        double Perimeter { get; }
        double CalcArea();
    }

    public abstract class ShapeBase : IShape
    {
        public abstract double Perimeter { get; }
        public abstract double CalcArea();

        protected static double EnsurePostive(double value , string paramName)
        {
            if(value <= 0)
                throw new ArgumentException($"{paramName} must be greater than zero");
            
            return value;
        }
    }

    class Squere : ShapeBase
    {
        public double Side { get; }

        public override double Perimeter { get { return Side * 4; } }

        public Squere(double side)
        {
            //if (side <= 0)
            //    throw new ArgumentException($"side must be greater than zero");
            //Side = side;
            Side = EnsurePostive(side,nameof(Side));
        }

        public override double CalcArea()
        {
            return Side * Side;
        }
    }

    class Rectangle : ShapeBase
    {
        public double Width { get; }
        public double Height { get; }

        public override double Perimeter { get { return 2 * (Width + Height); } }

        public Rectangle(double width , double height)
        {
            //if (width <= 0)
            //    throw new ArgumentException($"width must be greater than zero");
            //if (height <= 0)
            //    throw new ArgumentException($"height must be greater than zero");
            //Width  = width;
            //Height = height;
            Width = EnsurePostive(width, nameof(Width));
            Height = EnsurePostive(height, nameof(Height));
        }

        public override double CalcArea()
        {
            return Width * Height;
        }
    }
}
