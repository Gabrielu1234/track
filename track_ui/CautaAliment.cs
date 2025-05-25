using LibrarieClase;
using LibrarieDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace track_ui
{
    public partial class CautaAliment : UserControl
    {
        private AdministrareAliment adminAliment;

        public CautaAliment()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;


            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);
        }

        private void CautaAliment_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string denumire = metroDenumire.Text;
            Aliment aliment = adminAliment.CautareAlimentFisier(denumire); 

            if (aliment != null)
            {
                List<Aliment> listaAlimente = new List<Aliment>();
                listaAlimente.Add(aliment);
                metroGridAliment.DataSource = null;
                metroGridAliment.DataSource = listaAlimente.Select(s => new
                {
                    ID = s.id_aliment,
                    Denumire = s.denumire,
                    Calorii = s.calorii,
                    Proteine = s.proteine,
                    Carbohidrati = s.carbohidrati,
                    Grasimi = s.grasimi,
                    TipProdus = s.tip_produs
                }).ToList();
            }
            else
            {
                MessageBox.Show("Alimentul nu a fost găsit.");
            }
        }

        private void metroGridAliment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
