# Telerik C# course homework projects



even numbers program


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Enter number to compare");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else {
                Console.WriteLine("the nimber is odd");
            }


           
        }
    }
}
