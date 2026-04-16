//using Commen;
using OOP.Inhertiance;
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

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            ProcessEmployee(fullTimeEmployee);
            ///myfun01(); // static => will run ralted to reference
            ///myfun02(); // dynamic => will run ralted to object


            fullTimeEmployee.MyFun01();
            fullTimeEmployee.MyFun02();

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee);
            /////myfun01(); // dynamic => will run ralted to object
            /////myfun02(); // static => will run ralted to reference

            //FreeLanceEmployee freeLanceEmployee = new FreeLanceEmployee();
            //ProcessEmployee(freeLanceEmployee);
            /////myfun01(); // dafult => will run ralted to reference
            /////myfun02(); // dafult => will run ralted to reference
            #endregion
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
        public static void ProcessEmployee(Employee emp)
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

    }
}
