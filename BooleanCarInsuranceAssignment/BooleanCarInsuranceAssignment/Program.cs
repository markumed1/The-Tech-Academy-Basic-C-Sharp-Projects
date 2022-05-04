using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanCarInsuranceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display quetion and age with console.writeline 
            Console.WriteLine("What is your age?");

            int yourAge = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("You are " + yourAge + " years old" + "\n");


            Console.WriteLine("Have you ever had a DUI? Type True or False");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("You answered " + DUI + "\n");


            // using int tp declare a var. 
            int yourAge = 32;
            Console.WriteLine(yourAge);
            
            //use boolean method to display answer
            Console.WriteLine("Have you ever had a DUI?");
            bool gotDui = false;
            Console.WriteLine(gotDui);
            

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your have " + speedingTickets + " ticket(s)" + "\n");



            bool isQualified = (yourAge > 15) && (DUI == false) && (speedingTickets < 3);
            Console.WriteLine("Are you qualified?" + isQualified);





            Console.ReadLine();
        }
    }
}
