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
    public partial class EditareAliment: MetroForm
    {

        AdministrareAliment adminAliment;
        public EditareAliment(int id)
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
            Aliment aliment = adminAliment.GetAlimentByIndex(int.Parse(lblID.Text));
            if (aliment == null)
            {
                MessageBox.Show("Alimentul nu exista!");
                return;
            }
            else
            {
                metroDenumire.Text = aliment.denumire;
                metroCalorii.Text = aliment.calorii.ToString();
                metroProteine.Text = aliment.proteine.ToString();
                metroCarbohidratii.Text = aliment.carbohidrati.ToString();
                metroGrasimi.Text = aliment.grasimi.ToString();
                switch (aliment.tip_produs)
                {
                    case Aliment.TipProdus.Fructe:
                        metroRadioButton1.Checked = true;
                        break;
                    case Aliment.TipProdus.Legume:
                        metroRadioButton2.Checked = true;
                        break;
                    case Aliment.TipProdus.Carne:
                        metroRadioButton3.Checked = true;
                        break;
                    case Aliment.TipProdus.Lactate:
                        metroRadioButton4.Checked = true;
                        break;
                    case Aliment.TipProdus.Cereale:
                        metroRadioButton5.Checked = true;
                        break;
                    case Aliment.TipProdus.Dulciuri:
                        metroRadioButton6.Checked = true;
                        break;
                    case Aliment.TipProdus.Bauturi:
                        metroRadioButton7.Checked = true;
                        break;
                    case Aliment.TipProdus.Altele:
                        metroRadioButton8.Checked = true;
                        break;
                }
            }
        }

        private void EditareAliment_Load(object sender, EventArgs e)
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

            Aliment aliment = new Aliment(int.Parse(lblID.Text), denumire, calorii, proteine, carbohidrati, grasimi, tip_produs);
            if (ok == 1)
            {
                try
                {
                    adminAliment.ModificaAliment(aliment);
                    MessageBox.Show("Aliment editat cu succes!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la editarea alimentului: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }
        }
    }
}
