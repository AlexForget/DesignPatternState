using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage {
    class EtatEmpoisonne : EtatPersonnage {
        Personnage personnage;

        public EtatEmpoisonne(Personnage personnage) : base(personnage) {
            this.personnage = personnage;
        }
        public override void Attaquer() {
            Console.WriteLine("Le poisson vous a affaibli, l'attaque fait 50% des dommages");
        }

        public override void RecoitPoison() {
            Console.WriteLine("Deja empoisonné. Donc, doublement empoisonné?!");
        }

        public override void Soigner() {
            Console.WriteLine("Vous avez soigné votre poison");
            personnage.setEtat(personnage.getEtatSante());
        }

        public override void RecoitSortConfusion() {
            Console.WriteLine("J'ai pas implenté de double états, donnez mois une chance par pitié!!");
        }

        public override string DescriptionEtat() {
            return "Empoisonné";
        }
    }
}
