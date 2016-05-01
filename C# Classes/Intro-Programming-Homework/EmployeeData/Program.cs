using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main()
        {
             string firstName;
            string familyName;
            byte age;
            char gender;
            string IDnumber;
            uint uniqueEmployeeNumber;

            firstName = "Kali";
            familyName = "St";
            age = 23;
            gender = 'f';
            IDnumber = "823232";
            uniqueEmployeeNumber = 27560000;
            Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}",firstName,familyName,age,gender,IDnumber,uniqueEmployeeNumber);
        }
    }
}
