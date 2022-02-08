using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    public class Student
    {
        public string Name;
        public decimal[] Marks;
        public static decimal AveraheMarks;

        public decimal CalculateAverageMarks()
        {
            decimal Average = 0;
            for(int i=0;i < Marks.Length; i++)
            {
                Average += Marks[i];
            }
            return Average/Marks.Length;
        }
        public decimal CalculateMaxMarks()
        {
            decimal MaxMarks = -1;
            for (int i = 0; i < Marks.Length; i++)
            {
              if(MaxMarks<Marks[i])
                {
                    MaxMarks = Marks[i];
                }
            }
            return MaxMarks;
        }
        public decimal CalculateMinMarks()
        {
            decimal MinMarks = 99999;
            for (int i = 0; i < Marks.Length; i++)
            {
                if (MinMarks > Marks[i])
                {
                    MinMarks = Marks[i];
                }
            }
            return MinMarks;
        }
        public string CalculateGrade()
        {
            decimal percentage = 0;
            string Grade = "No Grades";
            for (int i = 0; i < Marks.Length; i++)
            {
                percentage += Marks[i];
            }
            percentage = (percentage / (Marks.Length));

            if (percentage > 90)
                Grade = "A";
            else if (percentage > 80)
                Grade = "B";
            else if (percentage > 70)
                Grade = "C";
            else if (percentage < 70)
                Grade = "D";

            return Grade;
        }
        public enum Options
        {
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0,choice;
            Student students = new Student();
            Console.WriteLine("Enter Student Name : ");
            students.Name = Console.ReadLine();
            Console.WriteLine("Enter Number of Subjects : ");
            n = Convert.ToInt32(Console.ReadLine());
            students.Marks = new decimal[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Enter Students Subject " + (i+1) + " Marks: ");
                students.Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }
            while(true)
            {

                Console.WriteLine("Enter 1 - Aggregate: Displays the Name: Average marks : ");
                Console.WriteLine("Enter 2 - MinMark: Displays the minimum marks of the student : ");
                Console.WriteLine("Enter 3 - MaximumMark: Displays the maximum mark : ");
                Console.WriteLine("Enter 4 - Grade: Displays grade : ");
                Console.WriteLine("Enter 0 to Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine(students.Name + " average marks is " + students.CalculateAverageMarks());
                        break;

                    case 2:
                        Console.WriteLine(students.Name + " Minimum marks is " + students.CalculateMinMarks());
                        break;

                    case 3:
                        Console.WriteLine(students.Name + " Maximum marks is " + students.CalculateMaxMarks());
                        break;

                    case 4:
                        Console.WriteLine(students.Name + " Grades is " + students.CalculateGrade());
                        break;

                    case 0:
                        return;
                        break;

                    default:
                        Console.WriteLine("Please enter proper number from the below menu : ");
                        break;
                }
            }
        }
    }
}
