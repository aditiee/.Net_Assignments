using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticProperty s = new StaticProperty();
            s.Display();
            StaticProperty.DisplayStatic();
        }
    }

    class StaticProperty
    {
        //NON - STATIC PROPERTY 
        private int i;
        public int I
        {
            set
            {
                i = value;
            }

            get
            {
                return i;
            }
        }

        //STATIC PROPERTY
        private static int j = 2;
        public static int J
        {
            set
            {
                j = value;
            }

            get
            {
                return j;
            }
        }

        //NON-STATIC METHOD
        public void Display()
        {
            Console.WriteLine("NON-STATIC PROPERTY : " + I);
            Console.WriteLine("STATIC PROPERTY : " + J);
        }

        //STATIC METHOD
        public static void DisplayStatic()
        {
            //Console.WriteLine("NON-STATIC PROPERTY : " + I);
            Console.WriteLine("STATIC PROPERTY : " + J);
        }

    }


    
}
