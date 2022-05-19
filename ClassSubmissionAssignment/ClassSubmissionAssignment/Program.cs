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
            mathMethod math = new mathMethod();//Instantiate
            Console.WriteLine("User please enter a number."); //display to user
            int num1 = Convert.ToInt32(Console.ReadLine()); //display's user's number
            math.DivideByTwo(num1); //user's number will be divided by two


            //Create method with output parameters
            int area, perimeter;
            //passing two parameter and getting two returning value.
            mathMethod.Rect(5, 4, out area, out perimeter); //calling mathMethod class
            Console.WriteLine("Area of Rectangle is {0}\t", area);
            Console.WriteLine("Perimeter of Rectangle is {0}\t", perimeter);


            MethodOverloading math2 = new MethodOverloading();

            int sum1 = math2.Add(20, 4);
            Console.WriteLine(sum1);

            int sum2 = math2.Add(20, 40, 60);
            Console.WriteLine(sum2);

            Console.ReadLine();
        }
        
    }
}
