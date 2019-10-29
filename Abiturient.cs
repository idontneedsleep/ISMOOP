using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Abiturient:Human
    {
        public double BalSertificate;
        public double BalDocument;
        public string NameSchool;
        public Abiturient(string Name, string LastName, string DateBirth, double BalSertificate, double BalDocument, string NameSchool)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.DateBirth = DateBirth;
            this.BalSertificate = BalSertificate;
            this.BalDocument = BalDocument;
            this.NameSchool = NameSchool;
        }
    }
}
