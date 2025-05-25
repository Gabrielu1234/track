using LibrarieClase;
using LibrarieDate;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace track_ui
{
    public partial class AdaugaAliment: UserControl
    {

        AdministrareAliment adminAliment;

        public AdaugaAliment()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;

            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);


        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            int ok = 1;
            string denumire = metroDenumire.Text;
            int calorii;
            int proteine;
            int carbohidrati;
            int grasimi;
            Aliment.TipProdus tipProdus;
            if(metroCarne.Checked)
            {
                tipProdus = Aliment.TipProdus.Carne;
            }
            else if (metroLactate.Checked)
            {
                tipProdus = Aliment.TipProdus.Lactate;
            }
            else if (metroCereale.Checked)
            {
                tipProdus = Aliment.TipProdus.Cereale;
            }
            else if (metroDulciuri.Checked)
            {
                tipProdus = Aliment.TipProdus.Dulciuri;
            }
            else if (metroBauturi.Checked)
            {
                tipProdus = Aliment.TipProdus.Bauturi;
            }
            else if (metroLegume.Checked)
            {
                tipProdus = Aliment.TipProdus.Legume;
            }
            else if (metroFructe.Checked)
            {
                tipProdus = Aliment.TipProdus.Fructe;
            }
            else
            {
                tipProdus = Aliment.TipProdus.Altele;
            }
            if (string.IsNullOrEmpty(denumire))
            {
                metroLabel1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel1.ForeColor = Color.Black;
            }
            if (!int.TryParse(metroCalorii.Text, out calorii))
            {
                metroLabel2.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel2.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(metroProteine.Text, out proteine))
            {
                metroLabel3.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel3.ForeColor = Color.Black;
            }
            if (!int.TryParse(metroCarbohidratii.Text, out carbohidrati))
            {
                metroLabel4.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel4.ForeColor = Color.Black;
            }
            if (!int.TryParse(metroGrasimi.Text, out grasimi))
            {
                metroLabel5.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroLabel5.ForeColor = Color.Black;
            }
            if (tipProdus==null)
            {
                MessageBox.Show("Selecteaza tipul de produs!");
                ok = 0;
            }

            int calorii_calculate = proteine * 4 + carbohidrati * 4 + grasimi * 9;
            if (calorii_calculate >= calorii + 50 || calorii_calculate <= calorii - 50)
            {
                MessageBox.Show("Caloriile nu sunt calculate corect!");
                ok = 0;
            }

            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);
            int nextId;
            if (nrAlimente > 0)
            {
                nextId = alimente.Max(a => a.id_aliment) + 1;
            }
            else
            {
                nextId = 1;
            }

            Aliment aliment = new Aliment(nextId, denumire, calorii, proteine, carbohidrati, grasimi, tipProdus);
            if (ok == 1)
            {
                adminAliment.AdaugaAliment(aliment);
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }

            metroDenumire.Text = "";
            metroCalorii.Text = "";
            metroProteine.Text = "";
            metroCarbohidratii.Text = "";
            metroGrasimi.Text = "";
            groupTipProdus.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);

        }

        private void AdaugaAliment_Load(object sender, EventArgs e)
        {

        }

        private void metroDenumire_Click(object sender, EventArgs e)
        {

        }

        private void metroTipProdus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroCarne_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
