using System;
using System.Globalization;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
                Worker worker= new Worker("Artur Pirozkov", 2010, 10, new Company("ISM", "Programmer", 15000));
                //Console.WriteLine($"{worker1.GetName()}, {worker1.GetYear()}, {worker1.GetMounth()}, {worker1.GetWorkPlace()}");
               // Worker worker2 = new Worker("Trap Pirogov", 2012, 1, new Company("ISM", "Programmer", 15000));
                //Console.WriteLine($"{worker2.GetName()}, {worker2.GetYear()}, {worker2.GetMounth()}, {worker2.GetWorkPlace()}");
                //Worker worker3 = new Worker(worker1);
                //Console.WriteLine($"{worker3.GetName()}, {worker3.GetYear()}, {worker3.GetMounth()}, {worker3.GetWorkPlace()}");
            
        }
        static void ReadWorkersArray(ref int n, params Worker []a)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
            }
        }
        static void PrintWorker(ref Worker worker)
        {
            Console.WriteLine($"{worker.GetName()}, {worker.GetYear()}, {worker.GetMounth()}, {worker.GetWorkPlace()}");
        }
        static void PrintWorkers(ref int n, out int c=Salary, params Worker []b)
        {
            c = Salary;
            for (int i = 0; i < n; i++)
            {
                if (b[i] > c) c = Salary;
            }
        }
    }
}
