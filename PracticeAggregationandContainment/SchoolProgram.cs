using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAggregationandContainment
{
   class SchoolProgram
    {

        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; // Aggregation



        List<Student> _classRoster; // Containment

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;
            _classRoster = new List<Student>();

        }

        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        public Instructor Instructor { get => _instructor; set => _instructor = value; }
        public List<Student> ClassRoster { get => _classRoster; }



        public void AddStudent(Student student) //Methods
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {
            return $"{_className} - {_classNumber} - {_roomNumber} - {_instructor} - Number of Students: {_classRoster.Count}";
        }



    }
}
