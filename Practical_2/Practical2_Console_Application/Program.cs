using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_Account CA = new Customer_Account(99999999,"Deep");
            Console.WriteLine("Enter Bank Name : ");
            CA.bank_name = Console.ReadLine();
            Console.WriteLine("Enter Customer Name : ");
            CA.customer_name = Console.ReadLine();
            Console.WriteLine("Enter Customer Account Number : ");
            CA.customer_accountNo = Convert.ToInt64(Console.ReadLine());

            CA.PrintInfo(CA);
        }
    }
}
