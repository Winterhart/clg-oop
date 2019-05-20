namespace domain {
    public class Transport{
        // Common properties to all transport
        private readonly double _averageSpeedKmHour;
        private readonly double _costPerKm;
        private readonly int _numberOfPassenger;

        
        protected double AverageSpeedKmHour {
            get { return _averageSpeedKmHour;}
        }

        protected double CostPerKm {
            get { return _costPerKm;}
        }

        protected int NumberOfPassenger {
            get { return _numberOfPassenger;}
        }


        public Transport(double avgSpeedKM, double costKm, int numberPassenger){
            this._averageSpeedKmHour = avgSpeedKM;
            this._costPerKm = costKm;
            this._numberOfPassenger = numberPassenger;
        }

        public double ComputeCostForRun(double distanceKm){
            return this._costPerKm * distanceKm;
        }

        public double ComputeAverageTime(double distanceKm){
            return  distanceKm / this._averageSpeedKmHour;
        }

        

    }
}