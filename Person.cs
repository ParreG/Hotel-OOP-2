using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_OOP_2
{
    class Person
    {
        public string Name;
        public int Age;
        string Emloyeeid;
        DateTime Startdate;
        public decimal Salary;
        string PhoneNumber;
        string Email;
        string Adress;

        public Person(string name, int age, string empoyeeId, DateTime startDate, decimal salary, string phoneNumber, string email, string adress)
        {
            Name = name;
            Age = age;
            Emloyeeid = empoyeeId;
            Startdate = startDate;
            Salary = salary;
            PhoneNumber = phoneNumber;
            Email = email;
            Adress = adress;
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

        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
        }

        public void CalculateYearsOfService()
        {

            Console.WriteLine($"{Name} har arbetat här i {(DateTime.Now - Startdate).Days / 365} År");
        }

        public void ChangeEmployeeId(string newId)
        {
            Emloyeeid = newId;
        }

        public void UpdateContactInfo(string phone, string email, string address)
        {
            PhoneNumber = phone;
            Email = email;
            Adress = address;
        }

    }
}
