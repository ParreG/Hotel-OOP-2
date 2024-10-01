using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Employee : Person
    {

        string Jobtitle;
        public enum ShiftPreference
        {
            Morning,
            Evning,
            Night
        }
        public ShiftPreference Shift;
        int VacationDays;
        decimal PerformanceRating;
        public Employee(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string jobTitle, string phoneNumber,
            string email, string adress,  ShiftPreference shift, int vacation, decimal performanceRating) : 
            base (name, age, empoyeeId, startDate, salary, phoneNumber, email, adress)
        {
            Jobtitle = jobTitle;
            Shift = shift;
            VacationDays = vacation;
            PerformanceRating = performanceRating;

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
