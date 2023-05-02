using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{




    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}