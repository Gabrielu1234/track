using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{
    class Aliment
    {
        string denumire { get; set; } ///ou per 100g
        double calorii { get; set; } ///=proteine*4+carbohidrati*4+grasimi*9
        double proteine { get; set; } ///12.6g
        double carbohidrati { get; set; } ///1.1g
        double grasimi { get; set; } ///9.5g
        string tip_produs { get; set; } ///origine animala

        public Aliment(string denumire, double calorii, double proteine, double carbohidrati, double grasimi, string tip_produs)
        {
            this.denumire = denumire;
            this.calorii = calorii;
            this.proteine = proteine;
            this.carbohidrati = carbohidrati;
            this.grasimi = grasimi;
            this.tip_produs = tip_produs;
        }
    }
}
