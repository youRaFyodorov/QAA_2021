using System;
using System.Collections.Generic;
using System.Text;

namespace CarDelegates
{
    public static class Helper
    {
        
        public static double GetMaxValue (this CarDealer carDealer, Func<Car, double> maxFunc)
        {
            double maxValue = maxFunc(carDealer.CarList[0]);

            for (int i = 1; i < carDealer.CarList.Count; i++)
            {
                if (maxFunc(carDealer.CarList[i]) > maxValue)
                {
                    maxValue = maxFunc(carDealer.CarList[i]);
                }
            }

            return maxValue;
        }
        
    }
}
