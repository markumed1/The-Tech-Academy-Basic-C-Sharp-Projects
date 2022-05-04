using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ////greater than (>) operator.
            //int num1 = 12;
            //int num2 = 14;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("The first number is larger.");
            //}
            //else
            //{
            //    Console.WriteLine("The second number is larger.");
            //}
            //Console.ReadLine();


            ////less than (<) operator.
            //int age = 19;

            //if (age < 21)
            //{
            //    Console.WriteLine("No, you may not purchase that bottle of wine.");
            //}
            //else
            //{
            //    Console.WriteLine("That will be $23.71");
            //}
            //Console.ReadLine();



            ////The 'lesser than or equal to' operator
            //int age = 20;

            ////The (age <= 20) asks the question, "is the value on the left less than or equal than to the value on the right?"
            //if (age <= 20)
            //{
            //    Console.WriteLine("No you may not purchase that bottle of wine.");
            //}
            //else
            //{
            //    Console.WriteLine("There you go!");
            //}
            //Console.ReadLine();



            ////The 'greater than or equal to' operator
            //int age = 20;

            //if (age >= 25)
            //{
            //    Console.WriteLine("Yes you may rent a car from us.");
            //}
            //else
            //{
            //    Console.WriteLine("No you may not rent a car from us.");
            //}
            //Console.ReadLine();



            ////The AND operator. The expressions before and after the AND
            //// operator both have to be true for the code in the curly
            ////braces to run.
            //int num1 = 7;
            //int num2 = 18;
            //int num3 = 12;
            //if (num2 > num1 && num3 < num2)
            //{
            //    Console.WriteLine("The second number is larger than the others.");
            //}
            //Console.ReadLine();



            int num1 = 7;
            if (true && true && true && num1 == 20)
            {
                Console.WriteLine("Everything was true!");
            }
            else
            {
                Console.WriteLine("There was a false somewhere!");
            }
            Console.ReadLine();
        }
    }   
}
