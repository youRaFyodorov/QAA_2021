using System;
using System.Collections.Generic;

namespace CarDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>() { new Car(Brand.Audi, "A6", BodyType.Coupe, EngineType.Gasoline, 2.0, 20000),
                                                  new Car(Brand.BMW, "7er", BodyType.Sedan, EngineType.Gasoline, 3.5, 30000),
                                                  new Car(Brand.Tesla, "Model-S", BodyType.Sedan, EngineType.Electric, 2.0, 50000)};
            
            CarDealer carDealer = new CarDealer(carList);
            Func<Car, double> averageEngineVolume = x => x.EngineVolume;
            Func<Car, double> averagePrice = x => x.Price;

            Predicate<Car> countGasoline = x => x.EngineType == EngineType.Gasoline;
            Predicate<Car> countLessThen = x => x.Price < 25000;

            Console.WriteLine("Average Volume: " + carDealer.GetAverage(averageEngineVolume));
            Console.WriteLine("Number of cars worth less than 25000: " + carDealer.GetCount(countLessThen));
            Console.WriteLine("Max Price is " + carDealer.GetMaxValue(averagePrice));
        }
    }
}
