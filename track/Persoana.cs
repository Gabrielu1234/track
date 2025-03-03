using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{
    public class Persoana
    {
        string nume { get; set; }
        double calorii_consumate { get; set; } ///incepe de la 0, creste cu ce mananca;
        double proteine_consumate { get; set; }
        double carbohidrati_consumati { get; set; }
        double grasimi_consumate { get; set; }
        double calorii_mentinere { get; set; } ///o sa fie comparat cu cele consumate
        int mese { get; set; } ///o sa fie incrementat

        public Persoana(string nume, double calorii_consumate, double proteine_consumate, double carbohidrati_consumati, double grasimi_consumate, double calorii_mentinere, int mese)
        {
            this.nume = nume;
            this.calorii_consumate = calorii_consumate;
            this.proteine_consumate = proteine_consumate;
            this.carbohidrati_consumati = carbohidrati_consumati;
            this.grasimi_consumate = grasimi_consumate;
            this.calorii_mentinere = calorii_mentinere;
            this.mese = mese;

        }


    }
}
