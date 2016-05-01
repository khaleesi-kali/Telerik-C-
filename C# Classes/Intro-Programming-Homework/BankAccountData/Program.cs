using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName;
            string middleName;
            string lastName;
            int balance;
            string bankName;
            string iban;
            string credCN1;
            string credCN2;
            string credCN3;

            firstName = "Kali";
            middleName = "B";
            lastName = "St";
            balance = 1223123;
            bankName = "UniCredit";
            iban = "2321312";
            credCN1 = "223232";
            credCN2 = "34234234";
            credCN3 = "23232323";

            Console.WriteLine("{0} {1} {2} \n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName,lastName,balance,bankName,iban,credCN1,credCN2,credCN3);
        }
    }
}
