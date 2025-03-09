using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LibrarieDate;
using LibrarieClase;

namespace Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana g = new Persoana();
            g.CitireTastatura();
            Persoana h = new Persoana("Gabi", 2000);

            AdministrarePersoane ap = new AdministrarePersoane();
            ap.AdaugaPersoana(g);
            ap.AdaugaPersoana(h);
            ap.AfisarePersoane();


            Aliment a = new Aliment();
            a.CitireTastarura();

            AdministrareAliment aa = new AdministrareAliment();
            aa.AdaugaAliment(a);
            Aliment b = new Aliment("Paine", 200, 10, 20, 30, "carbohidrati");
            aa.AdaugaAliment(b);
            aa.AfisareAlimente();

            Console.WriteLine(aa.CautareAliment("Paine").ToString());
        }
    }
}
