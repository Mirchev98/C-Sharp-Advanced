using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;

        private int cubicCapacity;

        public Engine(int horsePower, int cubicCapacity)
        {
            this.HorsePower = horsePower;

            this.CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get; set; }

        public int CubicCapacity { get; set; }
    }
}
