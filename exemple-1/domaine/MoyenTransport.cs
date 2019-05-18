namespace exemple_1 {
    /* 
        Class mère des moyen de transport 
    */
    public class MoyenTransport {

        // Propriété vitesse moyenne en Kilomètre/heure
        private double vitesseMoyenne;
        // Propriété coût ($) par Kilomètre
        private double coûtParKilo;
        // Propriété en Kilomètre
        private double distanceKilo;
        public MoyenTransport(double vitesse, double coût, double distance){
            Console.WriteLine("Moyen Transport initialisation");
            this.coûtParKilo = coût;
            this.vitesseMoyenne = vitesse;
            this.distanceKilo = distance;
        }

        /*
        Temps requis pour aller à destination (heure)
        Kilomètre / Kilomètre / heure => heure
         */
        public double CalculeTempsRequis(){
            return distanceKilo/vitesseMoyenne;
        }


        /*
         Coût pour le déplacement
          ( $ / Kilomètre ) * kilomètre => $
         */
        public double CaculePrixDéplacement() {
            return coûtParKilo * distanceKilo;
        }
    }
}