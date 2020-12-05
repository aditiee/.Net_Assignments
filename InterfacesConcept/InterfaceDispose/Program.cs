using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Class1 o = new Class1())
            {    
                o.Display();
            }
                Console.ReadLine();
        }
    }

    class Class1 : IDisposable
    {
        public void Display()
        {
            CheckForDisposed();
            Console.WriteLine("Class1 Display Method");
        }


    private void CheckForDisposed()
        {
            if(isDisposed)
            {
                throw new ObjectDisposedException("Class1");
            }
        }
        public bool isDisposed=false;
        public void Dispose()
        {
            Console.WriteLine("Dispose Method Called For Freeing Resources ");
            isDisposed = true;
        }
    }
}
