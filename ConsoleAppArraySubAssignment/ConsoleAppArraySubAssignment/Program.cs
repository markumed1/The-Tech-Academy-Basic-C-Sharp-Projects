using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArraySubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////one-dimensional array of STRINGS
            //string[] JapanCars = { "Honda", "Toyota", "Nissan", "Subaru", "Mitsubishi" };
            //Console.WriteLine("User please enter a number from 0 to 4\n");

            //int userIndex = Convert.ToInt32(Console.ReadLine()); //User select index
            //Console.WriteLine("You chose car brand: " + JapanCars[userIndex]); //This line will display the car brand at that index. 
            ////Number stored in the "userIndex" variable.

            //Console.ReadLine();


            //one-dimensional array of INTEGERS
            int[] myNumbers = { 10, 5, 15, 20, 30 };
            Console.WriteLine("User please enter a number from 0 to 4\n");

            int userIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose number: " + myNumbers[userIndex]);

            Console.ReadLine();

        }
    }
}
