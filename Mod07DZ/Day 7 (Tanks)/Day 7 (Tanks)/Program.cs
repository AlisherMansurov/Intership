using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace Day_7__Tanks_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank T34 = new Tank();
            T34.name = "T-34";
            Thread.Sleep(1);
            Tank Pantera = new Tank();
            Pantera.name = "Pantera";
            //Вывод ТТХ танка через метод ToString
            Console.WriteLine(T34);
            Console.WriteLine(Pantera);
            //Проверка на победу в бою одного танка по отношению к другому
            Console.WriteLine($"{T34 * Pantera} одержал победу!");
        }
    }
}
