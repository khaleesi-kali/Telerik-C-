using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            ulong m = ((ulong)1 << p);
            if (p >= 0 && p < 64)
            {
                if (v == 0)
                {
                    Console.WriteLine(n & ~m);
                }
                else
                {
                    Console.WriteLine(n | m);
                }
            }
        }
    }
}
