using System;
using LibrarieClase;
using LibrarieDate;
using MetroFramework.Forms;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace track_ui
{
    public partial class EditarePersoana : MetroFramework.Forms.MetroForm
    {
        AdministrarePersoane adminPersoane;
        public EditarePersoana(int id)
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string numeFisierPersoane = ConfigurationManager.AppSettings["NumeFisierPersoane"];
            string caleCompletaFisierPersoane = locatieFisierSolutie + "\\" + numeFisierPersoane;
            lblID.Text = id.ToString();
            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoane);
            SetareCampuri();
        }
        private void SetareCampuri()
        {
            Persoana persoana = adminPersoane.GetPersoanaByIndex(int.Parse(lblID.Text));
            if (persoana == null)
            {
                MessageBox.Show("Persoana nu exista!");
                return;
            }
            else
            {
                TextNume.Text = persoana.nume;
                TextCalorii.Text = persoana.calorii_mentinere.ToString();

            }
        }

        private void EditarePersoana_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int ok = 1;
            string nume = TextNume.Text;
            int calorii = TextCalorii.Text != "" ? int.Parse(TextCalorii.Text) : 0;
            if (string.IsNullOrEmpty(nume))
            {
                metroNume.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroNume.ForeColor = Color.Black;
            }
            if (calorii < 0)
            {
                metroCalorii.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroCalorii.ForeColor = Color.Black;
            }
            Persoana persoana = new Persoana(int.Parse(lblID.Text), nume, calorii);
            if (ok == 1)
            {
                try
                {
                    adminPersoane.ModificaPersoana(persoana);
                    MessageBox.Show("Persoana a fost modificata cu succes!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la modificarea persoanei: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");

            }
        }
    }
}
