using LibrarieClase;
using LibrarieDate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace track_ui
{
    public partial class CautaPersoana: UserControl
    {
        private AdministrarePersoane adminPersoane;
        public CautaPersoana()
        {
            InitializeComponent();
            string locatieFisierSolutie = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string numeFisierPersoane = System.Configuration.ConfigurationManager.AppSettings["NumeFisierPersoane"];

            string caleCompletaFisierPersoana = locatieFisierSolutie + "\\" + numeFisierPersoane;
            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoana);
        }

        private void metroCauta_Click(object sender, EventArgs e)
        {
            string nume = metroNume.Text;
            Persoana persoana = adminPersoane.CautarePersoanaFisier(nume);

            if (persoana != null)
            {
                List<Persoana> listaPersoane = new List<Persoana>();
                listaPersoane.Add(persoana);
                metroGridPersoana.DataSource = null;
                metroGridPersoana.DataSource = listaPersoane.Select(s => new
                {
                    Denumire = s.nume,
                    Calorii = s.calorii_consumate,
                    Proteine = s.proteine_consumate,
                    Carbohidratii = s.carbohidrati_consumati,
                    Grasimi = s.grasimi_consumate,
                    Mentinere = s.calorii_mentinere,
                    Mese = s.mese,
                    Activitate = s.GetActivitatiString(s.activitate)
                }).ToList();
            }
            else
            {
                MessageBox.Show("Nu exista persoana cautata");
            }
        }
        private void CautaPersoana_Load(object sender, EventArgs e)
        {

        }

        private void metroNume_Click(object sender, EventArgs e)
        {

        }
    }
}
