using System.Text;

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

            #region Operators

            #region Unary Operator
            //int X = 10;
            ///// prefix [increment and then print]
            //Console.WriteLine(++X); // increment x to 11 then print 11 
            ///// postfix [print and then increment]
            //Console.WriteLine(X++); // print x which is 11 then increment x to 12
            //Console.WriteLine(X); // print x which is 12
            ///// prefix [decrement and then print]
            //Console.WriteLine(--X); // decrement x to 11 then print 11
            ///// postfix [print and then decrement]
            //Console.WriteLine(X--); // print x which is 11 then decrement x to 10
            //Console.WriteLine(X); // print x which is 10
            #endregion

            #region Binary Operator
            //int sum, mul, sub, div, mod;
            //int num1 = 10, num2 = 3;
            //sum = num1 + num2; // 13
            //mul = num1 * num2; // 30
            //sub = num1 - num2; // 7
            //div = num1 / num2; // 3
            //mod = num1 % num2; // 1

            ////double div2 = 10.0 / 3; //int / int = int
            //double div2 = (double)num1 / num2;
            //Console.WriteLine(div2);
            #endregion

            #region Assignment Operator
            //int X;
            //X = 5; // assignment operator
            //X += 2; //x=x+2; // x=5+2; // x=7
            //X -= 3; //x=x-3; // x=7-3; // x=4
            //X *= 4; //x=x*4; // x=4*4; // x=16
            //X /= 2; //x=x/2; // x=16/2; // x=8
            //X %= 3; //x=x%3; // x=8%3; // x=2
            #endregion

            #region Relational Operator [Comparision]
            //int X = 10, Y = 20;
            //Console.WriteLine(X == Y); // equality operator
            //Console.WriteLine(X != Y); // inequality operator
            //Console.WriteLine(X > Y); // greater than operator
            //Console.WriteLine(X < Y); // less than operator
            //Console.WriteLine(X >= Y); // greater than or equal to operator
            //Console.WriteLine(X <= Y); // less than or equal to operator
            #endregion

            #region Logical Operator
            //Console.WriteLine(!false); // logical NOT operator
            //Console.WriteLine(false && true); // logical AND operator short circuiting
            //Console.WriteLine(true || false); // logical OR operator short circuiting

            //Console.WriteLine((4 < 5) && (!(7<9) || 5 == 5));
            #endregion

            #region Bitwise Operator
            //Console.WriteLine(false & true); // bitwise AND operator no short circuiting
            //Console.WriteLine(true | false); // bitwise OR operator no short circuiting
            //Console.WriteLine(true ^ false); // bitwise XOR operator no short circuiting
            #endregion

            #region Ternary Operator [Conditional operator]
            //int x = 4, y = 7;
            //if(x > y)
            //    Console.WriteLine("x is greater than y");
            //else
            //    Console.WriteLine("y is greater than x");

            //Console.WriteLine(x > y ? "x is greater than y" : "y is greater than x");

            //bool flag = x > y ? true : false;
            #endregion

            #region Operator Priorty
            /*
             * 1.unary operator (prefix)
             * 2.round brackets ()
             * 3.multiplicative operator (*, /, %)
             * 4.additive operator (+, -)
             */
            //int a = 20, b = 10, c = 15, d = 5, e;
            //e = (a + b) * c / d; // e = (20+10) * 15 / 5; // e = 30 * 15 / 5; // e = 450 / 5; // e = 90
            //e = ((--a + b) * c) / d; // a=19 , e = (19+10) * 15 / 5; // e = 29 * 15 / 5; // e = 435 / 5; // e = 87
            //e = --a + b * c / d; 
            #endregion
            #endregion

            #region string vs stringbuilder
            //string x = "Hello"; // syntex sugar for string x = new string("Hello");
            ////x = "world"; //x = new string("world"); // new string instance is created in heap and x is referring to it now
            //Console.WriteLine(x.GetHashCode());
            //x += " world"; // x = x + " world"; // x = "Hello" + " world"; // x = "Hello world"; // new string instance is created in heap and x is referring to it now
            //Console.WriteLine(x.GetHashCode());
            ////////////////////////////////////////////////////
            //StringBuilder y = new StringBuilder("Hello");
            //Console.WriteLine(y.GetHashCode());
            //y.Append(" world"); // no new stringbuilder instance is created in heap and y is still referring to the same instance
            //Console.WriteLine(y.GetHashCode());
            #endregion

            #region string Formating
            //// Equation : 4 + 2 = 6
            //int x = 4, y = 2;
            ////string result = "Equation : " + x + " + " + y + " = " + (x + y); // string concatenation
            ////string result = string.Format("Equation : {0} + {1} = {2}", x, y, x + y); // string format method
            //string result = $"Equation : {x} + {y} = {x + y}"; // string interpolation
            //Console.WriteLine(result);
            #endregion

            #region Conditional statment
            #region EX01
            #region If
            //Console.WriteLine("insert number of month in first qurter of year :");
            ////int month;
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    //Console.WriteLine(
            //    //    month == 1 ? "January" :
            //    //    month == 2 ? "February" :
            //    //    month == 3 ? "March" :
            //    //    "wrong month number"
            //    //    );

            //    //if (month == 1)
            //    //    Console.WriteLine("January");
            //    //else if (month == 2)
            //    //    Console.WriteLine("February");
            //    //else if (month == 3)
            //    //    Console.WriteLine("March");
            //    //else
            //    //    Console.WriteLine("wrong month number");
            //}
            //else
            //{
            //    Console.WriteLine("wrong format for month number");
            //}
            #endregion
            #region switch
            //Console.WriteLine("insert number of month in first qurter of year :");
            ////int month;
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    ///jump table is created in memory for switch statement
            //    switch (month)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        default:
            //            Console.WriteLine("wrong month number");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("wrong format for month number");
            //}
            #endregion
            #endregion
            #region EX02
            //int value = 3000;
            //switch (value)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        Console.WriteLine("option 02");
            //        Console.WriteLine("option 01");
            //        break;
            //    case 2000:
            //        Console.WriteLine("option 02");
            //        Console.WriteLine("option 01");
            //        break;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("wrong option");
            //        break;
            //}

            //switch (value)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        //Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("wrong option");
            //        break;
            //}
            #endregion
            #endregion

            #region loops statment
            //10 steps
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            ///1. for loop
            // for (start; end; increment | decrement )
            //start = 1
            //end => if true go to body
            //execute body
            //increment i to 2
            //end => if true go to body
            int i = 1; // start
            for (; ; )
            {
                if (i <= 10)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                        ++i;
                    }
                    else
                    {
                        ++i;
                        continue; // skip current iteration and go to end of loop
                    }
                    
                }
                else
                    break; // exit loop
            }





            #endregion
        }
    }
}
