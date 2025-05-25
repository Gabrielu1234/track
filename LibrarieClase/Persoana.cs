using System;

namespace LibrarieClase
{
    public class Persoana
    {
        [Flags]
        public enum TipActivitate
        {
            Niciuna = 0,
            Cardio = 1 << 0,      
            Forta = 1 << 1,       
            Mobilitate = 1 << 2,   
            Sporturi = 1 << 3,
            Altele = 1 << 4
        }
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
        private const int ACTIVITATE = 8;

        public int id_persoana { get; set; }
        public string nume { get; set; }
        public double calorii_consumate { get; set; } 
        public double proteine_consumate { get; set; }
        public double carbohidrati_consumati { get; set; }
        public double grasimi_consumate { get; set; }
        public double calorii_mentinere { get; set; } 
        public int mese { get; set; } 
        public TipActivitate activitate { get; set; }


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
            this.activitate = TipActivitate.Niciuna;


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
            this.activitate = (TipActivitate)Enum.Parse(typeof(TipActivitate), dateFisier[ACTIVITATE]);

        }
        public string ToStringPersoana()
        {
            return nume + " " + calorii_consumate + " " + proteine_consumate + " " + carbohidrati_consumati + " " + grasimi_consumate + " " + calorii_mentinere + " " + mese + " " + GetActivitatiString(activitate);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectPersoana = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}",
                SEPARATOR_PRINCIPAL_FISIER, id_persoana, nume, calorii_consumate, proteine_consumate, carbohidrati_consumati, grasimi_consumate, calorii_mentinere, mese,activitate);
            return obiectPersoana;

        }
        public Persoana AdaugaConsum(Aliment a,float grame)
        {
            calorii_consumate += a.calorii * (grame/100);
            proteine_consumate += a.proteine * (grame/100);
            carbohidrati_consumati += a.carbohidrati * (grame / 100);
            grasimi_consumate += a.grasimi * (grame / 100);
            mese++;
            return this;
        }
        public string GetActivitatiString(TipActivitate activitate)
        {
            string activitati = "";
            if ((activitate & TipActivitate.Cardio) == TipActivitate.Cardio)
                activitati += "Cardio ";
            if ((activitate & TipActivitate.Forta) == TipActivitate.Forta)
                activitati += "Forta ";
            if ((activitate & TipActivitate.Mobilitate) == TipActivitate.Mobilitate)
                activitati += "Mobilitate ";
            if ((activitate & TipActivitate.Sporturi) == TipActivitate.Sporturi)
                activitati += "Sporturi ";
            if ((activitate & TipActivitate.Altele) == TipActivitate.Altele)
                activitati += "Altele ";
            return activitati;
        }
    }
}
