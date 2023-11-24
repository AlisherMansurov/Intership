using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class SedanCar : Car
    {
        public SedanCar(string model, int speed) : base(model, speed) { }

        public override void StartRace()
        {
            Console.WriteLine($"{Model} начинает гонку!");
            Move();
        }
        public override void OnRace()
        {
            Move();
        }
    }
}
