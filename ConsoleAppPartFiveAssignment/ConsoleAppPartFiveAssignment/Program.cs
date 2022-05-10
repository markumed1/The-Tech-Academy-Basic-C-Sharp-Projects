using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPartFiveAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            values.Add("one");
            values.Add("two");
            values.Add("three");
            values.Add("two");
            values.Add("four");



            Console.WriteLine("User, please select text to search in the list");
            string userSelect = Console.ReadLine();

            if (values.Contains(userSelect))
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (userSelect == values[i])
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            else
            {
                Console.WriteLine("Your selection is not in the list");
            }

            Console.ReadLine();
        }
    }
}
