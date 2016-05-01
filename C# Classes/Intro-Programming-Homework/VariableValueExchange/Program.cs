using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableValueExchange
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = b - a;
            a = a + a;
            Console.WriteLine("Stuff happened and then! ");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
