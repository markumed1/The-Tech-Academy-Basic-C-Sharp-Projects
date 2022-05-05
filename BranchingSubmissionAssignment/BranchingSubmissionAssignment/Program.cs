using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening program with welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:\n");
            

            Console.WriteLine("Please enter the package weight.");

            //User enters current weight. 'Convert.ToInt32' method converts the string representation of a
            //number in a specified base to an equivalent 32-bit signed integer.
            int currentPackageWeight = Convert.ToInt32(Console.ReadLine());

            if (currentPackageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //this message will be displayed onto console if weight is > max weight.
            }
            else
            {
                Console.WriteLine("Please enter package width.");
                int currentPackageWidth = Convert.ToInt32(Console.ReadLine());




                Console.WriteLine("Please enter package width.");
                int currentPackageHeight = Convert.ToInt32(Console.ReadLine());




                Console.WriteLine("Please enter package width.");
                int currentPackageLength = Convert.ToInt32(Console.ReadLine());

                if (currentPackageWidth + currentPackageHeight + currentPackageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else 
                {
                    decimal quote = currentPackageWidth * currentPackageHeight * currentPackageLength * currentPackageWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote + " Thank you!");
                }
            }
                
     




           




            Console.ReadLine();
        }
    }
}
