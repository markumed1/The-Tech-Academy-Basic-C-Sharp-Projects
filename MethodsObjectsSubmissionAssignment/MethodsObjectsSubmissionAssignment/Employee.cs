using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmissionAssignment
{
    public class Employee : Person //Derived class
    {
       public int ID
        {
            get => ID;
        }

        internal new void FirstName()
        {
            throw new NotImplementedException();
        }
    }

   

    

}
