using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The ternary operator allows you to write a single line of code that will check
            // for a condition and, depending on the outcome, execute another portion of code.
            // In C#, the ternary operator is represented by the symbol “?:”
            //for example:
            int num1 = 7;
            int num2 = 12;

            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);

            //In our code, the value of the string variable "result is being set to one of the 
            //conditional statement.

            //stated in another way:

            //is num1 greater than num2? if it is, the variable result will have the value "num1
            //is greater than num2" (the string value on the left side of the colon). if the conditonal
            //statement retunrs false, the second string option "num1 is not greater than num2"
            //will be the value of the variable result (the string value on the right side of the colon).
        }
    }
}
