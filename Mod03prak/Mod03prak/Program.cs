using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mod03prak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////СТРОКИ
            //Console.WriteLine("Task1");
            //string str = "AAAABBBBCCCC";
            //string temp = "AAAA";
            //str = str + temp;
            //str = str.Remove(0, 4);
            //Console.WriteLine(str);
            //str = "AAAABBBBCCCC";
            //str = str.Remove(8, 4);
            //temp = "CCCC";
            //str = temp + str;
            //Console.WriteLine(str);

            //Console.WriteLine("Task2");
            //string str = "plus++minus-p+m-p+m-";
            //int sp = 0;
            //int sm = 0;
            //for (int j = 0; j < str.Length; j++)
            //{
            //    if (str[j].Equals('+'))
            //    {
            //        sp++;
            //    }
            //    if (str[j].Equals('-'))
            //    {
            //        sm++;
            //    }
            //}
            //Console.WriteLine($"количество плюсов - {sp}");
            //Console.WriteLine($"количество минусов - {sm}");

            //Console.WriteLine("Task3");
            //string str = "Я часто хожу в университет. Это пугает.";
            //int s = 0;
            //for (int j = 0; j < str.Length; j++)
            //{
            //    if (str[j].Equals(','))
            //    {
            //        s++;
            //    }
            //    if (str[j].Equals('.'))
            //    {
            //        s++;
            //    }
            //}
            //Console.WriteLine($"количество предложений - {s}");

            //Console.WriteLine("Task4");
            //string str = "ммм нннн";
            //int sm = 0;
            //int sn = 0;
            //for (int j = 0; j < str.Length; j++)
            //{
            //    if (str[j].Equals('м'))
            //    {
            //        sm++;
            //    }
            //    if (str[j].Equals('н'))
            //    {
            //        sn++;
            //    }
            //}
            //if (sm > sn)
            //{
            //    Console.WriteLine($"количество буквы м больше - {sm}");
            //}
            //else
            //{
            //    Console.WriteLine($"количество буквы н больше - {sn}");
            //}


            //Console.WriteLine("Task5");
            //string str = "Терминатор синего цвета спустился с лесТницы";
            //int inds = str.LastIndexOf('с');
            //int indT = str.LastIndexOf('Т');
            //if (inds > indT)
            //{
            //    Console.WriteLine("буква с встречается позже");
            //}
            //else
            //{
            //    Console.WriteLine("буква Т встречается позже");
            //}

            //Console.WriteLine("Task6");
            //string str = "Астана является столицей Казахстана.";
            //int ind = str.IndexOf('а');
            //if (ind >= 0)
            //{
            //    Console.WriteLine($"буква а есть в предложений, её порядочный номер {ind}");
            //}
            //else
            //{
            //    Console.WriteLine("буква а отсутствует в предложений");
            //}

            //Console.WriteLine("Task7");
            //string str = "Летели однажды русский, американец и немец в самолете.";
            //for (int j = 0; j < str.Length; j++)
            //{
            //    if (str[j].Equals('е'))
            //    {
            //        str = str.Remove(j, 1).Insert(j, 'и'.ToString());
            //    }
            //}
            //Console.WriteLine(str);

            //Console.WriteLine("Task8");
            //string str = "Летели однажды русский, американец и немец в самолете.";
            //for (int j = 2; j < str.Length; j+=3)
            //{
            //    str = str.Remove(j, 1).Insert(j, 'а'.ToString());
            //}
            //Console.WriteLine(str);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////МАССИВЫ И СТРОКИ

            //Console.WriteLine("Task1");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //int[,] B = new int[4, 3];
            //Console.WriteLine("Введите масив А");
            //for (int i = 0; i<5 ;i++) {
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("МАССИВ A: ");
            //for (int i = 0; i < 5; i++) {
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine("\nМАССИВ В: ");
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        B[i, j] = rnd.Next(1, 11);
            //    }
            //}
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 3; j++) {
            //       Console.Write(B[i, j] + " ");
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
            //        if (B[i,j] > max) {
            //            max = B[i, j];
            //        }
            //        if (B[i, j] < min) {
            //            min = B[i, j];
            //        }
            //        sum += B[i, j];
            //        pro *= B[i,j];
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

            //Console.WriteLine("Task2");
            //Random rnd = new Random();
            //int max;
            //int min;
            //Console.Write("Введите размерность первого массива: ");
            //int M = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите размерность второго массива: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            //if (M > N) {
            //    max = M;
            //    min = N;
            //}
            //else {
            //    max = N;
            //    min = M;
            //}
            //int[] A1 = new int[M];
            //int[] A2 = new int[N];
            //int[] A3 = new int[M + N];
            //for (int i = 0; i < M; i++) {
            //    A1[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("МАССИВ 1: ");
            //for (int i = 0; i < M; i++) {
            //    Console.Write(A1[i] + " ");
            //}
            //for (int i = 0; i < N; i++) {
            //    A2[i] = rnd.Next(1, 11);
            //}
            //Console.WriteLine("\nМАССИВ 2: ");
            //for (int i = 0; i < N; i++) {
            //    Console.Write(A2[i] + " ");
            //}
            //int a3 = 0;
            //for (int i = 0; i < min; i++) {
            //    for (int j = 0; j < max; j++) {
            //        if (A1[i] == A2[j] && A3.Contains(A1[i]) != true) {
            //            A3[a3] = A1[i];
            //            a3++;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < a3; i++) {
            //    Console.Write(A3[i] + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Task3");
            //Console.WriteLine("Введите слово: ");
            //string str = Console.ReadLine();
            //char[] stringArray = str.ToCharArray();
            //Array.Reverse(stringArray);
            //string reversedStr = new string(stringArray);
            //if (str == reversedStr)
            //{
            //    Console.WriteLine("Слово является палиндромом");
            //}
            //else
            //{
            //    Console.WriteLine("Слово не является палиндромом");
            //}

            //Console.WriteLine("Task4");
            //Console.WriteLine("Введите предложение: ");
            //string str = Console.ReadLine();
            //int s = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i].Equals(' ') || str[i].Equals('.'))
            //    {
            //        s++;
            //    }
            //}
            //Console.WriteLine($"Количество слов в предложений {s}");

            //Console.WriteLine("Task5");
            //Random rnd = new Random();
            //int[,] arr = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arr[i, j] = rnd.Next(-100, 101);
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int min = 0;
            //int max = 0;
            //int mini = 0;
            //int maxi = 0;
            //int minj = 0;
            //int maxj = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (arr[i, j] > max)
            //        {
            //            max = arr[i, j];
            //            maxi = i;
            //            maxj = j;
            //        }
            //        if (arr[i, j] < min)
            //        {
            //            min = arr[i, j];
            //            mini = i;
            //            minj = j;
            //        }
            //    }
            //}
            //int sI,eI,sJ,eJ;
            //int s = 0;
            //if (mini <= maxi) {
            //    sI = mini;
            //}
            //else {
            //    sI = maxi;
            //}
            //if (sI == mini) {
            //    eI = maxi;
            //}
            //else {
            //    eI = mini;
            //}
            //if (minj <= maxj) {
            //    sJ = minj;
            //}
            //else {
            //    sJ = maxj;
            //}
            //if (sJ == minj) {
            //    eJ = maxi;
            //}
            //else {
            //    eJ = mini;
            //}
            //for (int i = sI; i <= eI; i++) {
            //    for (int j = sJ; j <= eJ; j++) {
            //        s += arr[i, j];
            //    }
            //}
            //Console.WriteLine($"Сумма чисел между минимальным и максимальным элементами - {s}");

            //Console.WriteLine("Task6");
            //Console.WriteLine("Введите текст: ");
            //string str = Console.ReadLine();
            //char tempRes= Convert.ToChar(str[0]);
            //char res = Convert.ToChar(str[0]);
            //int tempSum = 1;
            //int sum = 1;
            //for (int i = 1; i < str.Length; i++) {
            //    if (tempRes == Convert.ToChar(str[i])) {
            //        tempSum++;
            //        if (tempSum > sum)
            //        {
            //            sum = tempSum;
            //            res = tempRes;
            //        }
            //    }
            //    else if (tempRes != Convert.ToChar(str[i]) && tempSum > sum)
            //    {
            //        tempRes = str[i];
            //        sum = tempSum;
            //        res = tempRes;
            //        tempSum = 0;
            //    }
            //    else {
            //        tempRes = str[i];
            //        tempSum = 0;
            //    }
            //}
            //Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов - {res}");

            //Console.WriteLine("Task7");
            //string str = "abc12abc343abce23324";
            //int s = 0;
            //for(int i = 0; i < str.Length; i++) {
            //    if (Char.IsNumber(str[i]))
            //    {
            //        s++;
            //    }
            //}
            //Console.WriteLine($"Количесто цифр в строке - {s}");

            Console.WriteLine("Task8");
            string str = "Avfdvldfvifsghrgdfer";
            string name = "Alisher ";
            for (int i = 0; i < str.Length; i++) {
                if (name.IndexOf(str[i]) != -1) {
                    name = name.Remove(name.IndexOf(str[i]), 1);
                }
            }
            if (name == " ")
            {
                Console.WriteLine("В тексте присутствует ваше имя");
            }
            else
            {
                Console.WriteLine("Нет имени");
            }

        }
    }
}


