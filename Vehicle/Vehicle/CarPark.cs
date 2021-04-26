using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class CarPark
    {
        private int ParkingSize;
        private Vehicle[] vehicles = null;

        private int Counter = 0;
        public CarPark(int size)
        {
            ParkingSize = size;
            vehicles = new Vehicle[size];
        }

        public void AddVehiclesToParking(Vehicle vehicle)
        {
            if (Counter < ParkingSize)
            {
                vehicles[Counter] = vehicle;
                Counter++;
            }
            else
            {
                Console.WriteLine("The parking lot is full");
            }
        }

        public void PrintVehiclesInformation()
        {
            for (int i = 0; i < Counter; i++)
            {
                Console.WriteLine(vehicles[i].GetFullInfo());
            }
        }
    }
}
