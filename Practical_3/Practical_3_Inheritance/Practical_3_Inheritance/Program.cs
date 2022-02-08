using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3_Inheritance
{
    public class Sponsor
    {
        protected string owner = "Rakuteen";
    }
    public class Team : Sponsor
    {
        private string teamName="CamPlayers";

        public string PrintInfo()
        {
            return owner + " - " + teamName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team Team1 = new Team();
            Console.WriteLine("Owner and Team name is : ");
            Console.WriteLine(Team1.PrintInfo());
            Console.ReadLine();
        }
    }
}
