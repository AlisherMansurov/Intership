using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Animal : IComparable<Animal>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Абстрактный метод для расчета пищи
        public abstract void CalculateFood();

        public int CompareTo(Animal other)
        {
            // Сначала сравниваем количество пищи в обратном порядке
            int FoodComparison = other.FoodAmount.CompareTo(this.FoodAmount);
            if (FoodComparison != 0)
                return FoodComparison;

            // Если количество пищи одинаковое, сортируем по имени
            return this.Name.CompareTo(other.Name);
        }

        // Свойство для количества пищи
        public abstract double FoodAmount { get; set; }
        public abstract string FoodType { get; set; }
    }

    // Потомок класса Animal - хищные животные
    public class Carnivore : Animal
    {
        public override double FoodAmount { get; set; }
        public override string FoodType { get; set; }

        public override void CalculateFood()
        {
            // Логика расчета для хищников
            FoodAmount = 10.0;
            FoodType = "Мясо";
        }
    }

    // Потомок класса Animal - всеядные животные
    public class Omnivore : Animal
    {
        public override double FoodAmount { get; set; }
        public override string FoodType { get; set; }

        public override void CalculateFood()
        {
            // Логика расчета для всеядных
            FoodAmount = 8.0;
            FoodType = "Трава и мясо";
        }
    }

    // Потомок класса Animal - травоядные животные
    public class Herbivore : Animal
    {
        public override double FoodAmount { get; set; }
        public override string FoodType { get; set; }

        public override void CalculateFood()
        {
            // Логика расчета для травоядных
            FoodAmount = 5.0;
            FoodType = "Трава";
        }
    }
}
