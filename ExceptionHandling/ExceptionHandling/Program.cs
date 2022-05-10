using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //The try-catch block holds the suspected code that may get exceptions.
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divided the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree); //Concatenated strings.
                Console.ReadLine();
            }
            catch (FormatException ex) //Catch argument is one way to filter for the excpetions you want to handle.
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }   
    }
}
