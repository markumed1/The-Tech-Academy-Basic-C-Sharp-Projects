using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart1Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring single dimensional array
            string[] names = { "Keven", "Mark", "Miles", "Katrina" };

            // prompts user to input text
            Console.WriteLine("User please input some text.");
            string sSize = Console.ReadLine();


            //A for loop that iterates through each string in the array and adds the user's
            //text input to the end of each string.
            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i] + sSize);
                
            }
            Console.ReadLine();
        }       
    }   
}
