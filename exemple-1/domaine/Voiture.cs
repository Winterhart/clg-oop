using System;
namespace exemple_1 {
    /**
        Classe dérivé de Moyen de transport
     */
    public class Voiture : MoyenTransport {
        public Voiture(double vitesse, double coût, double distance): 
        base(vitesse, coût, distance){
            Console.WriteLine("Voiture initialisation");
        }

        /**
         La classe voiture a un prix 2x plus grand que celui par defaut
         */
        public new double CaculePrixDéplacement(){
            return base.DistanceKilo * base.CoûtParKilo * 2;
        }
    }
}