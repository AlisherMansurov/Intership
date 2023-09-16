using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mod03Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Task1");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    A[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}

            //Console.WriteLine("Task2");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    A[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            //int max = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    if (A[i] > max)
            //    {
            //        max = A[i];
            //    }
            //}
            //int ind = Array.IndexOf(A, max);
            //Console.WriteLine($"\nиндекс максимального значения - {ind}");

            //Console.WriteLine("Task3");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    A[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            //int max = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    if (A[i] > max && A[i] % 2 == 0)
            //    {
            //        max = A[i];
            //    }
            //}
            //Console.WriteLine($"\nМаксимальное четное значение - {max}");

            //Console.WriteLine("Task4");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ: ");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine("\nВведите индекс элемента массива который хотите удалить");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = n; i < A.Length - 1; i++)
            //{
            //    A[i] = A[i + 1];
            //}
            //Array.Resize(ref A, A.Length - 1);
            //Console.WriteLine("МАССИВ после: ");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}

            //Console.WriteLine("Task5");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ: ");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine("\nВведите элемент массива который хотите удалить");
            //int n = Convert.ToInt32(Console.ReadLine());
            //A = A.Where(e => e != n).ToArray();
            //Console.WriteLine("МАССИВ после: ");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}

            //Console.WriteLine("Task6");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //for (int i = 0; i < A.Length; i++) {
            //    A[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ: ");
            //for (int i = 0; i < A.Length; i++) {
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine("\nВведите элемент который хотите добавить в массив: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\nВведите индекс массива куда хотите добавить в элемент: ");
            //int ind = Convert.ToInt32(Console.ReadLine());
            //int[] Na = new int[5 + 1];
            //Console.WriteLine("МАССИВ после: ");
            //for (int i = 0; i < Na.Length; i++) {
            //    if (i == ind) {
            //        Na[i] = n;
            //    }
            //    else if (i > ind) {
            //        Na[i] = A[i - 1];
            //    }
            //    else if (i < ind) {
            //        Na[i] = A[i];
            //    }
            //}
            //A = Na;
            //for (int i = 0; i < A.Length; i++) {
            //    Console.Write(A[i] + " ");
            //}

            //Console.WriteLine("Task7");
            //int[] A = { 1, 2, 3, 3, 4, 5 };
            //Dictionary<int, int> ECount = new Dictionary<int, int>();
            //foreach (int item in A) {
            //    if (ECount.ContainsKey(item)) {
            //        ECount[item]++;
            //    }
            //    else {
            //        ECount[item] = 1;
            //    }
            //}
            //for (int i = 0; i < A.Length; i++) {
            //    int item = A[i];
            //    if (ECount[item] == 2) {
            //        A = A.Where((val, idx) => idx != i).ToArray();
            //        i--;
            //    }
            //}
            //Console.WriteLine("МАССИВ после: ");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}

            //Console.WriteLine("Task8");
            //string str = "Коля вчера уехал в город за грибами";
            //int s, e;
            //for (int i = 0; i < str.Length; i++)
            //    if (str[i] == 'а') {
            //        s = 0;
            //        for (int j = i - 1; j >= 0; j--)
            //            if (str[j] == ' ') {
            //                s = j;
            //                j = 0;
            //            }
            //        e = str.Length;
            //        for (int j = i + 1; j < str.Length; j++)
            //            if (str[j] == ' ')
            //            {
            //                e = j;
            //                j = str.Length;
            //            }
            //        str = str.Remove(s, e - s);
            //        i = s;
            //    }
            //Console.WriteLine(str);

            //Console.WriteLine("Task9");
            //Random rnd = new Random();
            //int[,] B = new int[5, 5];
            //Console.WriteLine("\nМАССИВ: ");
            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j < 5; j++) {
            //        B[i, j] = rnd.Next(10, 31);
            //    }
            //}
            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j < 5; j++) {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int t = 0;
            //int s = 0;
            //int ti = 0;
            //int[] n = new int[5];
            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j < 5; j++) {
            //        t = B[j, i];
            //        for (int k = 0; k < 5; k++) {
            //            if (B[k, i] == t) {
            //                s++;
            //                if (s >= 2) {
            //                    n[ti] = i+1;
            //                    ti++;
            //                    k = 5;
            //                    j = 5;
            //                }
            //            }
            //        }
            //        s = 0;
            //    }
            //}
            //for ( int i = 0; i < 5; i++) {
            //    if (n[i] != 0) {
            //        s++;
            //    }
            //}
            //int[] rn = new int[s];
            //int x = 0;
            //Console.WriteLine();
            //for (int i = 0; i < 5; i++) {
            //    if (n[i] != 0) {
            //        rn[x] = n[i]-1;
            //        x++;
            //    }
            //}
            //int[,] Rb = new int[5, 5-s];
            //for (int i = 0; i < 5; i++) {
            //    x = 0;
            //    for (int j = 0; j < 5; j++) {
            //        if (rn.Contains(j) != true) {
            //            Rb[i, x] = B[i, j];
            //            x++;
            //        }
            //    }
            //}
            //Console.WriteLine("\nМАССИВ после: ");
            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j < 5-s; j++)
            //    {
            //        Console.Write(Rb[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Task10");
            //string c = " ";
            //int s = 0;
            //Console.WriteLine("Введите символы: ");
            //while (c != ".")
            //{
            //    c = Console.ReadLine();
            //    if (c == " ") {
            //        s++;
            //    }
            //}
            //Console.WriteLine($"Количество введенных пробелов: {s}");

            //Console.WriteLine("Task11");
            //Console.WriteLine("введите номер трамвайного билета:");
            //string temp = Console.ReadLine();
            //int b1 = Convert.ToInt32(temp[0] + temp[1] + temp[2]);
            //int b2 = Convert.ToInt32(temp[3] + temp[4] + temp[5]);
            //b1 = (b1 / 100) + (b1 % 100 / 10) + (b1 % 10);
            //b2 = (b2 / 100) + (b2 % 100 / 10) + (b2 % 10);
            //if (b1 == b2)
            //{
            //    Console.WriteLine("Билет счастливый");
            //}
            //else
            //{
            //    Console.WriteLine("Билет не счастливый");
            //}

            //Console.WriteLine("Task12");
            //Console.WriteLine("Введите строку: ");
            //string str = Console.ReadLine();
            //int s = 0;
            //for (int i = 0; i < str.Length; i++) {
            //    if (str[i] == 'P') {
            //        s++;    
            //    }
            //}
            //Console.WriteLine($"Количество вхождений буквы P - {s}");

            //Console.WriteLine("Task13");
            //string r = "345";
            //string t = "";
            //for (int i = r.Length - 1; i >= 0; i--)
            //    t += r[i];
            //Console.WriteLine(t);

            //Console.WriteLine("Task14");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //int[,] B = new int[4, 3];
            //Console.WriteLine("Введите масив А");
            //for (int i = 0; i < 5; i++) {
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("МАССИВ A: ");
            //for (int i = 0; i < 5; i++) {
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine("\nМАССИВ В: ");
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        B[i, j] = rnd.Next(1, 21);
            //    }
            //}
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int max = 0;
            //int min = A[0];
            //int sum = 0;
            //int pro = 1;
            //int sumA = 0;
            //int sumB = 0;
            //for (int i = 0; i < 5; i++) {
            //    if (A[i] > max) {
            //        max = A[i];
            //    }
            //    if (A[i] < min) {
            //        min = A[i];
            //    }
            //    sum += A[i];
            //    pro *= A[i];
            //    if (i % 2 == 0) {
            //        sumA += A[i];
            //    }
            //}
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        if (B[i, j] > max) {
            //            max = B[i, j];
            //        }
            //        if (B[i, j] < min) {
            //            min = B[i, j];
            //        }
            //        sum += B[i, j];
            //        pro *= B[i, j];
            //        if (j % 2 == 1) {
            //            sumB += B[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"Максимальный общий элемент - {max}");
            //Console.WriteLine($"Минимальный общий элемент - {min}");
            //Console.WriteLine($"Общая сумма - {sum}");
            //Console.WriteLine($"Общее произведение - {pro}");
            //Console.WriteLine($"Сумма А - {sumA}");
            //Console.WriteLine($"Сумма В - {sumB}");

            Console.WriteLine("Task15");
            string str = "dade/da/efef/da/fefefsf\\fefsef\\edfef";
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '/') {
                   str = str.Remove(i, 1);
                }
                if (str[i] == '\\') {
                    str = str.Remove(i, 2);
                }
            }
            Console.WriteLine(str);
        }
    }
}
