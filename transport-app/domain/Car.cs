using System;
namespace domain {
    public class Car : Transport{

        public Car(double avgSpeedKm, double costKm, int numberPassenger):
         base(avgSpeedKm, costKm, numberPassenger){}

        public sealed override TimeSpan ComputeAverageTime(double distanceKm)
        {
            // 10% Faster with car
            return TimeSpan.FromHours(0.9*(distanceKm / AverageSpeedKmHour));
        }

    }
}