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
            List<int> list = new List<int>() { 3, 5, 2, 7, 7, 5, 6 };

            Console.WriteLine("User, please select text to search in the list");
            string userSelect = Console.ReadLine();

            if (true)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(i);
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
