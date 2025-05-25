using LibrarieClase;
using LibrarieDate;
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
                foreach (var activitati in groupActivitate.Controls)
                {
                    if (activitati is CheckBox)
                    {
                        var activitatebox = activitati as CheckBox;
                        if (Enum.TryParse<Persoana.TipActivitate>(activitatebox.Text, out var activitateEnum) &&
                            persoana.activitate.HasFlag(activitateEnum))
                        {
                            activitatebox.Checked = true;
                        }
                    }
                }
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
            Persoana persoanafolosita = adminPersoane.GetPersoanaByIndex(int.Parse(lblID.Text));

            Persoana persoana = new Persoana(int.Parse(lblID.Text), nume, calorii);
            persoana.calorii_consumate = persoanafolosita.calorii_consumate;
            persoana.proteine_consumate = persoanafolosita.proteine_consumate;
            persoana.carbohidrati_consumati = persoanafolosita.carbohidrati_consumati;
            persoana.grasimi_consumate = persoanafolosita.grasimi_consumate;
            persoana.mese = persoanafolosita.mese; 

            foreach (var activitati in groupActivitate.Controls)
            {
                if (activitati is CheckBox)
                {
                    var activitatebox = activitati as CheckBox;
                    if (activitatebox.Checked)
                    {
                        // Convert the string to the enum value
                        if (Enum.TryParse<Persoana.TipActivitate>(activitatebox.Text, out var activitateEnum))
                        {
                            persoana.activitate |= activitateEnum; 
                        }
                    }
                }
            }
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

        private void metroMobilitate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
