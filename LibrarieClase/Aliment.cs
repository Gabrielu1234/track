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
        public Aliment(string denumire, double calorii, double proteine, double carbohidrati, double grasimi, string tip_produs)
        {
            this.denumire = denumire;
            this.calorii = calorii;
            this.proteine = proteine;
            this.carbohidrati = carbohidrati;
            this.grasimi = grasimi;
            this.tip_produs = tip_produs;
        }
        public string ToString()
        {
            return denumire + " " + calorii + " " + proteine + " " + carbohidrati + " " + grasimi + " " + tip_produs;
        }
        public void CitireTastarura()
        {
            Console.WriteLine("Denumire: ");
            denumire = Console.ReadLine();
            Console.WriteLine("Calorii: ");
            calorii = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Proteine: ");
            proteine = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Carbohidrati: ");
            carbohidrati = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Grasimi: ");
            grasimi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tip produs: ");
            tip_produs = Console.ReadLine();
        }
    }
}
