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
                Console.WriteLine("9. Mananaca persoana x aliment y");
                Console.WriteLine("10. Cauta Persoana");
                Console.WriteLine("11. Cauta Aliment");
                Console.WriteLine("12. Inchidere");

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
                        // modifica obiectul bine, dar nu il salveaza in fisier corect
                        Console.WriteLine("Numele persoanei cautate: ");
                        string numePersoana = Console.ReadLine();
                        Persoana persoanaGasita2 = adminPersoane.CautarePersoanaFisier(numePersoana);
                        Console.WriteLine("Numele alimentului: ");
                        string numeAliment = Console.ReadLine();
                        Aliment alimentGasit2 = adminAlimente.CautareAlimentFisier(numeAliment);
                        persoanaGasita2.AdaugaConsum(alimentGasit2);
                        Console.WriteLine(persoanaGasita2.ToStringPersoana());
                        adminPersoane.ModificarePersoanaFisier(persoanaGasita2);
                        break;
                    case "10":
                        Console.WriteLine("Numele persoanei cautate: ");
                        string numeCautat = Console.ReadLine();
                        Persoana persoanaGasita = adminPersoane.CautarePersoanaFisier(numeCautat);
                        if (persoanaGasita != null)
                        {
                            Console.WriteLine(persoanaGasita.ToStringPersoana());
                        }
                        else
                        {
                            Console.WriteLine("Persoana nu a fost gasita");
                        }
                        break;
                    case "11":
                        Console.WriteLine("Denumirea alimentului cautat: ");
                        string denumireCautata = Console.ReadLine();
                        Aliment alimentGasit = adminAlimente.CautareAlimentFisier(denumireCautata);
                        if (alimentGasit != null)
                        {
                            Console.WriteLine(alimentGasit.ToStringAliment());
                        }
                        else
                        {
                            Console.WriteLine("Alimentul nu a fost gasit");
                        }
                        break;
                    case "12":
                        return;
                    default:
                        Console.WriteLine("Optiune incorecta");
                        break;

                }
            } while (optiune != "12");
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
            Console.WriteLine("1. Fructe");
            Console.WriteLine("2. Legume");
            Console.WriteLine("3. Carne");
            Console.WriteLine("4. Lactate");
            Console.WriteLine("5. Cereale");
            Console.WriteLine("6. Dulciuri");
            Console.WriteLine("7. Bauturi");
            Console.WriteLine("8. Altele");
            int optiune = Convert.ToInt32(Console.ReadLine());
            return new Aliment(0, denumire, calorii, proteine, carbohidrati, grasimi, (Aliment.TipProdus)optiune);
        }
        public static Persoana CitireTastaturaPersoana()
        {
            string nume;
            double calorii;
            Console.WriteLine("Nume: ");
            nume = Console.ReadLine();
            Console.WriteLine("Calorii: ");
            calorii = double.Parse(Console.ReadLine());
            Persoana pers= new Persoana(0, nume, calorii);

            Console.WriteLine("Activitati: ");
            Console.WriteLine("1. Cardio");
            Console.WriteLine("2. Forta");
            Console.WriteLine("4. Mobilitate");
            Console.WriteLine("8. Sporturi");
            Console.WriteLine("16. Altele");
            string activitati= Console.ReadLine();
            string[] activitatiSplit = activitati.Split(' ');
            foreach (string activitate in activitatiSplit)
            {
                pers.activitate |= (Persoana.TipActivitate)Enum.Parse(typeof(Persoana.TipActivitate), activitate);
            }

            return pers;
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
