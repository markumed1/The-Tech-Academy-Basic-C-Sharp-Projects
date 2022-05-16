using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person 
    {
        public string firstName { get; set; } //properties
        public string lastName { get; set; }

        public abstract void SayName();
        
        
    }
    
}
