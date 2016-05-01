using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int thirdBit = (num & mask) >> 3;
            Console.WriteLine(thirdBit);
            

        }
    }
}
