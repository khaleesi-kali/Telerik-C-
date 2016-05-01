using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1000)
            {
                Console.WriteLine("false");
            }
            int d = number % 10;
            int c = (number / 10) % 10;
            int b= (number / 100) % 10;
            int a = (number / 1000) % 10;
            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d + "" + c + "" + b + "" + a);
            Console.WriteLine(d + "" + a + "" + b + "" + c);
            Console.WriteLine(a+ "" + c + "" + b + "" + d);

        }
    }
}
