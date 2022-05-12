using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Class1
    {
        //Create class and method that takes in integer
        public int GetAdd(int data)// <--Paramater in ()'s of method, method is 'GetAdd'
        {
            return data + 10; //return an integer
        }

        //Same method name 'GetAdd'. 
        public int GetAdd(decimal data) //<---Parameter: (decimal data)
        {
            return Convert.ToInt32(data + 6.2m); //Convert using 'Convert.ToInt32' return to an integer.

        }

        //Same method name.
        public int GetAdd(string data) //<--Parameter: (string data). 
        {
            return Convert.ToInt32(data) / 6; // Using different math ops. Take a string and convert in to an integer.
        }
    }




}

