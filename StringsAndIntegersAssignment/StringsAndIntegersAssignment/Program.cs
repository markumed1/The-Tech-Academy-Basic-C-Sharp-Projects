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
            try
            {
                //Create list of ints.
                List<int> numberList = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

                Console.WriteLine("user pick a number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                

                if (true)
                {
                    for (int i = 0; i < numberList.Count; i++)
                    {
                        Console.WriteLine(numberList[i] / userNumber);

                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
        
        
    }
}
