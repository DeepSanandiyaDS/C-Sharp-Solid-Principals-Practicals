using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[5];
                Console.WriteLine("array values are : ");
                for (int i=0;i<=5;i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("catch Message " + e);
            }
            finally
            {
                Console.WriteLine("This is finally block");
               
            }
            Console.ReadLine();
        }
    }
}
