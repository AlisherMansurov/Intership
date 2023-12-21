using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ContactLib;
using LiteDB;


namespace ModEX
{
    internal class ContactApp
    {
        static string path = ConfigurationManager
            .ConnectionStrings["DefaultConnection"]
            .ConnectionString;
        static void Main(string[] args)
        {
            FirstMenu();
        }

        static void FirstMenu()
        {
            while (true)
            {
                Console.Clear(); //Для красивого интерфейса
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1) Добавить контакт");
                Console.WriteLine("2) Найти контакт");
                Console.WriteLine("3) Редактировать контакт");
                Console.WriteLine("4) Удалить контакт");
                Console.WriteLine("5) Выйти");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        SearchContact();
                        break;
                    case 3:
                        EditContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5: 
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный Ввод, попробуйте снова.");
                        break;
                }
            }
        }

        static void AddContact() //Добавление контакта 
        {
            try //Обработчик ошибки
            {
                using (var db = new LiteDatabase(path)) //Подключение к бд
                {
                    Console.Clear(); //Для красивого интерфейса
                    var contactsCollection = db.GetCollection<Contact>("contacts"); //Получение коллекций 

                    int maxId = contactsCollection.Max("$.ID").AsInt32; // Вместо IdCounter я использовал максимально существующий ID контакта
                    if (maxId > 0) // если он больше нуля то добавляем +1 к id
                    {
                        maxId += 1;
                    }
                    Contact newContact = new Contact();
                    newContact.ID = maxId; // присваиваем id

                    Console.Write("Введите имя: ");
                    newContact.FirstName = Console.ReadLine();

                    Console.Write("Введите фамилию: ");
                    newContact.LastName = Console.ReadLine();

                    Console.Write("Введите номер телефона: ");
                    newContact.PhoneNumber = Console.ReadLine();

                    Console.Write("Введите адрес электронной почты: ");
                    newContact.Email = Console.ReadLine();

                    contactsCollection.Insert(newContact); // добавляем контакт в бд
                    Console.WriteLine("Контакт успешно добавлен.");
                    Thread.Sleep(3000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при добавлений контакта: {ex.Message}");
                Environment.Exit(0);
            }
        }

        static void SearchContact() // Поиск контакта по всем параметрам контакта
        {
            Console.Write("Введите строку для поиска: ");
            string searchQuery = Console.ReadLine().ToLower(); // Унификация строки для поиска 
            try
            {
                using (var db = new LiteDatabase(path)) //Подключение к бд
                {
                    var contactsCollection = db.GetCollection<Contact>("contacts"); //Получение коллекций 

                    var searchResults = contactsCollection.Find( //Ищем по всем параметрам
                        Query.Or(
                            Query.Contains("FirstName", searchQuery),
                            Query.Contains("LastName", searchQuery),
                            Query.Contains("PhoneNumber", searchQuery),
                            Query.Contains("Email", searchQuery)
                        )
                    );

                    if (searchResults.Any())
                    {
                        Console.WriteLine("Результаты поиска:");
                        foreach (var result in searchResults) // вывод всех контактов подходящих по пойску 
                        {
                            Console.WriteLine(result);
                        }
                        while (true) //Для красивого интерфейса
                        {
                            Console.Write("Вернуться в главное меню?(Y/N):"); // можно выйти на главное меню или попробовать снова
                            string choice = Console.ReadLine();
                            if (choice.ToLower() == "y") // возврат на главное меню
                            {
                                db.Dispose();
                                FirstMenu();
                            }
                            else if (choice.ToLower() == "n") // попробовать снова
                            {
                                db.Dispose();
                                SearchContact();
                            }
                            else
                            {
                                Console.WriteLine("Некорректный символ!");
                                Thread.Sleep(3000);
                            }
                        }
                    }
                    else
                    {
                        while (true) //Для красивого интерфейса
                        {
                            Console.Write("Контакт не найден, вернуться в главное меню?(Y/N):"); // можно выйти на главное меню или попробовать снова
                            string choice = Console.ReadLine();
                            if (choice.ToLower() == "y") // возврат на главное меню
                            {
                                db.Dispose();
                                FirstMenu();
                            }
                            else if (choice.ToLower() == "n") // попробовать снова
                            {
                                db.Dispose();
                                SearchContact();
                            }
                            else
                            {
                                Console.WriteLine("Некорректный символ!");
                                Thread.Sleep(3000);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) //Обработчик ошибки
            {
                Console.WriteLine($"Произошла ошибка при пойске контакта: {ex.Message}");
                Environment.Exit(0);
            }

        }

        static void EditContact() //Изменение контакта по ID
        {
            Console.Clear(); //Для красивого интерфейса
            Console.Write("Введите ID контакта для редактирования: ");
            int contactId = Convert.ToInt32(Console.ReadLine());
            try //Обработчик ошибки
            {
                using (var db = new LiteDatabase(path)) //Подключение к бд
                {
                    var contactsCollection = db.GetCollection<Contact>("contacts"); //Получение коллекций 
                    var contactToEdit = contactsCollection.FindOne(x => x.ID == contactId); //Находим контакт по id

                    if (contactToEdit != null)
                    {
                        Console.WriteLine($"Текущая информация о контакте (ID {contactToEdit.ID}):");
                        Console.WriteLine(contactToEdit);

                        Console.Write("Введите новое имя: ");
                        contactToEdit.FirstName = Console.ReadLine();

                        Console.Write("Введите новую фамилию: ");
                        contactToEdit.LastName = Console.ReadLine();

                        Console.Write("Введите новый номер телефона: ");
                        contactToEdit.PhoneNumber = Console.ReadLine();

                        Console.Write("Введите новый адрес электронной почты: ");
                        contactToEdit.Email = Console.ReadLine();

                        contactsCollection.Update(contactToEdit); // обновляем контакт
                        Console.WriteLine("Контакт успешно отредактирован!");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        while (true) //Для красивого интерфейса
                        {
                            Console.Write("Контакт не найден, вернуться в главное меню?(Y/N):"); // можно выйти на главное меню или попробовать снова
                            string choice = Console.ReadLine();
                            if (choice.ToLower() == "y")
                            {
                                db.Dispose();
                                FirstMenu(); // возврат на главное меню
                            }
                            else if (choice.ToLower() == "n")
                            {
                                db.Dispose();
                                EditContact(); // попробовать снова
                            }
                            else
                            {
                                Console.WriteLine("Некорректный символ!");
                                Thread.Sleep(3000);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) //Обработчик ошибки
            {
                Console.WriteLine($"Произошла ошибка при изменений контакта: {ex.Message}");
                Environment.Exit(0);
            }
        }

        static void DeleteContact() //Удаление контакта по ID
        {
            Console.Clear(); //Для красивого интерфейса
            Console.Write("Введите ID контакта для удаления: ");
            int contactId = Convert.ToInt32(Console.ReadLine());
            try //Обработчик ошибки
            {
                using (var db = new LiteDatabase(path)) //Подключение к бд
                {
                    var contactsCollection = db.GetCollection<Contact>("contacts"); //Получение коллекций 
                    Contact contactToDelete = contactsCollection.FindOne(x => x.ID == contactId); //находим контакт по id
                    if (contactToDelete != null)
                    {
                        Console.WriteLine($"Информация о контакте (ID {contactToDelete.ID}):");
                        Console.WriteLine(contactToDelete);

                        Console.Write("Вы уверены, что хотите удалить этот контакт?(Y/N): ");
                        string choice = Console.ReadLine();

                        if (choice.ToLower() == "y")
                        {
                            contactsCollection.Delete(contactId);

                            Console.WriteLine("Контакт успешно удален!");
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.WriteLine("Удаление отменено.");
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        while (true) //Для красивого интерфейса
                        {
                            Console.Write("Такой контакт не найден, вернуться в главное меню?(Y/N):"); // можно выйти на главное меню или попробовать снова
                            string choice = Console.ReadLine();
                            if (choice.ToLower() == "y") // возврат на главное меню
                            {
                                db.Dispose();
                                FirstMenu(); 
                            }
                            else if (choice.ToLower() == "n") // попробовать снова
                            {
                                db.Dispose();
                                DeleteContact();
                            }
                            else
                            {
                                Console.WriteLine("Некорректный символ!");
                                Thread.Sleep(3000);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) //Обработчик ошибки
            {
                Console.WriteLine($"Произошла ошибка при удалений контакта: {ex.Message}");
                Environment.Exit(0);
            }
        }
    }
}
