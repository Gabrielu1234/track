using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Persoana
    {
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
        public Persoana(string nume, double calorii_mentinere)
        {
            this.nume = nume;
            this.calorii_mentinere = calorii_mentinere;
   

        }
        public string ToString()
        {
            return nume + " " + calorii_consumate + " " + proteine_consumate + " " + carbohidrati_consumati + " " + grasimi_consumate + " " + calorii_mentinere + " " + mese;
        }
        public void CitireTastatura()
        {
            Console.WriteLine("Nume: ");
            nume = Console.ReadLine();
            Console.WriteLine("Calorii mentinere: ");
            calorii_mentinere = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}
