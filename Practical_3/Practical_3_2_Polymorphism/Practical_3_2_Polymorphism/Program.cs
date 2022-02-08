using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3_2_Polymorphism
{
    public class Bird
    {
        public virtual void Voice()
        {
            Console.WriteLine("Sound of Bird : Turr Turr");
        }
    }

    public class Duck : Bird
    {
        public override void Voice()
        {
            Console.WriteLine("Sound of Duck : Quack Quack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird();

            Bird myDuck = new Duck();

            myBird.Voice();

            myDuck.Voice();

            Console.ReadLine();
        }
    }
}
