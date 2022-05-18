using System;
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
            //mathMethod math = new mathMethod();//Instantiate
            //Console.WriteLine("User please enter a number."); //display to user
            //int num1 = Convert.ToInt32(Console.ReadLine()); //display's user's number
            //int quotient = math.DivideNumbers(num1);
            //Console.WriteLine(quotient);
            //Console.WriteLine(math.DivideNumbers(num1));

            int result = StaticMethod.Add(5, 10); //int var type 'result' = to class 'Static'
            Console.WriteLine(result);


            Console.ReadLine();
        }


    }
}
