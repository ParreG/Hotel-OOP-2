using System.Xml.Linq;

namespace Hotel_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
                ("Anna Gabrielsson", 40, "W001", new DateTime(2024, 2, 14), 45000, "Administration");

            Employee employee = new Employee
                ("Ahmed Lato", 56, "M036", new DateTime(1990, 01, 1), 29999, "Fix och trix", "Vaktmästare");
            Consultant consultant = new Consultant
                ("Apo Mohammed", 32, "M2314", new DateTime(2023, 06, 24), 85000, "IT säkerhet", 531, "Academic Work", "It säkerhet");

            List<Person> hotelStaff = new List<Person>();

            // Lägg till olika typer av anställda i listan
            hotelStaff.Add(new Manager("Maria Svensson", 45, "M002", new DateTime(2018, 5, 1), 55000m, "Operations"));
            hotelStaff.Add(new Employee("Johan Andersson", 28, "E002", new DateTime(2021, 9, 15), 32000m, "Front Desk", "Reception"));
            hotelStaff.Add(new Consultant("Sara Lindberg", 38, "C002", new DateTime(2023, 3, 1), 1200m, "Fix och trix", 500, "ClockWork", "Städning"));
            hotelStaff.Add(new Employee("Kalle Persson", 33, "E003", new DateTime(2020, 11, 1), 35000m, "Kök", "Kock"));
            hotelStaff.Add(new Manager("Eva Karlsson", 50, "M003", new DateTime(2015, 2, 1), 58000m, "HR"));

            Console.WriteLine("Hotellets personal består av: ");



            // Anropa metoder för att testa
            Console.WriteLine("Manager:");
            manager.PrintInfo();
            manager.Intruduce();
            manager.holdmeeting();

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Intruduce();
            employee.Work();

            Console.WriteLine("\nKonsulent:");
            consultant.PrintInfo();
            consultant.Intruduce();
            consultant.GiveAdvice();


        }
    }

    class Person
    {
        public string Name { get; set; }
        int Age { get; set; }
        string Emloyeeid { get; set; }
        DateTime Startdate { get; set; }
        decimal Salary { get; set; }

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
            Console.WriteLine("Personal info:");
            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}");
        }

        public void Intruduce()
        {
            Console.WriteLine($"Hej jag heter {Name}. Jag är {Age} år gammal. ");
        }

    }

    class Manager : Person
    {
        public string Department { get; set; }

        public Manager(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department) : base (name, age, empoyeeId, startDate, salary)
        {
            Department = department;
        }

        public void holdmeeting()
        {
            Console.WriteLine("Jag håller ett personal möte på hotellet.");
        }

        public void PlanBudget()
        {
            Console.WriteLine("Chefen planerar budgeten!");
        }

    }

    class Employee : Person
    {

        string Jobtitle { get; set; }

        public Employee(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string jobTitle) : base (name, age, empoyeeId, startDate, salary)
        {
            Jobtitle = jobTitle; 
        }

        public void Work()
        {
            Console.WriteLine($"{Name} arbetar just nu med att fixa entre dörren!");
        }
    }

    class Consultant : Person
    {
        Decimal HourlyRate;
        string ConsultingFirm;
        string Expertis;

        public Consultant (string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, Decimal hourlyRate, string consultingFirm, string expertis) : base(name, age, empoyeeId, startDate, salary)
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
    }

    class Housekeeper : Person
    {
        public Housekeeper(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string department, string jobTitle) : base(name, age, empoyeeId, startDate, salary)
        {

        }


    }
}


