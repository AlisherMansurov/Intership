using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //RangeOfArray Array = new RangeOfArray(-9, 15);

            //// Установка и получение значений
            //Array[-9] = 42;
            //Array[-5] = 20;
            //Array[0] = 30;
            //Array[5] = 45;
            //Array[10] = 10;
            //Array[15] = 15;

            //Console.WriteLine(Array[-9]);
            //Console.WriteLine(Array[-5]);//20
            //Console.WriteLine(Array[0]);
            //Console.WriteLine(Array[5]);
            //Console.WriteLine(Array[10]);
            //Console.WriteLine(Array[15]); //15

            //TASK 2
            GrocerySupermarket zakup = new GrocerySupermarket();
            int[] korzina = { zakup.Bread, zakup.Milk, zakup.eggs };
            zakup.Date = DateTime.Now;
            Zakup(korzina, zakup);
            
        }
        public static void Zakup(int[] korzina, GrocerySupermarket t)
        {
            double sum = 0;
            if (t.Date.TimeOfDay >= t.startTime && t.Date.TimeOfDay <= t.endTime)
            {
                for (int i = 0; i < korzina.Length; i++)
                {
                    sum += korzina[i] - korzina[i] * 0.15;
                }
                Console.WriteLine($"Сумма товаров: {sum} тенге");
            }
            else
            {
                for (int i = 0; i < korzina.Length; i++)
                {
                    sum += korzina[i];
                }
                Console.WriteLine($"Сумма товаров: {sum} тенге");
            }
        }
    }
}
