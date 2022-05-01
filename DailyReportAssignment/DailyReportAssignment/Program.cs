using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 'Console.WriteLine/ReadLine' Method to print out tech academy
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report:\n");
            

            // creating program with console methods
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName + "\n"); // adding "\n" creates new line

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse + "\n");

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Your page number is: " + pageNumber + "\n");

            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'" );
            string yourAnswer = Console.ReadLine();
            Console.WriteLine("Your answer is: " + yourAnswer + "\n");

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics." );
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Your exeperince in your own words: " + yourExperience + "\n");

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific." );
            string yourFeedBack = Console.ReadLine();
            Console.WriteLine("Your feedback in your own words: " + yourFeedBack + "\n");

            Console.WriteLine("How many hours did you study today?" );
            string Hours = Console.ReadLine();
            Console.WriteLine("You did: " + Hours + "hrs" + "\n");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");





            Console.ReadLine();
        }
    }
}
