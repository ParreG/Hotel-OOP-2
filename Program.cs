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
            hotelStaff.Add(new Manager("Anna Gabrielsson", 40, "W001", new DateTime(2024, 2, 14), 45000m, "Administration"));
            hotelStaff.Add(new Employee("Ahmed Lato", 56, "M036", new DateTime(1990, 01, 1), 29999m, "Fix och trix", "Vaktmästare"));
            hotelStaff.Add(new Manager("Pablo Rudrigez", 45, "M002", new DateTime(2018, 5, 1), 55000m, "Operations"));
            hotelStaff.Add(new Consultant("Sara Lindberg", 38, "C002", new DateTime(2023, 3, 1), 1200m, "Fix och trix", 500, "ClockWork", "Städning"));
            hotelStaff.Add(new Employee("Kalle Persson", 33, "E003", new DateTime(2020, 11, 1), 35000m, "Kök", "Kock"));
            hotelStaff.Add(new Manager("Eva Karlsson", 50, "M003", new DateTime(2015, 2, 1), 58000m, "HR"));
            List<Person> staff = new List<Person>();

            // Lägg till olika typer av anställda i listan
            staff.Add(new Manager("Abdoll Ali", 26, "U9731", new DateTime(2023, 12, 20), 36000m, "VD"));   // Manager
            staff.Add(new Consultant("Apo Mohammed", 32, "M2314", new DateTime(2023, 06, 24), 85000m, "IT säkerhet", 531, "Academic Work", "It säkerhet"));   // Consultant
            staff.Add(new Employee("Johan Andersson", 28, "E002", new DateTime(2021, 9, 15), 32000m, "Front Desk", "Reception"));    // Employee
            staff.Add(new Housekeeper("Anna Eriksson", 19, "L0921", new DateTime(2020, 10, 13), 19000m, "Fix och trix", "Städerska"));  // Housekeeper

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
            double averageAge = hotelStaff.Average(p => p.Age);
            decimal employerSalary = hotelStaff.Sum(p => p.Salary);
            decimal employerFee = employerSalary * 0.3141m;
            decimal totalEmployerCost = employerFee + employerSalary;


            Console.WriteLine($"\n||Total månadslön för anställda||\nExklusiv Arbetsgivaravgift: {employerSalary:C}\nArbbetsgivaravgiften är: {employerFee:C}");
            Console.WriteLine($"Totalt personal kostnad: {totalEmployerCost:C}");
            Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1} år");
        }
        
    }
}


