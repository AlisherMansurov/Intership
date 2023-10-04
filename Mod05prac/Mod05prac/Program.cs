using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CallerMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
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
