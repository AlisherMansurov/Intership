using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Task1");
            //int i = 0;
            //int s = 0;
            //string str = "";
            //string temp = "";
            //while (i==0)
            //{
            //    temp = Console.ReadLine();
            //    if (temp.Equals("."))
            //    {
            //        i = 1;
            //    }
            //    str = str + temp;
            //}
            //for (int j = 0; j < str.Length; j++)
            //{
            //    if (str[j].Equals(' ')) {
            //        s++;
            //    }
            //}
            //Console.WriteLine($"количество пробелов - {s}");

            //Console.WriteLine("Task2");
            //Console.WriteLine("введите счастливый билет:");
            //string temp = Console.ReadLine();
            //int b1 = Convert.ToInt32(temp[0]+ temp[1]+ temp[2]);
            //int b2 = Convert.ToInt32(temp[3] + temp[4] + temp[5]);
            //b1 = (b1 / 100) + (b1 % 100 / 10) + (b1 % 10);
            //b2 = (b2 / 100) + (b2 % 100 / 10) + (b2 % 10);
            //if (b1 == b2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //Console.WriteLine("Task3");
            //int A = 3;
            //int B = 7;
            //for (int i = A; i <= B; i++) {
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //    Console.Write("\n");
            //}

            //Console.WriteLine("Task4");
            //string N = Console.ReadLine();
            //char[] C = N.ToCharArray();
            //Array.Reverse(C);
            //Console.WriteLine(C);

            //Console.WriteLine("Task5");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = 7 * (x * x) - 3 * x + 6;
            //Console.WriteLine(y);

            //Console.WriteLine("Task6");
            //int a = Convert.ToInt32(Console.ReadLine());
            //x = 12 * (x * x) + 7 * a - 16;
            //Console.WriteLine(x);

            //Console.WriteLine("Task7");
            //Console.WriteLine("Введите а:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Периметр равен {4 * a}");

            //Console.WriteLine("Task8");
            //Console.WriteLine("Введите r:");
            //int r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Диаметр равен {2 * r}");

            //Console.WriteLine("Task9");
            //double R = Math.Sqrt(Math.Pow(6350.0 + 1.0, 2) - Math.Pow(6350.0, 2));
            //Console.WriteLine($"Расстояние до линии горизонта {R}");

            //Console.WriteLine("Task10");
            //Console.Write("Введите x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //double z = x * 3 - 2.5 * x * y + 1.78 * (x * x) - 2.5 * y + 1;

            //Console.WriteLine("Task11");
            //Console.Write("Введите первое число:");
            //double h = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите второе число:");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.Write($"среднее арифметическоe: {(h+b)/2}");
            //Console.Write($"среднее геометрическое: {Math.Pow(h + b, 1.0 / 3)}");

            //Console.WriteLine("Task12");
            //Console.Write("Введите массу тела:");
            //double m = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите объем тела:");
            //double v = Convert.ToDouble(Console.ReadLine());
            //Console.Write($"Плотнасть тела равна: {m/v}");

            //Console.WriteLine("Task13");
            //int a = 1; 
            //int b = 2;
            //int c = 3;
            //int Temp = b;
            //b = c;
            //c = a;
            //a = Temp;
            //Console.WriteLine($"A) a,b,c - {a}, {b}, {c}");
            //a = 1;
            //b = 2;
            //c = 3;
            //Temp = b;
            //b = a;
            //a = c;
            //c = Temp;
            //Console.WriteLine($"B) a,b,c - {a}, {b}, {c}");

            //Console.WriteLine("Task14");
            //bool X = false;
            //bool Y = true;
            //bool Z = false;
            //Console.WriteLine($" X или Z - {X || Z}");
            //Console.WriteLine($" X и Y - {X && Y}");
            //Console.WriteLine($" X и Z - {X && Z}");

            //Console.WriteLine("Task15");
            //double v1 = 15.4;
            //double v2 = 15.7;
            //if (v1 > v2) {
            //    Console.WriteLine("v1 больше v2");
            //}
            //else {
            //    Console.WriteLine("v2 больше v1");
            //}

            //Console.WriteLine("Task16");
            //double feet = 378;
            //double kilometr = 1.0;
            //if (feet * 0.0003048 > kilometr) {
            //    Console.WriteLine($"километр меньше чем {feet} футов");
            //}
            //else {
            //    Console.WriteLine($"{feet} футов меньше чем километр");
            //}

            //Console.WriteLine("Task17");
            //Console.Write("Введите натуральное число:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 1)
            //{
            //    Console.WriteLine("число нечетное");
            //}
            //else {
            //    Console.WriteLine("число четное");
            //}
            //if (a % 10 == 7) {
            //    Console.WriteLine("число оканчивается на 7");
            //}
            //else {
            //    Console.WriteLine("число не оканчивается на 7");
            //}


            //Console.WriteLine("Task18");
            //Console.Write("Введите двухзначное число:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a/10 > a%10) {
            //    Console.WriteLine("первое число больше");
            //}
            //else if (a / 10 < a % 10) {
            //    Console.WriteLine("второе число больше");
            //}
            //else {
            //    Console.WriteLine("числа равны");
            //}

            //if (a / 10 == a % 10)
            //{
            //    Console.WriteLine("цифры одинаковы");
            //}
            //else
            //{
            //    Console.WriteLine("цифры не одинаковы");
            //}

            Console.WriteLine("Task19");
            Console.Write("Введите день недели: ");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Понелеьник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }

            Console.WriteLine("Task20");
            Console.Write("порядковый номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
            }
        }
    }
}
