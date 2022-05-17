using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person, IQuittable //Inheritence from Person.cs class
    {
        public object ID { get; private set; }

        //Implement the SayName() method inside of the employee class
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        } 
        public void Quit()
        {

        }
        // "bool" is what method returns, it returns a bool(boolean), keyword for "True or False".
        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return false;
        }


    }


}
