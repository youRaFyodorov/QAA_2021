using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Motorcycle : Vehicle, IRefuelable
    {
        public string TypeOfMotorcycle { get; }

        public Motorcycle(double engineVolume, string transmission, int maxSpeed, string typeOfMotorcycle):
            base(engineVolume, transmission, maxSpeed)
        {
            TypeOfMotorcycle = typeOfMotorcycle;
        }

        public override string GetFullInfo()
        {
            return $"Motorcycle: Engine volume = {EngineVolume}, transmission: {Transmission}, Max speed = {MaxSpeed}, " +
                $"Type of motorcycle = {TypeOfMotorcycle}";
        }
        public override void Refuel()
        {
            Console.Write("Motorcycle not refueled");
        }
    }
}
