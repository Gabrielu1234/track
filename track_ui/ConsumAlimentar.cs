using LibrarieClase;
using LibrarieDate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace track_ui
{
    public partial class ConsumAlimentar : MetroFramework.Forms.MetroForm
    {
        AdministrarePersoane administrarePersoane;
        AdministrareAliment administrareAliment;
        public ConsumAlimentar(int id)
        {
            InitializeComponent();
            string locatieFisierSolutie = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string numeFisierAlimente = System.Configuration.ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;
            administrareAliment = new AdministrareAliment(caleCompletaFisierAlimente);
            string numeFisierPersoane = System.Configuration.ConfigurationManager.AppSettings["NumeFisierPersoane"];
            string caleCompletaFisierPersoane = locatieFisierSolutie + "\\" + numeFisierPersoane;
            administrarePersoane = new AdministrarePersoane(caleCompletaFisierPersoane);
            lblID.Text = id.ToString();


        }

        private void ConsumAlimentar_Load(object sender, EventArgs e)
        {
            AfiseazaMetroGrid(administrareAliment.GetAlimente(out int nrAlimente).ToList());
        }
        public void AfiseazaMetroGrid(List<Aliment> alimente)
        {
            metroGridAliment.DataSource = null;

            if (alimente != null && alimente.Any())
            {
                metroGridAliment.DataSource = alimente.Select(s => new
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
        }

        private void metroAdauga_Click(object sender, EventArgs e)
        {
            Aliment alimentSelectat = administrareAliment.GetAlimentByIndex(Convert.ToInt32(metroGridAliment.CurrentRow.Cells[0].Value));
            Persoana persoanaSelectata = administrarePersoane.GetPersoanaByIndex(Convert.ToInt32(lblID.Text));
            if (TextGrame.Text == string.Empty)
            {
                MessageBox.Show("Trebuie sa introduci numarul de grame consumate!");
            }
            else
            {
                administrarePersoane.ManancaPersoana(alimentSelectat, persoanaSelectata, Convert.ToSingle(TextGrame.Text));
            }
            this.Close();

        }
    }
}
