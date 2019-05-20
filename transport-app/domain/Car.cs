namespace domain {
    public class Car : Transport{

        public Car(double avgSpeedKm, double costKm, int numberPassenger):
         base(avgSpeedKm, costKm, numberPassenger){}

        public sealed override double ComputeAverageTime(double distanceKm){
            // 10 % faster than regular transport
            return (0.9*(distanceKm / base.AverageSpeedKmHour));
        }

    }
}