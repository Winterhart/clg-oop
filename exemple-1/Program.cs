using System;
namespace exemple_1
{
    /**
        Utilisation classique du principe d'héritage (inheritance)
        Pour ce program nous allons suivre la convention de Microsoft et C# 
        (https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------- Moyen de transport ---------- ");
            // Nouvelle voiture avec 30 Km/h vitesse moyenne, 2.34$ / Km et 20Km de distance 
            Voiture voiture = new Voiture(30, 2.34, 20);
            // Démonstation du prix du déplacement
            Console.WriteLine("Prix Totale pour le trajet: {0} $",
             voiture.CaculePrixDéplacement());
        }
    }
}
