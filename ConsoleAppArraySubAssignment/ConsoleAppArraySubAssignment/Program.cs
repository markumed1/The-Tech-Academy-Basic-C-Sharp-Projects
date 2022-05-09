using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArraySubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////one-dimensional array of STRINGS
            //string[] JapanCars = { "Honda", "Toyota", "Nissan", "Subaru", "Mitsubishi" };
            //Console.WriteLine("User please enter a number from 0 to 4\n");

            //int userIndex = Convert.ToInt32(Console.ReadLine()); //User select index
            //Console.WriteLine("You chose car brand: " + JapanCars[userIndex]); //This line will display the car brand at that index. 
            ////Number stored in the "userIndex" variable.


            //Console.ReadLine();


            ////one - dimensional array of integers
            //int[] mynumbers = { 10, 5, 15, 20, 30 };
            //Console.WriteLine("user please enter a number from 0 to 4\n");

            //int userindex = Convert.ToInt32(Console.ReadLine());

            //if (userindex <= 4) //If statement, user enters a number out of range
            //{
            //    Console.WriteLine("index does not exist " + mynumbers[userindex]); //Displays message
            //}
            //else
            //{
            //    Console.WriteLine($"{userindex} is out of range ");
            //}


            //Console.ReadLine();



            //Create a list of strings.
            //string[] str = new string[] { "Howzit", "braddah", "Mark", "shoots!" };

            //int strChoice;

            int listChoice;

            List<string> wordList = new List<string>(); //Storing strings in collection
            wordList.Add("Rajah");
            wordList.Add("Sup Bulleh");
            wordList.Add("Ho ya");
            wordList.Add("Oh nah");


            Console.WriteLine("User please select item between 0 - 3"); //asking user to choose a number
            listChoice = Convert.ToInt32(Console.ReadLine());

            //if elese statment if user chooses number beyond range
            if (listChoice < wordList.Count)
            {
                Console.WriteLine(wordList[Convert.ToInt32(listChoice)]);
            }
            else
            {
                Console.WriteLine("That number does not exist in the index.");
            }




            Console.ReadLine();



        }
    }
}
