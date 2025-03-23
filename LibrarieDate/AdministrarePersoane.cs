using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace LibrarieDate
{
    public class AdministrarePersoane
    {
        private const int NR_MAX_PERSOANE = 100;
        private Persoana[] persoane;
        private int nrPersoane;
        private string numeFisier;

        public AdministrarePersoane()
        {
            persoane = new Persoana[NR_MAX_PERSOANE];
            nrPersoane = 0;
        }
        public AdministrarePersoane(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        /*
        public void AdaugaPersoana(Persoana p)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
            {
                swFisierText.WriteLine(p.id_persoana + ";" + p.nume + ";" + p.calorii_consumate + ";" + p.proteine_consumate + ";" + p.carbohidrati_consumati + ";" + p.grasimi_consumate + ";" + p.calorii_mentinere + ";" + p.mese);
            }
        }
        */
        public void AdaugaPersoana(Persoana p)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
            {
                swFisierText.WriteLine(p.ConversieLaSir_PentruFisier());
            }
        }
        // nu pune obiectul modificat bine in fisier
        public void ModificarePersoanaFisier(Persoana p)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
            {
                for (int i = 0; i < nrPersoane; i++)
                {
                    if (persoane[i].nume == p.nume)
                    {
                        persoane[i] = p;
                    }
                    sw.WriteLine(persoane[i].ConversieLaSir_PentruFisier());
                }
            }
        }
        public Persoana[] GetPersoane(out int nrPersoane)
        {
            Persoana[] copie = new Persoana[NR_MAX_PERSOANE];
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string linie;
                nrPersoane = 0;
                while ((linie = sr.ReadLine()) != null)
                {
                    copie[nrPersoane++] = new Persoana(linie);
                }
            }
            return copie;
        }
        public string AfisarePersoane()
        {
            string s = "";
            for (int i = 0; i < nrPersoane; i++)
            {
                s += persoane[i].ToStringPersoana() + "\n";
            }
            return s;
        }
        /*
        public Persoana CautarePersoana(string nume)
        {
            for (int i = 0; i < nrPersoane; i++)
            {
                if (persoane[i].nume == nume)
                {
                    return persoane[i];
                }
            }
            return null;
        }
        */
        public Persoana CautarePersoanaFisier(string nume)
        {
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    Persoana p = new Persoana(linie);
                    if (p.nume == nume)
                    {
                        return p;
                    }
                }
            }
            return null;
        }
    }
}
