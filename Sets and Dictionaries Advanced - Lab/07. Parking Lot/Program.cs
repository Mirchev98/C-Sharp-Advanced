using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine().Split(", ");

            HashSet<string> cars = new HashSet<string>();
            
            while (cmd[0] != "END")
            {
                string action = cmd[0];
                string car = cmd[1];

                if (action == "IN")
                {
                    cars.Add(car);
                }
                else
                {
                    cars.Remove(car);
                }
                cmd = Console.ReadLine().Split(", ");
            }

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
