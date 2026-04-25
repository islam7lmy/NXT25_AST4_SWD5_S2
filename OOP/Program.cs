//using Commen;
using OOP.Inhertiance;
using OOP.InterFaces;
using OOP.PolyMorphism_OverRiding;
using System;
using System.Drawing;
using System.Xml.Linq;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            /// Access Modifiers Types
            /// 1. private
            /// 2. private protected => inhertance
            /// 3. protected => inhertance
            /// 4. internal
            /// 5. internal protected => inhertance
            /// 6. public

            ///rank r = rank.first; 
            /// not valid because it's internal 
            /// only avilable in same asembly

            //TypeA a = new TypeA();
            /// valid because it's public 
            /// avilable in all asemblies
            //a.x = 10; //invalid because it's private
            //a.y = 1; //invalid because it's internal
            //a.z = 2; //valid because it's public


            //TypeC C = new TypeC();
            //C.x = 10; //invalid because it's private
            //C.y = 1; //invalid because it's internal
            //C.z = 2; //valid because it's public
            #endregion

            #region Struct
            #region Ex01: Point
            //Point p1;
            ///// allocate 8 unitialized bytes in stack
            ///// Console.WriteLine(p1); // invalid because not intilized

            //p1.x = 10;
            //p1.y = 20;
            //Console.WriteLine(p1);


            ////p1 = new Point();
            ///// new keyword just for Constructor Selection  
            ///// that will initialize the attributes of struct

            ////p1 = new Point(10 , 20);
            #endregion
            #region Ex02: Employee
            //Employee emp = new Employee();
            //emp.SetName("123456789123456789123456789");
            //Console.WriteLine(emp.GetName());

            //emp.Salary = 1000;
            //Console.WriteLine(emp.Salary);
            //Console.WriteLine(emp.Deductions);

            //emp.Salary = 20000000;
            //Console.WriteLine(emp.Salary);
            //Console.WriteLine(emp.Deductions);

            //emp.Age = 30; //invalid because the setter is private
            //Console.WriteLine(emp.Age); // valid because the getter is public
            #endregion
            #region Ex03 : PhoneBook [Indexer]
            //list of names[0] and numbers[0] => 1st contact
            //names[1] and numbers[1] => 2nd contact

            //PhoneBook book = new PhoneBook();
            //Console.WriteLine(book.ToString()); // valid because the method is public

            //book.AddContact("Ahmed", "01000000000");
            //book.AddContact("Mohamed", "01111111111");
            //book.AddContact("Ali", "01222222222");
            //book.AddContact("Omar", "01555555555"); //invalid because the phone book is full
            //Console.WriteLine(book.ToString());


            //book.SetNumber("Ahmed", "01099999999"); // valid because the method is public
            //Console.WriteLine(book.GetNumber("Ahmed")); // valid because the method is public

            //book["Mohamed"] = "01199999999"; // valid because the indexer is public
            //Console.WriteLine(book["Mohamed"]); // valid because the indexer is public

            //for (int i = 0; i < book.Count; i++)
            //    Console.WriteLine(book[i]);
            #endregion
            #endregion

            #region Class
            #region EX: Car
            //Car car;
            /// declare a reference variable of type Car refer to null
            /// allocate 4 unitialized bytes in stack
            /// zero bytes in heap for the object

            //car.Id = 1; // invalid because car is null
            //car.Model = "BMW"; // invalid because car is null
            //car.Speed = 200; // invalid because car is null

            ///car = new Car();
            ///new
            ///1. allocate required bytes in heap for the object
            ///2. initialize the attributes of the object with default values
            ///3. call user defined constructor if exist

            //car = new Car(1, "BMW", 200);
            //car.Id = 2;
            //car.Model = "Mercedes";
            //car.Speed = 250;


            //Car car1 = new Car(); //
            //Console.WriteLine();
            //Car car2 = new Car(20); //
            //Console.WriteLine();
            //Car car3 = new Car(30, "Mercedes"); //
            //Console.WriteLine();
            //Car car4 = new Car(40, "Audi", 300); //
            #endregion
            #region Inhertance
            //object obj = new object();
            //obj.ToString(); // valid because it's public
            //obj.GetHashCode(); // valid because it's public
            //obj.Equals(obj); // valid because it's public
            //obj.GetType(); // valid because it's public


            //Parent parent = new Parent(10);
            //Child child = new Child(20, 30);
            #endregion
            #region realtionship Between Calsses
            ///inhertance child is parent, dog is an animal
            ///aggregation has a
            ///1. Compostion => room has walls
            ///2. association => room has chairs
            #endregion
            #region Class vs Struct
            //Car c1 = new Car();
            //Car c2 = c1; // shallow copy => both c1 and c2 refer to the same object in heap
            //c2.Id = 99;
            //Console.WriteLine(c1.Id); // 99 because c1 and c2 refer to the same object in heap
            /////Reference type => stored reference in stack and object in heap
            /////Supports inheritance => [all access modifers]
            /////clr will always generate empty parameterless constructor ,if no user-defined constructor exists
            /////clr will no longer generate empty parameterless constructor, if u write user-defined constructor
            //// default constructor => do nothing 
            /////Used for complex objects and behavior


            //Point p1 = new Point();
            //Point p2 = p1; // deep copy => p2 is a copy of p1 and refer to a different object in heap
            //p2.x = 99;
            //Console.WriteLine(p1.x); // 0 because p1 and p2 refer to different objects in heap
            /////Value type => Stored on the stack
            /////Cannot inherit from another class =>  [private, internal, public]
            /////clr will always Generate Parameterless Constructor
            //// default constructor => initialize the attributes of struct with their default values
            /////Often used for small, simple data => recomanded 16 bytes or less
            #endregion
            #endregion

            #region PolyMorphism
            #region Overlodaing
            //int num1 = 10, num2 = 20;
            //Sum(num1, num2); //two integer numbers

            //double num3 = 10, num4 = 20;
            //Sum(num3, num4);

            //float num5 = 10, num6 = 20;
            //Sum(num5, num6);
            #endregion
            #region OverRiding
            //TypeA typeA = new TypeA(10);
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(10,20);
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion
            #endregion

            #region Binding
            //Employee emp;
            /////allocat 4 bytes for reference from type employee refere to null

            //emp = new Employee();
            ///// allocat object in heap

            #region What is binding
            /// reference from base type => object from drived type
            //Employee emp01 = new FullTimeEmployee(); //binding
            //emp01.Id = 10;
            //emp01.Name = "ahmed";
            //emp01.Age = 30;
            ////emp01.Salary = 10; //notvalid
            //emp01.MyFun01();
            //emp01.MyFun02();

            //Employee emp02 = new PartTimeEmployee(); //binding
            //emp02.Id = 10;
            //emp02.Name = "ahmed";
            //emp02.Age = 30;
            ////emp02.HourRate = 10; //notvalid
            ////emp02.CountOfHours = 10; //notvalid
            //emp02.MyFun01();
            //emp02.MyFun02();

            //Employee emp03 = new FreeLanceEmployee(); //binding
            //emp03.Id = 10;
            //emp03.Name = "ahmed";
            //emp03.Age = 30;
            ////emp03.Project = 10; //notvalid
            //emp03.MyFun01();
            //emp03.MyFun02();
            #endregion

            #region NotBinding
            //FullTimeEmployee fullTimeEmployee01 = (FullTimeEmployee)new Employee(); //not binding

            #endregion

            #region Why binding
            //int x = 5;
            //int y = 10;
            //y = x;
            //y = 30;
            //Console.WriteLine(x); //5

            //FullTimeEmployee fullTimeEmployee01 = new FullTimeEmployee();

            //FullTimeEmployee fullTimeEmployee02 = new FullTimeEmployee();

            //fullTimeEmployee02 = fullTimeEmployee01;/// will copy address

            //Employee employee01 = fullTimeEmployee01; /// will copy address

            ////int y = 15;
            ////object x = y;
            //object xx = new FullTimeEmployee();
            ////ProcessEmployee(employee01);

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //ProcessEmployee(fullTimeEmployee);
            /////myfun01(); // static => will run ralted to reference
            /////myfun02(); // dynamic => will run ralted to object


            //fullTimeEmployee.MyFun01();
            //fullTimeEmployee.MyFun02();

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee);
            /////myfun01(); // dynamic => will run ralted to object
            /////myfun02(); // static => will run ralted to reference

            //FreeLanceEmployee freeLanceEmployee = new FreeLanceEmployee();
            //ProcessEmployee(freeLanceEmployee);
            /////myfun01(); // dafult => will run ralted to reference
            /////myfun02(); // dafult => will run ralted to reference
            #endregion

            #region More Practise on Binding
            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 11;
            ////typeA.B = 22; //not valid
            ////typeA.C = 33; //not valid
            //typeA.MyFun01(); // out put //I am Base [Parent]
            //typeA.MyFun02(); // out put //TypeC : A = 11 , B = 2 , C = 3

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 11;
            //typeB.B = 22;
            ////typeB.C = 33; //not valid
            //typeB.MyFun01(); // out put //I am Base [Child]
            //typeB.MyFun02(); // out put //TypeC : A = 11 , B = 22 , C = 3

            //TypeA typeA = new TypeD(1, 2, 3, 4);//TypeC : A = 1 , B = 22 , C = 3
            //TypeB typeB = new TypeD(1, 2, 3, 4);//TypeC : A = 1 , B = 22 , C = 3
            //TypeC typeC = new TypeD(1, 2, 3, 4);//TypeC : A = 1 , B = 22 , C = 3

            //typeA.MyFun02();
            //typeB.MyFun02();
            //typeC.MyFun02();


            //TypeA typeA1 = new TypeE(1,2,3,4,5);
            //TypeB typeB1 = new TypeE(1,2,3,4,5);
            //TypeC typeC1 = new TypeE(1,2,3,4,5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD3 = new TypeF(1, 2, 3, 4, 5);

            //typeA1.MyFun02();//TypeC : A = 1 , B = 22 , C = 3
            //typeB1.MyFun02();//TypeC : A = 1 , B = 22 , C = 3
            //typeC1.MyFun02();//TypeC : A = 1 , B = 22 , C = 3
            //typeD1.MyFun02();//TypeD : A = 1 , B = 2 , C = 3 , D = 4
            //typeD2.MyFun02();//TypeE : A = 1 , B = 2 , C = 3 , D = 4 , E = 5
            //typeD3.MyFun02();//TypeE : A = 1 , B = 2 , C = 3 , D = 4


            #endregion

            #endregion

            #region InterFaces
            #region Ex01
            //IMyType myType = new IMyType(); //notvalid
            //myType.Salary = 20;
            //myType.MyFun();

            //IMyType myType = new MyType(); //binding
            //IMyType myType = new MyTypev2(); //binding
            //myType.Salary = 20;
            //myType.MyFun();
            //myType.Print();

            //MyType myType01 = new MyType(); //binding
            //myType01.Salary = 20;
            //myType01.MyFun();
            //myType01.Print();//not valid
            #endregion
            #region Ex02
            //SeriesByTwo series02 = new SeriesByTwo();
            //Print10NumbersFromSeries(series02);

            //SeriesByThree series03 = new SeriesByThree();
            //Print10NumbersFromSeries(series03);

            //SeriesByFive series05 = new SeriesByFive();
            //Print10NumbersFromSeries(series05);

            //SeriesBySix series06 = new SeriesBySix();
            //Print10NumbersFromSeries(series06);
            #endregion
            #region Implment Interface Implicitly Vs Implment Interface Explicitly
            //InterFaces.Car car = new InterFaces.Car();
            //car.Speed = 20;
            //car.Backward();
            //car.Forward();
            //car.Right();
            //car.Left();


            //AirPlan plan = new AirPlan();
            //plan.Speed = 80;
            ////plan.Backward(); // not valid //explicit implmintation

            //IMoveable moveablePlan = plan;
            //moveablePlan.Backward();
            //moveablePlan.Forward();
            //moveablePlan.Right();
            //moveablePlan.Left();

            //IFlayable flayablePlan = plan;
            //flayablePlan.Backward();
            //flayablePlan.Forward();
            //flayablePlan.Right();
            //flayablePlan.Left();
            #endregion
            #region Shallow Copy vs Deep Copy
            //int x = 10;
            //int y = 20;
            //y = x;
            //y = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            //Arr02[0] = 90; 
            #endregion

            #region Deep Copy
            //int[] test = (int[]) (new object());
            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            //Arr02[0] = 90;
            #endregion

            //foreach (int i in Arr01)
            //{
            //    Console.Write(i);
            //    Console.Write("\t");
            //}
            //Console.WriteLine();
            //foreach (int i in Arr02)
            //{
            //    Console.Write(i);
            //    Console.Write("\t");
            //}
            #endregion

            #region Built-In Interface ICloneable
            //InterFaces.Employee emp01 = new InterFaces.Employee();
            //emp01.Id = 20;
            //emp01.Name = "ahmed";
            //emp01.Salary = 8000;
            //emp01.Address = "Cairo";


            //InterFaces.Employee emp02 = new InterFaces.Employee()
            //{
            //    Id = 10,
            //    Name = "Ali",
            //    Salary = 4000,
            //    Address = "Alex"
            //};

            //Console.WriteLine($"Emp01: {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02: {emp02.GetHashCode()}");

            #region Shallow copy
            //emp02 = emp01;
            //Console.WriteLine("After shallow");
            //Console.WriteLine($"Emp01: {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02: {emp02.GetHashCode()}"); 
            #endregion
            #region Deep Copy
            //emp02 = InterFaces.Employee.DeepCopy(emp01);
            //emp02 = new InterFaces.Employee(emp01);
            //emp02 = (InterFaces.Employee) emp01.Clone();
            //Console.WriteLine("After Deep");
            //Console.WriteLine($"Emp01: {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02: {emp02.GetHashCode()}");
            #endregion
            //emp02.Id = 99;
            //Console.WriteLine($"Emp01: {emp01}");
            //Console.WriteLine($"Emp02: {emp02}");
            #endregion

            #region Built-In Interface IComparable

            #endregion
            #endregion

            #region Abstract

            #endregion

            #region Operator Overloading

            #endregion

            #region User-Defined Casting Operator

            #endregion
        }

        #region PolyMorphism 1. function overloading
        ///1. datatype of paramaters
        ///2. Count number of paramaters
        ///3. reorder paramaters if not same datatype

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int y, short x)
        {
            return x + y;
        }

        public static int Sum(short y, int x)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static int Sum(double x, double y)
        {
            return (int)(x + y);
        }

        public static int Sum(float x, float y)
        {
            return (int)(x + y);
        }

        public static double SumDoubles(double x, double y)
        {
            return x + y;
        }

        public static float SumFloat(float x, float y)
        {
            return x + y;
        }
        #endregion


        #region Binding
        public static void ProcessEmployee(PolyMorphism_OverRiding.Employee emp)
        {
            if (emp is not null)
            {
                emp.MyFun01();
                emp.MyFun02();
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if(emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}
        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}
        //public static void ProcessEmployee(FreeLanceEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}
        #endregion

        #region Interfaces
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(series.Current);
                    Console.Write("\t");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }
        }

        //public static void Print10NumbersFromSeries(SeriesByThree series)
        //{
        //    if (series is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.Write(series.Current);
        //            Console.Write("\t");
        //            series.GetNext();
        //        }
        //        series.Reset();
        //        Console.WriteLine();
        //    }
        //}

        //public static void Print10NumbersFromSeries(SeriesByFour series)
        //{
        //    if (series is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.Write(series.Current);
        //            Console.Write("\t");
        //            series.GetNext();
        //        }
        //        series.Reset();
        //        Console.WriteLine();
        //    }
        //}
        #endregion

    }
}
