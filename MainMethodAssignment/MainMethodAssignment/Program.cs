using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static public void Main(string[] args)
        {
            Class1 operatorObject = new Class1();

            int numInt = 5;
            decimal numDecimal = 2.5m;
            string numString = "8";

            Console.WriteLine(operatorObject.GetAdd(numInt));
            Console.WriteLine(operatorObject.GetAdd(numDecimal));
            Console.WriteLine(operatorObject.GetAdd(numString));



            Console.ReadLine();
        }
        
    }
}
