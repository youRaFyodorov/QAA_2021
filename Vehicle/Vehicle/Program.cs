using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPark autoPark = new CarPark(4);

            autoPark.AddVehiclesToParking(new Car(1.6, "automatic", 197, 120));
            autoPark.AddVehiclesToParking(new Car(1.8, "mechanical", 210, 170));
            autoPark.AddVehiclesToParking(new Truck(15.6, "automatic", 160, 21000));
            autoPark.AddVehiclesToParking(new Bus(7.12, "automatic", 106, 50));
            autoPark.AddVehiclesToParking(new Motorcycle(1.0, "mechanical", 299, "sport"));

            autoPark.PrintVehiclesInformation();
        }
    }
}
