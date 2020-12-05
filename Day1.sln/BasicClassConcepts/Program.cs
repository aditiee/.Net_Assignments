using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program1
    {
        static void Main(string[] args)
        {
            Program2 p = new Program2();
            p.Add(1,2);
            Console.WriteLine(p.Add(1, 2, 3));
            Console.WriteLine(p.Add(10));
            Console.WriteLine("Aditi Gudadhe");

        }

    
    }

    public class Program2
    {
   //Right to Left
       public int Add(int a,int b=0)
        {
            return a + b;

        }

       public int Add(int a, int b,int c)
        {
            return a + b + c;

        }
    }
}

namespace BasicClassConcepts1
{
    class n1
    {
        void display()
        {
            Console.WriteLine("Namespace 2");
        }
    }

    class Program
    {
        void display()
        {
            Console.WriteLine("Namespace 2");
        }
    }
}
