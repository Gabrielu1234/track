using LibrarieClase;
using System;
using System.IO;

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
        public void AdaugaPersoana(Persoana p)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
            {
                swFisierText.WriteLine(p.ConversieLaSir_PentruFisier());
            }
        }
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
            Array.Resize(ref copie, nrPersoane);
            return copie;
        }
        public Persoana GetPersoanaByIndex(int index)
        {
            try
            {
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana persoana = new Persoana(line);
                        if (persoana.id_persoana == index)
                            return persoana;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
        public void ModificaPersoana(Persoana p)
        {
            Persoana[] persoane = GetPersoane(out nrPersoane);
            int id=p.id_persoana;
            using(StreamWriter sw = new StreamWriter(numeFisier, false))
            {
                for (int i = 0; i < nrPersoane; i++)
                {
                    if (persoane[i].id_persoana == id)
                    {
                        sw.WriteLine(p.ConversieLaSir_PentruFisier());
                    }
                    else
                    {
                        sw.WriteLine(persoane[i].ConversieLaSir_PentruFisier());
                    }
                }
            }
        }
        public void StergePersoanaFisier(Persoana p)
        {
            Persoana[] persoane = GetPersoane(out nrPersoane);
            using (StreamWriter sw = new StreamWriter(numeFisier, false))
            {
                for (int i = 0; i < nrPersoane; i++)
                {
                    if (persoane[i].nume != p.nume)
                    {
                        sw.WriteLine(persoane[i].ConversieLaSir_PentruFisier());
                    }
                }
            }
        }
        public void ManancaPersoana(Aliment aliment, Persoana p,float grame)
        {
            p = p.AdaugaConsum(aliment,grame);
            ModificaPersoana(p);
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
