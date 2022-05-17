using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    // Created an abstact person
    public abstract class Person 
    {
        // Created two props
        public string firstName { get; set; } 
        public string lastName { get; set; }

        // created method
        public abstract void SayName();


        
        
    }
    
}
