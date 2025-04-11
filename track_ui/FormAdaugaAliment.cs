using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibrarieClase;
using LibrarieDate;
using System.Configuration;

namespace track_ui
{
    public partial class FormAdaugaAliment: MetroForm
    {
        public int top = 2;

        //Aliment
        AdministrareAliment adminAliment;

        private MetroLabel lblaDenumire1;
        private MetroLabel lblaCalorii1;
        private MetroLabel lblaProteine1;
        private MetroLabel lblaCarbohidrati1;
        private MetroLabel lblaGrasimi1;
        private MetroLabel lblaTipProdus1;

        private MetroLabel txtaliment;
        private MetroTextBox txtDenumire;
        private MetroTextBox txtCalorii;
        private MetroTextBox txtProteine;
        private MetroTextBox txtCarbohidrati;
        private MetroTextBox txtGrasimi;
        private MetroComboBox txtTipProdus;


        private MetroButton AddAliment;

        //Dimensiuni
        private const int LATIME_CONTROL = 100;
        private const int DIMENISUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 125;


        public FormAdaugaAliment()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;

            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);

            //setate proprietati
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Adauga Aliment";
        }

        private void FormAdaugaAliment_Load(object sender, EventArgs e)
        {
            AfisareTxtAliment();
        }
        private void AfisareTxtAliment()
        {
            top++;

            txtaliment = new MetroLabel();
            txtaliment.Text = "Adauga Aliment";
            txtaliment.Width = LATIME_CONTROL;
            txtaliment.AutoSize = true;
            txtaliment.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtaliment);


            //adauga control tip MetroLabel pt denumire
            lblaDenumire1 = new MetroLabel();
            lblaDenumire1.Text = "Denumire";
            lblaDenumire1.Width = LATIME_CONTROL;
            lblaDenumire1.Left = 1 * DIMENSIUNE_PAS_X;
            lblaDenumire1.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaDenumire1);

            txtDenumire = new MetroTextBox();
            txtDenumire.Width = LATIME_CONTROL;
            txtDenumire.Left = 1 * DIMENSIUNE_PAS_X;
            txtDenumire.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtDenumire);

            //adauga control tip MetroLabel pt calorii
            lblaCalorii1 = new MetroLabel();
            lblaCalorii1.Text = "Calorii";
            lblaCalorii1.Width = LATIME_CONTROL;
            lblaCalorii1.Left = 2 * DIMENSIUNE_PAS_X;
            lblaCalorii1.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaCalorii1);

            txtCalorii = new MetroTextBox();
            txtCalorii.Width = LATIME_CONTROL;
            txtCalorii.Left = 2 * DIMENSIUNE_PAS_X;
            txtCalorii.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtCalorii);

            //adauga control tip MetroLabel pt proteine
            lblaProteine1 = new MetroLabel();
            lblaProteine1.Text = "Proteine";
            lblaProteine1.Width = LATIME_CONTROL;
            lblaProteine1.Left = 3 * DIMENSIUNE_PAS_X;
            lblaProteine1.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaProteine1);

            txtProteine = new MetroTextBox();
            txtProteine.Width = LATIME_CONTROL;
            txtProteine.Left = 3 * DIMENSIUNE_PAS_X;
            txtProteine.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtProteine);

            //adauga control tip MetroLabel pt carbohidrati
            lblaCarbohidrati1 = new MetroLabel();
            lblaCarbohidrati1.Text = "Carbohidrati";
            lblaCarbohidrati1.Width = LATIME_CONTROL;
            lblaCarbohidrati1.Left = 4 * DIMENSIUNE_PAS_X;
            lblaCarbohidrati1.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaCarbohidrati1);

            txtCarbohidrati = new MetroTextBox();
            txtCarbohidrati.Width = LATIME_CONTROL;
            txtCarbohidrati.Left = 4 * DIMENSIUNE_PAS_X;
            txtCarbohidrati.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtCarbohidrati);

            //adauga control tip MetroLabel pt grasimi
            lblaGrasimi1 = new MetroLabel();
            lblaGrasimi1.Text = "Grasimi";
            lblaGrasimi1.Width = LATIME_CONTROL;
            lblaGrasimi1.Left = 5 * DIMENSIUNE_PAS_X;
            lblaGrasimi1.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaGrasimi1);

            txtGrasimi = new MetroTextBox();
            txtGrasimi.Width = LATIME_CONTROL;
            txtGrasimi.Left = 5 * DIMENSIUNE_PAS_X;
            txtGrasimi.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtGrasimi);

            //adauga control tip MetroLabel pt tip produs
            lblaTipProdus1 = new MetroLabel();
            lblaTipProdus1.Text = "Tip Produs";
            lblaTipProdus1.Width = LATIME_CONTROL;
            lblaTipProdus1.Left = 6 * DIMENSIUNE_PAS_X;
            lblaTipProdus1.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaTipProdus1);

            txtTipProdus = new MetroComboBox();
            txtTipProdus.Width = LATIME_CONTROL;
            txtTipProdus.Left = 6 * DIMENSIUNE_PAS_X;
            txtTipProdus.Top = top * DIMENISUNE_PAS_Y;
            txtTipProdus.Items.Add(Aliment.TipProdus.Fructe);
            txtTipProdus.Items.Add(Aliment.TipProdus.Legume);
            txtTipProdus.Items.Add(Aliment.TipProdus.Carne);
            txtTipProdus.Items.Add(Aliment.TipProdus.Lactate);
            txtTipProdus.Items.Add(Aliment.TipProdus.Cereale);
            txtTipProdus.Items.Add(Aliment.TipProdus.Dulciuri);
            txtTipProdus.Items.Add(Aliment.TipProdus.Bauturi);
            txtTipProdus.Items.Add(Aliment.TipProdus.Altele);
            this.Controls.Add(txtTipProdus);

            //adauga control tip buton pt adauga aliment
            AddAliment = new MetroButton();
            AddAliment.Text = "Adauga Aliment";
            AddAliment.Width = LATIME_CONTROL;
            AddAliment.Left = 7 * DIMENSIUNE_PAS_X;
            AddAliment.Top = top * DIMENISUNE_PAS_Y;
            AddAliment.Click += AdaugaAliment;
            AddAliment.AutoSize = true;
            AddAliment.BackColor = Color.White;
            AddAliment.ForeColor = Color.Black;
            this.Controls.Add(AddAliment);

        }
        private void AdaugaAliment(object sender, EventArgs e)
        {
            int ok = 1;
            string denumire = txtDenumire.Text;
            int calorii;
            int proteine;
            int carbohidrati;
            int grasimi;
            int tip_produs = txtTipProdus.SelectedIndex + 1;
            if (string.IsNullOrEmpty(denumire))
            {
                lblaDenumire1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblaDenumire1.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(txtCalorii.Text, out calorii))
            {
                lblaCalorii1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblaCalorii1.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(txtProteine.Text, out proteine))
            {
                lblaProteine1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblaProteine1.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(txtCarbohidrati.Text, out carbohidrati))
            {
                lblaCarbohidrati1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblaCarbohidrati1.ForeColor = Color.Yellow;
            }
            if (!int.TryParse(txtGrasimi.Text, out grasimi))
            {
                lblaGrasimi1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblaGrasimi1.ForeColor = Color.Yellow;
            }
            if (txtTipProdus.SelectedIndex == -1)
            {
                lblaTipProdus1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblaTipProdus1.ForeColor = Color.Yellow;
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
                adminAliment.AdaugaAliment(aliment);
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }
        }
    }
}
