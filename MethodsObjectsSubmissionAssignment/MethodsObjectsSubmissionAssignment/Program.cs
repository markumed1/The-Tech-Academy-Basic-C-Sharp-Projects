using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiate
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();//Calling the superclass SayName() on employee object.

            Console.ReadLine();

        }
    }
}
