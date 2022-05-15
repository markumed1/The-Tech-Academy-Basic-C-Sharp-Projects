using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class MathMethod
    {
        public void AddNumbers(int num1, int num2, out int result)
        {
            result = num1 + num2;
        }
        public void AddNumbers()
        {

            int num1 = 5;
            int num2 = 3;
            int result;
            AddNumbers(5, 3, out result);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
