using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod07prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Task1 obj1 = new Task1(1, "Hello");
            //Task1 obj2 = new Task1(1, "Hello");

            //// Проверка на равенство с использованием оператора ==
            //if (obj1 == obj2)
            //{
            //    Console.WriteLine("obj1 и obj2 равны");
            //}            
            //else
            //{
            //    Console.WriteLine("obj1 и obj2 не равны");
            //}

            //// Проверка на неравенство с использованием оператора !=
            //if (obj1 != obj2)
            //{
            //    Console.WriteLine("obj1 и obj2 не равны");
            //}
            //else
            //{
            //    Console.WriteLine("obj1 и obj2 равны");
            //}

            //// Проверка на равенство с использованием Equals
            //if (obj1.Equals(obj2))
            //{
            //    Console.WriteLine("obj1 и obj2 равны (с использованием Equals)");
            //}


            //TASK 2
            //Task2 arr1 = new Task2(new int[] { 1, 2, 3 });
            //Task2 arr2 = new Task2(new int[] { 4, 5, 6 });

            //if (arr1 > arr2)
            //{
            //    Console.WriteLine("arr1 больше чем arr2");
            //}
            //else if (arr1 < arr2)
            //{
            //    Console.WriteLine("arr1 меньше чем arr2");
            //}
            //else
            //{
            //    Console.WriteLine("arr1 равно arr2");
            //}


            //TASK 3-4
            Task2 arr3 = new Task2(new int[] { 1, 2, 3});
            Task2 arr4 = new Task2(new int[] { 4, 5, 6});
            Task2 resArr1 = arr3 * arr4;

            Console.WriteLine("умножение массивов" + resArr1);

            Console.WriteLine("доступ по индексу" + resArr1[1]);

            Console.WriteLine("размер массива" + resArr1.Length);

            Console.WriteLine("проверка на равенство" + (arr3 ==arr4));

            Console.WriteLine("сравнение" + (arr3 <= arr4));

            Task2 resArr2 = arr3 + arr4;

            Console.WriteLine("объединение массивов" + resArr2);

            Console.WriteLine("проверка на неравенство" + (resArr2 != resArr1));
        }
    }
}
