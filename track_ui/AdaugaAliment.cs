using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieClase;
using LibrarieDate;
using System.Configuration;
using System.IO;

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
            int tip_produs = metroTipProdus.SelectedIndex + 1;
            if (string.IsNullOrEmpty(denumire))
            {
                metroDenumire.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroDenumire.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(metroCalorii.Text, out calorii))
            {
                metroCalorii.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroCalorii.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(metroProteine.Text, out proteine))
            {
                metroProteine.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroProteine.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(metroCarbohidratii.Text, out carbohidrati))
            {
                metroCarbohidratii.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroCarbohidratii.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(metroGrasimi.Text, out grasimi))
            {
                metroGrasimi.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroGrasimi.ForeColor = Color.Yellow;
            }
            if (metroTipProdus.SelectedIndex == -1)
            {
                metroTipProdus.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                metroTipProdus.ForeColor = Color.Yellow;
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

            Aliment aliment = new Aliment(nextId, denumire, calorii, proteine, carbohidrati, grasimi, (Aliment.TipProdus)tip_produs);
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
            metroTipProdus.SelectedIndex = -1;

        }

        private void AdaugaAliment_Load(object sender, EventArgs e)
        {
            //aduga optiuni in comboBox
            metroTipProdus.Items.Add("Fructe");
            metroTipProdus.Items.Add("Legume");
            metroTipProdus.Items.Add("Carne");
            metroTipProdus.Items.Add("Lactate");
            metroTipProdus.Items.Add("Cereale");
            metroTipProdus.Items.Add("Dulciuri");
            metroTipProdus.Items.Add("Bauturi");
            metroTipProdus.Items.Add("Altele");
            metroTipProdus.SelectedIndex = -1;

        }
    }
}
