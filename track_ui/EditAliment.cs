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
    public partial class EditAliment: UserControl
    {
        AdministrareAliment adminAliment;
        public EditAliment(int id)
        {

            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;
            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);
            lblID.Text = id.ToString();
            SetareCampuri();
        }
        private void SetareCampuri()
        {
            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);
            int id = int.Parse(lblID.Text);
            id--;
            if (alimente == null || id < 0 || id >= alimente.Length)
            {
                MessageBox.Show("Alimentul nu exista!");
                return;
            }
            else
            {
                metroDenumire.Text = alimente[id].denumire.ToString();
                metroCalorii.Text = alimente[id].calorii.ToString();
                metroProteine.Text = alimente[id].proteine.ToString();
                metroCarbohidratii.Text = alimente[id].carbohidrati.ToString();
                metroGrasimi.Text = alimente[id].grasimi.ToString();
                if (alimente[id].tip_produs == Aliment.TipProdus.Fructe)
                {
                    metroRadioButton1.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Legume)
                {
                    metroRadioButton2.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Carne)
                {
                    metroRadioButton3.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Lactate)
                {
                    metroRadioButton4.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Cereale)
                {
                    metroRadioButton5.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Dulciuri)
                {
                    metroRadioButton6.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Bauturi)
                {
                    metroRadioButton7.Checked = true;
                }
                else if (alimente[id].tip_produs == Aliment.TipProdus.Altele)
                {
                    metroRadioButton8.Checked = true;
                }
            }
        }

        private void EditAliment_Load(object sender, EventArgs e)
        {

        }

        private void metroTipProdus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string denumire = metroDenumire.Text;
            int calorii;
            int proteine;
            int carbohidrati;
            int grasimi;
            int ok = 1;
            Aliment.TipProdus tip_produs = Aliment.TipProdus.Altele;
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
            // Verificare tip produs radiobx
            if (metroRadioButton1.Checked)
            {
                tip_produs = Aliment.TipProdus.Fructe;
            }
            else if (metroRadioButton2.Checked)
            {
                tip_produs = Aliment.TipProdus.Legume;
            }
            else if (metroRadioButton3.Checked)
            {
                tip_produs = Aliment.TipProdus.Carne;
            }
            else if (metroRadioButton4.Checked)
            {
                tip_produs = Aliment.TipProdus.Lactate;
            }
            else if (metroRadioButton5.Checked)
            {
                tip_produs = Aliment.TipProdus.Cereale;
            }
            else if (metroRadioButton6.Checked)
            {
                tip_produs = Aliment.TipProdus.Dulciuri;
            }
            else if (metroRadioButton7.Checked)
            {
                tip_produs = Aliment.TipProdus.Bauturi;
            }
            else if (metroRadioButton8.Checked)
            {
                tip_produs = Aliment.TipProdus.Altele;
            }

            int calorii_calculate = proteine * 4 + carbohidrati * 4 + grasimi * 9;
            if (calorii_calculate >= calorii + 50 || calorii_calculate <= calorii - 50)
            {
                MessageBox.Show("Caloriile nu sunt calculate corect!");
                ok = 0;
            }

            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);
            int id = int.Parse(lblID.Text);
            if (alimente == null || id < 0 || id >= alimente.Length)
            {
                MessageBox.Show("Alimentul nu exista!");
                return;
            }
            else
            {
                alimente[id].denumire = denumire;
                alimente[id].calorii = calorii;
                alimente[id].proteine = proteine;
                alimente[id].carbohidrati = carbohidrati;
                alimente[id].grasimi = grasimi;
                alimente[id].tip_produs = tip_produs;
            }
        }
    }
}
