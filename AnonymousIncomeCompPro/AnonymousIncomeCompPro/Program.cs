using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeCompPro
{
    class Program
    {

        static void Main(string[] args)
        {
            Double annual_salary;

            //Starting the program with intro title
            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1");
            Console.WriteLine("hourly Rate?");
            string hourlyRate = Console.ReadLine();
            Console.WriteLine("Your hourly rate is: " + hourlyRate + "\n");

            Console.WriteLine("hours worked per week?");
            string weeklyHours = Console.ReadLine();
            Console.WriteLine("Your weekly hours is: " + weeklyHours + "\n");

            Console.WriteLine("Annual salary");
            Console.WriteLine("Person 1: ");
            annual_salary = Convert.ToInt32(Console.ReadLine());

            

            Console.ReadLine();
          
            
        }

    }
}
