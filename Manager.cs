using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Manager : Person
    {
        public string Department;
        int TeamSize;
        decimal BonusPercentage;
        public enum ManagementLevel
        {
            Joniur,
            Middle,
            Senior
        }
        ManagementLevel Management;

        public Manager(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string phoneNumber, string email, string adress,
            int teamSize, decimal bonusPercentage, ManagementLevel management) : 
        base(name, age, empoyeeId, startDate, salary, phoneNumber, email, adress)
        {

            Department = department;
            TeamSize = teamSize;
            BonusPercentage = bonusPercentage;
            Management = Management;
        }

        public void Holdmeeting()
        {
            Console.WriteLine("Jag håller ett personal möte på hotellet.");
        }

        public void PlanBudget()
        {
            Console.WriteLine("Chefen planerar budgeten!");
        }
        public override void DoWork()
        {
            Console.WriteLine("Chefen planerar och leder inom avdelningen för lyxsviter.");
        }

    }
}
