using System;
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

            Console.WriteLine("----- Transport App ----");
            Car car = new Car(30.2, 0.76, 2);
            
            List<Transport> transports = {car};


        }
    }
}
