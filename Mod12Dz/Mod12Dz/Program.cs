using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLib;

namespace Mod12Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaceGame raceGame = new RaceGame();

            var cars = new List<Car>();
            SportsCar sportsCar = new SportsCar("Ferrari", 5);
            SedanCar sedanCar = new SedanCar("Toyota", 4);
            Truck truck = new Truck("Volvo", 3);
            Bus bus = new Bus("Mercedes", 2);

            cars.Add(sportsCar);
            cars.Add(sedanCar);
            cars.Add(truck);
            cars.Add(bus);

            raceGame.OnRaceFinish += Winner;

            raceGame.StartRace(cars[0]);
            raceGame.StartRace(cars[1]);
            raceGame.StartRace(cars[2]);
            raceGame.StartRace(cars[3]);

            while (sportsCar.Position < 100 && sedanCar.Position < 100 && truck.Position < 100 && bus.Position < 100)
            {
                cars[0].OnRace();
                cars[1].OnRace();
                cars[2].OnRace();
                cars[3].OnRace();
                int s;

                for (int j = 0; j < cars.Count; j++)
                {
                    s = 0;
                    for (int k = j + 1; k < cars.Count; k++)
                    {
                        if (cars[j].Position > cars[k].Position)
                        {
                            s += 1;
                        }
                    }
                    if(s == 3) 
                    {
                        Console.WriteLine($"{cars[j].Model} На первом Месте! {cars[j].Position}");
                    }
                    if (s == 2)
                    {
                        Console.WriteLine($"{cars[j].Model} На втором Месте! {cars[j].Position}");
                    }
                    if (s == 1)
                    {
                        Console.WriteLine($"{cars[j].Model} На третьем Месте! {cars[j].Position}");
                    }
                    if (s == 0)
                    {
                        Console.WriteLine($"{cars[j].Model} На последнем Месте! {cars[j].Position}");
                    }
                }

                Console.WriteLine();
            }
            

            Console.ReadLine();
        }

        private static void Winner(Car car)
        {
            Console.WriteLine($"{car.Model} победитель!");
        }
    }
}
