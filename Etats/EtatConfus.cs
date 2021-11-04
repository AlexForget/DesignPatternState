using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage.Etats {
    class EtatConfus : EtatPersonnage {
        Personnage personnage;

        public EtatConfus(Personnage personnage) : base(personnage) {
            this.personnage = personnage;
        }

        public override void Diplomatie() {
            Console.WriteLine("Vous tenez des propos confus, votre ennemi s'enrage!");
        }

        public override void Fuir() {
            Console.WriteLine("Vous n'avez aucune idée par ou fuir.");
        }

        public override void RecoitSortConfusion() {
            Console.WriteLine("Déjà confus. Donc, doublement confus??");
        }

        public override void Soigner() {
            Console.WriteLine("Vous retrouvez vos esprits!");
            personnage.setEtat(personnage.getEtatSante());
        }

        public override void RecoitPoison() {
            Console.WriteLine("J'ai pas implenté de double états, donnez mois une chance par pitié!!");
        }

        public override string DescriptionEtat() {
            return "Confus";
        }
    }
}
