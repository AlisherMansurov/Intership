using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using StorageLib;

namespace Mod09prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
            {
            new Flash("FlashDrive1", "Kingston", 3, 64),
            new DVD("DVD", "Sony", 0.01, "односторонний"),
            new HDD("HDD", "Seagate", 1, 2, 500)
            };

            // Расчет общего количества памяти всех устройств
            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            Console.WriteLine($"Общая память всех устройств: {totalMemory} ГБ");

            // Копирование информации на устройства
            double dataSize = 565;
            double dataSize2 = 8;// Размер данных в GB
            foreach (var device in devices)
            {
                if (device is DVD)
                {
                    device.CopyData(dataSize2);
                }
                else
                {
                    device.CopyData(dataSize);
                }            
            }

            // Расчет необходимого количества носителей информации
            double fileSize = 0.78; // Размер одного файла в GB
            int requiredDevices = (int)Math.Ceiling(dataSize / fileSize);
            Console.WriteLine($"Необходимые устройства для передачи данных: {requiredDevices}");

            // Вывод информации о свободном месте на каждом устройстве
            foreach (var device in devices)
            {
                Console.WriteLine($"Свободное место на {device.Name}: {device.GetFreeSpace()} ГБ");
            }

            // Вывод общей информации об устройствах
            foreach (var device in devices)
            {
                device.GetDeviceInfo();
            }

            Console.ReadLine();
        }
    }
}
