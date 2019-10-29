using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Worker
{
    public class Company
    {
        protected string Name;
        protected string Position;
        protected int Salary;

        public Company(string Name, string Position, int Salary)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
        }
        private void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        private void SetPosition(string Position)
        {
            this.Position = Position;
        }
        public string GetPosition()
        {
            return Position;
        }
        private void SetSalary(int Salary)
        {
            this.Salary = Salary;
        }
        public int GetSalary()
        {
            return Salary;
        }
    }
}
