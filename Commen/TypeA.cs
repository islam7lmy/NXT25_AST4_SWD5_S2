using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels => refer to number

    /// What You Can Write Inside The Class Or Struct?
    /// 1. variables => fields (Attributes)
    /// 2. functions => Methods
    /// 3. Constructor => special method
    /// 4. Properties
    /// 5. Events
    /// 6. Indexers

    /// What You Can Write Inside The Interface?
    /// 1. Method Signature
    /// 2. property Signature
    /// 3. event Signature
    /// 4. indexer signature
    /// 5. Default Implementation (C# 8.0 +)

    /// Allowed Access Modifiers Inside The Namespace 
    /// public
    /// internal [Default Access Modifier]

    enum rank
    {
        first, second, third, fourth, fifth, sixth, seventh
    }

    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class 
        /// 1. private [default] 
        /// 2. private protected => inhertance
        /// 3. protected => inhertance
        /// 4. internal
        /// 5. internal protected => inhertance
        /// 6. public

        int x; //private => allow to acces by class members
        internal int y;
        public int z;   

        void test()
        {
            rank r = rank.first;

            x = 10;
            y = 20;
            z = 30;
        }
    }
}
