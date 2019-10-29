using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Worker
{
    public class Worker
    {
        protected string Name;
        protected int Year;
        protected int Mounth;
        protected Company WorkPlace;
        private void SetName(string Name)
        {
           this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        private void SetYear(int Year)
        {
            this.Year = Year;
        }
        public int GetYear()
        {
            return Year;
        }
        private void SetMounth(int Mounth)
        {
            this.Mounth = Mounth;
        }
        public int GetMounth()
        {
            return Mounth;
        }
        private void SetWorkPlace(Company WorkPlace)
        {
            this.WorkPlace = WorkPlace;
        }
        public Company GetWorkPlace()
        {
            return WorkPlace;
        }
        public Worker() { }
        public Worker(string name, int year, int mounth, Company workPlace)
        {
            Name= name;
            Year = year;
            Mounth = mounth;
            WorkPlace = workPlace;
        }
        public Worker(Worker previousWorker)
        {
            Name = previousWorker.Name;
            Year = previousWorker.Year;
            Mounth = previousWorker.Mounth;
            WorkPlace = previousWorker.WorkPlace;
        }
        static void GetWorkExperience(ref int a, ref int b, ref int c=Year, ref int d=Mounth)
        {
           a = DateTime.Now.Month.ToInt32();
           b = DateTime.Now.Year.ToInt32();
            if (a>d) a = a - d;
            else
            {
                a = d - a;
                b--;
            }
            b = b - c;
        }
        static void GetTotalMoney(ref int Salary, ref int b, ref int c = Year, ref int d = Mounth)
        {
            d = d + c * 12;
            b = d * Salary;
        }
    }
}
