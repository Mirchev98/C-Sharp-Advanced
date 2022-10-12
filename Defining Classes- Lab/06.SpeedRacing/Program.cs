using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace _06.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] currentCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string currentCarName = currentCar[0];
                double currentFuelAmount = double.Parse(currentCar[1]);
                double currentFuelConsumption = double.Parse(currentCar[2]);

                Car car = new Car()
                {
                    Model = currentCarName,
                    FuelAmount = currentFuelAmount,
                    FuelConsumptionPerKilometer = currentFuelConsumption,
                    TravelledDistance = 0
                };

                cars.Add(currentCarName, car);

            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                string currentModel = command[1];
                double currentKilometers = double.Parse(command[2]);

                Car car = cars[currentModel];

                car.Drive(currentKilometers);

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
