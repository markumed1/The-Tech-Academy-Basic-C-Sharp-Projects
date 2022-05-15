using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod mathMethod = new MathMethod();//Instantiate
            Console.WriteLine("User enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 5;

            Console.WriteLine(num1 / num2);

            string numberAsString = "1640";

            int number;
            if (Int32.TryParse(numberAsString, out number))
                Console.WriteLine($"Converted '{numberAsString}' to {number}");
            else
                Console.WriteLine($"Unable to convert '{numberAsString}'");
            // The example displays the following output:
            //       Converted '1640' to 1640

            Console.ReadLine();
        }


    }
}
