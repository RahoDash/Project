using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIClonaeable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person nikola = new Person("Nikola Tesla", new Job("CEO", new Salary(42, 420)));
            PrintInfo(nikola);

            Person nikolaClone = (Person)nikola.Clone();

            PrintInfo(nikolaClone);
            Console.WriteLine("Change clone Name, Job.Description, Salary.Amount, Salary.Bonus");
            nikolaClone.Name = "John Doe";
            nikolaClone.Job.Salary.Amount = 100;
            nikolaClone.Job.Salary.Bonus = 1000;
            nikolaClone.Job.Description = "CTO";

            Console.WriteLine("Original");
            PrintInfo(nikola);

            Console.WriteLine("Clone");
            PrintInfo(nikolaClone);
        }

        private static void PrintInfo(Person paramPerson)
        {
            Console.WriteLine("Name: {0}", paramPerson.Name);
            Console.WriteLine("     Job: {0}",paramPerson.Job.Description);
            Console.WriteLine("         Amoun : {0} k$", paramPerson.Job.Salary.Amount);
            Console.WriteLine("         Bonus : {0} k$", paramPerson.Job.Salary.Bonus);
            Console.WriteLine();
        }
    }
}
