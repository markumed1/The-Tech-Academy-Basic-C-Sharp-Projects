using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProgram = new mathMethod(); //instantiate

            //call the method in the class, passing two numbers, call the method in the class, specifying the parameters by name.
            myProgram.MathNums(2, 3);  
            myProgram.MathNums(num1: 10, num2: 5);


            Console.ReadLine();
        }
    }
}
