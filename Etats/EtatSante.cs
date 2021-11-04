using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePatternPersonnage {
    class EtatSante : EtatPersonnage {
        Personnage personnage;

        public EtatSante(Personnage personnage) : base(personnage) {
            this.personnage = personnage;
        }

        public override string DescriptionEtat() {
            return "En santé";
        }
    }
}
