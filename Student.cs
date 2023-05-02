using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CsiGrade { get; set; }
        public int GenEdGrade { get; set; }

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CsiGrade = csiGrade;
            GenEdGrade = genEdGrade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - CSI Grade {CsiGrade} - GenEd Grade {GenEdGrade}";
        }
    }

}


