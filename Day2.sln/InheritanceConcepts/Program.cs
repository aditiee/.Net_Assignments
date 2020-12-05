using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    class Program
    {
       public static void Main(string[] args)
        {
            //BaseClass o = new BaseClass();
            DerivedClass o = new DerivedClass();
                      
        }

        public class BaseClass : Object //by default it will inherit from the object class
        {
            public int a;

        }
        public class DerivedClass : BaseClass
        {
            public int b;

        }
    }
}

/*namespace InheritanceConcepts2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass o = new BaseClass();
            
            //DerivedClass o = new DerivedClass();
            

        }

        public class BaseClass : Object //by default it will inherit from the object class
        {
            public int PUBLIC;
            private int PRIVATE;
            protected int PROTECTED;
            internal int INTERNAL;
            protected internal int PROTECTED_INTERNAL;

        }
        public class DerivedClass : BaseClass
        {
            void DoNothing()
            {
             
            }

        }
    }
}*/
