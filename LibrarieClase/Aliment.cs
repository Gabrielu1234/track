using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Aliment
    {
        public enum TipProdus
        {
            Fructe = 1,
            Legume = 2,
            Carne = 3,
            Lactate = 4,
            Cereale = 5,
            Dulciuri = 6,
            Bauturi = 7,
            Altele = 8,
        };
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int CALORII = 2;
        private const int PROTEINE = 3;
        private const int CARBOHIDRATI = 4;
        private const int GRASIMI = 5;
        private const int TIP_PRODUS = 6;


        public int id_aliment { get; set; }
        public string denumire { get; set; } 
        public double calorii { get; set; } ///=proteine*4+carbohidrati*4+grasimi*9
        public double proteine { get; set; } 
        public double carbohidrati { get; set; } 
        public double grasimi { get; set; } 
        public TipProdus tip_produs { get; set; } 

        public Aliment()
        {
            denumire = "";
            calorii = 0;
            proteine = 0;
            carbohidrati = 0;
            grasimi = 0;
        }
        public Aliment(int id_aliment, string denumire, double calorii, double proteine, double carbohidrati, double grasimi, TipProdus tip_produs)
        {
            this.id_aliment = id_aliment;
            this.denumire = denumire;
            this.calorii = calorii;
            this.proteine = proteine;
            this.carbohidrati = carbohidrati;
            this.grasimi = grasimi;
            this.tip_produs = tip_produs;
        }
        public Aliment(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id_aliment = Convert.ToInt32(dateFisier[ID]);
            this.denumire = dateFisier[DENUMIRE];
            this.calorii = Convert.ToDouble(dateFisier[CALORII]);
            this.proteine = Convert.ToDouble(dateFisier[PROTEINE]);
            this.carbohidrati = Convert.ToDouble(dateFisier[CARBOHIDRATI]);
            this.grasimi = Convert.ToDouble(dateFisier[GRASIMI]);
            this.tip_produs = (TipProdus)Enum.Parse(typeof(TipProdus), dateFisier[TIP_PRODUS]);
        }
        public string ToStringAliment()
        {
            return denumire + " " + calorii + " " + proteine + " " + carbohidrati + " " + grasimi + " " + tip_produs;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectAliment = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER, id_aliment, denumire, calorii, proteine, carbohidrati, grasimi, tip_produs);
            return obiectAliment;
        }
    }
}
