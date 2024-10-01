using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        string Emloyeeid { get; set; }
        DateTime Startdate { get; set; }
        public decimal Salary { get; set; }

        public Person(string name, int age, string empoyeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            Emloyeeid = empoyeeId;
            Startdate = startDate;
            Salary = salary;
        }

        public void PrintInfo()
        {

            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}");
            
        }

        public void Intruduce()
        {
            Console.WriteLine($"Hej jag heter {Name}. Jag är {Age} år gammal. ");
        }

        public virtual void DoWork()
        {
            Console.WriteLine("En person: ");
        }

    }
}
