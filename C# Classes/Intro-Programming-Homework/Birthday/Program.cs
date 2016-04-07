using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write your birthday in the format MM.DD.YYYY :\r\n ");
            DateTime Birthday = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
            DateTime today = DateTime.Now;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age)) age--;
            Console.WriteLine("Your are right now is :" + age);
            Console.WriteLine("Your age in 10 years will be: " + (age + 10));
        }

    }

}
