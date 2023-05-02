using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    public class SchoolProgram
    {
        private string _className;
        private string _classNumber;
        private string _roomNumber;
        private Instructor _instructor;
        private List<Student> _classRoster = new List<Student>();

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;
        }

        public  string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public string ClassNumber
        {
            get { return _classNumber; }
                set { _classNumber = value; }
        }

        public string RoomNumber
        {
             get { return _roomNumber; }
            set { _roomNumber = value; }
        }

        public Instructor Instructor
        {
            get { return _instructor; }
           set { _instructor = value; }
        }

        public IReadOnlyList<Student> ClassRoster
        {
            get { return _classRoster; }
        }

        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            var student = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {
            return $"{ClassName} {ClassNumber} - {RoomNumber} - {_instructor} - Number of Students: {_classRoster.Count}";
        }
    }
}