﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() //Instantaiate an Employee object.
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employee.SayName(); //Called the SayName() method on the object.
            Console.ReadLine();
        }
    }
}
