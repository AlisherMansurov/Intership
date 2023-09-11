using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mod02prak
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            //Console.WriteLine("1  2  3");

            //Console.WriteLine("5 \n10 \n21");

            //Console.WriteLine((double)10/100);

            //Console.WriteLine(234/7);

            //int a = 99;
            //Console.WriteLine($"число десятков - {a/10}");
            //Console.WriteLine($"число единиц - {a % 10}");
            //Console.WriteLine($"сумма цифр - {(a / 10) + (a % 10)}");
            //Console.WriteLine($"произведение цифр - {(a / 10) * (a % 10)}");

            //bool A = true;
            //bool C = false;
            //bool B = false;
            //Console.WriteLine(A || B);
            //Console.WriteLine(A && B);
            //Console.WriteLine(B || C);

            //a = 20;
            //int r = 10;
            //if (a * a > 3.14 * r * r) 
            //{
            //    Console.WriteLine("Площадь квадрата больше");
            //}
            //else
            //{
            //    Console.WriteLine("Площадь круга больше");
            //}

            //int v1 = 23;
            //int m1 = 40;
            //int v2 = 21;
            //int m2 = 37;
            //if (m1 / v1 > m2 / v2)
            //{
            //    Console.WriteLine("Плотность тела 1 больше");
            //}
            //else
            //{
            //    Console.WriteLine("Плотность тела 2 больше");
            //}

            //int U1 = 30;
            //int U2 = 30;
            //int R1 = 4;
            //int R2 = 2;
            //if (U1 / R1 < U2 / R2)
            //{
            //    Console.WriteLine("Сила тока меньше в 1 цепи");
            //}
            //else
            //{
            //    Console.WriteLine("Сила тока меньше в 2 цепи");
            //}

            //for (int i = 20; i <= 35; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Введите b-");
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = 10; i <= b; i++)
            //{
            //    Console.WriteLine(i*i);
            //}
            //Console.WriteLine("Введите a-");
            //a = Convert.ToInt32(Console.ReadLine());
            //for (int i = a; i <= 50; i++)
            //{
            //    Console.WriteLine(i * i * i);
            //}
            //Console.WriteLine("Введите a-");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите b-");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (b > a)
            //{
            //    for (int i = a; i <= b; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Введите x-");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = 3 * x ^ 2 + 2 * x + 4;
            //Console.WriteLine($"y = {y}");

            //Console.WriteLine("Введите радиус r-");
            //r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Длина окружности - {2 * 3.14 * r} \n площадь круга - {3.14 * r * r}");

            //Console.WriteLine("Введите четырехзначное число: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Сумма цифр - {(c/1000) + (c/100 % 10) + (c / 10 % 10) + (c % 10)}");
            //Console.WriteLine($"произведение цифр - {(c / 1000) * (c / 100 % 10) * (c / 10 % 10) * (c % 10)}");

            //int r = 456;
            //Console.WriteLine($"1 - {r / 100}");
            //Console.WriteLine($"1 - {r % 100 / 10}");
            //Console.WriteLine($"1 - {r % 10}");
            //int x = 100 * (r / 100)+10*(r % 10)+(r % 100 / 10);
            //Console.WriteLine(x);

            //bool X = true;
            //bool Y = false;
            //Console.WriteLine(!X&&!Y);
            //Console.WriteLine(X || (!X&&Y));
            //Console.WriteLine((!X&&Y)||Y);

            //int a = 3;
            //int b = 4;
            //int x = 4;
            //int y = 2;
            //swap(ref a, ref b);

            //f(ref a, ref b, x, y);
            //Console.WriteLine($"{a} \n {b}");

            //int m1 = 4;
            //int m2 = 2;
            //int m3 = 1;

            //if (m1 < m2 && m1 < m3)
            //{
            //    Console.WriteLine($"наименьшее число {m1}");
            //}
            //else if (m2 < m1 && m2 < m3)
            //{
            //    Console.WriteLine($"наименьшее число {m2}");
            //}
            //else
            //{
            //    Console.WriteLine($"наименьшее число {m3}");
            //}

            //Random rnd = new Random();
            //int randomN = rnd.Next(2, 6);
            //switch (randomN)
            //{
            //    case 2:
            //        Console.WriteLine("Неуд");
            //        break;
            //    case 3:
            //        Console.WriteLine("Удовл");
            //        break;
            //    case 4:
            //        Console.WriteLine("Хорош");
            //        break;
            //    case 5:
            //        Console.WriteLine("Отлич");
            //        break;
            //}

            //int M = 10;
            //int N = 20;
            //Console.WriteLine(f(M, N));
            //

            int N = 8;
            int n = 5;

            int result = f(N, n);

            Console.WriteLine($"Наименьшее число, большее или равное {N}, которое делится нацело на {n}, это {result}");


        }
        //public static void swap(ref int a, ref int b) {
        //  int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //static int f(int a, int b, int x, int y)
        //{
        //    if (y<x)
        //    {
        //        a = x * y;
        //        b = x / y;
        //        return a;
        //    }
        //    else
        //    {
        //        a = y * x;
        //        b = y / x;
        //        return b;
        //    }

        //}

        //static int f(int x, int y)
        //{
        //    if (x == 0 && y == 0)
        //    {
        //        return 0;
        //    }
        //    else if (y == 0)
        //    {
        //        return 12 / x;
        //    }
        //    else if (x == 0)
        //    {
        //        return 12 / y;
        //    }
        //    else
        //    {
        //        return 144 / (x * y);
        //    }
        //}

        //static int f(int h, int m, int s)
        //{
        //    return h * 3600 + m * 60 + s;
        //}

        //static int f(int m, int d)
        //{
        //    return m * 30 + d;
        //}

        //static int f(int m1, int m2, int m3)
        //{
        //    if (m1 < m2 && m1<m3)
        //    {
        //        return m1;
        //    }
        //    else if (m2 < m1 && m2 < m3)
        //    {
        //        return m2;
        //    }
        //    else 
        //    {
        //        return m3;
        //    }
        //}

        //static bool even(int n)
        //{
        //    if (n%2 == 1)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //static int f(int M, int N)
        //{
        //    int s = 0;
        //    for (int i = M; i <= N; i++) {
        //        if (i % 2 == 1)
        //        {
        //            s += i;
        //        }
        //    }
        //    return s;
        //}

        static int f(int N, int n)
        {
            int result = N; 

            while (result % n != 0)
            {
                result++; 
            }

            return result;
        }
    }
}
