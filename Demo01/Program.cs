using System.Collections;
using System.Runtime.InteropServices;
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
            // e = --a + b * c / d; // a = 19 , e = 19 + 10 * 15 / 5; // e = 19 + 150 / 5; // e = 19 + 30; // e = 49
            //Console.WriteLine(e);
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
            #region Calculater
            //take number then opertation then number and show result
            //calculater do (+ - * / %)
            //write program to do that and make it protictive
            //int num1, num2;
            //char op;
            //double result;

            //Console.WriteLine("enter first number");
            //if (!int.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("invalid format for first number");
            //    return;
            //}
            //Console.WriteLine("enter operation (+ - * / %)");
            //if (!(char.TryParse(Console.ReadLine(), out op)
            //    &&
            //    (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')))
            //{
            //    Console.WriteLine("invalid format for operation");
            //    return;
            //}

            //Console.WriteLine("enter last number");
            //if (!int.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.WriteLine("invalid format for last number");
            //    return;
            //}
            //else if ((op == '/' || op == '%') && num2 == 0)
            //{
            //    Console.WriteLine("can not divide by zero");
            //    return;
            //}

            //switch (op)
            //{
            //    case '+': result = num1 + num2; break;
            //    case '-': result = num1 - num2; break;
            //    case '*': result = num1 * num2; break;
            //    case '/': result = (double)num1 / num2; break;
            //    case '%': result = num1 % num2; break;
            //    default: return;

            //}
            //Console.WriteLine($"{num1} {op} {num2} = {result}");
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

            #region For
            ///1. for loop
            // for (start; end; increment | decrement )
            //start = 1
            //end => if true go to body
            //execute body
            //increment i to 2
            //end => if true go to body

            //for (int i = 0; i <= 10 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1; // start
            //for (; ; )
            //{
            //    if (i <= 10)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //            ++i;
            //        }
            //        else
            //        {
            //            ++i;
            //            continue; // skip current iteration and go to end of loop
            //        }

            //    }
            //    else
            //        break; // exit loop
            //} 
            #endregion

            #region while
            ///2. while 
            //Console.WriteLine("insert 0 if you want to continue");
            //string input = Console.ReadLine();
            //while(input == "0")
            //{
            //    Console.WriteLine("hello");
            //    Console.WriteLine("insert 0 if you want to continue or any key if you want to exist");
            //    input = Console.ReadLine();
            //}


            //while (reader.Read())
            //{ 

            //}

            //while (true)
            //{
            //    //Console.WriteLine("insert first number");
            //    //double num1;
            //    //while (!double.TryParse(Console.ReadLine(), out num1))
            //    //{
            //    //    Console.WriteLine("wrong foramt, please insert first number");
            //    //}
            //    //Console.WriteLine("insert opration");
            //    //var op1 = Console.ReadLine();
            //    //Console.WriteLine("insert seconed number");
            //    //var num2 = Console.ReadLine();
            //    //var result = 0;
            //    //Console.WriteLine($"Eqution: {num1} {op1} {num2} = {result}");
            //    //Console.WriteLine("**********************************************");
            //}
            #endregion

            #region do while
            //for (int i = 11; i <= 10 ; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 11;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            //int choice;
            //do
            //{
            //    Console.WriteLine("insert (1) to add");
            //    Console.WriteLine("insert (2) to Exit");
            //    choice = int.Parse(Console.ReadLine());
            //}while (choice != 2);
            #endregion

            #region Foreach
            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};
            //for (int i = 0; i < names.Count; i++)
            //{
            //    names[i] = "t";
            //    Console.WriteLine(names[i]);
            //}
            ////VS

            ////collections
            //foreach (var item in names)
            //    item = "t";//not valid
            #endregion

            #region EX00
            //int num1, num2;
            //char op;
            //double result;
            //do
            //{
            //    Console.WriteLine("enter first number");
            //} while (!int.TryParse(Console.ReadLine(), out num1));

            //do
            //{
            //    Console.WriteLine("enter operation (+ - * / %)");
            //} while (!(char.TryParse(Console.ReadLine(), out op)
            //    &&
            //    (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')));

            //do
            //{
            //    Console.WriteLine($"enter last number{(op == '/' || op == '%' ? " and make sure not be zero" : "")}");
            //} while (
            //!int.TryParse(Console.ReadLine(), out num2)
            //||
            //((op == '/' || op == '%') && num2 == 0));


            //switch (op)
            //{
            //    case '+': result = num1 + num2; break;
            //    case '-': result = num1 - num2; break;
            //    case '*': result = num1 * num2; break;
            //    case '/': result = (double)num1 / num2; break;
            //    case '%': result = num1 % num2; break;
            //    default: return;

            //}
            //Console.WriteLine($"{num1} {op} {num2} = {result}");
            #endregion
            #endregion

            #region block scope
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////Console.WriteLine(i); // out of scope

            //while (double.TryParse(Console.ReadLine(), out double x))
            //{

            //}
            ////x = 3;// out of scope

            //if (double.TryParse(Console.ReadLine(), out double x))
            //{
            //    int y = 0;
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("hello");
            ////y = 0; // not valid
            //x = 3;

            //{
            //    int z = 0;
            //}

            #endregion

            #region Arrays
            #region one D Array
            //array is reference type
            //int[] numbers;
            // Declare for Reference from Type "Array of Integrs"
            // Refering to the default value of Reference Type = NULL
            // CLR Will Allocate 4 Bytes for The Reference at STACK
            // CLR Will Allocate Zero Bytes at HEAP  


            //numbers = new int[5];
            // CLR Allocate 20 Bytes at HEAP,
            // Intiailized with the default value of int = 0

            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

            //numbers[4] = 1;
            //numbers[5] = 2; //invalid
            //Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank}");


            ///read elments of arry from user 
            ///print elemnts of arry to user
            ///write program to do that with protictive code and readable messages

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    /*Console.WriteLine($"enter the {i + 1} element of array");
            //    if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("invalid input");
            //        i--;
            //    }*/

            //    Console.WriteLine($"enter the {i + 1} element of array");
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("invalid input");
            //    }

            //    /* do
            //     {
            //         Console.WriteLine($"enter the {i + 1} element of array");
            //     } while (!int.TryParse(Console.ReadLine(), out numbers[i]));*/
            //}

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Two D Array [Rectangular]
            //int[,] Marks;
            //Marks = new int[3, 5];
            //Console.WriteLine($"the size of array = {Marks.Length} , the number of dimensions = {Marks.Rank}");
            //Console.WriteLine($"number of rows = {Marks.GetLength(0)} , number of column = {Marks.GetLength(1)}");


            ///read elments of arry from user 
            ///print elemnts of arry to user
            ///write program to do that with protictive code and readable messages
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"insert array elemnt Marks[{i},{j}]");
            //        while (!int.TryParse(Console.ReadLine(), out Marks[i, j]))
            //        {
            //            Console.WriteLine("invalid input please reenter valid data");
            //        }
            //    }

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    int row = i / Marks.GetLength(1); // currnt row
            //    int column = i % Marks.GetLength(1); // currnt column
            //    Console.WriteLine($"insert array elemnt Marks[{row},{column}]");
            //    while (!int.TryParse(Console.ReadLine(), out Marks[row, column]))
            //    {
            //        Console.WriteLine("invalid input please reenter valid data");
            //    }
            //}

            //foreach (int i in Marks)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Two D Array [Judged]
            //int[][,] numbers;
            //numbers = new int[3][,];

            //numbers[0] = new int[3, 5]; //num1 => arr
            //numbers[1] = new int[1, 3]; //num2 => arr
            //numbers[2] = new int[2, 1]; //num3 => arr

            //Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank}");
            //Console.WriteLine($"the size of array = {numbers[0].Length} , the number of dimensions = {numbers[0].Rank}");
            //Console.WriteLine($"number of rows = {numbers[0].GetLength(0)} , number of column = {numbers[0].GetLength(1)}");

            //for ( int j = 0; j < numbers.Length; j++)
            //{
            //    for (int i = 0; i < numbers[j].Length; i++)
            //    {
            //        int row = i / numbers[j].GetLength(1); // currnt row
            //        int column = i % numbers[j].GetLength(1); // currnt column
            //        Console.WriteLine($"insert array elemnt numbers[{j}][{row},{column}]");
            //        while (!int.TryParse(Console.ReadLine(), out numbers[j][row, column]))
            //        {
            //            Console.WriteLine("invalid input please reenter valid data");
            //        }
            //    }
            //}

            //foreach (var arr in numbers)
            //{
            //    foreach(int i in arr)
            //        Console.WriteLine(i);
            //}

            //Point[] points = new Point[5];
            //points[0] = new Point(); //p1 = new point();
            //points[0].X = 10; //p1.x = 10;
            //points[0].Y = 10; //p1.y = 10;

            //points[1] = new Point(); // p2 = new point();
            //points[1].X = 10; //p2.x = 10;
            //points[1].Y = 10; //p2.y =10;
            #endregion
            #region Array Methods
            //int[] numbers = { 8, 3, 4, 5, 6, 7, 9, 7, 1, 3 };
            #region 1. Class Member Methods [Static Methods]
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers);

            //Point[] newarr = new Point[3];
            //newarr[0] = new Point();
            //newarr[1] = new Point();
            //newarr[2] = new Point();
            //Array.Clear(newarr);

            // Console.WriteLine(Array.IndexOf(numbers,7)); // find first index
            // Console.WriteLine(Array.LastIndexOf(numbers,7)); // find last index
            //var arr =  Array.CreateInstance(typeof(int), 10); //int[] arr = new int[];
            #endregion
            #region 2. Object Member Methods [Non-Static Methods]
            //int[] newarr = new int[15];
            //numbers.CopyTo(newarr, 2);
            //numbers.SetValue(18, 5);
            //Console.WriteLine(numbers[5]);

            //int[] dest = new int[numbers.Length];
            //numbers.CopyTo(dest, 0);


            //var dest = Array.CreateInstance(numbers.GetType().GetElementType(), numbers.Length);
            //numbers.CopyTo(dest, 0);
            #endregion
            //foreach (var i in dest)
            //{
            //    Console.WriteLine(i);
            //}


            ///Ex01: write a program find the longest distance between 
            ///Two equal cells.
            ///In this example.The distance is 
            ///measured by the number Of cells- for example

            //int size;
            //Console.WriteLine("enter size of array");
            //while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
            //{
            //    Console.WriteLine("wrong format, enter size of array");
            //}
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter the {i + 1} element of array");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.WriteLine($"wrong format, enter the {i + 1} element of array");
            //    }
            //}

            //int maxdist = -1;
            //foreach (int i in arr)
            //{
            //    int dist = Array.LastIndexOf(arr, i) - Array.IndexOf(arr, i) - 1;
            //    if(dist > maxdist)
            //        maxdist = dist;
            //}

            //Console.WriteLine(maxdist);

            #endregion
            #endregion

            #region Boxing vs UnBoxing 
            //// Boxing   : Casting from ValueType to ReferenceType
            //// UnBoxing : Casting from ReferenceType to ValueType

            //int is object
            //int x = 10;
            //object obj = x; // boxing => copy of data saved in x
            //x = 20;
            //Console.WriteLine(obj);

            //object[] data = new object[3];
            //data[0] = 10; //boxing 
            //data[1] = 3200.50m; //boxing
            //data[2] = "ali"; //not boxing

            //ArrayList list = new ArrayList();
            //list.Add(10); //boxing

            //List<int> ints = new List<int>();
            //ints.Add(10);

            ///unboxing
            //object obj = 10;
            //int x =(int) obj; //explict casting
            //Console.WriteLine(x);
            //double x =(double) obj;
            //Console.WriteLine(x);
            //int a = 10;
            //double b = a;

            //object O1 = new object();
            //O1 = "Ahmed"; //not boxing

            //O1 = 5;    // int[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 'A';  // char[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 3.3;  // double[ValueType] to object[ReferenceType] -> Boxing
            //O1 = true; // bool[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateTime();  // DateTime[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateOnly(); // DateOnly[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new TimeOnly(); // TimeOnly[ValueType] to object[ReferenceType] -> Boxing

            #endregion

            #region nullable types
            // NullableTypes : ValueTypes allows NULL as a Value
            // Assign Null as a Value for ValueType[int, char, bool, decimal, etc] Variables


            //int age = null; //invalid
            //int age = 0;

            //int? age = null; //nullable integer : allow int value + null
            //double? age1 = null;//nullable double : allow dounble value + null

            //int x = 8;
            //int? y = x;
            //y = null;
            ////x =(int) y; //explicit

            //if (y is not null)
            //    x =(int) y;

            //if (y.HasValue)
            //    x = y.Value;

            //x = y.HasValue ? y.Value : 0;

            /////null coalescing operator
            //x = y ?? 0;
            #endregion

            #region null propagation operator
            //int x = default; //0
            //int[] arr = default; //null

            //int length; //= arr.Length; //runtime error
            //if (arr is not null)
            //    length = arr.Length;

            //if (arr is not null)
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }

            //int? length = arr?.Length;
            //int length = arr?.Length ?? 0;

            // employee?.department?.deptname ?? "N/A"

            #endregion

            #region Functions
            #region prototype and calling
            //print line of 10 element of "#";
            //PrintLine();

            //print line of number inserted by user and pattern inserted by user
            //PrintLine(20,"$"); //passing parameters by postion 
            //PrintLine(pattern: "$",number: 20); //passing parameters by names 
            //PrintLine(, "$"); //invalid
            //PrintLine(pattern: "$"); //passing parameters by names
            #endregion

            #region value type
            //class memeber method function take two numbers and swap them
            //int x = 9; int y = 4;
            //Console.WriteLine($"before swap: x = {x} , y = {y}"); //9 ,4
            //SwapByValue(x, y);
            //Console.WriteLine($"after swap: x = {x} , y = {y}"); //9 ,4

            //Console.WriteLine("***********************By ref******************");

            //Console.WriteLine($"before swap: x = {x} , y = {y}"); //9 ,4
            //SwapByRef(ref x,ref y);
            //Console.WriteLine($"after swap: x = {x} , y = {y}"); //9 ,4
            #endregion

            #region reference type
            //write class memeber method take arr of int one diminssion and return sum of array element
            //int[] numarr = { 3, 5, 6 };
            //Console.WriteLine($"hashcode = {numarr.GetHashCode()}");
            //Console.WriteLine("******************passing by value********************");
            ////Console.WriteLine(SumArrayByValue(numarr)); //14
            ////Console.WriteLine(numarr[0]); //3 / 10 => 10
            //SumArrayByValue(numarr);
            //Console.WriteLine($"hashcode = {numarr.GetHashCode()}");
            //Console.WriteLine($"after initilize {numarr[0]}"); //3 / 1 => 3

            //Console.WriteLine("******************passing by ref********************");
            ////Console.WriteLine(SumArrayByRef(ref numarr)); //14
            ////Console.WriteLine(numarr[0]); //3 / 20 => 20 
            //SumArrayByRef(ref numarr);
            //Console.WriteLine($"hashcode = {numarr.GetHashCode()}");
            //Console.WriteLine($"after initilize {numarr[0]}"); //3 / 1 => 1
            #endregion

            #region passing by out
            //write class memeber method to take two integer numbers and return sum and mul
            //int a = 1 , b = 2 , sum , mul;
            //SumMul(a, b, out sum, out mul);
            //SumMul(a, b, out _, out mul);

            //SumMulByOut(a, b, out sum, out mul);

            //SumMulByRef(a, b, ref sum, ref mul);
            #endregion

            #region Params
            //int[] newarr = new int[] { 1, 2, 3, 4, 5, 6 };
            //SumArray(newarr);

            //Console.WriteLine(SumArray(new int[] { 1, 2, 3, 4, 5, 6 }));

            //Console.WriteLine(SumArrayWithParams(1, 2, 3, 4, 5, 6));

            #region Ex : Enum + params
            //CalculateBill(14, 12, Menu.Pizaa, Menu.Juice, Menu.Salad, Menu.Dessert);
            #endregion
            #endregion
            #endregion

            #region Exceptions Handling
            //try
            //{
            //    DoSomeCode();
            //}
            ////catch (Exception ex)
            ////{
            ////    //throw;
            ////    Console.WriteLine(ex.Message);
            ////}
            //finally
            //{
            //    //[Release | Deallocate | Delete | Close] unmanaged resources (databaseconnection , file)
            //    Console.WriteLine("finally");
            //}
            //Console.WriteLine("program is still running");
            #endregion

            #region Enums
            #region Ex01
            //Days day = Days.thr;
            //Console.WriteLine(day.ToString());
            //Console.WriteLine((int)day);
            //day =(Days) 10;
            //Console.WriteLine(day.ToString());
            //Point p1 = new Point();
            //Console.WriteLine(p1.ToString()); 
            #endregion

            #region Ex02
            //Console.WriteLine((int) Gender.Male);
            //Console.WriteLine((int) Gender.male);
            //Console.WriteLine((int) Gender.M);
            //Console.WriteLine((int) Gender.m);
            #endregion
            #endregion
        }

        #region Functions

        #region prototype and calling
        /// <summary>
        /// object memeber method
        /// </summary>
        //public void PrintLine() 
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine("");
        //}


        /// <summary>
        /// class memeber method
        /// </summary>
        //public static void PrintLine()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine("");
        //}

        //public static void PrintLine(int number, string pattern)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine("");
        //}

        //public static void PrintLine(int number = 10, string pattern = "#")
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine("");
        //}
        #endregion

        #region value type

        /// passing by value
        //static void SwapByValue(int num1 , int num2)
        //{
        //    Console.WriteLine($"inner function,before Swap By Value: x = {num1} , y = {num2}");
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine($"inner function,after Swap By Value: x = {num1} , y = {num2}");
        //}

        ///// passing by ref
        //static void SwapByRef(ref int num1,ref int num2)
        //{
        //    Console.WriteLine($"inner function,before Swap By Ref: x = {num1} , y = {num2}");
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine($"inner function,after Swap By Ref: x = {num1} , y = {num2}");
        //}

        #endregion

        #region reference type
        ////passing by value
        //static int SumArrayByValue(int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[3] { 1, 2, 3 };
        //    foreach (int i in Arr)
        //    {
        //        sum += i;
        //    }
        //    //Arr[0] = 10;
        //    return sum;
        //}

        ////passing by ref
        //static int SumArrayByRef(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[3] { 1, 2, 3 };
        //    foreach (int i in Arr)
        //    {
        //        sum += i;
        //    }
        //   // Arr[0] = 20;
        //    return sum;
        //}
        #endregion

        #region passing out
        //static void SumMulByOut (int x, int y,out int sum,out int mul)
        //{
        //    //sum = default;
        //    //mul = default;
        //    sum = x + y;
        //    mul = x * y;
        //}

        //static void SumMulByRef(int x, int y, ref int sum, ref int mul)
        //{
        //    //sum = default;
        //    //mul = default;
        //    //sum = x + y;
        //    //mul = x * y;
        //}
        #endregion

        #region params
        //static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int i in arr)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //static int SumArrayWithParams(string x, params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int i in arr)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        #region Ex : Enum + params
        ///class member method take tax and service and all ordered items 
        ///print the shape as bellow:
        /// order details :
        /// pizza : 120
        /// juice : 60
        /// ـــــــــــــــــــ
        /// total item : 180
        /// tax : (total item * (tax / 100))
        /// service : (total item * (service  / 100))
        /// ـــــــــــــــــــ
        /// total oreder : total + tax + service
        /// return total + tax + service;

        //static double CalculateBill(int tax, int service,params Menu[] items)
        //{
        //    double total = 0, taxinmony = 0 , serviceinmony = 0;
        //    Console.WriteLine("order details :");
        //    foreach (Menu item in items)
        //    {
        //        Console.WriteLine($"{item} : {(int)item}");
        //        total += (int)item;
        //    }
        //    Console.WriteLine("ــــــــــــــــــ");
        //    Console.WriteLine($"total items : {total}");
        //    taxinmony = (total * ((double)tax / 100));
        //    Console.WriteLine($"tax : {taxinmony}");
        //    serviceinmony = (total * ((double)service / 100));
        //    Console.WriteLine($"service : {serviceinmony}");
        //    Console.WriteLine("ــــــــــــــــــ");
        //    total += taxinmony + serviceinmony;
        //    Console.WriteLine($"total order :{total}");
        //    return total;
        //}

        #endregion
        #endregion
        #endregion

        #region Exceptions Handling
        //static void DoSomeCode()
        //{
        //    int x, y, z;

        //    Console.WriteLine("please enter first number: ");
        //    x = int.Parse(Console.ReadLine());

        //    Console.WriteLine("please enter last number: ");
        //    y = int.Parse(Console.ReadLine());

        //    z = x / y;

        //    Console.WriteLine($"result is : {z}");

        //    int[] arr = { 1, 2, 3 };

        //    Console.WriteLine("please enter index number to change it's value: ");
        //    int index = int.Parse(Console.ReadLine());

        //    arr[index] = 99;
        //}

        //static void DoSomeProtictiveCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        do
        //        {
        //            Console.WriteLine("please enter first number: ");
        //        } while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.WriteLine("please enter last number: ");
        //        } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

        //        z = x / y;

        //        Console.WriteLine($"result is : {z}");

        //        int[] arr = { 1, 2, 3 };
        //        int index;
        //        do
        //        {
        //            Console.WriteLine("please enter index number to change it's value:");
        //        } while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= arr.Length);
        //        arr[index] = 99;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion
    }

    #region Enums [labels]
    //enum Days : int
    //{
    //    sat = 0,
    //    sun = 1,
    //    mon = 2,
    //    tus = 3,
    //    wed = 4,
    //    thr = 5,
    //    fri = 6
    //}

    //enum Gender : int
    //{
    //    Male = 1, male = 1, M = 1, m = 1, Female = 2, female = 2, F = 2, f = 2
    //}

    //enum Branches : byte // 0 => 255
    //{
    //    smartvally = 105, gamasa = 201, _6oct = 252, mansoura = 253, asyuit = 254, banha = 255
    //}

    //enum Menu
    //{
    //    Pizaa = 120,
    //    Burger = 150,
    //    Juice = 40,
    //    Salad = 30,
    //    Dessert = 60
    //}

    #region Permissions

    #endregion
    #endregion
}
