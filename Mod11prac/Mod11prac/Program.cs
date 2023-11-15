using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeelib;

namespace Mod11prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1;

            employee1.name = "Кто то там";
            employee1.vacancy = Vacancies.PoliceOfficer;
            employee1.hireDate = new int[] { 2022, 5, 15 };
            employee1.salary = 250000;

            Console.WriteLine($"Имя: {employee1.name}");
            Console.WriteLine($"Должность: {employee1.vacancy}");
            Console.WriteLine($"Дата приема на работу: {employee1.hireDate[0]}.{employee1.hireDate[1]}.{employee1.hireDate[2]}");
            Console.WriteLine($"Зарплата: {employee1.salary}");

            Console.ReadLine();
        }
    }
}
