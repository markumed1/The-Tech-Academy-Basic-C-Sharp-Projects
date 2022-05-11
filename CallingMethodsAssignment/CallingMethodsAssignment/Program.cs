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
            Console.WriteLine("User please pick a number to do math operations on.");
            string line = Console.ReadLine();

            var operatorObject = new Operator();
            var result = operatorObject.GetAdd(data);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
