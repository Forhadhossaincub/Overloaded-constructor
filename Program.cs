using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_constructor
{


    class MyClass
    {
        public int x;
        public MyClass()
        {
            Console.WriteLine("Inside MyClass().");
            x = 0;
        }
        public MyClass(int i)
        {
            Console.WriteLine("Inside MyClass(int).");
            x = i;
        }
        public MyClass(double d)
        {
            Console.WriteLine("Inside MyClass(double).");
            x = (int)d;
        }
        public MyClass(int i, int j)
        {
            Console.WriteLine("Inside MyClass(int, int).");
            x= i*j;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloaded_constructor Program");

            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass(50);
            MyClass t3 = new MyClass(50.0);
            MyClass t4 = new MyClass(50,50);

            Console.WriteLine($"t1.x is : {t1.x}");
            Console.WriteLine($"t2.x is : {t2.x}");
            Console.WriteLine($"t2.x is : {t3.x}");
            Console.WriteLine($"t3.x is : {t4.x}");
          
            Console.ReadKey();

        }
    }
}
