using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticConstr.Display();
            StaticConstr s = new StaticConstr();

           
        }
    }

    public class StaticConstr
    {
        static StaticConstr()
        {
            Console.WriteLine("STATIC CONSTRUCTOR GETS CALLED!!");
        }

        public static void Display()
        {
            Console.WriteLine("STATC METHODS GETS CALLED!");
        }

    }
}
