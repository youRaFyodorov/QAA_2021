using System;
using System.Collections.Generic;
using System.Text;

namespace CarDelegates
{
    public class CarDealer
    {
        public List<Car> CarList { get; set; }
        public CarDealer(List<Car> carList)
        {
            CarList = carList;
        }

        public double GetAverage(Func<Car, double> avarageFunc)
        {
            double averageVolume = 0;
            foreach (Car car in CarList)
            {
                averageVolume += avarageFunc(car);
            }
            return averageVolume / Car.Counter;
        }
        public double GetCount(Predicate<Car> countFunc)
        {
            int count = 0;
            foreach (Car car in CarList)
            {
                if (countFunc(car))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
