using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private Random random;
        public string name { get; set; }
        public int Ammunition { get; private set; }
        public int Armor { get; private set; }
        public int Maneuverability { get; private set; }

        public Tank(): this("")
        {

        }
        public Tank(string name)
        {
            //Генерация случайных чисел которая зависит от времени
            random = new Random((int)DateTime.Now.Ticks);

            this.name = name; 

            // Генерируем случайное число от 0 до 100 в ТТХ(Тактико-Технические Характеристики) танка
            Ammunition = random.Next(101); 
            Armor = random.Next(101);
            Maneuverability = random.Next(101);
        }

        public static Tank operator *(Tank a, Tank b)
        {
            if (a.Ammunition > b.Ammunition && a.Armor > b.Armor ||
                a.Ammunition > b.Ammunition && a.Maneuverability > b.Maneuverability ||
                a.Armor > b.Armor && a.Maneuverability > b.Maneuverability)
            {
                return  a;
            }
            else if (a.Ammunition < b.Ammunition && a.Armor < b.Armor ||
                a.Ammunition < b.Ammunition && a.Maneuverability < b.Maneuverability ||
                a.Armor < b.Armor && a.Maneuverability < b.Maneuverability)
            {
                return b;
            }
            else
            {
                return null;
            }

        }

        //Метод Получение текущих значений параметров танка: Бое­комплект, Уровень брони, Уровень маневренности в виде строки.
        public override string ToString()
        {
            return $"Танк {name} c уровнем боекомплекта {Ammunition}, уровнем брони {Armor} и уровнем маневренности {Maneuverability}";
        }

    }
}
