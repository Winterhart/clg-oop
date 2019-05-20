using System;
namespace domain {

    public class Transport {
        // Common properties to all transport
        private readonly double _averageSpeedKmHour;
        private readonly double _costPerKm;
        private readonly int _numberOfPassenger;

        private const double MAXIMUM_AVG_SPEED = 100000;
        protected double AverageSpeedKmHour {
            get { return _averageSpeedKmHour;}
        }

        protected double CostPerKm {
            get { return _costPerKm;}
        }

        protected int NumberOfPassenger {
            get { return _numberOfPassenger;}
        }


        public Transport(double avgSpeedKm, double costKm, int numberPassenger){
            if(avgSpeedKm < 0 || avgSpeedKm > MAXIMUM_AVG_SPEED){
                throw new ArgumentOutOfRangeException(nameof(avgSpeedKm), 
                "Average Speed must be larger than 0 and smaller than 100 000 Km/h");
            }
            this._averageSpeedKmHour = avgSpeedKm;
            this._costPerKm = costKm;
            this._numberOfPassenger = numberPassenger;
        }

        public virtual double ComputeCostForRun(double distanceKm){
            return CostPerKm * distanceKm;
        }

        public virtual TimeSpan ComputeAverageTime(double distanceKm){
            return TimeSpan.FromHours(distanceKm / AverageSpeedKmHour);
        }

    }
}