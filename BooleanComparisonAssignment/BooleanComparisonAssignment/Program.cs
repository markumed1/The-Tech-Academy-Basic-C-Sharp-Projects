using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparisonAssignment
{
    class Program
    {
        public static string Red { get; private set; }

        static void Main(string[] args)
        {
            ////Opening program with question to console
            //Console.WriteLine("Guess my favourite number between 1 and 50?");
            //int number = Convert.ToInt32(Console.ReadLine()); //declaring a variable. using convert method Converts the specified string representation of a number.
            //bool isGuessed = number == 47; //my favourite number

            //// The do while loop stops execution exits when a boolean condition evaluates to false
            //do
            //{
            //    // Switch statement is a multiway branch statement. It provides an efficient way to
            //    // transfer the execution to different parts of a code based on the value of the expression
            //    switch (number)
            //    {
            //        case 33: //switch case statement is a selection statement. In other words is 33 the correct number.
            //            Console.WriteLine("You guessed 33. Try again.");
            //            Console.WriteLine("Guess my favourite #?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break; //the break statement is used to terminate a loop(for, if, while, etc.)
            //        case 50:
            //            Console.WriteLine("You guessed 50. Try again.");
            //            Console.WriteLine("Guess my favourite #?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 47:
            //            Console.WriteLine("You guessed 47. That is correct");
            //            isGuessed = true;
            //            break;
            //        case 10:
            //            Console.WriteLine("You guessed 10. Try again.");
            //            Console.WriteLine("Guess my favourite #?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default: //this default will display messaged if user inputs other numbers other than the ones listed above.
            //            Console.WriteLine("You  are wrong.");
            //            Console.WriteLine("Guess my favourite #?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;


            //    }

            //}
            //while (!isGuessed); //The do/while loop is a variant of the while loop.
            //                    //This loop will execute the code block once, before checking if the condition is true, then it will repeat 

            //Console.ReadLine();


            //While statement 
            int x = 1;
            while (x <= 10) //condition. 
            {
                Console.WriteLine(x); //everytime you hit enter number will increase by 1 until 10 and program ends.
                x++;

                Console.ReadLine();
            }



        }
        



            
    }   
}
