using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Bus: Vehicle
    {
        public int NumOfPassengerSeates { get; }

        public Bus (double engineVolume, string transmission, int maxSpeed, int numOfPassengerSeates):
            base(engineVolume, transmission, maxSpeed)
        {
            NumOfPassengerSeates = numOfPassengerSeates;
        }

        public override string GetFullInfo()
        {
            return $"Bus: Engine volume = {EngineVolume}, transmission: {Transmission}, Max speed = {MaxSpeed}, " +
                $"Number of passenger seates = {NumOfPassengerSeates}";
        }
    }
}
