namespace domain {
    public class Bus : Transport{
        public Bus(double avgSpeedKm, double costKm, int numberPassenger) :
        base(avgSpeedKm, costKm, numberPassenger){}

        public override double ComputeCostForRun(double distanceKm){
            return 4.25;
        }
    }
}