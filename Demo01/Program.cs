namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Comment
            //line comment

            /*
             block comment
             */
            #endregion

            #region Value Type
            //int X;
            ///// allocate 4 uninitialized bytes in stack for X
            ///// int : C# keyword for System.Int32 struct

            //X = 5;

            //Int32 Y;
            ///// allocate 4 uninitialized bytes in stack for Y
            ///// int32 : BCL struct for 32-bit signed integer

            //Y = X;

            //X += 1; // X = X + 1; // X = 5 + 1; // X = 6

            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            #endregion

            #region Reference Type
            //Point p1;
            //// allocate 4 bytes in stack for p1 , referring to null
            //// zero bytes allocated in heap for Point instance

            //p1 = new Point();
            ///// new
            ///// 1.allocate required bytes in heap for Point instance (4 byte for x , 4 byte for y)
            ///// 2.initialize allocated bytes with default value of it's datatype  (x = 0 , y = 0)
            ///// 3.call user defined constructor if any (not in this case)
            ///// 4.return address of allocated memory in heap to caller (p1 = address of Point instance in heap)

            //Point p2 = new Point();

            //p2 = p1; // p2 = address of Point instance in heap

            //p1.X = 5;

            //Console.WriteLine(p1.X);
            //Console.WriteLine(p2.X);
            #endregion

            #region Object
            //Point o1 = new Point();
            //object o2 = new object();

            //o1.ToString(); // System.Object.ToString() method is called
            //o1.Equals(o2); // System.Object.Equals() method is called
            //o1.GetHashCode(); // System.Object.GetHashCode() method is called
            //o1.GetType(); // System.Object.GetType() method is called

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //o2 = o1;
            //Console.WriteLine("after assignment");

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());
            #endregion

            #region Fractions and Discards
            // for better readability of large numbers, we can use _ as a separator in numeric literals
            //int X = 1_000_000_000; //_ discard to improve readabilty

            //float f1 = 15.3f;
            //double d1 = 15.3;
            //decimal m1 = 15.3m;
            #endregion

            #region Value Type Casting
            /// 1. implicit casting (safe casting)
            //int X = 5;
            //long Y = X; // implicit casting from int to long
            //Y = 1_000_000_000_000; // long literal

            //X = Y; // compile time error : cannot implicitly convert long to int

            /// 2. explicit casting (unsafe casting)
            //X = (int)Y; // explicit casting from long to int
            //unchecked 
            //{
            //    X = (int)Y;
            //}
            //checked
            //{
            //    int Z = (int)Y;
            //    unchecked
            //    {
            //        Console.WriteLine(Z);
            //    }
            //}

            /// 3. parse (string to value type)
            //Console.Write("Please enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello" + name);
            //Console.WriteLine("your age is " + age);

            // 4. try parse (string to value type with error handling)
            //Console.Write("Please enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age;
            //var x = int.TryParse(Console.ReadLine(), out age);
            //if (x)
            //{
            //    Console.WriteLine("Hello" + name);
            //    Console.WriteLine("your age is " + age);
            //}
            //else
            //{
            //    Console.WriteLine("you enterend wrong formate for age");
            //}

            // 5. convert class (Convert From Any Datatype To Any Datatype)
            //Console.Write("Please enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello" + name);
            //Console.WriteLine("your age is " + age);
            #endregion
        }
    }
}
