﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BankLib;

namespace Mod13Dz
{
    internal class Program
    {
        static Queue<Client> queue = new Queue<Client>();
        static void Main(string[] args)
        {
            FirstMenu();
        }

        static void FirstMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Встать в очередь");
            Console.WriteLine("2) Обслужить следующего клиента");
            Console.WriteLine("3) Выйти из программы");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddClientToQueue();
                    break;

                case "2":
                    ServeNextClient();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    Thread.Sleep(3000);
                    FirstMenu();
                    break;
            }
            Console.WriteLine();
        }

        static void AddClientToQueue()
        {
            Console.Clear();
            Console.WriteLine("Выберите услугу:");
            Console.WriteLine("1. Кредитование");
            Console.WriteLine("2. Открытие вклада");
            Console.WriteLine("3. Консультация");
            Console.WriteLine("4. Назад");

            string choice = Console.ReadLine();
            string service= "";

            switch (choice)
            {
                case "1":
                    service = "Кредитование";
                    break;
                case "2":
                    service = "Открытие вклада";
                    break;
                case "3":
                    service = "Консультация";
                    break;
                case "4":
                    FirstMenu();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    Thread.Sleep(3000);
                    AddClientToQueue();
                    break;
            }
            Console.Write("Введите ИИН клиента: ");
            string id = Console.ReadLine();

            Client client = new Client(id, service);

            queue.Enqueue(client);

            Console.WriteLine($"{client.Service} клиент {client.Id} добавлен в очередь.");
            PrintQueueStatus();
        }

        static void ServeNextClient()
        {
            if (queue.Count > 0)
            {
                Client client = queue.Dequeue();
                Console.WriteLine($"Обслужен {client.Service} клиент {client.Id}.");
            }
            else
            {
                Console.WriteLine("Очередь пуста. Нет клиентов для обслуживания.");
            }

            PrintQueueStatus();
        }

        static void PrintQueueStatus()
        {
            Console.WriteLine();
            Console.WriteLine($"Текущая очередь ({queue.Count} чел.):");
            foreach (var client in queue)
            {
                Console.WriteLine($"{client.Service} клиент {client.Id}");
            }

            Console.WriteLine();
            Console.WriteLine("Вернуться в меню [Y/N]?");
            string choice = Console.ReadLine();

            if (choice == "Y" || choice == "y")
            {
                FirstMenu();
            }
            else if (choice == "N" || choice == "n") 
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                Thread.Sleep(3000);
                PrintQueueStatus();
            }
        }

    }
}
