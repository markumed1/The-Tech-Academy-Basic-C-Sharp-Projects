using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class mathMethod //created a class
    {
        //Created a void method, outputs an int.
        public void DivideByTwo(int num1)
        {
            Console.WriteLine(num1 / 2); //method divide data that will be passed by two
        }

        public static void Rect(int len, int width, out int area, out int permiter)
        {
            area = len * width;
            permiter = 2 * (len + width);
        }
    }
    public class MethodOverloading
    {
        public int Add(int a, int b) //adding two int val.
        {
            int sum = a + b;
            return sum;
        }

        //adding three int val.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;

        }
    }
{
