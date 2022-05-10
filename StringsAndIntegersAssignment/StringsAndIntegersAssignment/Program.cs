using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of ints.
            List<int> numberList = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            Console.WriteLine("user pick a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                for (int i = 0; i < numberList.Count; i++)
                {
                    Console.WriteLine(numberList[i]);
                    Console.WriteLine(" , ");
                }
            }
        

        }
        
        
    }
}
