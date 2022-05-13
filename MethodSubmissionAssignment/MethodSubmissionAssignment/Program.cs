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
            //instantiate the class
            Method method = new Method(); 
            Console.WriteLine("user, please enter a number."); // run console twice
            int myNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second optional number"); //user enter's optional #

            try
            {
                
                int myNum2 = Convert.ToInt32(Console.ReadLine()); 
                int result = Method.MathMethod(myNum1, myNum2); // adds up two numbers entered by user.
                Console.WriteLine(result);

            }
            catch //if user does not put in second number this catch will loop in default number from first try.
            {
                int result = Method.MathMethod(myNum1);
                Console.WriteLine(result);
            }

           

            Console.ReadLine();
        }
    }
}
