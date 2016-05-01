using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char cc = '\u00A9';
            Console.WriteLine("   "+ cc);
            Console.WriteLine();
            Console.WriteLine("  " + cc + " "+ cc + " ");
            Console.WriteLine();
            Console.WriteLine(" "+ cc + "   " + cc);
            Console.WriteLine();
            Console.WriteLine(cc + " "+ cc +" " + cc+ " "+cc);
        }
    }
}
