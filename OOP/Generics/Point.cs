using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            //    ///Generics.Point p1 = new Generics.Point(1, 0); // old way => 1
            //    ///Generics.Point p2 = new Generics.Point(0, 1); // old way => 1
            //    ///if two things are equal (Equals(..) == true) then they must return the same value of GetHashCode()
            //    ///if the GetHashCode is equal, it is not necessary for them to be the same; 
            //    ///this collision, and equals will be called to see if it is a real equality or not.

            //return X.GetHashCode() + Y.GetHashCode();

            return HashCode.Combine(X, Y);
        }

        //public Point(int x , int y)
        //{
        //    X = x;
        //    Y = y;
        //}

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        //public override bool Equals(object? obj)
        //{
        //    //Point p =(Point) obj; //[unsafe]

        //    ///is type check
        //    ///from type point or from type inhert from point
        //    //if(obj is Point p)
        //    //    return this.X == p.X && this.Y == p.Y;
        //    //return false;
        //    //return obj is Point p && X == p.X && Y == p.Y;


        //    ///as casting operator : refernce , nullable datatype
        //    //int? x = obj as int?;
        //    //Point p = obj as Point;
        //    //if (p is not null)
        //    //    return this.X == p.X && this.Y == p.Y;
        //    //return false;

        //}
    }
}
