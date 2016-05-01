using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (a > 500 || a < -500 || b > 500 || b < -500 || h > 500 || h < -500)
            {
                Console.WriteLine("false");
            }
            double area = (a + b) * h / 2;
            Console.WriteLine("{0:F7}", area);
        }
    }
}
