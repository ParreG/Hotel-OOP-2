using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Consultant : Person
    {
        Decimal HourlyRate;
        string ConsultingFirm;
        string Expertis;

        public Consultant(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, Decimal hourlyRate,
            string consultingFirm, string expertis, string phoneNumber, string email, string adress) :
            base(name, age, empoyeeId, startDate, salary, phoneNumber, email, adress)
        
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertis = expertis;
        }

        public void GiveAdvice()
        {
            Console.WriteLine($"Den här konsulenten hjälper så mycket med att förbätta hotellet!");
            Console.WriteLine($"Konsulenten har expertis inom {Expertis}");
        }

        public override void DoWork()
        {
            Console.WriteLine("Konsulten erbjuder strategisk rådgivning om hotelsäkerhet");
        }
    }
    
}
