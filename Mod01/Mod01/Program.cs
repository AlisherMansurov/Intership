using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое ФИО: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Приветствую {name}");
            Console.WriteLine("--------------------");
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма равна - {a + b}");
        }
    }
}
