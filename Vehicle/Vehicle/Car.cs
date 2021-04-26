using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car: Vehicle
    {
        public int Horsepower { get; }

        public Car (double engineVolume, string transmission, int maxSpeed, int horsepower):
            base (engineVolume, transmission, maxSpeed)
        {
            Horsepower = horsepower;
        }

        public override string GetFullInfo()
        {
           return $"Car: Engine volume = {EngineVolume}, transmission: {Transmission}, Max speed = {MaxSpeed}, " +
                $"Horsepower = { Horsepower }";
        }
    }
}
