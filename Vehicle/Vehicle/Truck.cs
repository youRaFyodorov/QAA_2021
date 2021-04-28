using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Truck: Vehicle, IRefuelable
    {
        public int LiftingCapacity { get; } //Kg

        public Truck(double engineVolume, string transmission, int maxSpeed, int liftingCapacity):
            base(engineVolume, transmission, maxSpeed)
        {
            LiftingCapacity = liftingCapacity;
        }

        public override string GetFullInfo()
        {
            return $"Truck: Engine volume = {EngineVolume}, transmission: {Transmission}, Max speed = {MaxSpeed}, " +
                $"Lifting capacity = {LiftingCapacity}";
        }
        public override void Refuel()
        {
            Console.Write("Truck fueled");
        } 
    }
}
