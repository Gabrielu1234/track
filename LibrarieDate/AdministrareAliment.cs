using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieClase;

namespace LibrarieDate
{
    public class AdministrareAliment
    {
        private const int NR_MAX_ALIMENTE = 100;
        private Aliment[] alimente;
        private int nrAlimente;
        public AdministrareAliment()
        {
            alimente = new Aliment[NR_MAX_ALIMENTE];
            nrAlimente = 0;
        }
        public void AdaugaAliment(Aliment a)
        {
            alimente[nrAlimente++] = a;
        }
        public void AfisareAlimente()
        {
            for (int i = 0; i < nrAlimente; i++)
            {
                Console.WriteLine(alimente[i].ToString());
            }
        }
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
    }
}
