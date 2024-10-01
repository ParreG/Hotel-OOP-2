using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Housekeeper : Person
    {
        public enum CleaningSpeed
        {
            Fast,
            Average,
            Thorough
        }
        CleaningSpeed cleaningSpeed;
        List<string> SpecialtyAreas;
        Dictionary<string, int> SuppliesInventory;

        public Housekeeper(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string jobTitle, string phoneNumber, string email, string adress) :
            base(name, age, empoyeeId, startDate, salary, phoneNumber, email, adress)
        
        {

        }
        public override void DoWork()
        {
            Console.WriteLine("Städerskan städar hotellrummen.");
        }

    }
}
