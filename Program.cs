using System.Xml.Linq;
using System.Globalization;

namespace Hotel_OOP_2
{
    internal class Program
    {
        static void Seperator()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            // Ställer in den globala kulturen till svenska (Sverige)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE"); 


            List<Person> hotelStaff = new List<Person>();

            // Lägg till olika typer av anställda i listan
            hotelStaff.Add(new Manager("Anna Gabrielsson", 40, "W001", new DateTime(2015, 2, 14), 45000m, "Administration", "073-1234567", "anna.gabrielsson@adminmail.com",
                "Storgatan 5", 5, 10 , Manager.ManagementLevel.Middle));

            hotelStaff.Add(new Employee("Ahmed Lato", 56, "M036", new DateTime(1990, 01, 1), 29999m, "Fix och trix", "Vaktmästare", "070-9876543", "ahmed.lato@handyman.se",
                "Långgatan 12", Employee.ShiftPreference.Morning, 32, 92m));

            hotelStaff.Add(new Manager("Pablo Rudrigez", 45, "M002", new DateTime(2018, 5, 1), 55000m, "Operations", "076-7654321", "pablo.rudrigez@operations.com", "Björkvägen 3",
                 8, 12, Manager.ManagementLevel.Senior));

            hotelStaff.Add(new Consultant("Sara Lindberg", 38, "C002", new DateTime(2023, 3, 1), 1200m, "Fix och trix", 500, "ClockWork", "Städning", "072-2345678", "sara.lindberg@clockwork.se",
                "Ringvägen 8"));

            hotelStaff.Add(new Employee("Kalle Persson", 33, "E003", new DateTime(2020, 11, 1), 35000m, "Kök", "Kock", "079-8765432", "kalle.persson@chef.se", "Torget 9", Employee.ShiftPreference.Morning,
                25, 87m));

            hotelStaff.Add(new Manager("Eva Karlsson", 50, "M003", new DateTime(2015, 2, 1), 58000m, "HR", "073-4567890", "eva.karlsson@hrteam.com", "Strandvägen 2",
                 18, 20, Manager.ManagementLevel.Senior));

            List<Person> staff = new List<Person>();

            // Lägg till olika typer av anställda i listan
            staff.Add(new Manager("Abdoll Ali", 26, "U9731", new DateTime(2023, 12, 20), 36000m, "VD", "070-6543210", "abdoll.ali@ceo.se", "Kyrkogatan 4",
                 2, 3, Manager.ManagementLevel.Joniur));

            staff.Add(new Consultant("Apo Mohammed", 32, "M2314", new DateTime(2023, 06, 24), 85000m, "IT säkerhet", 531, "Academic Work", "It säkerhet", "076-5432109",
                "apo.mohammed@itsecure.com", "Skolgatan 11"));

            staff.Add(new Employee("Johan Andersson", 28, "E002", new DateTime(2021, 9, 15), 32000m, "Front Desk", "Reception", "072-3456789", "johan.andersson@reception.com",
                "Fyrvägen 14", Employee.ShiftPreference.Morning, 18, 69m));

            staff.Add(new Housekeeper("Anna Eriksson", 19, "L0921", new DateTime(2020, 10, 13), 19000m, "Fix och trix", "Städerska", "079-2345678", "anna.eriksson@cleaningcrew.com", "Gröna gatan 6"));

            Console.WriteLine("Hotellets personal består av: ");
            Console.WriteLine();

            foreach (var person in hotelStaff)
            {            
                person.PrintInfo();
                person.Intruduce();

                if (person is Manager manager)
                {
                    manager.Holdmeeting();
                    manager.PlanBudget();
                }
                else if (person is Employee employee)
                {
                    employee.Work();
                }
                else if (person is Consultant consultant)
                {
                    consultant.GiveAdvice();
                }
                Console.WriteLine();
                Seperator(); // Lägger till en avgränsare för läsbarhet
                Console.WriteLine();

            }



            foreach (var Person in staff)
            {
                Person.DoWork();
            }

            Console.WriteLine();
            double averageAge = hotelStaff.Average(p => p.Age) + staff.Average(p1 => p1.Age); ;
            decimal employerSalary = hotelStaff.Sum(p => p.Salary) + staff.Sum(p1 => p1.Salary);
            decimal employerFee = employerSalary * 0.3141m;
            decimal totalEmployerCost = employerFee + employerSalary;


            Console.WriteLine($"\n||Total månadslön för anställda||\nExklusiv Arbetsgivaravgift: {employerSalary:C}\nArbbetsgivaravgiften är: {employerFee:C}");
            Console.WriteLine($"Totalt personal kostnad: {totalEmployerCost:C}");
            Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1} år");

            for (int i = 0; i < hotelStaff.Count; i++)
            {
                hotelStaff[i].CalculateYearsOfService();
            }

            
        }
        
    }
}


