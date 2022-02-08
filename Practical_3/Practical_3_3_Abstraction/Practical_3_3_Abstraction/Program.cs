using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3_3_Abstraction
{
    public class Laptop
    {
        private string brand;

        private string model;

        private string motherboard;

        public Laptop()
        {
            Console.WriteLine("Enter Brand info : ");
            brand = Console.ReadLine();
            Console.WriteLine("Enter Model info : ");
            model = Console.ReadLine();
            Console.WriteLine("Enter Mother Board info : ");
            motherboard = Console.ReadLine();
        }

        public void LaptopDetails()
        {
            Console.WriteLine("Name of the Brand : " + brand);
            Console.WriteLine("Name of the Model : " + model);
            MotherBoardInfo();
            Console.WriteLine(motherboard);
        }

        private void MotherBoardInfo()
        {
            Console.WriteLine("* MotherBoard Information *");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop myLaptop = new Laptop();
            myLaptop.LaptopDetails();
            Console.ReadLine();
        }
    }
}
