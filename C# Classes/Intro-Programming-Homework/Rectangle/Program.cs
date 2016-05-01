using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a * b;
            double d = a * 2 + b * 2;
            Console.Write("{0:0.00}", c); Console.Write(" {0:0.00}", d);
        }
    }
}
