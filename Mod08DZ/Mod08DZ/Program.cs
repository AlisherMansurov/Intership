using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Task1 squaredArray = new Task1(5);

            ////Задаем значение через индексатор
            //squaredArray[0] = 1;
            //squaredArray[1] = 2;
            //squaredArray[2] = 3;

            //Console.WriteLine(squaredArray[0]); //1
            //Console.WriteLine(squaredArray[1]); //4
            //Console.WriteLine(squaredArray[2]);

            //TASK 2
            Console.Write("Введите площадь помещения (в м^2): ");
            double squareArea = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество проживающих людей: ");
            int numberOfResidents = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сезон (1 - Весна, 2 - Лето, 3 - осень или 4 - зима): ");
            int season = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите наличие льгот (1 - ветеран труда, 2 - ветеран войны, 3 - без льгот): ");
            int discountType = Convert.ToInt32(Console.ReadLine());

            // Базовые тарифы
            double heatingRate = 10;  // Тариф на отопление (на 1 м^2)
            double waterRate = 5;     // Тариф на воду (на 1 человека)
            double gasRate = 3;       // Тариф на газ (на 1 человека)
            double repairRate = 7;    // Тариф на текущий ремонт (на 1 м^2)

            // Расчет начислений
            double heatingPayment;
            if (season >= 3)
            {
                heatingPayment = squareArea * heatingRate + (squareArea * heatingRate)*0.5;
            }
            else 
            {
                heatingPayment = squareArea * heatingRate;
            }
            double waterPayment = numberOfResidents * waterRate;
            double gasPayment = numberOfResidents * gasRate;
            double repairPayment = squareArea * repairRate;

            // Расчет льгот
            double discount = 0;
            if (discountType == 1) // Ветеран труда - 30% скидка
            {
                discount = 0.3;
            }
            else if (discountType == 2) // Ветеран войны - 50% скидка
            {
                discount = 0.5;
            }

            // Расчет итого
            double totalPayment = heatingPayment + waterPayment + gasPayment + repairPayment;
            totalPayment = totalPayment - (totalPayment * discount);
            Console.Clear();
            // Вывод таблицы
            Console.WriteLine("Вид платежа\t" + "Начислено\t" + "Льготная скидка\t" + "Итого");
            Console.WriteLine("Отопление\t" + heatingPayment + "\t\t" + discount + "\t\t" + (heatingPayment - heatingPayment*discount));
            Console.WriteLine("Вода\t\t" + waterPayment + "\t\t" + discount + "\t\t" + (waterPayment-waterPayment*discount));
            Console.WriteLine("Газ\t\t" + gasPayment + "\t\t" + discount + "\t\t" + (gasPayment-gasPayment*discount));
            Console.WriteLine("Ремонт\t\t" + repairPayment + "\t\t" + discount + "\t\t" + (repairPayment - repairPayment*discount));
            Console.WriteLine("Итого\t\t" + + totalPayment);

        }
    }
}
