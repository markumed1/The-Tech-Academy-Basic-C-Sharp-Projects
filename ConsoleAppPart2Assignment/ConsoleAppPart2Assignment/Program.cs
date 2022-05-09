using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Creating infinite loop. Using while loop
            //while (true)
            //{
            //    //This statement will be printed infinite times
            //    Console.WriteLine("Boto Boyz for life!");



            //Breaking Infinite loop
            int x = 1;

            while (true)
            {
                if (x == 7)
                    break;

                Console.WriteLine("Boto Boyz for life!");
                x++;

                Console.ReadLine();
            }
            
        }
    }
}
