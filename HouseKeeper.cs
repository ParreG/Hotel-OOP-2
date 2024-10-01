using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Housekeeper : Person
    {
        public Housekeeper(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string jobTitle) : base(name, age, empoyeeId, startDate, salary)
        {

        }
        public override void DoWork()
        {
            Console.WriteLine("Städerskan städar hotellrummen.");
        }

    }
}
