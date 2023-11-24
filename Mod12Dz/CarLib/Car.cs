using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public abstract class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; }

        public delegate void RaceHandler(Car car);
        public event RaceHandler OnFinish;

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
            Position = 0;
        }

        public abstract void StartRace();
        public abstract void OnRace();
        protected void Move()
        {
            Random rnd = new Random();
            Position += rnd.Next(Speed);
            if (Position >= 100)
            {
                OnFinish?.Invoke(this);
            }
        }
    }
}
