using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int cBit = 0;

            for (int i = b1; i < b1 + end; i++)
            {
                int mask = 1 << i;
                int firstBit = (int)((number & mask) >> i);

                mask = 1 << b2 + cBit;
                int secondBit = (int)((number & mask) >> b2 + cBit);

                if (firstBit == 0)
                {
                    mask = ~(1 << b2 + cBit);
                    number = (uint)(number & mask);
                }
                else if (firstBit == 1)
                {
                    mask = 1 << b2 + cBit;
                    number = (uint)(number | mask);
                }
                if (secondBit == 0)
                {
                    mask = ~(1 << i);
                    number = (uint)(number & mask);
                }
                else if (secondBit == 1)
                {
                    mask = 1 << i;
                    number = (uint)(number | mask);
                }
                cBit++;
            }
            Console.WriteLine(number);
        }
    }
}
