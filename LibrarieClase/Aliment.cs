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
        public string denumire { get; set; } ///ou per 100g
        public double calorii { get; set; } ///=proteine*4+carbohidrati*4+grasimi*9
        public double proteine { get; set; } ///12.6g
        public double carbohidrati { get; set; } ///1.1g
        public double grasimi { get; set; } ///9.5g
        public string tip_produs { get; set; } ///origine animala

        public Aliment()
        {
            denumire = "";
            calorii = 0;
            proteine = 0;
            carbohidrati = 0;
            grasimi = 0;
            tip_produs = "";
        }
        public Aliment(int id_aliment, string denumire, double calorii, double proteine, double carbohidrati, double grasimi, string tip_produs)
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
            this.tip_produs = dateFisier[TIP_PRODUS];
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
