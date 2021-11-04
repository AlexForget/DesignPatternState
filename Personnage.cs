using DemoStatePatternPersonnage.Etats;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage {
    class Personnage {
        int pointsDeVie;
        EtatPersonnage etat;

        EtatPersonnage sante;
        EtatPersonnage empoisonne;
        EtatPersonnage coufus;
        EtatPersonnage mort;
        /*--------------------*/
        EtatPersonnage affaibli;
        /*--------------------*/

        public Personnage(int pointsDeVie) {
            this.pointsDeVie = pointsDeVie;

            sante = new EtatSante(this);
            empoisonne = new EtatEmpoisonne(this);
            coufus = new EtatConfus(this);
            mort = new EtatMort(this);
            /*--------------------*/
            affaibli = new EtatAffaibli(this);
            /*--------------------*/

            if (pointsDeVie > 1) {
                etat = sante;
                /*--------------------*/
            } else if(pointsDeVie == 1) {
                etat = affaibli;
                /*--------------------*/
            } else {
                etat = mort;
            }
        }

        // Actions personnages

        public void Attaquer() {
            etat.Attaquer();
        }

        public void Soigner() {
            etat.Soigner();
        }

        public void Fuir() {
            etat.Fuir();
        }

        public void Diplomatie() {
            etat.Diplomatie();
        }

        public void recoitDommage(int dommage) {
            etat.RecoitDommage(dommage);
        }

        public void recoitPoison() {
            etat.RecoitPoison();
        }

        public void recoitSortConfusion() {
            etat.RecoitSortConfusion();
        }

        public override string ToString() {
            return $"\nGlorieux George \nPoint de vie : {pointsDeVie} \nÉtat : {etat.DescriptionEtat()} \n";
        }

        // Setter - Points de vie

        public int getPointsDeVie() {
            return pointsDeVie;
        }

        public void setPointsDeVie(int pointsDeVie) {
            this.pointsDeVie = pointsDeVie;
        }

        // Setter - Getter états

        public void setEtat(EtatPersonnage etat) {
            this.etat = etat;
        }

        public EtatPersonnage getEtatSante() {
            return sante;
        }

        public EtatPersonnage getEtatEmpoisonne() {
            return empoisonne;
        }

        public EtatPersonnage getEtatConfus() {
            return coufus;
        }

        public EtatPersonnage getEtatMort() {
            return mort;
        }

        /*--------------------*/
        public EtatPersonnage getEtatAffaibli() {
            return affaibli;
        }
        /*--------------------*/

    }

}
