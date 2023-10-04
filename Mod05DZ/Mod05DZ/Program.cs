using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mod05DZ
{
    class Program
    {

        static void Main(string[] args)
        {
            //TASK1
            //    string url = "http://BLABLABLAKAK.com/CHOTOTOTAM1";

            //    try
            //    {
            //        WebClient client = new WebClient();
            //        string response = client.DownloadString(url);
            //        Console.WriteLine("Ответ с веб ресурса: " + response);
            //    }
            //    catch (WebException ex)
            //    {
            //        Console.WriteLine("Ошибка: " + ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Непредвиденная ошибка: " + ex.Message);
            //    }

            //    Console.WriteLine("Программа заваршена.");
            //}

            //TASK2
            //int[] arr = { 1, 2, 3, 4, 5 };

            //try
            //{
            //    Console.WriteLine("Пытаемся получить 11 элемент массива: " + arr[10]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Ошибка: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Программа завершена.");
            //}

            //TASK3
            //try
            //{
            //    CallerMethod();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Ошибка: " + ex.Message);
            //}

            //TASK4
        }
        static void CallerMethod()
        {
            try
            {
                //Вызываем метод
                CalledMethod();
            }
            catch (Exception ex)
            {
                // Поднимаем исключение к вызывающему методу
                throw ex;
            }
        }

        static void CalledMethod()
        {
            // Создаем исключение
            throw new InvalidOperationException("Exception generated in CalledMethod.");
        }
    }
}