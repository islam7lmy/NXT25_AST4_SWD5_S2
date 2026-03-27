using Commen;
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
            Employee emp = new Employee();
            emp.SetName("123456789123456789123456789");
            Console.WriteLine(emp.GetName());

            emp.Salary = 1000;
            Console.WriteLine(emp.Salary);
            Console.WriteLine(emp.Deductions);

            emp.Salary = 20000000;
            Console.WriteLine(emp.Salary);
            Console.WriteLine(emp.Deductions);
            #endregion
            #region Ex03 : PhoneBook [Indexer]

            #endregion
            #endregion
        }
    }
}
