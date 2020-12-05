using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesConcepts
{
    class Property
    {
        public int a = 1;
        private int b ;

        public void set(int b)
        {
            if(b > 5)
            {
                this.b = b;
            }
            else
            {
                Console.WriteLine("Invalid NORMAL!");
            }
        }

       public int get()
        {
            return b;
        }
        private int c = 3;
        public int C
        {
            set
            {
        if(value >0)
        {
                b = value;
        }
        else
        {
        Console.WriteLine("Invalid PROPERTY!");
        }
            }

            get
            {
                return b;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Property p = new Property();
            Console.WriteLine("Public a : " + p.a);
            Console.WriteLine("Private c: " + p.C);
            Console.WriteLine("-------");
            
             p.set(2);
            Console.WriteLine("NORMAL b: " + p.get());


        }

    }
}
