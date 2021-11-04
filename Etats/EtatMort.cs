using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage.Etats {
    class EtatMort : EtatPersonnage {
        Personnage personnage;

        public EtatMort(Personnage personnage) : base(personnage) {
            this.personnage = personnage;
        }
        public override void Attaquer() {
            Console.WriteLine("Désolé, t'es mort!!! Tu ne peux pas attaquer");
        }

        public override void Diplomatie() {
            Console.WriteLine("Désolé, t'es mort!!! C'est difficile la diplomatie dans cet état.");
        }

        public override void Fuir() {
            Console.WriteLine("Un cadavre, ça ne fuit pas vraiment...");
        }

        public override void Soigner() {
            Console.WriteLine("Impossible de se soigner quand notre cerveau n'est plus actif");
        }

        public override void RecoitDommage(int dommage) {
            Console.WriteLine("Ce personnage est mort, qu'est-ce que tu pensais qui allais se passer???");
        }

        public override void RecoitPoison() {
            Console.WriteLine("C'est pas vraiment possible d'empoisonné un mort non?!");
        }

        public override void RecoitSortConfusion() {
            Console.WriteLine("La confusion demande un esprit vivant...");
        }

        public override string DescriptionEtat() {
            return "Mort";
        }
    }        
}
