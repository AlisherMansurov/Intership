using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace Mod11Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            Console.Write("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine($"Укажите данные {i+1}-го сотрудника");
                Console.Write("Введите имя: ");
                string fn = Console.ReadLine();
                Console.Write("Введите Фамилию: ");
                string ln = Console.ReadLine();
                Console.Write("Введите дату принятия на работу дд.ММ.гггг (день.месяц.год):");
                string d = Console.ReadLine();
                DateTime dob;
                while (!DateTime.TryParseExact(d, "dd.MM.yyyy", null, DateTimeStyles.None, out dob));
                Console.Write("Введите должность: ");
                string p = Console.ReadLine();
                Console.Write("Введите пол(М/Ж): ");
                char g = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите зарплату: ");
                int s = Convert.ToInt32(Console.ReadLine());
                manager.AddEmployee(new Employee { FName = fn, LName = ln, HireDate = dob, Position = p, Gender = g, Salary = s });
                Console.WriteLine();
            }

            // Выполнение задач
            Console.WriteLine("вывести полную информацию обо всех сотрудниках; (желательно использовать перегрузку функции ToString())");
            manager.AllEmployees();
            Console.WriteLine();
            Console.WriteLine("вывести полную информацию о сотрудниках, выбранной должности");
            manager.EmployeesByPosition("Менеджер");
            Console.WriteLine();
            Console.WriteLine("найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.");
            manager.ManagersAboveAvgClerkSalary();
            Console.WriteLine();
            Console.WriteLine("распечатать информацию обо всех сотрудниках, принятых на работу позже определенной даты (дата передается пользователем), отсортированную в алфавитном порядке по фамилии сотрудника.");
            manager.EmployeesHiredAfterDate(new DateTime(2022, 3, 1));
            Console.WriteLine();
            Console.WriteLine("Вывести информацию о всех мужчинах, женщинах в зависимости от того что передаст пользователь. Предусмотреть случай, когда, пользователь не выбирает конкретный пол, т.е. просто хочет получить информацию о всех.");
            manager.EmployeesByGender('М');
        }
    }
}
