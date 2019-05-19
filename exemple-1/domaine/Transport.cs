using System;
namespace exemple_1 {
    /* 
        Class mère des transports 
    */
    public class Transport {
        // Propriété vitesse moyenne en Kilomètre/heure
        public double VitesseMoyenne {get; private set;}
        // Propriété coût ($) par Kilomètre
        public double CoûtParKilo {get; private set;}
        // Propriété en Kilomètre
        public double DistanceKilo {get; private set;}
        public Transport(double vitesse, double coût, double distance){
            Console.WriteLine("Moyen Transport initialisation");
            this.CoûtParKilo = coût;
            this.VitesseMoyenne = vitesse;
            this.DistanceKilo = distance;
        }

        /*
        Temps requis pour aller à destination (heure)
        Kilomètre / Kilomètre / heure => heure
         */
        public double CalculeTempsRequis(){
            return DistanceKilo/VitesseMoyenne;
        }


        /*
         Coût pour le déplacement
          ( $ / Kilomètre ) * kilomètre => $
         */
        public double CaculePrixDéplacement() {
            return CoûtParKilo * DistanceKilo;
        }
    }
}