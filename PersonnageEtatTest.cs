using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage {
    class PersonnageEtatTest {
        static void Main(string[] args) {

            // Création en santé
            Console.WriteLine("\n\n---------------------TEST SANTÉ----------------------");
            Personnage perso = new Personnage(10);

            Console.WriteLine(perso.ToString());

            perso.Attaquer();
            perso.Fuir();
            perso.Diplomatie();
            perso.Soigner();


            // État affaibli
            Console.WriteLine("\n\n---------------------TEST AFFAIBLI----------------------");
            perso.recoitDommage(9);

            Console.WriteLine(perso.ToString());

            perso.Attaquer();
            perso.Fuir();
            perso.Diplomatie();
            perso.Soigner();

            Console.WriteLine(perso.ToString());

            // État empoisonné
            Console.WriteLine("\n\n---------------------TEST EMPOISONNÉ----------------------");
            perso.recoitPoison();

            Console.WriteLine(perso.ToString());

            perso.recoitDommage(5);
            perso.Attaquer();
            perso.Fuir();
            perso.Diplomatie();
            perso.Soigner();

            Console.WriteLine(perso.ToString());

            // État confus
            Console.WriteLine("\n\n---------------------TEST CONFUS----------------------");
            perso.recoitSortConfusion();

            Console.WriteLine(perso.ToString());

            perso.recoitDommage(2);
            perso.Attaquer();
            perso.Fuir();
            perso.Diplomatie();
            perso.Soigner();

            Console.WriteLine(perso.ToString());

            // État mort
            Console.WriteLine("\n\n---------------------TEST MORT----------------------");
            perso.recoitDommage(100);

            Console.WriteLine(perso.ToString());

            perso.Attaquer();
            perso.Fuir();
            perso.Diplomatie();
            perso.Soigner();

            Console.WriteLine(perso.ToString());

        }
    }
}
