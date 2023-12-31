﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLib
{
    public class HDD : Storage
    {
        private double usbSpeed;
        private int partitionsCount;
        private double partitionsSize;

        public HDD(string name, string model, double usbSpeed, int partitionsCount, double partitionsSize)
        {
            Name = name;
            Model = model;
            this.usbSpeed = usbSpeed;
            this.partitionsCount = partitionsCount;
            this.partitionsSize = partitionsSize;
        }

        public override double GetMemory()
        {
            return partitionsCount * partitionsSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} ГБ данных в HDD. еобходимое время: {dataSize / usbSpeed} секунд.");
        }

        public override double GetFreeSpace()
        {
            return partitionsSize * 0.2 * partitionsCount; //20% памяти на каждом разделе свободно
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"HDD: {Name}, Модель: {Model}, скорость USB: {usbSpeed} ГБ/с, Разделы: {partitionsCount}, Размер разделов: {partitionsSize} ГБ");
        }
    }
}
