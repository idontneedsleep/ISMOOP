using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Human
    {
        public string Name;
        public string LastName;
        public string DateBirth;
        public Human() { }
        public Human(string Name, string LastName, string DateBirth)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.DateBirth = DateBirth;
        }
        public Human(Human previousHuman)
        {
            Name = previousHuman.Name;
            LastName = previousHuman.LastName;
            DateBirth = previousHuman.DateBirth;
        }
    }
}
