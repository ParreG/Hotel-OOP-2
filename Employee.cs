using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Employee : Person
    {

        string Jobtitle { get; set; }

        public Employee(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string jobTitle) : base(name, age, empoyeeId, startDate, salary)
        {
            Jobtitle = jobTitle;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} arbetar just nu med att fixa entre dörren!");
        }

        public override void DoWork()
        {
            Console.WriteLine("Anställden gör sina uppgifter som receptionist");
        }
    }
}
