using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            //declaring a string.
            //string myName = "Mark";
            //int myNumber = 5;

            ////This is a simple program
            //Console.WriteLine("What is your name?"); // display's this on the console
            //string yourName = Console.ReadLine(); //assigns output to a string variable. ReadLine() takes in.
            //Console.WriteLine("Your name is: " + yourName); //taking the variable and print it back.
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number? ");
            string favoriteNumber = Console.ReadLine(); //'Console.Readline();' can only take strings
            int favNum = Convert.ToInt32(favoriteNumber);//cast the results. converting string to an int.
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = '\u2103';

            //decimal moneyInBank = 100.5m;

            //double heightInCentimeters = 211.30202092;

            //float secondsLeft = 2.62f;

            //short temperatureOnMars = -341;

            //string myName = "Mark";

            //int currentAge = 34;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingStatus);





            Console.ReadLine();


        }
    }
}
