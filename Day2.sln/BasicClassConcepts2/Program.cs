using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 o;
            //o=new Class1();
            Class1 o = new Class1();
            Console.WriteLine();
            Class1 o2 = new Class1(5);
            Console.WriteLine(o.P1);
            Console.WriteLine(o2.P1);
            o = null;
            o2 = null;
            Console.ReadLine();
            GC.Collect();//This is the way we call the garbage collector
            Console.ReadLine();
        }
        static void Main1()
        {
            Class1 c = new Class1();
            //Console.WriteLine(c.i = 100);
            //c.i=100;


            /* c.SetI(100);
             Console.WriteLine(c.GetI());
             Console.ReadLine();*/

            c.P1 = 10;
            Console.WriteLine("Value : " + c.P1);
            c.P2 = "Aditi";
            Console.WriteLine("Value : " + c.P2);

            //c.P3=new;
            Console.WriteLine("Read only Property : " +c.P3);
            Console.ReadLine();
            c.P4 = 123;
            Console.WriteLine("Auto properties : " + c.P4);
        }
    }

    public class Class1
    {
        #region Properties
        // public int i;
        private int i;

        //to validate something we do it using setter and getter method
        /* public void SetI(int x)
         {
             if(x<100)
             {
                 i = x;

             }
             else
             {
                 //throw an exception here
                 Console.WriteLine("Invalid value");
             }
         }

         public int GetI()
         {
             return i;
         }
        */

        //instead of this create a property

        //property
        private int p1;//variable name begins with small

        public int P1//property name begins with Capital
        {
            set
            {
                //to set passed value is available as "value"
                if(value < 100)
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

        /* private string p2;
         public string P2
         {
             set
             {
                 p2 = value;
             }
             get
             {
                 return p2;
             }
         }
        */

        //Class level variables are called as "Fields"
        public string P2;


        //Read only property
        private string p3="Aditi";
        public string P3
        {
          
            get
            {
                return p3;
            }
        }

        //auto property
        public int P4
        {
            //compiler will generate the variable for you
            //first generates the private variable and also generates the code for it
            set;
            get;
        }

        #endregion

        #region Constructors
        //Constructor
        public Class1()
        {
            Console.WriteLine("No Parameter Constructor");
           
        }
        public Class1(int P1)
        {
            //P1=a;
           // p1 = a;
            Console.WriteLine(" Parameter Constructor");
            this.P1 = P1;
          
        }
        #endregion

        ~Class1()
        {
            Console.WriteLine("Destructor");
        }
    }
}
