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

            //name = name.ToUpper(); //converts string to uppercase
            //name = name.ToLower(); //converts string to lowercase

            //Console.WriteLine(name);
            //Console.ReadLine();

            //*****Creating a StringBuilder Object*****//

            //StringBuilder sb = new StringBuilder(); 

            //sb.Append("My name is Mark");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            //******END StringBuilder***************//

            //Concatenation is the process of appending one string to the end of another string.
            //You concatenate strings by using the + operator.
            //Concatenation of literals is performed at compile time, not run time.
            string text = "Historically, the world of data and the world of objects " +
            "have not been well integrated. Programmers work in C# or Visual Basic " +
            "and also in SQL or XQuery. On the one side are concepts such as classes, " +
            "objects, fields, inheritance, and .NET Framework APIs. On the other side " +
            "are tables, columns, rows, nodes, and separate languages for dealing with " +
            "them. Data types often require translation between the two worlds; there are " +
            "different standard functions. Because the object world has no notion of query, a " +
            "query can only be represented as a string without compile-time type checking or " +
            "IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
            "objects in memory is often tedious and error-prone.";

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
