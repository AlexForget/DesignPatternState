using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage.Etats {
    class EtatAffaibli : EtatPersonnage {
        Personnage personnage;

        public EtatAffaibli(Personnage personnage) : base(personnage) {
            this.personnage = personnage;
        }

        public override void Attaquer() {
            Console.WriteLine("Vous êtes trop faible pour avoir un réel impact, l'attaque ne fait que 10% des dégâts.");
        }

        public override void Soigner() {
            base.Soigner();
            personnage.setEtat(personnage.getEtatSante());
        }

        public override void Fuir() {
            Console.WriteLine("Vous êtes trop faible pour pouvoir courir");
        }

        public override void RecoitSortConfusion() {
            Console.WriteLine("J'ai pas implenté de double états, donnez mois une chance par pitié!!");
        }

        public override void RecoitPoison() {
            Console.WriteLine("J'ai pas implenté de double états, donnez mois une chance par pitié!!");
        }

        public override string DescriptionEtat() {
            return "Affaibli";
        }
    }
}
