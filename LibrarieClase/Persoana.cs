using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Persoana
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;
        private const int CALORII_CONSUMATE = 2;
        private const int PROTEINE_CONSUMATE = 3;
        private const int CARBOHIDRATI_CONSUMATI = 4;
        private const int GRASIMI_CONSUMATE = 5;
        private const int CALORII_MENTINERE = 6;
        private const int MESE = 7;

        public int id_persoana { get; set; }
        public string nume { get; set; }
        public double calorii_consumate { get; set; } ///incepe de la 0, creste cu ce mananca;
        public double proteine_consumate { get; set; }
        public double carbohidrati_consumati { get; set; }
        public double grasimi_consumate { get; set; }
        public double calorii_mentinere { get; set; } ///o sa fie comparat cu cele consumate
        public int mese { get; set; } ///o sa fie incrementat


        public Persoana()
        {
            nume = "";
            calorii_consumate = 0;
            proteine_consumate = 0;
            carbohidrati_consumati = 0;
            grasimi_consumate = 0;
            calorii_mentinere = 0;
            mese = 0;
        }
        public Persoana(int id_persoana, string nume, double calorii_mentinere)
        {
            this.id_persoana = id_persoana;
            this.nume = nume;
            this.calorii_mentinere = calorii_mentinere;


        }
        public Persoana(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id_persoana = Convert.ToInt32(dateFisier[ID]);
            this.nume = dateFisier[NUME];
            this.calorii_consumate = Convert.ToDouble(dateFisier[CALORII_CONSUMATE]);
            this.proteine_consumate = Convert.ToDouble(dateFisier[PROTEINE_CONSUMATE]);
            this.carbohidrati_consumati = Convert.ToDouble(dateFisier[CARBOHIDRATI_CONSUMATI]);
            this.grasimi_consumate = Convert.ToDouble(dateFisier[GRASIMI_CONSUMATE]);
            this.calorii_mentinere = Convert.ToDouble(dateFisier[CALORII_MENTINERE]);
            this.mese = Convert.ToInt32(dateFisier[MESE]);

        }
        public string ToStringPersoana()
        {
            return nume + " " + calorii_consumate + " " + proteine_consumate + " " + carbohidrati_consumati + " " + grasimi_consumate + " " + calorii_mentinere + " " + mese;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectPersoana = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER, id_persoana, nume, calorii_consumate, proteine_consumate, carbohidrati_consumati, grasimi_consumate, calorii_mentinere, mese);
            return obiectPersoana;

        }
        //functie care adauga calorii, proteine, carbohidrati si grasimi consumate de o persoana folosind un aliment si masa acestuia
        public void AdaugaConsum(Aliment a)
        {
            calorii_consumate += a.calorii;
            proteine_consumate += a.proteine;
            carbohidrati_consumati += a.carbohidrati;
            grasimi_consumate += a.grasimi;
            mese++;
        }
    }
}
