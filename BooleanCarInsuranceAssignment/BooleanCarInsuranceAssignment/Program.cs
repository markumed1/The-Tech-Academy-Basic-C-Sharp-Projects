﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanCarInsuranceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = 32;
            Console.WriteLine(yourAge);
 
            Console.WriteLine("Have you ever had a DUI?");
            bool gotDui = false;
            Console.WriteLine(gotDui);
            

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = 1;
            Console.WriteLine(speedingTickets);

            Console.WriteLine("Qualified?");
            bool qualified = true;
            Console.WriteLine(qualified);

       

            Console.ReadLine();
        }
    }
}
