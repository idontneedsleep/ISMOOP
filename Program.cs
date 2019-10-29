using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hum1 = new Human("Nya", "Tyan", "10.3.2002");
            Console.WriteLine($"{hum1.Name} {hum1.LastName}, {hum1.DateBirth}");
            Abiturient abi1 = new Abiturient("Nyan", "Tyan", "25.3.2000", 180, 9.5, "School 21");
            Console.WriteLine($"{abi1.Name} {abi1.LastName}, {abi1.DateBirth}, {abi1.BalSertificate}, {abi1.BalDocument}, {abi1.NameSchool}");
            Student student1 = new Student("Nyan", "Tyan", "25.3.2000", "first", "IPZ-19-2", "FIKT",  "KPI");
            Console.WriteLine($"{student1.Name} {student1.LastName}, {student1.DateBirth}, {student1.Course}, {student1.Group}, {student1.Faculty}, {student1.NameVNZ}");
            Proffesor prof1 = new Proffesor("Nyan", "Tyan", "25.3.1995", "teacher", "Computer Science", "ZDU");
            Console.WriteLine($"{prof1.Name} {prof1.LastName}, {prof1.DateBirth}, {prof1.Position}, {prof1.Cafedra}, {prof1.NameVNZ}");
            Library_user user1 = new Library_user("Charlie", "Tyan", "25.3.2003", 1500674329, "13.8.2015", 1000);
            Console.WriteLine($"{user1.Name} {user1.LastName}, {user1.DateBirth}, {user1.Number}, {user1.Date}, {user1.Vnesok}");
        }
    }
}
