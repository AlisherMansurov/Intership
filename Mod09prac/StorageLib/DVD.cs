using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLib
{
    public class DVD : Storage
    {
        private double readWriteSpeed;
        private string type;

        public DVD(string name, string model, double readWriteSpeed, string type)
        {
            Name = name;
            Model = model;
            this.readWriteSpeed = readWriteSpeed;
            this.type = type;
        }

        public override double GetMemory()
        {
            return (type == "односторонний") ? 4.7 : 9;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} ГБ данных в DVD. Необходимое время: {dataSize / readWriteSpeed} секунд.");
        }

        public override double GetFreeSpace()
        {
            return 0; //свободного места нет
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"DVD: {Name}, Модель: {Model}, Скорость чтения/записи: {readWriteSpeed} ГБ/с, Тип: {type}");
        }
    }
}
