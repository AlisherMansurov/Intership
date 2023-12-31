﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Banc
    {
        // Генерация счета
        public static string CreateAccountNumber()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                int randomNumber = random.Next(0, 10); // Генерация случайной цифры от 0 до 9
                stringBuilder.Append(randomNumber);
            }

            string randomString = stringBuilder.ToString();
            return randomString;
        }
        // Генерация пароля
        public static string CreatePassword()
        {
            Random random = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789"; // Символы, из которых будут генерироваться буквы
            char[] randomLetters = new char[8];

            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(alphabet.Length);
                randomLetters[i] = alphabet[index];
            }

            string randomString = new string(randomLetters);
            return randomString;
        }



        }
}
