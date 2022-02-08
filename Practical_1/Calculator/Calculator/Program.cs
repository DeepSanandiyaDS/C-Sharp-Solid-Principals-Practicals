using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Enter First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The sum of the " + number1 + " and " + number2 + " is " + (number1 + number2) + "\n");
            Console.Write("The subtraction  of the " + number1 + " and " + number2 + " is " + (number1 - number2) + "\n");
            Console.Write("The multiplication  of the " + number1 + " and " + number2 + " is " + (number1 * number2) + "\n");
            if(number2 != 0)
            {
                Console.Write("The division of the " + number1 + " and " + number2 + " is " + (number1 / number2)+ "\n");
            }
            else
            {
                Console.Write("The division of the " + number1 + " and " + number2 + " is not possible" + "\n");
            }
            Console.ReadLine();

        }
    }
}
