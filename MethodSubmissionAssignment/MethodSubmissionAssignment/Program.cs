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

            int num1 = 6;
            int num2 = 5;

            
            Console.WriteLine(MathOperator.MethodMath(num1));
            Console.WriteLine(MathOperator.MethodMath(num2));


            Console.ReadLine();
        }
    }
}
