using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double kilometers)
        {
            if (this.FuelAmount < this.FuelConsumptionPerKilometer * kilometers)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= kilometers * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += kilometers;
            }
        }
    }
}
