using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void OldMain(string[] args)
        {
            Class1 o = new Class1();
            //Method 1
            o.Insert();
            o.Update();
            o.Delete();
            o.Display();
            Console.WriteLine();

            //Method 2
            //Reference to the interface
            IDbFunctions oIDb;//implicity creating refrenece
            oIDb = o;
            oIDb.Insert();

            Console.WriteLine();

            //Method 3
            ((IDbFunctions)o).Delete();//Explicity creating reference

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Method1
            Class1 o1 = new Class1();
            //o1.Insert();
            Class2 o2 = new Class2();
            //o2.Insert();

            InsertMethod(o1);//calling class1 instance
            InsertMethod(o2);

          
            IDbFunctions oIDb;
            oIDb = o1;
           // oIDb.Insert();

            IDbFunctions oIDb2;
            oIDb2 = o2;
            //oIDb2.Insert();

        }

        static void InsertMethod(IDbFunctions oIDb)
        {
            oIDb.Insert();
        }


        public interface IDbFunctions
        {
           
            void Insert();
            void Update();
            void Delete();

           


        }

        public class Class1 : IDbFunctions
        {
            public void Display()
            {
                Console.WriteLine("Class1 - Display");
            }
            public void Delete()
            {
                Console.WriteLine("Class1 - IDb.Delete");
            }

            public void Insert()
            {
                Console.WriteLine("Class1 - IDb.Insert");
            }

            public void Update()
            {
                Console.WriteLine("Class1 - IDb.Update");
            }
        }

        public class Class2 : IDbFunctions
        {
            public void Display()
            {
                Console.WriteLine("Class2 - Display");
            }
            public void Delete()
            {
                Console.WriteLine("Class2 - IDb.Delete");
            }

            public void Insert()
            {
                Console.WriteLine("Class2 - IDb.Insert");
            }

            public void Update()
            {
                Console.WriteLine("Class2 - IDb.Update");
            }
        }
    }
}
