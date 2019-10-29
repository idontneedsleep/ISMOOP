using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Student : Human
    {
        public string Course;
        public string Group;
        public string Faculty;
        public string NameVNZ;
        public Student(string Name, string LastName, string DateBirth, string Course, string Group, string  Faculty, string NameVNZ)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.DateBirth = DateBirth;
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.NameVNZ = NameVNZ;
        }
    }
}
