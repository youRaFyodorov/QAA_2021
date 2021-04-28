using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    abstract class Vehicle: IRefuelable
    {
        public double EngineVolume { get; }
        public string Transmission { get; }
        public int MaxSpeed { get; } 

        public Vehicle (double engineVolume, string transmission, int maxSpeed)
        {
            EngineVolume = engineVolume;
            Transmission = transmission;
            MaxSpeed = maxSpeed;
        }

        public virtual string GetFullInfo()
        {
            return $"Engine volume = {EngineVolume}, transmission: {Transmission}, Max speed = {MaxSpeed}, ";
        }
        public abstract void Refuel();
  
    }
}
