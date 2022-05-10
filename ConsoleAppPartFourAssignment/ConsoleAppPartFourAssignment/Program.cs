using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPartFourAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of strings where each item in the list is unique.
            //setting my list
            List<string> list = new List <string> ();
            list.Add("hello");
            list.Add("good bye");
            list.Add("good morning");
            list.Add("welcome");
            list.Add("thank you");
            list.Add("morning");


            Console.WriteLine("user please input text to search for List");
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (userInput == list[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Your choice is not in the list");
            }
            Console.ReadLine();
        }
    }
}
