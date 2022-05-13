using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Method MathOperator = new Method();

            Console.WriteLine("User please input two numbers, one at a time. Don't need to enter a second number, Just press enter.");
            int userinput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(MathOperator.MethodMath(userinput));
            


            Console.ReadLine();
        }
    }
}
