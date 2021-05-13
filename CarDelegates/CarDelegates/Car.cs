using System;
using System.Collections.Generic;
using System.Text;

namespace CarDelegates
{
    public class Car
    {
        public Brand Brand { get; }
        public string Model { get; }
        public BodyType BodyType { get; }
        public EngineType EngineType { get; }
        public double EngineVolume { get; }
        public double Price { get; }
        public static int Counter = 0;

        public Car(Brand brand, string model, BodyType bodyType, EngineType engineType, double engineVolume, double price)
        {
            Brand = brand;

            Model = model;
            BodyType = bodyType;
            EngineType = engineType;
            if (engineVolume > 0)
            {
                EngineVolume = engineVolume;
            }
            else throw new ArgumentOutOfRangeException();
            if (price > 0)
            {
                Price = price;
            }
            else throw new ArgumentOutOfRangeException();
            Counter++;
        }
    }
}
