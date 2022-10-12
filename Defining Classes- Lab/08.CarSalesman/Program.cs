using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();

            List<Car> cars = new List<Car>();

            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] inputEngines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(inputEngines);

                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(inputCars, engines);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Engine CreateEngine(string[] inputEngines)
        {
            string currentEngineModel = inputEngines[0];

            int currentEnginePower = int.Parse(inputEngines[1]);

            Engine engine = new Engine(currentEngineModel, currentEnginePower);

            if (inputEngines.Length > 2)
            {
                int displacement;

                var isDigit = int.TryParse(inputEngines[2], out displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = inputEngines[2];
                }

                if (inputEngines.Length > 3)
                {
                    engine.Efficiency = inputEngines[3];
                }
            }


            return engine;
        }
        public static Car CreateCar(string[] inputCars, List<Engine> engines)
        {
            string currentCarModel = inputCars[0];

            string currentEngine = inputCars[1];

            Engine engine = engines.Find(x => x.Model == currentEngine);

            Car car = new Car(currentCarModel, engine);

            if (inputCars.Length > 2)
            {
                int weight;

                var isDigit = int.TryParse(inputCars[2], out weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = inputCars[2];
                }
            }

            if (inputCars.Length > 3)
            {
                car.Color = inputCars[3];
            }

            return car;
        }
    }
}
