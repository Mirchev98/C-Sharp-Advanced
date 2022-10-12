using System;
using System.Collections;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passing = int.Parse(Console.ReadLine());

            string car = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            
            int counter = 0;
            
            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < passing; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                    car = Console.ReadLine();
                    continue;
                }
                
                cars.Enqueue(car);
                car = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
