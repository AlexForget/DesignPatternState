using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage {
    abstract class EtatPersonnage {
        Personnage personnage;

        protected EtatPersonnage(Personnage personnage) {
            this.personnage = personnage;
        }

        public virtual void Attaquer() {
            Console.WriteLine("L'attaque fait 100% des dégats");
        }

        public virtual void Soigner() {
            Console.WriteLine("Vous vous soignez, vous retrouvez le maximum de vos points de vie");
            personnage.setPointsDeVie(10);
        }

        public virtual void Fuir() {
           Console.WriteLine("Vous vuyez le combat");
        }

        public virtual void Diplomatie() {
            Console.WriteLine("Après une profonde conversation, votre ennemi vous comprend et va prendre une bière avec vous");
        }

        public virtual void RecoitDommage(int dommage) {

            personnage.setPointsDeVie(personnage.getPointsDeVie() - dommage);

            Console.WriteLine($"Vous avez reçu {dommage} points de dommage");

            if (personnage.getPointsDeVie() <= 0) {
                personnage.setEtat(personnage.getEtatMort());
            }
            /*--------------------*/
            if (personnage.getPointsDeVie() == 1) {
                personnage.setEtat(personnage.getEtatAffaibli());
            }
            /*--------------------*/
        }

        public virtual void RecoitPoison() {
            personnage.setEtat(personnage.getEtatEmpoisonne());
        }

        public virtual void RecoitSortConfusion() {
            personnage.setEtat(personnage.getEtatConfus());
        }

        abstract public string DescriptionEtat();

    }
}
