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
            Program myProgram = new Program(); //instantiate
            myProgram.mathMethod(2, 3);
            myProgram.mathMethod(num: 10, num2: 5);
           

            Console.ReadLine();
        }
    }
}
