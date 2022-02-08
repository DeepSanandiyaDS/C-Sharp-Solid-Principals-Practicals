using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = Console.ReadLine();

            if (Convert.ToBoolean(int.Parse(userResponse))) // it throws the exception when user input is a string
            {
                Console.WriteLine("The entered value is a integer");
            }
            Console.ReadLine();
        }
    }
}
