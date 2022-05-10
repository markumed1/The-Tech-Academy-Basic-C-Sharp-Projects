using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPartSixAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> names = new List<string>(); //list of strings
            names.Add("Kurt Cobain");
            names.Add("Talib Kweli");
            names.Add("Bruno Mars");
            names.Add("Eminem");
            names.Add("Rihanna");
            names.Add("Kurt Cobain");

            List<string> newNames = new List<string>(); //Empty list

            //For each loop. Loop through the collection and each time through
            //loop it will use the next name from the collection
            foreach (string name in names)
            {
                if (newNames.Contains(name)) // using if statement if the condition is true (name exist on list)
                {
                    Console.WriteLine(name + " is already on the list");
                }
            else if(!newNames.Contains(name)) //using else if condition is not true (name not on list)
                {
                    newNames.Add(name);
                    Console.WriteLine(name + " has not appeared on the list");
                }
            }
            Console.ReadLine();
        }
    }
}
