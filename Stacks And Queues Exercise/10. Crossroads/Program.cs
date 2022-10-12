using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int green = int.Parse(Console.ReadLine());

            int freeWindow = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int passedCars = 0;

            bool endCheck = false;

            while (command != "END")
            {
                int timeToPass = green;
                int bonus = freeWindow;
                
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    while (timeToPass != 0 && cars.Any())
                    {
                        string currentCar = cars.Dequeue();
                        passedCars++;

                        foreach (var character in currentCar)
                        {
                            if (timeToPass == 0)
                            {
                                if (bonus == 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {character}.");
                                    endCheck = true;
                                    break;
                                }

                                bonus--;
                            }
                            else
                            {
                                timeToPass--;
                            }
                        
                        }
                    }

                    timeToPass = green;
                    bonus = freeWindow;

                    if (endCheck)
                    {
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            if (!endCheck)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
