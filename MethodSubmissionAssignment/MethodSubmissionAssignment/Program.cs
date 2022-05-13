using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Method method = new Method(); 
            Console.WriteLine("user, input two numbers, one at a time. You need not to enter anything for the second number.");

            int myNum1 = Convert.ToInt32(Console.ReadLine());
            int myNum2 = Convert.ToInt32(Console.ReadLine());

           if (myNum1 == 0 )
            {
                Console.WriteLine(method);
            }
           else if (myNum2 == 0 )
            {
                Console.WriteLine(method);
            }

           
            


            Console.ReadLine();
        }
    }
}
