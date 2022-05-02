using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 6;
            //int num2 = 9;
            //int total = num1 + num2;
            //Console.WriteLine(total);


            //int num1 = 6;
            //int num2 = 9;
            //int difference = num1 - num2;
            //Console.WriteLine(difference);


            //int num1 = 35;
            //int num2 = 5;
            //int product = num1 * num2;
            //Console.WriteLine(product);


            //int num1 = 100;
            //int num2 = 10;
            //int quotient = num1 / num2;
            //Console.WriteLine(quotient);

            //-----NOTES---------------------------------//
            //int num1 = 7;
            //float num2 = 5.5f;
            //??? total = num1 + num2;
            //the .5, in this case we use "float" can have decimal places.
            //float total = num1 + num2;
            //If you needed “total” to be of type “int,” then you would need to cast num2 to int before performing the calculation:

            //int total = num1 + (int32)num2;

            //When casting “down” from a precision number to an integer, the numbers after the decimal are lost.In other words, it always rounds down.
            //------END NOTES----------------------------//


            //----MATH CASTING-----//
            //double num1 = 7.03230923;
            //float num2 = 5.9f;
            //double total = num1 + num2;
            //Console.WriteLine(total);

            //A “float” is 32-bit and a “double” is 64-bit. In other words, a “float” is no more than 7 digits long,
            //and a “double” is no more than 15-16 digits long. So a “double” is the more precise choice.

            //When the compiler converts a “float” to a “double” without being told to, this is called an “implicit conversion.”

            //If we wanted to go the other way and convert a “double” to a “float,” we would have to do an “explicit conversion”
            //on the “double” value.
            //double num1 = 7.03230923;
            //float num2 = 5.9f;
            //float total = (float)num1 + num2;
            //Console.WriteLine(total);

            //There is no implicit conversation available from a "float" or "double" to a "decimal". These conversions must be done
            //"explicitly. this is due solely to the nature of floats and decimals, which are encoded very differently than other
            //number data types.

            //ex: You can implicitly cast from ineger data types like "int" to a "decimal" this way:
            //decimal num1 = 7.3230923m;
            //int num2 = 5;
            //decimal total = num1 + num2;
            //Console.WriteLine(total);

            //or:

            //decimal num1 = 7.3230923m;
            //sbyte num2 = 5;
            //decimal total = num1 + num2;
            //Console.WriteLine(total);



            //---------------MATH WITH STRINGS------------------------//
            //string firstName = "Erin";
            //string lastName = "Wood";
            //Console.WriteLine(firstName + lastName); //While this looks like math, it’s actually called “string concatenation.”
            //output ErinWood.

            //string name = "Bob";
            //int number = 5;
            //Console.WriteLine(name + number);
            //output Bob5




            Console.ReadLine();
        }
    }
}
