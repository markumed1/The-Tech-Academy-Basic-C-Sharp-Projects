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
            //Use a double type variable to define numeric variables holding numbers with decimals
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            //displays result of user's input
            Console.WriteLine("Your hourly rate is: " + hourlyRate1 + "\n");

            Console.WriteLine("hours worked per week?");
            //Use convert class to support conversation to and from the database in this case for 'double'
            double weeklyHours1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your weekly hours are: " + weeklyHours1 + "\n");
            

            Console.WriteLine("Person 2");
            Console.WriteLine("hourly Rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your hourly rate are: " + hourlyRate2 + "\n");

            Console.WriteLine("hours worked per week?");
            double weeklyHours2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your weekly hours are: " + weeklyHours2 + "\n");
            
            Console.WriteLine("Annual salary of Person 1");
            Console.WriteLine("Person 1: ");
            //Math operation to determine Person's salary. Hourly rate times weekly hours times 52 weeks
            double annual_salary1 = hourlyRate1 * weeklyHours1 * 52;
            Console.WriteLine(annual_salary1);

            Console.WriteLine("Annual salary of Person 2");
            Console.WriteLine("Person 2: ");
            double annual_salary2 = hourlyRate2 * weeklyHours2 * 52;
            Console.WriteLine(annual_salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annual_salary1 > annual_salary2);


            Console.ReadLine();





        }

    }
}
