using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main()
        {
            for (int c = 33; c <= 126; c++)
            {
                Console.Write((char)c);
            }
            Console.WriteLine();
        }
    }
}
