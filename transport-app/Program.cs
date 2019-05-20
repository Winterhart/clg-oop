using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using domain;


namespace transport_app
{
    /*
    Voici transport-app. 
    Ce programme suis la "C# naming convention"
    https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
     */
    class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("----- Transport App ----");

            var transports = new List<Transport> {
                new Car(30.2, 0.76, 1),
                new Bus(22, 0, 20),
                new Taxi(29, 1.75, 2),
                // Flying engine
                new Transport(300, 10.2, 3)
            };

            foreach(var transport in transports){
                Console.WriteLine(transport.GetType().ToString());
                double travelDistance = 20;
                var travelTime = transport.ComputeAverageTime(travelDistance);

                Console.WriteLine("For {0} Km, Average Time: {1} hours and {2} minutes",
                    travelDistance, travelTime.Hours, travelTime.Minutes);

                Console.WriteLine("Price for the run: {0:C} \n",
                    transport.ComputeCostForRun(travelDistance));
                
            }

        }
    }
}
