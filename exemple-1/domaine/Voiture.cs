using System;
namespace exemple_1 {
    public class Voiture : MoyenTransport {
        public Voiture(double vitesse, double coût, double distance): 
        base(vitesse, coût, distance){
            Console.WriteLine("Voiture initialisation");
        }
    }
}