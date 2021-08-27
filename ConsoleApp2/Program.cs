using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kolya = new Employee()
            {
                Name = "Kolya",
                LastName = "Burov",
                profession = "junior"
            };
            Kolya.GetInfo();
            Employee andrey = new Employee()
            {
                Name = "andrey",
                LastName = "Shefchenko",
                profession = "senior"
            };
            andrey.GetInfo();
            Employee fotima = new Employee()
            {
                Name = "Fotima",
                LastName = "Alam",
                profession = "midl"
            };
            fotima.GetInfo();
        }
    }
    class Employee
    {
        public string Name;
        public string LastName;
        public string profession;
        public double Salary;
        public double tax;
        public Employee() { }
        public Employee(string prof, double salary, string name, string lastName, double Csalary) 
        {
            profession = prof; Salary = salary; Name = name; LastName = lastName; tax = Csalary;
        }
        public void GetInfo()
        {
            if (profession == "junior") Salary = 1000;
            else if (profession == "midl") Salary = 2170;
            else if (profession == "senior") Salary = 4500;
            else Console.WriteLine("такой должности в системе нет");
            tax = (Salary * 14) / 100;
            Console.WriteLine($"Имя: {Name}, Фамилия: {LastName}, Должность: {profession}, Зарплата: {Salary}, налог: {tax}, чистая ЗП {Salary - tax}");
        }
        // я добавил 3 ий string чтобы вывести Должность "Надеюсь это не будет считаться минусом"
    }
}
