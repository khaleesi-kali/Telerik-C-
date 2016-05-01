using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            c = (string)c;
            Console.WriteLine(c);

        }
    }
}
