﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod mathMethod = new MathMethod();//Instantiate
            Console.WriteLine("User enter a number."); //display to user
            int num1 = Convert.ToInt32(Console.ReadLine()); //display's user's number
            int num2 = 2;

            Console.WriteLine(num1 / num2);

            

            Console.ReadLine();
        }


    }
}
