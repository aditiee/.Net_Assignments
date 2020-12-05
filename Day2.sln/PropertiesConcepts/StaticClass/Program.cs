using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Member : " + StaticClass.Static_i);
        }
    }

    public static class StaticClass
    {
        //public int i = 1; cannot have non-static members and methods inside the static class
        public static int Static_i = 2;

        static StaticClass()
        {
            Console.WriteLine("Static Constructor get Called!!");
        }

        //can only have static members
        //cannot be instantiated
        //cannot be used as a base class


    }

    /*public class NormalClass : StaticClass
    {

    }*/


}