using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person //Inheritence from Person.cs class
    {
        //Implement the SayName() method inside of the employee class
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        } 
        
    }


}
