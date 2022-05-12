using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 operatorObject = new Class1();
            Console.WriteLine("User please pick a number to do math operations on."); //display on console for user
            int userinput = Convert.ToInt32(Console.ReadLine());

            
          


            //display's answers onto console.
            Console.WriteLine(operatorObject.GetAdd(userinput));
            Console.WriteLine(operatorObject.GetSubtract(userinput));
            Console.WriteLine(operatorObject.GetDivide(userinput));
            Console.ReadLine();
        }
    }
}
