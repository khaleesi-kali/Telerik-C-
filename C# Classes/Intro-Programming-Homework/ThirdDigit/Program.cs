using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            char[] n = number.ToCharArray();
            Array.Reverse(n);

            if (number.Length < 3)
            {
            Console.WriteLine("false 0");
            }
            else if (n[2] == '7')
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false {0}", n[2]);
            }

        }
    }
}
