using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieClase;

namespace LibrarieDate
{
    public class AdministrarePersoane
    {
        private const int NR_MAX_PERSOANE = 100;
        private Persoana[] persoane;
        private int nrPersoane;

        public AdministrarePersoane()
        {
            persoane = new Persoana[NR_MAX_PERSOANE];
            nrPersoane = 0;
        }

        public void AdaugaPersoana(Persoana p)
        {
            persoane[nrPersoane++] = p;
        }
        public void AfisarePersoane()
        {
            for (int i = 0; i < nrPersoane; i++)
            {
                Console.WriteLine(persoane[i].ToString());
            }
        }
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
    }
}
