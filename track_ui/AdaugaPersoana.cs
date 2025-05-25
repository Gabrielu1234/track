using LibrarieClase;
using LibrarieDate;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace track_ui
{
    public partial class AdaugaPersoana: UserControl
    {
        AdministrarePersoane adminPersoane;

        public AdaugaPersoana()
        {
            InitializeComponent();
            string locatieFisierSolutie = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string numeFisierPersoane = System.Configuration.ConfigurationManager.AppSettings["NumeFisierPersoane"];
            string caleCompletaFisierPersoana = locatieFisierSolutie + "\\" + numeFisierPersoane;
            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoana);
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AdaugaPersoana_Load(object sender, EventArgs e)
        {
        }

        private void metroAdauga_Click(object sender, EventArgs e)
        {
            int ok = 1;
            string nume = metroNume.Text;
            double calorii_mentinere;

            if (string.IsNullOrEmpty(nume))
            {
                metroLabel1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel1.ForeColor = Color.Black;
            }

            if (!double.TryParse(metroCalorii.Text, out calorii_mentinere))
            {
                metroLabel2.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel2.ForeColor = Color.Black;
            }


                Persoana.TipActivitate activitate = Persoana.TipActivitate.Niciuna;

                if (metroCardio.Checked)
                {
                    activitate |= Persoana.TipActivitate.Cardio;
                }
                if (metroForta.Checked)
                {
                    activitate |= Persoana.TipActivitate.Forta;
                }
                if (metroMobilitate.Checked)
                {
                    activitate |= Persoana.TipActivitate.Mobilitate;
                }
                if (metroSporturi.Checked)
                {
                    activitate |= Persoana.TipActivitate.Sporturi;
                }
                if (metroAltele.Checked)
                {
                    activitate |= Persoana.TipActivitate.Altele;
                }

                if (activitate == Persoana.TipActivitate.Niciuna)
                {
                    MessageBox.Show("Selecteaza cel putin o activitate fizica!");
                    ok = 0;
                }

            if (ok == 1)
            {
                Persoana[] persoane = adminPersoane.GetPersoane(out int nrPersoane);
                int nextId = nrPersoane > 0 ? persoane.Max(p => p.id_persoana) + 1 : 1;

                Persoana persoana = new Persoana(nextId, nume, calorii_mentinere)
                {
                    activitate = activitate
                };

                adminPersoane.AdaugaPersoana(persoana);
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }
            metroNume.Text = "";
            metroCalorii.Text = "";
            metroCardio.Checked = false;
            metroForta.Checked = false;
            metroMobilitate.Checked = false;
            metroSporturi.Checked = false;
            metroAltele.Checked = false;

        }

        private void metroSporturi_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
