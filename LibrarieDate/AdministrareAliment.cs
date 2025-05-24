using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace LibrarieDate
{
    public class AdministrareAliment
    {
        private const int NR_MAX_ALIMENTE = 100;
        private Aliment[] alimente;
        private int nrAlimente;
        private string numeFisier;
        public AdministrareAliment()
        {
            alimente = new Aliment[NR_MAX_ALIMENTE];
            nrAlimente = 0;
        }
        public AdministrareAliment(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        /*
        public void AdaugaAliment(Aliment a)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
            {
                swFisierText.WriteLine(a.id_aliment + ";" + a.denumire + ";" + a.calorii + ";" + a.proteine + ";" + a.carbohidrati + ";" + a.grasimi + ";" + a.tip_produs);
            }
        }
        */
        public void AdaugaAliment(Aliment a)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
            {
                swFisierText.WriteLine(a.ConversieLaSir_PentruFisier());
            }
        }
        public Aliment[] GetAlimente(out int nrAlimente)
        {
            Aliment[] copie = new Aliment[NR_MAX_ALIMENTE];
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string linie;
                nrAlimente = 0;
                while ((linie = sr.ReadLine()) != null)
                {
                    copie[nrAlimente++] = new Aliment(linie);
                }
            }
            Array.Resize(ref copie, nrAlimente);
            return copie;
        }
        public Aliment GetAlimentByIndex(int index)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Carte pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Aliment aliment = new Aliment(line);
                        if (aliment.id_aliment == index)
                            return aliment;
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
        public void ModificaAliment(Aliment a)
        {
            Aliment[] alimente = GetAlimente(out int nrAlimente);
            int id = a.id_aliment;
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, false))
            {
                for (int i = 0; i < nrAlimente; i++)
                {
                    if (alimente[i].id_aliment == id)
                    {
                        swFisierText.WriteLine(a.ConversieLaSir_PentruFisier());
                    }
                    else
                    {
                        swFisierText.WriteLine(alimente[i].ConversieLaSir_PentruFisier());
                    }
                }
            }
        }
        public void StergeAliment(Aliment a)
        {
            Aliment[] alimente = GetAlimente(out int nrAlimente);
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, false))
            {
                for (int i = 0; i < nrAlimente; i++)
                {
                    if (alimente[i].id_aliment != a.id_aliment)
                    {
                        swFisierText.WriteLine(alimente[i].ConversieLaSir_PentruFisier());
                    }
                }
            }
        }
        public string AfisareAlimente()
        {
            string s = "";
            for (int i = 0; i < nrAlimente; i++)
            {
                s += alimente[i].ToStringAliment() + "\n";
            }
            return s;
        }
        /*
        public Aliment CautareAliment(string denumire)
        {
            for (int i = 0; i < nrAlimente; i++)
            {
                if (alimente[i].denumire == denumire)
                {
                    return alimente[i];
                }
            }
            return null;
        }
        */
        public Aliment CautareAlimentFisier(string denumire)
        {
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    Aliment a = new Aliment(linie);
                    if (a.denumire == denumire)
                    {
                        return a;
                    }
                }
            }
            return null;
        }
    }
}
