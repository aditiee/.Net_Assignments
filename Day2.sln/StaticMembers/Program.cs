using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.s_Display();
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;
            Class1.s_i = 1234;
            Console.WriteLine(Class1.s_i);
            Console.ReadLine();
            Class1.s_Display();
            Console.ReadLine();

            Class1.s_P1 = 10;
            Console.WriteLine(Class1.s_P1);

            Console.BackgroundColor = ConsoleColor.Yellow;
        }
    }

    public class Class1
    {
        //static constructor
        static Class1()
        {
            Console.WriteLine("Static constructor!!");
        }


        public int i;
        //Static variable : one single copy for the class
        public static int s_i;

        //Static Method : why we need a static method ? - so that we dont need to create an instance of the class
        public void Display()
        {
            Console.WriteLine("Display");
            Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        //static method
        public static void s_Display()
        {
            Console.WriteLine("Static Display");
            //Console.WriteLine(i);
            Console.WriteLine(s_i);
        }


        //non-static property
        private int p1;//variable name begins with small

        public int P1//property name begins with Capital
        {
            set
            {
                //to set passed value is available as "value"
                if (value < 100)
                {
                    p1 = value;
                }
                else
                {
                    Console.WriteLine("Invalid P1");
                }


            }

            get
            {
                return p1;
            }
        }
        

        //Static property
        private static int s_p1;//variable name begins with small

        public static int s_P1//property name begins with Capital
        {
            set
            {
                //to set passed value is available as "value"
                if (value < 100)
                {
                    s_p1 = value;
                }
                else
                {
                    Console.WriteLine("Invalid P1");
                }


            }

            get
            {
                return s_p1;
            }
        }
    }
}
