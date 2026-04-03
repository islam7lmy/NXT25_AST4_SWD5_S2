using Commen;
using OOP.Inhertiance;
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

            #endregion
            #region OverRiding
            /// static binded

            ///dynamic binded
            #endregion
            #endregion

            #region Binding

            #endregion
        }


    }
}
