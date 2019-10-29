using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Library_user: Human
    {
        public int Number;
        public string Date;
        public int Vnesok;
        public Library_user(string Name, string LastName, string DateBirth, int Number, string Date, int Vnesok)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.DateBirth = DateBirth;
            this.Number = Number;
            this.Date = Date;
            this.Vnesok = Vnesok;
        }
    }
}
