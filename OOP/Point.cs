using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Class Or Struct?
        /// 1. variables => fields (Attributes)
        /// 2. functions => Methods
        /// 3. Constructor => special method
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers

        public int x;
        public int y;

        // clr will always generate paramaterless constructor
        public Point()
        {
            x = default;
            y = default;
        }

        /// to initialize all attributes with default value based on it's daatatype
        /// You Can't Create User-Defined Parameterless Constructor Inside Struct (Except C# 10.0)


        /// user defined constructor
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
