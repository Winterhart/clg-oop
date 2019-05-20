namespace domain {
    public class Taxi : Car {
        public Taxi(double avgSpeedKm, double costKm, int numberPassenger) : 
        base(avgSpeedKm, costKm, numberPassenger){}

        public override double ComputeCostForRun(double distanceKm){
            // 25% more expansive
            return  5.00 + (base.CostPerKm * distanceKm);
        }

    }
}