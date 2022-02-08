using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Console_Application
{
    class Customer_Account
    {
        public string bank_name;
        public long customer_accountNo;
        public String customer_name;
        
        public Customer_Account(long accountNo, string customerName)
        {
            customer_accountNo = accountNo;
            this.customer_name = customerName;
        }

        public void PrintInfo(Customer_Account CA)
        {
            Console.WriteLine("\n Name of the bank is : " + CA.bank_name + "\n");
            Console.WriteLine(" Name of the Customer is : " + CA.customer_name + "\n");
            Console.WriteLine(" Customer account number is : " + CA.customer_accountNo + "\n");
            Console.ReadLine();
        }
    }
}
