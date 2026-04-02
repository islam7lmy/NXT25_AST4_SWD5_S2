using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        public int Id;
        // encapsulation : seprate the data defintion (attributes) from it's usage (GetterSetter or Property)
        #region Name [Getter Setter Method]
        string name; //length 20

        /// getter for name attribute
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value.Length <= 20 ? value : value.Substring(0, 20);
        }
        #endregion

        #region 1. full property [attribute + property]
        decimal salary; //field
        public decimal Salary
        {
            get { return salary; }
            set { salary = value < 2000 ? 2000 : value; }
        }
        #endregion
        #region 2. automatic property [backingfield + property]
        //int age;

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        /// clr Will Generate Backing Field [Hidden Private Attribute]
        //public int Age; // field [Attribute]
        public int Age { get; private set; }

        /// deduction is 20% of salary
        public decimal Deductions { get { return Salary * .2m; } }
        #endregion

        public Employee(int _id, string _name, decimal _salary, int _age)
        {
            Id = _id;
            SetName(_name);
            Salary = _salary;
            Age = _age;
        }
    }
}
