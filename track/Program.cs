using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using LibrarieDate;
using LibrarieClase;
using System.ComponentModel;

namespace Tracker
{
    class Program
    {
        static void Main(string[] args)
        {

            string numeFisierPersoane = ConfigurationManager.AppSettings["NumeFisierPersoane"];
            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            AdministrarePersoane adminPersoane = new AdministrarePersoane(numeFisierPersoane);
            AdministrareAliment adminAlimente = new AdministrareAliment(numeFisierAlimente);


            Persoana persoanaNou = new Persoana();
            int nrPersoane = 0;

            Aliment alimentNou = new Aliment();
            int nrAlimente = 0;

            string optiune;
            do
            {
                Console.WriteLine("1. Adauga persoana");
                Console.WriteLine("2. Adauga aliment");
                Console.WriteLine("3. Afisare persoane");
                Console.WriteLine("4. Afisare alimente");
                Console.WriteLine("5. Salvare persoane");
                Console.WriteLine("6. Salvare alimente");
                Console.WriteLine("7. Afisare ultima persoana");
                Console.WriteLine("8. Afisare ultimul aliment");
                Console.WriteLine("9. Mananaca ultima persoana");
                Console.WriteLine("10. Inchidere");

                Console.WriteLine("Optiunea ta: ");
                optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        persoanaNou = CitireTastaturaPersoana();
                        break;
                    case "2":
                        alimentNou = CitireTastaturaAliment();
                        break;
                    case "3":
                        Persoana[] persoane = adminPersoane.GetPersoane(out nrPersoane);
                        AfisarePersoane(persoane, nrPersoane);
                        break;
                    case "4":
                        Aliment[] alimente = adminAlimente.GetAlimente(out nrAlimente);
                        AfisareAlimente(alimente, nrAlimente);
                        break;
                    case "5":
                        int idPersoana = ++nrPersoane;
                        persoanaNou.id_persoana = idPersoana;
                        adminPersoane.AdaugaPersoana(persoanaNou);
                        break;
                    case "6":
                        int idAliment = ++nrAlimente;
                        alimentNou.id_aliment = idAliment;
                        adminAlimente.AdaugaAliment(alimentNou);
                        break;
                    case "7":
                        AfisarePersoana(persoanaNou);
                        break;
                    case "8":
                        AfisareAliment(alimentNou);
                        break;
                    case "9":
                        persoanaNou.AdaugaConsum(alimentNou);
                        break;
                    case "10":
                        return;
                    default:
                        Console.WriteLine("Optiune incorecta");
                        break;

                }
            } while (optiune != "10");
        }
        public static Aliment CitireTastaturaAliment()
        {
            string denumire;
            int calorii;
            int proteine;
            int carbohidrati;
            int grasimi;
            string tip;
            Console.WriteLine("Denumire: ");
            denumire = Console.ReadLine();
            Console.WriteLine("Calorii: ");
            calorii = int.Parse(Console.ReadLine());
            Console.WriteLine("Proteine: ");
            proteine = int.Parse(Console.ReadLine());
            Console.WriteLine("Carbohidrati: ");
            carbohidrati = int.Parse(Console.ReadLine());
            Console.WriteLine("Grasimi: ");
            grasimi = int.Parse(Console.ReadLine());
            Console.WriteLine("Tip: ");
            tip = Console.ReadLine();
            return new Aliment(0, denumire, calorii, proteine, carbohidrati, grasimi, tip);
        }
        public static Persoana CitireTastaturaPersoana()
        {
            string nume;
            double calorii;
            Console.WriteLine("Nume: ");
            nume = Console.ReadLine();
            Console.WriteLine("Calorii: ");
            calorii = double.Parse(Console.ReadLine());
            return new Persoana(0, nume, calorii);
        }
        public static void AfisarePersoane(Persoana[] persoane, int nrPersoane)
        {
            Console.WriteLine("Persoane: ");
            for (int i = 0; i < nrPersoane; i++)
            {
                Console.WriteLine(persoane[i].ToStringPersoana());
            }
        }
        public static void AfisareAlimente(Aliment[] alimente, int nrAlimente)
        {
            Console.WriteLine("Alimente: ");
            for (int i = 0; i < nrAlimente; i++)
            {
                Console.WriteLine(alimente[i].ToStringAliment());
            }
        }
        public static void AfisarePersoana(Persoana persoana)
        {
            Console.WriteLine("Ultima persoana adaugata: ");
            Console.WriteLine(persoana.ToStringPersoana());
        }
        public static void AfisareAliment(Aliment aliment)
        {
            Console.WriteLine("Ultimul aliment adaugat: ");
            Console.WriteLine(aliment.ToStringAliment());
        }
    }
}
