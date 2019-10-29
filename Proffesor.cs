using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Proffesor:Human
    {
        public string Position;
        public string Cafedra;
        public string NameVNZ;
        public Proffesor(string Name, string LastName, string DateBirth, string Position, string Cafedra, string NameVNZ)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.DateBirth = DateBirth;
            this.Position = Position;
            this.Cafedra = Cafedra;            
            this.NameVNZ = NameVNZ;
        }
    }
}
