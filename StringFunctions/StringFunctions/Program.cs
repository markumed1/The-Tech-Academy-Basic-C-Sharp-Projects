using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Mark";
            ////using escape charcter backslash \ before double quotes to avoid error. \n breaks to a new line. \t tabs string.
            //string quote = "The man said, \"Hello\", Mark. \n Hello on a new line. \n \t Hello on a tab,";
            //string fileName = @"C:\Users\Mark";

            //bool trueOrFalse = name.Contains("k");
            //trueOrFalse = name.EndsWith("k");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Mark");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
