using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal interface IMoveable
    {
        public int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }

    internal interface IFlayable
    {
        public int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }

    class Car : IMoveable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car is move BackWard");
        }

        public void Forward()
        {
            Console.WriteLine("Car is move Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car is move Left");
        }

        public void Right()
        {
            Console.WriteLine("Car is move Right");
        }
    }

    class AirPlan : IMoveable , IFlayable
    {
        /// Implicit Implmintation
        public int Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine($"AirPlan is move BackWard with speed {Speed}");
        }

        void IFlayable.Backward()
        {
            Console.WriteLine($"AirPlan is Flay BackWard with speed {Speed}");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlan is move Forward");
        }

        void IFlayable.Forward()
        {
            Console.WriteLine("AirPlan is Flay Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlan is move Left");
        }

        void IFlayable.Left()
        {
            Console.WriteLine("AirPlan is Flay Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlan is move Right");
        }

        void IFlayable.Right()
        {
            Console.WriteLine("AirPlan is Flay Right");
        }
    }
}
